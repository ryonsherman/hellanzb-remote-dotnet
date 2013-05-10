using System;
using System.Collections;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using CookComputing.XmlRpc;
using Microsoft.Win32;

namespace HellaNzbRemote
{
    public partial class MainForm : Form
    {
        private string FormatBytes(long bytes)
        {
            if (bytes > Math.Pow(1024, 3))
            {
                return string.Format("{0:##.##} GB", bytes / Math.Pow(1024, 3));
            }
            else if (bytes > Math.Pow(1024, 2))
            {
                return string.Format("{0:##.##} MB", bytes / Math.Pow(1024, 2));
            }
            else if (bytes > 1024)
            {
                return string.Format("{0:##.##} KB", bytes / 1024);
            }
            else
            {
                return string.Format("{0:##.##} B", bytes);
            }
        }

        /// <summary>
        /// Application version
        /// </summary>
        public const string VERSION = "1.0.0";
        /// <summary>
        /// Application version date
        /// </summary>
        public const string VERSION_DATE = "January 2011";
        /// <summary>
        /// Application version URL
        /// </summary>
        public const string VERSION_URL = "http://hellanzb-remote-dotnet.googlecode.com/svn/trunk/version.xml";
        
        /// <summary>
        /// Default form update timer interval
        /// </summary>
        public const int DEFAULT_UI_UPDATE_INTERVAL = 3000;

        /// <summary>
        /// Application prefereces registry key path
        /// </summary>
        public const string REGISTRY_KEY_PREFERENCES = "SOFTWARE\\HellaNZB Remote\\Preferences";
        /// <summary>
        /// Application server list registry key path
        /// </summary>
        public const string REGISTRY_KEY_SERVER_LIST = "SOFTWARE\\HellaNZB Remote\\ServerList";
        /// <summary>
        /// Windows registry key path
        /// </summary>
        public const string REGISTRY_KEY_WINDOWS_AUTORUN = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

        /// <summary>
        /// User interface update interval registry value
        /// </summary>
        public const string REGISTRY_VALUE_UI_UPDATE_INTERVAL = "UI.UpdateInterval";        
        /// <summary>
        /// Minimize to tray option registry value
        /// </summary>
        public const string REGISTRY_VALUE_UI_MINIMIZE_TO_TRAY = "UI.MinimizeToTray";
        /// <summary>
        /// Disable minimize message option registry value
        /// </summary>
        public const string REGISTRY_VALUE_UI_MINIMIZE_DISABLE_NOTIFICATIONS = "UI.MinimizeDisableNotifications";
        /// <summary>
        /// Minimize at start option registry value
        /// </summary>
        public const string REGISTRY_VALUE_UI_MINIMIZE_AT_START = "UI.MinimizeToTrayAtStart";
        /// <summary>
        /// Check for updates option registry value
        /// </summary>
        public const string REGISTRY_VALUE_UI_CHECK_FOR_UPDATES_AT_START = "UI.CheckForUpdatesAtStart";
        /// <summary>
        /// Windows autorun registry value;
        /// </summary>
        public const string REGISTRY_VALUE_WINDOWS_START_AT_LOGIN = "HellaNZB Remote";        

        /// <summary>
        /// Server username field index
        /// </summary>
        public const int INDEX_SERVER_USERNAME = 0;
        /// <summary>
        /// Server password field index
        /// </summary>
        public const int INDEX_SERVER_PASSWORD = 1;
        /// <summary>
        /// Server hostname field index
        /// </summary>
        public const int INDEX_SERVER_HOSTNAME = 2;
        /// <summary>
        /// Server port field index
        /// </summary>
        public const int INDEX_SERVER_PORT = 3;
        /// <summary>
        /// Server auto-connect option field index
        /// </summary>
        public const int INDEX_SERVER_AUTOCONNECT = 4;

        /// <summary>
        /// Form update timer
        /// </summary>
        private System.Windows.Forms.Timer _timer;

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
        /// Minimize to tray option
        /// </summary>
        private bool _minimizeToTray = true;
        /// <summary>
        /// Hide minimize message option
        /// </summary>
        private bool _minimizeHideMessage = false;
        /// <summary>
        /// Disable tray notifications option
        /// </summary>
        private bool _minimizeDisableNotifications = false;
        
        /// <summary>
        /// Main application form
        /// </summary>
        public MainForm()
        {
            // Disable illegal cross thread call check
            Control.CheckForIllegalCrossThreadCalls = false;

            // Create form update timer
            _timer = new System.Windows.Forms.Timer();
            _timer.Tick += new EventHandler(form_TimerTick);
            _timer.Interval = DEFAULT_UI_UPDATE_INTERVAL;

            // Initialize design components
            InitializeComponent();
            
            // Open application preferences registry key
            _preferencesRegistryKey = Registry.CurrentUser.OpenSubKey(REGISTRY_KEY_PREFERENCES, true);
            if (_preferencesRegistryKey == null)
            {
                // Create application preferences registry key if not found
                Registry.CurrentUser.CreateSubKey(REGISTRY_KEY_PREFERENCES);
                // Open application preferences registry key
                _preferencesRegistryKey = Registry.CurrentUser.OpenSubKey(REGISTRY_KEY_PREFERENCES, true);
            }
            // Open application server list registry key
            _serverListRegistryKey = Registry.CurrentUser.OpenSubKey(REGISTRY_KEY_SERVER_LIST, true);
            if (_serverListRegistryKey == null)
            {
                // Create application server list registry key if not found
                Registry.CurrentUser.CreateSubKey(REGISTRY_KEY_SERVER_LIST);
                // Open application server list registry key
                _serverListRegistryKey = Registry.CurrentUser.OpenSubKey(REGISTRY_KEY_SERVER_LIST, true);
            }

            // Set form update interval from preferences registry key
            _timer.Interval = ((string)_preferencesRegistryKey.GetValue(REGISTRY_VALUE_UI_UPDATE_INTERVAL) != null) ? int.Parse((string)_preferencesRegistryKey.GetValue(REGISTRY_VALUE_UI_UPDATE_INTERVAL)) : DEFAULT_UI_UPDATE_INTERVAL;
            // Set minimize to tray option from registry value
            _minimizeToTray = ((string)_preferencesRegistryKey.GetValue(REGISTRY_VALUE_UI_MINIMIZE_TO_TRAY) == "False") ? false : true;
            // Set disable tray notifications option from registry value
            _minimizeDisableNotifications = ((string)_preferencesRegistryKey.GetValue(REGISTRY_VALUE_UI_MINIMIZE_DISABLE_NOTIFICATIONS) == "False") ? false : true;

            // Check for application update if option selected
            if ((string)_preferencesRegistryKey.GetValue(REGISTRY_VALUE_UI_CHECK_FOR_UPDATES_AT_START) != "False")
            {                
                CheckForUpdates();
            }
            // Set window state to minimized if minimize at start option selected
            if ((string)_preferencesRegistryKey.GetValue(REGISTRY_VALUE_UI_MINIMIZE_AT_START) == "True")
            {                
                WindowState = FormWindowState.Minimized;
            }
                        
            // Close application preferences registry key
            _preferencesRegistryKey.Close();
            // Close application server list registry key
            _serverListRegistryKey.Close();

            // Update server list
            UpdateServerList();
        }        

        /// <summary>
        /// XML text reader
        /// </summary>
        private XmlTextReader xmlTextReader;

        /// <summary>
        /// Check for application updates
        /// </summary>
        private void CheckForUpdates(bool showMessage = false)
        {
            try
            {
                string newVersion = string.Empty;
                string updateUrl = string.Empty;

                xmlTextReader = new XmlTextReader(VERSION_URL);
                xmlTextReader.MoveToContent();
                if (xmlTextReader.NodeType == XmlNodeType.Element && xmlTextReader.Name == "data")
                {
                    string elementName = string.Empty;
                    while (xmlTextReader.Read())
                    {                        
                        if (xmlTextReader.NodeType == XmlNodeType.Element)
                        {
                            elementName = xmlTextReader.Name;
                        }
                        else if (xmlTextReader.NodeType == XmlNodeType.Text)
                        {
                            switch (elementName)
                            {
                                case "version":
                                    newVersion = xmlTextReader.Value;
                                    break;
                                case "url":
                                    updateUrl = xmlTextReader.Value;
                                    break;
                            }
                        }
                    }
                }

                string title = Application.ProductName + " v" + VERSION;                
                if (updateUrl != string.Empty && newVersion != string.Empty && newVersion != VERSION)
                {                    
                    string question = "Version " + newVersion + " is available for download!" + Environment.NewLine + Environment.NewLine + "Download this version now?";
                    if (DialogResult.Yes == MessageBox.Show(this, question, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        System.Diagnostics.Process.Start(updateUrl);
                    }                    
                }
                else if (showMessage)
                {
                    string message = "No update available at this time.";
                    MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                if (xmlTextReader != null) xmlTextReader.Close();
            }
        }
        
        /// <summary>
        /// Form resize event handler
        /// </summary>
        private void form_Resize(object sender, EventArgs e)
        {            
            // Check if window is minimized and if minimize to tray option is selected
            if (WindowState == FormWindowState.Minimized && _minimizeToTray)
            {
                // Hide window
                Hide();

                if (!_minimizeHideMessage)
                {
                    // Create notification balloon tip details
                    notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon.BalloonTipTitle = Application.ProductName;
                    notifyIcon.BalloonTipText = "Application minimized to the taskbar." + Environment.NewLine + "Click to disable this message.";
                    // Disable minimization notification if ballon tip clicked
                    notifyIcon.BalloonTipClicked -= form_Restore;
                    notifyIcon.BalloonTipClicked += new EventHandler(notifyIcon_BalloonTipClicked);
                    // Show notification ballon tip
                    notifyIcon.ShowBalloonTip(3000);
                }
            }
        }

        /// <summary>
        /// Form restore event handler
        /// </summary>
        private void form_Restore(object sender, EventArgs e)
        {
            // Show window
            Show();
            // Set window state to normal
            WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// Form close event handler
        /// </summary>
        private void form_Close(object sender, EventArgs e)
        {
            if (_isUpdating == true)
            {
                // Sleep thread if form is updating
                Thread.Sleep(100);
            }
        }       
        
        /// <summary>
        /// Form update timer tick event handler
        /// </summary>        
        private void form_TimerTick(object sender, EventArgs e)
        {
            // Check if form is not currently updating
            if (_isUpdating == false)
            {
                // Create new update thread
                Thread Thread = new Thread(new ThreadStart(UpdateForm));
                // Start thread
                Thread.Start();
            }
        }

        /// <summary>
        /// Currently connected boolean
        /// </summary>
        private bool _isConnected = false;
        /// <summary>
        /// Currently paused boolean
        /// </summary>
        private bool _isPaused = false;
        /// <summary>
        /// Currently updating boolean
        /// </summary>
        private bool _isUpdating = false;
        /// <summary>
        /// Current server status
        /// </summary>
        private XmlRpcStruct _statusStruct;

        /// <summary>
        /// Update form elements
        /// </summary>
        private void UpdateForm()
        {
            if (_isUpdating == true)
            {
                // Return if currently updating
                return;
            }
            
            // Instantiate server
            IHellaNzbProxy hellaNzbProxy = InstantiateServer(_username, _password, _hostname, _port);
            try
            {
                // Set currently updating boolean to true
                _isUpdating = true;
                // Attempt to get server status
                _statusStruct = hellaNzbProxy.Status();
                
                // Set currently connected boolean to true
                _isConnected = true;
                // Toggle connected status
                ToggleUiItemsConnected("Connected to " + _username + "@" + _hostname + ":" + _port + ", Version: " + (string)_statusStruct["version"] + " Uptime: " + (string)_statusStruct["uptime"]);

                // Set currently paused boolean
                _isPaused = (bool)_statusStruct["is_paused"];
                // Toggle pause status
                ToggleUiItemsPaused();
            }
            catch (Exception e)
            {
                // Set currently updating boolean to false
                _isUpdating = false;
                // Disconnect from server
                ServerDisconnect(e.Message);
                return;
            }       
            
            // Update transfer list
            UpdateTransferListView();
            // Update log
            UpdateLogListBox();

            // Set currently updating boolean to false
            _isUpdating = false;
        }

        /// <summary>
        /// Currentl transfer list view index
        /// </summary>
        private int _transferListViewIndex = -1;

        /// <summary>
        /// Update transfer list view
        /// </summary>
        private void UpdateTransferListView()
        {
            ListViewItem item;
            ListViewItem.ListViewSubItem subItem;
                        
            listViewTransfers.Items.Clear();
            object[] downloadArray = (object[])_statusStruct["currently_downloading"];
            foreach (object downloadItem in downloadArray)
            {
                XmlRpcStruct downloadItemStruct = (XmlRpcStruct)downloadItem;

                item = new ListViewItem();
                item.Text = (listViewTransfers.Items.Count + 1).ToString();
                ArrayList tagArrayList = new ArrayList();
                tagArrayList.Add((Int32)downloadItemStruct["id"]);
                if ((string)downloadItemStruct["rarPassword"] != string.Empty)
                {
                    tagArrayList.Add((string)downloadItemStruct["rarPassword"]);
                }
                item.Tag = tagArrayList;

                subItem = new ListViewItem.ListViewSubItem();
                subItem.Text = System.Web.HttpUtility.UrlDecode((string)downloadItemStruct["nzbName"]);
                item.SubItems.Add(subItem);

                subItem = new ListViewItem.ListViewSubItem();
                subItem.Text = FormatBytes(long.Parse(((int)downloadItemStruct["total_mb"]).ToString()) * (long)Math.Pow(1024, 2));
                item.SubItems.Add(subItem);

                subItem = new ListViewItem.ListViewSubItem();
                subItem.Text = (_isPaused) ? "Paused" : "Downloading";
                item.SubItems.Add(subItem);

                subItem = new ListViewItem.ListViewSubItem();
                subItem.Text = ((Int32)_statusStruct["percent_complete"]).ToString() + "%";
                item.SubItems.Add(subItem);

                subItem = new ListViewItem.ListViewSubItem();
                subItem.Text = TimeSpan.FromSeconds((Int32)_statusStruct["eta"]).ToString();
                item.SubItems.Add(subItem);                

                listViewTransfers.Items.Add(item);
            }
            object[] queueArray = (object[])_statusStruct["queued"];
            foreach (object queueItem in queueArray)
            {
                XmlRpcStruct queueItemStruct = (XmlRpcStruct)queueItem;

                item = new ListViewItem();
                item.Text = (listViewTransfers.Items.Count + 1).ToString();
                ArrayList tagArrayList = new ArrayList();
                tagArrayList.Add((Int32)queueItemStruct["id"]);
                if ((string)queueItemStruct["rarPassword"] != string.Empty)
                {
                    tagArrayList.Add((string)queueItemStruct["rarPassword"]);
                }
                item.Tag = tagArrayList;

                subItem = new ListViewItem.ListViewSubItem();
                subItem.Text = System.Web.HttpUtility.UrlDecode((string)queueItemStruct["nzbName"]);
                item.SubItems.Add(subItem);

                subItem = new ListViewItem.ListViewSubItem();
                subItem.Text = FormatBytes(long.Parse(((int)queueItemStruct["total_mb"]).ToString()) * (long)Math.Pow(1024, 2));                
                item.SubItems.Add(subItem);

                subItem = new ListViewItem.ListViewSubItem();
                subItem.Text = "Queued";
                item.SubItems.Add(subItem);

                subItem = new ListViewItem.ListViewSubItem();
                item.SubItems.Add(subItem);
                
                subItem = new ListViewItem.ListViewSubItem();
                item.SubItems.Add(subItem);               

                listViewTransfers.Items.Add(item);
            }
            
            if (_transferListViewIndex >= 0)
            {
                listViewTransfers.Items[_transferListViewIndex].Selected = true;
            }
        }

        /// <summary>
        /// Last displayed log entry
        /// </summary>
        private string _lastLogString = string.Empty;

        /// <summary>
        /// Update log element
        /// </summary>
        private void UpdateLogListBox()
        {
            // Get array of log entry objects
            object[] LogArray = (object[])_statusStruct["log_entries"];
            
            // Check if log entries exist in array
            if (LogArray.Length > 0)
            {
                // Get last entry in log array
                XmlRpcStruct LastEntryStruct = (XmlRpcStruct)LogArray[LogArray.Length - 1];
                // Set last log entry
                string LastEntrystring = string.Empty + (string)LastEntryStruct["ERROR"] + (string)LastEntryStruct["INFO"];
                // Check that last log entry does not match last displayed log entry
                if (LastEntrystring != _lastLogString)
                {
                    // Set last displayed log entry to current log entry
                    _lastLogString = LastEntrystring;

                    if (LastEntryStruct["ERROR"] != null)
                    {
                        // Show error message if log entry contains an error
                        ShowNotifyIconMessage(LastEntrystring, ToolTipIcon.Error);
                    }
                    else if (WindowState == FormWindowState.Minimized && !_minimizeDisableNotifications)
                    {
                        // Show notification message if windows is currently minimized                        
                        ShowNotifyIconMessage(LastEntrystring);
                    }

                    // Iterate array of log entries
                    foreach (object Log in LogArray)
                    {
                        // Get current log entry structure
                        XmlRpcStruct LogStruct = (XmlRpcStruct)Log;
                        // Add log entry to log element
                        listBoxLog.Items.Add(System.Web.HttpUtility.UrlDecode((string)LogStruct["ERROR"] + (string)LogStruct["INFO"]));
                        
                        // Get currently selected log entry
                        int holdSelectedIndex = listBoxLog.SelectedIndex;
                        // Scroll to end of list
                        listBoxLog.SelectedIndex = listBoxLog.Items.Count - 1;
                        // Set currently selected log entry
                        listBoxLog.SelectedIndex = holdSelectedIndex;
                    }
                }
            }
        }
        
        //
        // MenuItem Event Handlers
        //

        /// <summary>
        /// Add NZB From File 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemAddNzbFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open NZB";
            openFileDialog.Filter = "NZB Files (*.nzb)|*.nzb";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // TODO: Enable local file addition
            }
        }

        private void menuItemAddNzbFromUrl_Click(object sender, EventArgs e)
        {
            AddNzbFromUrlDialog addNzbFromUrlDialog = new AddNzbFromUrlDialog();
            if (addNzbFromUrlDialog.ShowDialog() == DialogResult.OK)
            {
                if (addNzbFromUrlDialog.url != String.Empty)
                {
                    IHellaNzbProxy hellaNzbProxy = InstantiateServer(_username, _password, _hostname, _port);
                    if (hellaNzbProxy != null)
                    {
                        hellaNzbProxy.EnqueueURL(addNzbFromUrlDialog.url);
                        UpdateForm();
                    }
                }
            }
        }

        private void menuItemAddNzbFromNewzbinId_Click(object sender, EventArgs e)
        {
            AddNzbFromNewzbinIdDialog addNzbFromNewzbinIdDialog = new AddNzbFromNewzbinIdDialog();
            if (addNzbFromNewzbinIdDialog.ShowDialog() == DialogResult.OK)
            {
                if (addNzbFromNewzbinIdDialog.newzbinId != String.Empty)
                {
                    IHellaNzbProxy hellaNzbProxy = InstantiateServer(_username, _password, _hostname, _port);
                    if (hellaNzbProxy != null)
                    {
                        hellaNzbProxy.EnqueueNewzbin(int.Parse(addNzbFromNewzbinIdDialog.newzbinId));
                        UpdateForm();
                    }
                }
            }
        }

        private void menuItemDisconnect_Click(object sender, EventArgs e)
        {
            ServerDisconnect();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            form_Close(sender, e);
            Close();
        }

        private void menuItemShowLog_Click(object sender, EventArgs e)
        {
            menuItemShowLog.Checked = (menuItemShowLog.Checked) ? false : true;
            splitContainerMainForm.Panel2Collapsed = (menuItemShowLog.Checked) ? false : true;
        }

        /// <summary>
        /// Application preferences menu item event handler
        /// </summary>
        private void menuItemPreferences_Click(object sender, EventArgs e)
        {
            // Instantiate preferences dialog
            PreferencesDialog preferencesDialog = new PreferencesDialog();
            // Update
            if (DialogResult.OK == preferencesDialog.ShowDialog())
            {
                // Open application preferences registry key
                _preferencesRegistryKey = Registry.CurrentUser.OpenSubKey(REGISTRY_KEY_PREFERENCES, true);
                
                // Set form update interval from preferences registry key
                _timer.Interval = ((string)_preferencesRegistryKey.GetValue(REGISTRY_VALUE_UI_UPDATE_INTERVAL) != null) ? int.Parse((string)_preferencesRegistryKey.GetValue(REGISTRY_VALUE_UI_UPDATE_INTERVAL)) : DEFAULT_UI_UPDATE_INTERVAL;
                // Set minimize to tray option from registry value
                _minimizeToTray = ((string)_preferencesRegistryKey.GetValue(REGISTRY_VALUE_UI_MINIMIZE_TO_TRAY) == "False") ? false : true;
                // Set disable tray notifications option from registry value
                _minimizeDisableNotifications = ((string)_preferencesRegistryKey.GetValue(REGISTRY_VALUE_UI_MINIMIZE_DISABLE_NOTIFICATIONS) == "False") ? false : true;

                // Close application preferences registry key
                _preferencesRegistryKey.Close();
            }
        }        

        /// <summary>
        /// Check for application updates menu item event handler
        /// </summary>
        private void menuItemCheckForUpdates_Click(object sender, EventArgs e)
        {
            // Check for application updates
            CheckForUpdates(true);
        }

        /// <summary>
        /// Display application license menu item event handler
        /// </summary>
        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            string title = "About " + Application.ProductName;
            string message = Application.ProductName + " " + VERSION + ", " + VERSION_DATE + Environment.NewLine
            + "Copyright © 2010-2011 Ryon Sherman" + Environment.NewLine
            + "http://code.google.com/p/hellanzb-remote-dotnet/" + Environment.NewLine
            + Environment.NewLine
            + "This program is free software: you can redistribute it and/or modify "
            + "it under the terms of the GNU General Public License (GPL) as published by "
            + "the Free Software Foundation, either version 3 of the License, or "
            + "(at your option) any later version." + Environment.NewLine
            + Environment.NewLine
            + "This program is distributed in the hope that it will be useful, "
            + "but WITHOUT ANY WARRANTY; without even the implied warranty of "
            + "MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the "
            + "GNU General Public License for more details." + Environment.NewLine
            + Environment.NewLine
            + "You should have received a copy of the GNU General Public License"
            + "along with this program.  If not, see http://www.gnu.org/licenses/gpl.html";

            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //
        // ToolStripButton Event Handlers
        //

        private void toolStripButtonConnect_Click(object sender, EventArgs e)
        {
            if (!_isConnected) ServerConnect();
        }

        private void toolStripButtonConnect_DropDownClick(object sender, EventArgs e)
        {
            UpdateServerList();

            toolStripButtonConnect.DropDownItems.Clear();
            for (int index = 0; index < _serversList.Count; index++)
            {
                string[] server = (string[])_serversList[index];
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = server[0] + "@" + server[2] + ":" + server[3];
                item.Tag = index;
                if ((int)item.Tag == _serversListIndex)
                {
                    item.Checked = true;
                }
                toolStripButtonConnect.DropDownItems.Add(item);
            }
        }

        private void toolStripButtonConnect_DropDownItemClick(object sender, ToolStripItemClickedEventArgs e)
        {
            int selectedIndex = (int)e.ClickedItem.Tag;

            if (selectedIndex != _serversListIndex || (selectedIndex == _serversListIndex && !_isConnected))
            {
                ServerDisconnect();
                SelectServer(selectedIndex);
                ServerConnect();
            }
        }

        private void toolStripButtonDisconnect_Click(object sender, EventArgs e)
        {
            menuItemDisconnect_Click(sender, e);
        }

        private void toolStripButtonAddNzbFromFile_Click(object sender, EventArgs e)
        {
            menuItemAddNzbFromFile_Click(sender, e);
        }

        private void toolStripButtonAddNzbFromWeb_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItemAddNzbFromUrl.Checked)
            {
                toolStripMenuItemAddNzbFromUrl_Click(sender, e);
            }
            else if (toolStripMenuItemAddNzbFromNewzbinId.Checked)
            {
                toolStripMenuItemAddNzbFromNewzbinId_Click(sender, e);
            }
        }

        private void toolStripMenuItemAddNzbFromUrl_Click(object sender, EventArgs e)
        {
            toolStripMenuItemAddNzbFromUrl.Checked = true;
            toolStripMenuItemAddNzbFromNewzbinId.Checked = false;
            menuItemAddNzbFromUrl_Click(sender, e);
        }

        private void toolStripMenuItemAddNzbFromNewzbinId_Click(object sender, EventArgs e)
        {
            toolStripMenuItemAddNzbFromNewzbinId.Checked = true;
            toolStripMenuItemAddNzbFromUrl.Checked = false;
            menuItemAddNzbFromNewzbinId_Click(sender, e);
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            string title = Application.ProductName;
            string message = "Are you sure you want to remove the selected NZB?";
            if (DialogResult.Yes == MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                IHellaNzbProxy hellaNzbProxy = InstantiateServer(_username, _password, _hostname, _port);
                if (hellaNzbProxy != null)
                {
                    if (_transferListViewIndex == 0)
                    {
                        hellaNzbProxy.Cancel();
                    }
                    else
                    {
                        ListViewItem transferListViewItem = listViewTransfers.Items[_transferListViewIndex];
                        ArrayList itemTagArrayList = (ArrayList)transferListViewItem.Tag;
                        hellaNzbProxy.Dequeue((int)itemTagArrayList[0]);
                    }
                    _transferListViewIndex = -1;
                    UpdateForm();
                }
            }
        }

        private void toolStripButtonForceStart_Click(object sender, EventArgs e)
        {
            IHellaNzbProxy hellaNzbProxy = InstantiateServer(_username, _password, _hostname, _port);
            if (hellaNzbProxy != null)
            {
                ListViewItem transferListViewItem = listViewTransfers.Items[_transferListViewIndex];
                ArrayList itemTagArrayList = (ArrayList)transferListViewItem.Tag;
                hellaNzbProxy.Force((int)itemTagArrayList[0]);
                _transferListViewIndex = 0;
                UpdateForm();
            }
        }

        private void toolStripButtonResume_Click(object sender, EventArgs e)
        {
            IHellaNzbProxy hellaNzbProxy = InstantiateServer(_username, _password, _hostname, _port);
            if (hellaNzbProxy != null)
            {
                hellaNzbProxy.Continue();
                UpdateForm();
            }
        }

        private void toolStripButtonPause_Click(object sender, EventArgs e)
        {
            IHellaNzbProxy hellaNzbProxy = InstantiateServer(_username, _password, _hostname, _port);
            if (hellaNzbProxy != null)
            {
                hellaNzbProxy.Pause();
                UpdateForm();
            }
        }

        private void toolStripButtonQueueDown_Click(object sender, EventArgs e)
        {
            IHellaNzbProxy hellaNzbProxy = InstantiateServer(_username, _password, _hostname, _port);
            if (hellaNzbProxy != null)
            {
                if (_transferListViewIndex == 0)
                {
                    ListViewItem transferListViewItem = listViewTransfers.Items[1];
                    ArrayList itemTagArrayList = (ArrayList)transferListViewItem.Tag;
                    hellaNzbProxy.Force((int)itemTagArrayList[0]);
                    _transferListViewIndex = 1;
                    UpdateForm();
                }
                else
                {
                    ListViewItem transferListViewItem = listViewTransfers.Items[_transferListViewIndex];
                    ArrayList itemTagArrayList = (ArrayList)transferListViewItem.Tag;
                    hellaNzbProxy.Down((int)itemTagArrayList[0], 1);
                    UpdateForm();
                }
            }
        }

        private void toolStripButtonQueueUp_Click(object sender, EventArgs e)
        {
            IHellaNzbProxy hellaNzbProxy = InstantiateServer(_username, _password, _hostname, _port);
            if (hellaNzbProxy != null)
            {
                ListViewItem transferListViewItem = listViewTransfers.Items[_transferListViewIndex];
                ArrayList itemTagArrayList = (ArrayList)transferListViewItem.Tag;
                if (_transferListViewIndex == 1)
                {
                    hellaNzbProxy.Force((int)itemTagArrayList[0]);
                    _transferListViewIndex = 0;
                    UpdateForm();
                }
                else
                {
                    hellaNzbProxy.Up((int)itemTagArrayList[0], 1);
                    UpdateForm();
                }
            }
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            string title = Application.ProductName;
            string message = "Are you sure you want to cancel the current download?";
            if (DialogResult.Yes == MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                IHellaNzbProxy hellaNzbProxy = InstantiateServer(_username, _password, _hostname, _port);
                if (hellaNzbProxy != null)
                {
                    hellaNzbProxy.Cancel();
                    _transferListViewIndex = -1;
                    UpdateForm();
                }
            }
        }

        private void toolStripButtonPreferences_Click(object sender, EventArgs e)
        {
            menuItemPreferences_Click(sender, e);
        }

        private void toolStripButtonReload_Click(object sender, EventArgs e)
        {
            UpdateForm();
        }

        //
        // ListView Event Handlers
        //

        private void listViewTransfers_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewItem transferListViewItem = listViewTransfers.GetItemAt(e.X, e.Y);
            _transferListViewIndex = (transferListViewItem != null) ? transferListViewItem.Index : -1;
        }

        private void listViewTransfers_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateForm();

            listViewTransfers.ContextMenu = (_transferListViewIndex >= 0) ? contextMenuTransfers : null;
            
            if (_transferListViewIndex == 0)
            {                
                toolStripButtonForceStart.Enabled = contextMenuItemForceStart.Enabled = false;
                toolStripButtonRemove.Enabled = contextMenuItemRemove.Visible = false;
                toolStripButtonCancel.Enabled = contextMenuItemCancel.Visible = true;                
                toolStripButtonQueueUp.Enabled = contextMenuItemQueueUp.Enabled = false;
                toolStripButtonQueueDown.Enabled = contextMenuItemQueueDown.Enabled = true;
            }            
            else if (_transferListViewIndex == listViewTransfers.Items.Count - 1)
            {
                toolStripButtonForceStart.Enabled = contextMenuItemForceStart.Enabled = true;
                toolStripButtonRemove.Visible = contextMenuItemRemove.Visible = true;
                toolStripButtonCancel.Enabled = contextMenuItemCancel.Visible = false;
                toolStripButtonQueueUp.Enabled = contextMenuItemQueueUp.Enabled = true;
                toolStripButtonQueueDown.Enabled = contextMenuItemQueueDown.Enabled = false;
            }
            else if (_transferListViewIndex > 0)
            {                
                toolStripButtonForceStart.Enabled = contextMenuItemForceStart.Enabled = true;
                toolStripButtonRemove.Enabled = contextMenuItemRemove.Visible = true;
                toolStripButtonCancel.Enabled = contextMenuItemCancel.Visible = false;
                toolStripButtonQueueUp.Enabled = contextMenuItemQueueUp.Enabled = true;
                toolStripButtonQueueDown.Enabled = contextMenuItemQueueDown.Enabled = true;
            }
            else
            {                
                toolStripButtonForceStart.Enabled = false;                
                toolStripButtonRemove.Enabled = false;                
                toolStripButtonCancel.Enabled = false;                
                toolStripButtonQueueUp.Enabled = false;                
                toolStripButtonQueueDown.Enabled = false;                                
            }
        }

        //
        // ListView ContextMenuItem Event Handlers
        //

        private void contextMenuItemForceStart_Click(object sender, EventArgs e)
        {
            toolStripButtonForceStart_Click(sender, e);
        }

        private void contextMenuItemRemove_Click(object sender, EventArgs e)
        {
            toolStripButtonRemove_Click(sender, e);
        }

        private void contextMenuItemCancel_Click(object sender, EventArgs e)
        {
            toolStripButtonCancel_Click(sender, e);
        }

        private void contextMenuItemQueueDown_Click(object sender, EventArgs e)
        {
            toolStripButtonQueueDown_Click(sender, e);
        }

        private void contextMenuItemQueueUp_Click(object sender, EventArgs e)
        {
            toolStripButtonQueueUp_Click(sender, e);
        }

        private void contextMenuItemSetRarPassword_Click(object sender, EventArgs e)
        {
            ListViewItem transferListViewItem = listViewTransfers.Items[_transferListViewIndex];
            ArrayList itemTagArrayList = (ArrayList)transferListViewItem.Tag;

            string currentRarPassword = (itemTagArrayList[1] != null) ? (string)itemTagArrayList[1] : string.Empty;

            SetRarPasswordDialog setRarPasswordDialog = new SetRarPasswordDialog(currentRarPassword);
            if (setRarPasswordDialog.ShowDialog() == DialogResult.OK)
            {
                if (setRarPasswordDialog.rarPassword != string.Empty)
                {
                    IHellaNzbProxy hellaNzbProxy = InstantiateServer(_username, _password, _hostname, _port);
                    if (hellaNzbProxy != null)
                    {                        
                        hellaNzbProxy.SetRarPassword((int)itemTagArrayList[0], setRarPasswordDialog.rarPassword);
                        UpdateForm();
                    }
                }
            }
        }

        //
        // NotifyIcon Event Handlers
        //

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            // Hide minimize message
            _minimizeHideMessage = true;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                form_Restore(sender, e);
            }
        }

        private void notifyIcon_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    if (_isConnected)
                    {
                        string message;
                        if (_isPaused)
                        {
                            message = "Paused";
                        }
                        else if (listViewTransfers.Items.Count > 0)
                        {
                            string file = listViewTransfers.Items[0].SubItems[1].Text;
                            string percent = ((Int32)_statusStruct["percent_complete"]).ToString();
                            int eta = (Int32)_statusStruct["eta"];
                            string speed = ((eta > 0) ? ((int)_statusStruct["rate"]).ToString() : "0") + " kB/s";

                            message = file + " is at " + percent + "%" + Environment.NewLine;
                            message += "ETA " + TimeSpan.FromSeconds(eta).ToString() + " at " + speed;
                        }
                        else
                        {
                            message = "Idle";
                        }
                        ShowNotifyIconMessage(message);
                    }
                    else
                    {
                        ShowNotifyIconMessage("Disconnected");
                    }
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                notifyIcon.ContextMenu = contextMenuNotifyIcon;
            }
        }

        //
        // NotifyIcon ContextMenuItem Event Handlers
        //      

        private void contextMenuItemOpen_click(object sender, EventArgs e)
        {
            form_Restore(sender, e);
        }

        private void contextMenuItemResume_Click(object sender, EventArgs e)
        {
            toolStripButtonResume_Click(sender, e);
        }

        private void contextMenuItemPause_Click(object sender, EventArgs e)
        {
            toolStripButtonPause_Click(sender, e);
        }

        private void contextMenuItemAddNzbFromFile_Click(object sender, EventArgs e)
        {
            menuItemAddNzbFromFile_Click(sender, e);
        }

        private void contextMenuItemAddNzbFromUrl_Click(object sender, EventArgs e)
        {
            menuItemAddNzbFromUrl_Click(sender, e);
        }

        private void contextMenuItemAddNzbFromNewzbinId_Click(object sender, EventArgs e)
        {
            menuItemAddNzbFromNewzbinId_Click(sender, e);
        }

        private void contextMenuItemPreferences_Click(object sender, EventArgs e)
        {
            form_Restore(sender, e);
            menuItemPreferences_Click(sender, e);
        }

        private void contextMenuItemDisconnect_Click(object sender, EventArgs e)
        {
            menuItemDisconnect_Click(sender, e);
        }

        private void contextMenuItemExit_Click(object sender, EventArgs e)
        {
            menuItemExit_Click(sender, e);
        }

        //
        // UI Control Methods
        //

        private void ToggleUiItemsConnected(string status)
        {
            menuItemAddNzbFromFile.Enabled = true;
            menuItemAddNzbFromUrl.Enabled = true;
            menuItemAddNzbFromNewzbinId.Enabled = true;

            toolStripButtonAddNzbFromFile.Enabled = true;
            toolStripButtonAddNzbFromWeb.Enabled = true;
            toolStripButtonPause.Enabled = true;
            toolStripButtonReload.Enabled = true;
            
            statusLabelDisconnectedIcon.Visible = false;
            statusLabelConnectingIcon.Visible = false;
            statusLabelConnectedIcon.Visible = true;
            statusLabelStatus.Text = status;

            contextMenuItemAddNzb.Enabled = true;
        }

        private void ToggleUiItemsConnecting(string status)
        {
            menuItemDisconnect.Enabled = true;

            toolStripButtonDisconnect.Enabled = true;
            
            statusLabelDisconnectedIcon.Visible = false;
            statusLabelConnectedIcon.Visible = false;
            statusLabelConnectingIcon.Visible = true;
            statusLabelStatus.Text = status;

            contextMenuItemDisconnect.Enabled = true;
        }

        private void ToggleUiItemsDisconnected(string status = null)
        {
            menuItemDisconnect.Enabled = false;
            menuItemAddNzbFromFile.Enabled = false;
            menuItemAddNzbFromUrl.Enabled = false;
            menuItemAddNzbFromNewzbinId.Enabled = false;
            toolStripButtonDisconnect.Enabled = false;
            toolStripButtonAddNzbFromFile.Enabled = false;
            toolStripButtonAddNzbFromWeb.Enabled = false;                    
            toolStripButtonRemove.Enabled = false;
            toolStripButtonForceStart.Enabled = false;
            toolStripButtonResume.Visible = false;
            toolStripButtonPause.Visible = true;
            toolStripButtonPause.Enabled = false;
            toolStripButtonCancel.Enabled = false;
            toolStripButtonQueueDown.Enabled = false;
            toolStripButtonQueueUp.Enabled = false;
            toolStripButtonReload.Enabled = false;
            
            listViewTransfers.Items.Clear();
            listBoxLog.Items.Clear();

            statusLabelSpeed.Text = "Idle";
            statusLabelConnectingIcon.Visible = false;
            statusLabelConnectedIcon.Visible = false;
            statusLabelDisconnectedIcon.Visible = true;
            statusLabelStatus.Text = (status != null) ? status : "Disconnected";

            contextMenuItemResume.Visible = false;
            contextMenuItemPause.Visible = true;
            contextMenuItemPause.Enabled = false;
            contextMenuItemAddNzb.Enabled = false;
            contextMenuItemDisconnect.Enabled = false;
        }

        private void ToggleUiItemsPaused()
        {
            if (_isPaused)
            {
                toolStripButtonResume.Visible = true;
                toolStripButtonPause.Visible = false;
                toolStripButtonPause.Enabled = false;

                statusLabelSpeed.Text = "Paused";

                contextMenuItemResume.Visible = true;
                contextMenuItemPause.Visible = false;
                contextMenuItemPause.Enabled = false;
            }
            else if (listViewTransfers.Items.Count > 0)
            {
                toolStripButtonResume.Visible = false;
                toolStripButtonPause.Visible = true;
                toolStripButtonPause.Enabled = true;

                int eta = (Int32)_statusStruct["eta"];
                statusLabelSpeed.Text = ((eta > 0) ? statusLabelSpeed.Text = "ETA " + TimeSpan.FromSeconds(eta).ToString() + " @ " + ((int)_statusStruct["rate"]).ToString() : "0") + " kB/s";

                contextMenuItemResume.Visible = false;
                contextMenuItemPause.Visible = true;
                contextMenuItemPause.Enabled = true;
            }
            else
            {
                toolStripButtonResume.Visible = false;
                toolStripButtonPause.Visible = true;
                toolStripButtonPause.Enabled = false;

                statusLabelSpeed.Text = "Idle";

                contextMenuItemResume.Visible = false;
                contextMenuItemPause.Visible = true;
                contextMenuItemPause.Enabled = false;
            }
        }
        
        /// <summary>
        /// Send system tray icon notification message
        /// </summary>
        private void ShowNotifyIconMessage(string message, ToolTipIcon icon = ToolTipIcon.Info)
        {
            // Set balloon tip details
            notifyIcon.BalloonTipIcon = icon;
            notifyIcon.BalloonTipTitle = Application.ProductName;
            notifyIcon.BalloonTipText = message;
            // Remove 
            notifyIcon.BalloonTipClicked -= notifyIcon_BalloonTipClicked;
            notifyIcon.BalloonTipClicked += new EventHandler(form_Restore);
            notifyIcon.ShowBalloonTip(500);
        }
                
        //
        // Server Methods
        //
        
        /// <summary>
        /// Currently selected server index
        /// </summary>
        private int _serversListIndex = -1;
        /// <summary>
        /// List of available servers
        /// </summary>
        ArrayList _serversList = new ArrayList();

        /// <summary>
        /// Populate servers array list and perform auto-connect
        /// </summary>
        private void UpdateServerList()
        {
            // Open application server list registry key
            _serverListRegistryKey = Registry.CurrentUser.OpenSubKey(REGISTRY_KEY_SERVER_LIST, true);

            // Clear servers array list
            _serversList.Clear();
            // Iterate list of servers from registry key
            foreach (string registryKeyValue in _serverListRegistryKey.GetValueNames())
            {
                // Get server from registry key
                string[] server = (string[])_serverListRegistryKey.GetValue(registryKeyValue);
                // Add server to server array list
                _serversList.Add(server);

                // Check if current server auto-connect option is selected
                if (server[INDEX_SERVER_AUTOCONNECT] == "True" && !_isConnected)
                {
                    // Select current server
                    SelectServer(int.Parse(registryKeyValue));
                    // Connect to server
                    ServerConnect();
                }
            }

            // Close application server list registry key
            _serverListRegistryKey.Close();

            // Select only server available
            if (_serversList.Count == 1)
            {
                SelectServer(0);
            }
        }

        /// <summary>
        /// Connection authentication username
        /// </summary>
        private string _username = "hellanzb";
        /// <summary>
        /// Connection authentication password
        /// </summary>
        private string _password = "changeme";
        /// <summary>
        /// Connection hostname
        /// </summary>
        private string _hostname = "localhost";
        /// <summary>
        /// Connection port
        /// </summary>
        private string _port = "8760";

        /// <summary>
        /// Select current server from server list array
        /// </summary>
        private void SelectServer(int index)
        {
            // Set current server index
            _serversListIndex = index;
            // Get server from server list array
            string[] Server = (string[])_serversList[_serversListIndex];
            // Set server connection details
            _username = Server[INDEX_SERVER_USERNAME];
            _password = Server[INDEX_SERVER_PASSWORD];
            _hostname = Server[INDEX_SERVER_HOSTNAME];
            _port = Server[INDEX_SERVER_PORT];
        }

        /// <summary>
        /// Connect to server
        /// </summary>
        private void ServerConnect()
        {            
            // Start form update timer
            _timer.Start();
            // Toggle connecting status
            ToggleUiItemsConnecting("Connecting to " + _username + "@" + _hostname + ":" + _port);
        }

        /// <summary>
        /// Connect from server
        /// </summary>
        private void ServerDisconnect(string status = null)
        {
            // Stop form update timer
            _timer.Stop();
            // Set currently connected boolean to false
            _isConnected = false;
            // Clear last log entry
            _lastLogString = string.Empty;
            // Reset transfer list view index
            _transferListViewIndex = -1;
            // Toggle disconnected status
            ToggleUiItemsDisconnected(status);
        }

        /// <summary>
        /// Instantiate server proxy
        /// </summary>
        public static IHellaNzbProxy InstantiateServer(string username, string password, string hostname, string port)
        {
            // Create server proxy
            IHellaNzbProxy HellaNzbProxy = XmlRpcProxyGen.Create<IHellaNzbProxy>();

            try
            {
                // Attempt connect to server
                HellaNzbProxy.Url = "http://" + hostname + ":" + port;
                HellaNzbProxy.Credentials = new System.Net.NetworkCredential(username, password);
            }
            catch (Exception)
            {
                return null;
            }

            // Return server proxy
            return HellaNzbProxy;
        }
    }

    /// <summary>
    /// Server proxy interface
    /// </summary>
    public interface IHellaNzbProxy : IXmlRpcProxy
    {
        [XmlRpcMethod("status")]            
        XmlRpcStruct Status();

        [XmlRpcMethod("pause")]             
        XmlRpcStruct Pause();

        [XmlRpcMethod("continue")]          
        XmlRpcStruct Continue();

        [XmlRpcMethod("force")]             
        XmlRpcStruct Force(int id);

        [XmlRpcMethod("dequeue")]           
        void Dequeue(int id);

        [XmlRpcMethod("down")]              
        void Down(int id, int amount);

        [XmlRpcMethod("up")]                
        void Up(int id, int amount);

        [XmlRpcMethod("cancel")]            
        void Cancel();

        [XmlRpcMethod("enqueueurl")]        
        void EnqueueURL(string url);

        [XmlRpcMethod("enqueuenewzbin")]    
        XmlRpcStruct EnqueueNewzbin(int id);

        [XmlRpcMethod("setrarpass")]
        XmlRpcStruct SetRarPassword(int id, string password);
    }
}
