using System;
using System.Collections;
using System.Windows.Forms;
using Microsoft.Win32;

namespace HellaNzbRemote
{
    public partial class PreferencesDialog : Form
    {
        /// <summary>
        /// Windows registry key
        /// </summary>
        private RegistryKey _windowsRegistryKey;
        /// <summary>
        /// Application preferences registry key
        /// </summary>
        private RegistryKey _preferencesRegistryKey;
        /// <summary>
        /// Application server list registry key
        /// </summary>
        private RegistryKey _serverListRegistryKey;

        /// <summary>
        /// Application preferences form
        /// </summary>
        public PreferencesDialog()
        {
            // Initialize design components
            InitializeComponent();

            // Open Windows startup registry key
            _windowsRegistryKey = Registry.CurrentUser.OpenSubKey(MainForm.REGISTRY_KEY_WINDOWS_AUTORUN, true);
            // Open application preferences registry key
            _preferencesRegistryKey = Registry.CurrentUser.OpenSubKey(MainForm.REGISTRY_KEY_PREFERENCES, true);
            // Open application server list registry key
            _serverListRegistryKey = Registry.CurrentUser.OpenSubKey(MainForm.REGISTRY_KEY_SERVER_LIST, true);

            // Get option values from registry keys
            if ((string)_preferencesRegistryKey.GetValue(MainForm.REGISTRY_VALUE_UI_UPDATE_INTERVAL) != null) numBoxFormUpdateInterval.Value = int.Parse((string)_preferencesRegistryKey.GetValue(MainForm.REGISTRY_VALUE_UI_UPDATE_INTERVAL));
            if ((string)_preferencesRegistryKey.GetValue(MainForm.REGISTRY_VALUE_UI_MINIMIZE_TO_TRAY) == "False") checkBoxMinimizeToTray.Checked = false;
            if ((string)_preferencesRegistryKey.GetValue(MainForm.REGISTRY_VALUE_UI_MINIMIZE_DISABLE_NOTIFICATIONS) == "True") checkBoxDisableTrayNotifications.Checked = true;
            if ((string)_windowsRegistryKey.GetValue(MainForm.REGISTRY_VALUE_WINDOWS_START_AT_LOGIN) == Application.ExecutablePath.ToString()) checkBoxStartAtLogin.Checked = true;            
            if ((string)_preferencesRegistryKey.GetValue(MainForm.REGISTRY_VALUE_UI_MINIMIZE_AT_START) == "True") checkBoxMinimizeAtStart.Checked = true;            
            if ((string)_preferencesRegistryKey.GetValue(MainForm.REGISTRY_VALUE_UI_CHECK_FOR_UPDATES_AT_START) == "False") checkBoxCheckForUpdates.Checked = false;

            // Close Windows startup registry key
            _windowsRegistryKey.Close();
            // Close application preferences registry key
            _preferencesRegistryKey.Close();
            // Close application server list registry key
            _serverListRegistryKey.Close();
            
            // Update server list
            UpdateServerList();
        }

        private bool ValidateConnectionTabControl()
        {
            if (textBoxUsername.Text == string.Empty) usernameErrorProvider.SetError(textBoxUsername, "Username is required");
            else usernameErrorProvider.Clear();
            if (textBoxPassword.Text == string.Empty) passwordErrorProvider.SetError(textBoxPassword, "Password is required");
            else passwordErrorProvider.Clear();
            if (textBoxHostname.Text == string.Empty) hostnameErrorProvider.SetError(textBoxHostname, "Hostname is required");
            else hostnameErrorProvider.Clear();
            int portNumber;
            if (textBoxPort.Text == string.Empty) portErrorProvider.SetError(textBoxPort, "Port is required");
            else if (!int.TryParse(textBoxPort.Text, out portNumber)) portErrorProvider.SetError(textBoxPort, "Port must be a number");
            else portErrorProvider.Clear();

            Boolean validationPassed = true;
            if (usernameErrorProvider.GetError(textBoxUsername) != string.Empty) validationPassed = false;
            if (passwordErrorProvider.GetError(textBoxPassword) != string.Empty) validationPassed = false;
            if (hostnameErrorProvider.GetError(textBoxHostname) != string.Empty) validationPassed = false;
            if (portErrorProvider.GetError(textBoxPort) != string.Empty) validationPassed = false;

            return validationPassed;
        }

        //
        // Button Event Handlers
        //

        private void buttonSaveServer_Click(object sender, EventArgs e)
        {
            if (ValidateConnectionTabControl())
            {
                // Open application server list registry key
                _serverListRegistryKey = Registry.CurrentUser.OpenSubKey(MainForm.REGISTRY_KEY_SERVER_LIST, true);

                string connectAtStart = (checkBoxConnectAtStart.Checked) ? "True" : "False";                

                if (listBoxServers.SelectedIndex >= 0)
                {
                    foreach (string registryKeyValue in _serverListRegistryKey.GetValueNames())
                    {
                        string[] server = (string[])_serverListRegistryKey.GetValue(registryKeyValue);

                        if (registryKeyValue == listBoxServers.SelectedIndex.ToString())
                        {
                            server[MainForm.INDEX_SERVER_USERNAME] = textBoxUsername.Text;
                            server[MainForm.INDEX_SERVER_PASSWORD] = textBoxPassword.Text;
                            server[MainForm.INDEX_SERVER_HOSTNAME] = textBoxHostname.Text;
                            server[MainForm.INDEX_SERVER_PORT] = textBoxPort.Text;
                            server[MainForm.INDEX_SERVER_AUTOCONNECT] = connectAtStart;
                        }
                        else if (checkBoxConnectAtStart.Checked)
                        {
                            server[MainForm.INDEX_SERVER_AUTOCONNECT] = "False";
                        }
                        _serverListRegistryKey.SetValue(registryKeyValue, server);
                    }
                }
                else
                {
                    ArrayList serverList = new ArrayList();
                    foreach (string registryKeyValue in _serverListRegistryKey.GetValueNames())
                    {
                        string[] server = (string[])_serverListRegistryKey.GetValue(registryKeyValue);
                        if (checkBoxConnectAtStart.Checked)
                        {
                            server[MainForm.INDEX_SERVER_AUTOCONNECT] = "False";
                        }
                        serverList.Add(server);
                        _serverListRegistryKey.DeleteValue(registryKeyValue);
                    }
                    int index;
                    for (index = 0; index < serverList.Count; index++)
                    {
                        _serverListRegistryKey.SetValue(index.ToString(), serverList[index]);
                    }
                    string[] newregistryKeyValue = { textBoxUsername.Text, textBoxPassword.Text, textBoxHostname.Text, textBoxPort.Text, connectAtStart };
                    _serverListRegistryKey.SetValue(index.ToString(), newregistryKeyValue);
                }
                // Open application server list registry key
                _serverListRegistryKey.Close();

                UpdateServerList();
            }
        }

        private void buttonRemoveServer_Click(object sender, EventArgs e)
        {
            _serverListRegistryKey.DeleteValue(listBoxServers.SelectedIndex.ToString());
            removeServerButton.Enabled = false;

            ArrayList servers = new ArrayList();
            foreach (string value in _serverListRegistryKey.GetValueNames())
            {
                servers.Add((string[])_serverListRegistryKey.GetValue(value));
                _serverListRegistryKey.DeleteValue(value);
            }
            for (int key = 0; key < servers.Count; key++)
            {
                _serverListRegistryKey.SetValue(key.ToString(), servers[key]);
            }
            UpdateServerList();
        }

        private void buttonTestConnection_Click(object sender, EventArgs e)
        {
            if (ValidateConnectionTabControl())
            {
                IHellaNzbProxy hellaNzbProxy = MainForm.InstantiateServer(textBoxUsername.Text, textBoxPassword.Text, textBoxHostname.Text, textBoxPort.Text);                
                try
                {
                    hellaNzbProxy.Status();

                    string title = "HellaNZB Remote";
                    string message = "Connection established successfully.";
                    MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    string title = "HellaNZB Remote";
                    string message = "A connection to the server could not be established.";
                    MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }        

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Open Windows startup registry key
            _windowsRegistryKey = Registry.CurrentUser.OpenSubKey(MainForm.REGISTRY_KEY_WINDOWS_AUTORUN, true);
            // Open application preferences registry key
            _preferencesRegistryKey = Registry.CurrentUser.OpenSubKey(MainForm.REGISTRY_KEY_PREFERENCES, true);
            // Open application server list registry key
            _serverListRegistryKey = Registry.CurrentUser.OpenSubKey(MainForm.REGISTRY_KEY_SERVER_LIST, true);

            // Set option values
            _preferencesRegistryKey.SetValue(MainForm.REGISTRY_VALUE_UI_UPDATE_INTERVAL, numBoxFormUpdateInterval.Value);
            _preferencesRegistryKey.SetValue(MainForm.REGISTRY_VALUE_UI_MINIMIZE_TO_TRAY, (checkBoxMinimizeToTray.Checked) ? "True" : "False");
            _preferencesRegistryKey.SetValue(MainForm.REGISTRY_VALUE_UI_MINIMIZE_DISABLE_NOTIFICATIONS, (checkBoxDisableTrayNotifications.Checked) ? "True" : "False");            
            _preferencesRegistryKey.SetValue(MainForm.REGISTRY_VALUE_UI_MINIMIZE_AT_START, (checkBoxMinimizeAtStart.Checked) ? "True" : "False");            
            _preferencesRegistryKey.SetValue(MainForm.REGISTRY_VALUE_UI_CHECK_FOR_UPDATES_AT_START, (checkBoxCheckForUpdates.Checked) ? "True" : "False");

            if (checkBoxStartAtLogin.Checked)
            {
                _windowsRegistryKey.SetValue(MainForm.REGISTRY_VALUE_WINDOWS_START_AT_LOGIN, "\"" + Application.ExecutablePath.ToString() + "\"");
            }
            else if ((string)_windowsRegistryKey.GetValue(MainForm.REGISTRY_VALUE_WINDOWS_START_AT_LOGIN) != null)
            {
                _windowsRegistryKey.DeleteValue(MainForm.REGISTRY_VALUE_WINDOWS_START_AT_LOGIN);
            }

            // Close Windows startup registry key
            _windowsRegistryKey.Close();
            // Close application preferences registry key
            _preferencesRegistryKey.Close();
            // Close application server list registry key
            _serverListRegistryKey.Close();
            
            // Set dialog result
            DialogResult = DialogResult.OK;
            // Close dialog
            Close();
        }

        /// <summary>
        /// Cancel dialog event handler
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Set dialog result
            DialogResult = DialogResult.Cancel;
            // Close dialog
            Close();
        }
        
        private void listBoxServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxServers.SelectedIndex >= 0)
            {
                string[] server = (string[])_serversList[listBoxServers.SelectedIndex];
                textBoxUsername.Text = server[MainForm.INDEX_SERVER_USERNAME];
                textBoxPassword.Text = server[MainForm.INDEX_SERVER_PASSWORD];
                textBoxHostname.Text = server[MainForm.INDEX_SERVER_HOSTNAME];
                textBoxPort.Text = server[MainForm.INDEX_SERVER_PORT];
                checkBoxConnectAtStart.Checked = (server[MainForm.INDEX_SERVER_AUTOCONNECT] == "True") ? true : false;

                removeServerButton.Enabled = true;
                buttonSaveServer.Text = "Save Server";
            }
        }

        /// <summary>
        /// List of available servers
        /// </summary>
        ArrayList _serversList = new ArrayList();

        /// <summary>
        /// Populate servers array list and servers list box
        /// </summary>
        private void UpdateServerList()
        {
            // Open application server list registry key
            _serverListRegistryKey = Registry.CurrentUser.OpenSubKey(MainForm.REGISTRY_KEY_SERVER_LIST, true);

            // Clear servers array list
            _serversList.Clear();
            // Clear list box of servers
            listBoxServers.Items.Clear();
            // Iterate list of servers from registry key
            foreach (string registryKeyValue in _serverListRegistryKey.GetValueNames())
            {
                // Get server from registry key
                string[] server = (string[])_serverListRegistryKey.GetValue(registryKeyValue);
                // Add server to server array list
                _serversList.Add(server);
                // Format server list box item
                string item = server[MainForm.INDEX_SERVER_USERNAME] + "@" + server[MainForm.INDEX_SERVER_HOSTNAME] + ":" + server[MainForm.INDEX_SERVER_PORT];
                // Add item to server list box
                listBoxServers.Items.Add(item);
            }

            // Close application server list registry key
            _serverListRegistryKey.Close();

            // Clear fields
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxHostname.Clear();
            textBoxPort.Clear();
            checkBoxConnectAtStart.Checked = false;
            // Reset save server button text
            buttonSaveServer.Text = "Add Server";
        }
    }
}
