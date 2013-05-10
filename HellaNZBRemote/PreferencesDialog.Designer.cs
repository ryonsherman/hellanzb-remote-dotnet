namespace HellaNzbRemote
{
    partial class PreferencesDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesDialog));
            this.tabControlPreferences = new System.Windows.Forms.TabControl();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.removeServerButton = new System.Windows.Forms.Button();
            this.buttonSaveServer = new System.Windows.Forms.Button();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelHostname = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.checkBoxConnectAtStart = new System.Windows.Forms.CheckBox();
            this.buttonTestConnection = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxHostname = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.listBoxServers = new System.Windows.Forms.ListBox();
            this.labelServers = new System.Windows.Forms.Label();
            this.tabPageUi = new System.Windows.Forms.TabPage();
            this.checkBoxDisableTrayNotifications = new System.Windows.Forms.CheckBox();
            this.checkBoxCheckForUpdates = new System.Windows.Forms.CheckBox();
            this.checkBoxMinimizeAtStart = new System.Windows.Forms.CheckBox();
            this.checkBoxMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.numBoxFormUpdateInterval = new System.Windows.Forms.NumericUpDown();
            this.labelFormUpdateInterval = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.usernameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.passwordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.hostnameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.portErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBoxStartAtLogin = new System.Windows.Forms.CheckBox();
            this.tabControlPreferences.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.tabPageUi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxFormUpdateInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostnameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPreferences
            // 
            this.tabControlPreferences.Controls.Add(this.tabPageConnection);
            this.tabControlPreferences.Controls.Add(this.tabPageUi);
            this.tabControlPreferences.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlPreferences.Location = new System.Drawing.Point(5, 5);
            this.tabControlPreferences.Name = "tabControlPreferences";
            this.tabControlPreferences.SelectedIndex = 0;
            this.tabControlPreferences.Size = new System.Drawing.Size(479, 231);
            this.tabControlPreferences.TabIndex = 3;
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.Controls.Add(this.removeServerButton);
            this.tabPageConnection.Controls.Add(this.buttonSaveServer);
            this.tabPageConnection.Controls.Add(this.labelPort);
            this.tabPageConnection.Controls.Add(this.labelHostname);
            this.tabPageConnection.Controls.Add(this.labelPassword);
            this.tabPageConnection.Controls.Add(this.checkBoxConnectAtStart);
            this.tabPageConnection.Controls.Add(this.buttonTestConnection);
            this.tabPageConnection.Controls.Add(this.textBoxPort);
            this.tabPageConnection.Controls.Add(this.textBoxHostname);
            this.tabPageConnection.Controls.Add(this.textBoxPassword);
            this.tabPageConnection.Controls.Add(this.textBoxUsername);
            this.tabPageConnection.Controls.Add(this.labelUsername);
            this.tabPageConnection.Controls.Add(this.listBoxServers);
            this.tabPageConnection.Controls.Add(this.labelServers);
            this.tabPageConnection.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnection.Size = new System.Drawing.Size(471, 205);
            this.tabPageConnection.TabIndex = 0;
            this.tabPageConnection.Text = "Connection";
            this.tabPageConnection.UseVisualStyleBackColor = true;
            // 
            // removeServerButton
            // 
            this.removeServerButton.Enabled = false;
            this.removeServerButton.Location = new System.Drawing.Point(88, 173);
            this.removeServerButton.Name = "removeServerButton";
            this.removeServerButton.Size = new System.Drawing.Size(75, 23);
            this.removeServerButton.TabIndex = 13;
            this.removeServerButton.Text = "&Remove";
            this.removeServerButton.UseVisualStyleBackColor = true;
            this.removeServerButton.Click += new System.EventHandler(this.buttonRemoveServer_Click);
            // 
            // buttonSaveServer
            // 
            this.buttonSaveServer.Location = new System.Drawing.Point(6, 172);
            this.buttonSaveServer.Name = "buttonSaveServer";
            this.buttonSaveServer.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveServer.TabIndex = 12;
            this.buttonSaveServer.Text = "&Add Server";
            this.buttonSaveServer.UseVisualStyleBackColor = true;
            this.buttonSaveServer.Click += new System.EventHandler(this.buttonSaveServer_Click);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(284, 105);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(29, 13);
            this.labelPort.TabIndex = 11;
            this.labelPort.Text = "Port:";
            // 
            // labelHostname
            // 
            this.labelHostname.AutoSize = true;
            this.labelHostname.Location = new System.Drawing.Point(240, 79);
            this.labelHostname.Name = "labelHostname";
            this.labelHostname.Size = new System.Drawing.Size(73, 13);
            this.labelHostname.TabIndex = 10;
            this.labelHostname.Text = "Hostname/IP:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(257, 53);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Password:";
            // 
            // checkBoxConnectAtStart
            // 
            this.checkBoxConnectAtStart.AutoSize = true;
            this.checkBoxConnectAtStart.Location = new System.Drawing.Point(319, 159);
            this.checkBoxConnectAtStart.Name = "checkBoxConnectAtStart";
            this.checkBoxConnectAtStart.Size = new System.Drawing.Size(113, 17);
            this.checkBoxConnectAtStart.TabIndex = 8;
            this.checkBoxConnectAtStart.Text = "Connect at startup";
            this.checkBoxConnectAtStart.UseVisualStyleBackColor = true;
            // 
            // buttonTestConnection
            // 
            this.buttonTestConnection.Location = new System.Drawing.Point(319, 129);
            this.buttonTestConnection.Name = "buttonTestConnection";
            this.buttonTestConnection.Size = new System.Drawing.Size(130, 23);
            this.buttonTestConnection.TabIndex = 7;
            this.buttonTestConnection.Text = "&Test Connection";
            this.buttonTestConnection.UseVisualStyleBackColor = true;
            this.buttonTestConnection.Click += new System.EventHandler(this.buttonTestConnection_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(319, 102);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(130, 20);
            this.textBoxPort.TabIndex = 6;
            // 
            // textBoxHostname
            // 
            this.textBoxHostname.Location = new System.Drawing.Point(319, 76);
            this.textBoxHostname.Name = "textBoxHostname";
            this.textBoxHostname.Size = new System.Drawing.Size(130, 20);
            this.textBoxHostname.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(319, 50);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(130, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(319, 24);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(130, 20);
            this.textBoxUsername.TabIndex = 3;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(255, 27);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username:";
            // 
            // listBoxServers
            // 
            this.listBoxServers.FormattingEnabled = true;
            this.listBoxServers.Location = new System.Drawing.Point(6, 19);
            this.listBoxServers.Name = "listBoxServers";
            this.listBoxServers.Size = new System.Drawing.Size(228, 147);
            this.listBoxServers.TabIndex = 1;
            this.listBoxServers.SelectedIndexChanged += new System.EventHandler(this.listBoxServers_SelectedIndexChanged);
            // 
            // labelServers
            // 
            this.labelServers.AutoSize = true;
            this.labelServers.Location = new System.Drawing.Point(6, 3);
            this.labelServers.Name = "labelServers";
            this.labelServers.Size = new System.Drawing.Size(46, 13);
            this.labelServers.TabIndex = 0;
            this.labelServers.Text = "Servers:";
            // 
            // tabPageUi
            // 
            this.tabPageUi.Controls.Add(this.checkBoxStartAtLogin);
            this.tabPageUi.Controls.Add(this.checkBoxDisableTrayNotifications);
            this.tabPageUi.Controls.Add(this.checkBoxCheckForUpdates);
            this.tabPageUi.Controls.Add(this.checkBoxMinimizeAtStart);
            this.tabPageUi.Controls.Add(this.checkBoxMinimizeToTray);
            this.tabPageUi.Controls.Add(this.numBoxFormUpdateInterval);
            this.tabPageUi.Controls.Add(this.labelFormUpdateInterval);
            this.tabPageUi.Location = new System.Drawing.Point(4, 22);
            this.tabPageUi.Name = "tabPageUi";
            this.tabPageUi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUi.Size = new System.Drawing.Size(471, 205);
            this.tabPageUi.TabIndex = 1;
            this.tabPageUi.Text = "User Interface";
            this.tabPageUi.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisableTrayNotifications
            // 
            this.checkBoxDisableTrayNotifications.AutoSize = true;
            this.checkBoxDisableTrayNotifications.Location = new System.Drawing.Point(163, 56);
            this.checkBoxDisableTrayNotifications.Name = "checkBoxDisableTrayNotifications";
            this.checkBoxDisableTrayNotifications.Size = new System.Drawing.Size(140, 17);
            this.checkBoxDisableTrayNotifications.TabIndex = 5;
            this.checkBoxDisableTrayNotifications.Text = "Disable tray notifications";
            this.checkBoxDisableTrayNotifications.UseVisualStyleBackColor = true;
            // 
            // checkBoxCheckForUpdates
            // 
            this.checkBoxCheckForUpdates.AutoSize = true;
            this.checkBoxCheckForUpdates.Checked = true;
            this.checkBoxCheckForUpdates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCheckForUpdates.Location = new System.Drawing.Point(163, 126);
            this.checkBoxCheckForUpdates.Name = "checkBoxCheckForUpdates";
            this.checkBoxCheckForUpdates.Size = new System.Drawing.Size(143, 17);
            this.checkBoxCheckForUpdates.TabIndex = 4;
            this.checkBoxCheckForUpdates.Text = "Check for update at start";
            this.checkBoxCheckForUpdates.UseVisualStyleBackColor = true;
            // 
            // checkBoxMinimizeAtStart
            // 
            this.checkBoxMinimizeAtStart.AutoSize = true;
            this.checkBoxMinimizeAtStart.Location = new System.Drawing.Point(163, 103);
            this.checkBoxMinimizeAtStart.Name = "checkBoxMinimizeAtStart";
            this.checkBoxMinimizeAtStart.Size = new System.Drawing.Size(101, 17);
            this.checkBoxMinimizeAtStart.TabIndex = 3;
            this.checkBoxMinimizeAtStart.Text = "Minimize at start";
            this.checkBoxMinimizeAtStart.UseVisualStyleBackColor = true;
            // 
            // checkBoxMinimizeToTray
            // 
            this.checkBoxMinimizeToTray.AutoSize = true;
            this.checkBoxMinimizeToTray.Checked = true;
            this.checkBoxMinimizeToTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMinimizeToTray.Location = new System.Drawing.Point(163, 33);
            this.checkBoxMinimizeToTray.Name = "checkBoxMinimizeToTray";
            this.checkBoxMinimizeToTray.Size = new System.Drawing.Size(133, 17);
            this.checkBoxMinimizeToTray.TabIndex = 2;
            this.checkBoxMinimizeToTray.Text = "Minimize to system tray";
            this.checkBoxMinimizeToTray.UseVisualStyleBackColor = true;
            // 
            // numBoxFormUpdateInterval
            // 
            this.numBoxFormUpdateInterval.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numBoxFormUpdateInterval.Location = new System.Drawing.Point(163, 6);
            this.numBoxFormUpdateInterval.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numBoxFormUpdateInterval.Name = "numBoxFormUpdateInterval";
            this.numBoxFormUpdateInterval.Size = new System.Drawing.Size(120, 20);
            this.numBoxFormUpdateInterval.TabIndex = 1;
            this.numBoxFormUpdateInterval.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // labelFormUpdateInterval
            // 
            this.labelFormUpdateInterval.AutoSize = true;
            this.labelFormUpdateInterval.Location = new System.Drawing.Point(8, 8);
            this.labelFormUpdateInterval.Name = "labelFormUpdateInterval";
            this.labelFormUpdateInterval.Size = new System.Drawing.Size(149, 13);
            this.labelFormUpdateInterval.TabIndex = 0;
            this.labelFormUpdateInterval.Text = "Update transfer list every (ms):";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(409, 241);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(328, 241);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // usernameErrorProvider
            // 
            this.usernameErrorProvider.ContainerControl = this;
            this.usernameErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("usernameErrorProvider.Icon")));
            // 
            // passwordErrorProvider
            // 
            this.passwordErrorProvider.ContainerControl = this;
            this.passwordErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("passwordErrorProvider.Icon")));
            // 
            // hostnameErrorProvider
            // 
            this.hostnameErrorProvider.ContainerControl = this;
            this.hostnameErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("hostnameErrorProvider.Icon")));
            // 
            // portErrorProvider
            // 
            this.portErrorProvider.ContainerControl = this;
            this.portErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("portErrorProvider.Icon")));
            // 
            // checkBoxStartAtLogin
            // 
            this.checkBoxStartAtLogin.AutoSize = true;
            this.checkBoxStartAtLogin.Location = new System.Drawing.Point(163, 80);
            this.checkBoxStartAtLogin.Name = "checkBoxStartAtLogin";
            this.checkBoxStartAtLogin.Size = new System.Drawing.Size(85, 17);
            this.checkBoxStartAtLogin.TabIndex = 6;
            this.checkBoxStartAtLogin.Text = "Start at login";
            this.checkBoxStartAtLogin.UseVisualStyleBackColor = true;
            // 
            // PreferencesDialog
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 272);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tabControlPreferences);
            this.Controls.Add(this.buttonCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PreferencesDialog";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.tabControlPreferences.ResumeLayout(false);
            this.tabPageConnection.ResumeLayout(false);
            this.tabPageConnection.PerformLayout();
            this.tabPageUi.ResumeLayout(false);
            this.tabPageUi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxFormUpdateInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostnameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPreferences;
        private System.Windows.Forms.TabPage tabPageConnection;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button removeServerButton;
        private System.Windows.Forms.Button buttonSaveServer;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelHostname;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.CheckBox checkBoxConnectAtStart;
        private System.Windows.Forms.Button buttonTestConnection;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxHostname;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.ListBox listBoxServers;
        private System.Windows.Forms.Label labelServers;
        private System.Windows.Forms.ErrorProvider usernameErrorProvider;
        private System.Windows.Forms.ErrorProvider passwordErrorProvider;
        private System.Windows.Forms.ErrorProvider hostnameErrorProvider;
        private System.Windows.Forms.ErrorProvider portErrorProvider;
        private System.Windows.Forms.TabPage tabPageUi;
        private System.Windows.Forms.NumericUpDown numBoxFormUpdateInterval;
        private System.Windows.Forms.Label labelFormUpdateInterval;
        private System.Windows.Forms.CheckBox checkBoxMinimizeToTray;
        private System.Windows.Forms.CheckBox checkBoxMinimizeAtStart;
        private System.Windows.Forms.CheckBox checkBoxCheckForUpdates;
        private System.Windows.Forms.CheckBox checkBoxDisableTrayNotifications;
        private System.Windows.Forms.CheckBox checkBoxStartAtLogin;

    }
}