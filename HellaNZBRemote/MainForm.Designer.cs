namespace HellaNzbRemote
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabelSpeed = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeperator9 = new System.Windows.Forms.ToolStripSeparator();
            this.statusLabelDisconnectedIcon = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelConnectingIcon = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelConnectedIcon = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAddNzbFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAddNzbFromUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAddNzbFromNewzbinId = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemShowLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOptionsHelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonConnect = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripButtonDisconnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAddNzbFromFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddNzbFromWeb = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItemAddNzbFromUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddNzbFromNewzbinId = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonForceStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonResume = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonQueueDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonQueueUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPreferences = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReload = new System.Windows.Forms.ToolStripButton();
            this.splitContainerMainForm = new System.Windows.Forms.SplitContainer();
            this.listViewTransfers = new System.Windows.Forms.ListView();
            this.columnHeaderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProgress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControlMainForm = new System.Windows.Forms.TabControl();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.contextMenuTransfers = new System.Windows.Forms.ContextMenu();
            this.contextMenuItemForceStart = new System.Windows.Forms.MenuItem();
            this.contextMenuItemRemove = new System.Windows.Forms.MenuItem();
            this.contextMenuItemCancel = new System.Windows.Forms.MenuItem();
            this.contextMenuItemSeperator1 = new System.Windows.Forms.MenuItem();
            this.contextMenuItemQueueUp = new System.Windows.Forms.MenuItem();
            this.contextMenuItemQueueDown = new System.Windows.Forms.MenuItem();
            this.contextMenuItemSeperator2 = new System.Windows.Forms.MenuItem();
            this.contextMenuItemSetRarPassword = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuNotifyIcon = new System.Windows.Forms.ContextMenu();
            this.contextMenuItemOpen = new System.Windows.Forms.MenuItem();
            this.contextMenuItemSeperator3 = new System.Windows.Forms.MenuItem();
            this.contextMenuItemResume = new System.Windows.Forms.MenuItem();
            this.contextMenuItemPause = new System.Windows.Forms.MenuItem();
            this.contextMenuItemAddNzb = new System.Windows.Forms.MenuItem();
            this.contextMenuItemAddNzbFromFile = new System.Windows.Forms.MenuItem();
            this.contextMenuItemAddNzbFromUrl = new System.Windows.Forms.MenuItem();
            this.contextMenuItemAddNzbFromNewzbinId = new System.Windows.Forms.MenuItem();
            this.contextMenuItemSeperator4 = new System.Windows.Forms.MenuItem();
            this.contextMenuItemPreferences = new System.Windows.Forms.MenuItem();
            this.contextMenuItemSeperator5 = new System.Windows.Forms.MenuItem();
            this.contextMenuItemDisconnect = new System.Windows.Forms.MenuItem();
            this.contextMenuItemExit = new System.Windows.Forms.MenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainForm)).BeginInit();
            this.splitContainerMainForm.Panel1.SuspendLayout();
            this.splitContainerMainForm.Panel2.SuspendLayout();
            this.splitContainerMainForm.SuspendLayout();
            this.tabControlMainForm.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelSpeed,
            this.toolStripSeperator9,
            this.statusLabelDisconnectedIcon,
            this.statusLabelConnectingIcon,
            this.statusLabelConnectedIcon,
            this.statusLabelStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 339);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(684, 23);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabelSpeed
            // 
            this.statusLabelSpeed.Name = "statusLabelSpeed";
            this.statusLabelSpeed.Size = new System.Drawing.Size(26, 18);
            this.statusLabelSpeed.Text = "Idle";
            // 
            // toolStripSeperator9
            // 
            this.toolStripSeperator9.Name = "toolStripSeperator9";
            this.toolStripSeperator9.Size = new System.Drawing.Size(6, 23);
            // 
            // statusLabelDisconnectedIcon
            // 
            this.statusLabelDisconnectedIcon.Image = ((System.Drawing.Image)(resources.GetObject("statusLabelDisconnectedIcon.Image")));
            this.statusLabelDisconnectedIcon.Name = "statusLabelDisconnectedIcon";
            this.statusLabelDisconnectedIcon.Size = new System.Drawing.Size(16, 18);
            // 
            // statusLabelConnectingIcon
            // 
            this.statusLabelConnectingIcon.Image = ((System.Drawing.Image)(resources.GetObject("statusLabelConnectingIcon.Image")));
            this.statusLabelConnectingIcon.Name = "statusLabelConnectingIcon";
            this.statusLabelConnectingIcon.Size = new System.Drawing.Size(16, 18);
            this.statusLabelConnectingIcon.Visible = false;
            // 
            // statusLabelConnectedIcon
            // 
            this.statusLabelConnectedIcon.Image = ((System.Drawing.Image)(resources.GetObject("statusLabelConnectedIcon.Image")));
            this.statusLabelConnectedIcon.Name = "statusLabelConnectedIcon";
            this.statusLabelConnectedIcon.Size = new System.Drawing.Size(16, 18);
            this.statusLabelConnectedIcon.Visible = false;
            // 
            // statusLabelStatus
            // 
            this.statusLabelStatus.Name = "statusLabelStatus";
            this.statusLabelStatus.Size = new System.Drawing.Size(79, 18);
            this.statusLabelStatus.Text = "Disconnected";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemOptions,
            this.menuItemOptionsHelpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(684, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAddNzbFromFile,
            this.menuItemAddNzbFromUrl,
            this.menuItemAddNzbFromNewzbinId,
            this.toolStripSeparator1,
            this.menuItemDisconnect,
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "&File";
            // 
            // menuItemAddNzbFromFile
            // 
            this.menuItemAddNzbFromFile.Enabled = false;
            this.menuItemAddNzbFromFile.Name = "menuItemAddNzbFromFile";
            this.menuItemAddNzbFromFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuItemAddNzbFromFile.Size = new System.Drawing.Size(266, 22);
            this.menuItemAddNzbFromFile.Text = "&Add NZB from File...";
            this.menuItemAddNzbFromFile.Visible = false;
            this.menuItemAddNzbFromFile.Click += new System.EventHandler(this.menuItemAddNzbFromFile_Click);
            // 
            // menuItemAddNzbFromUrl
            // 
            this.menuItemAddNzbFromUrl.Enabled = false;
            this.menuItemAddNzbFromUrl.Name = "menuItemAddNzbFromUrl";
            this.menuItemAddNzbFromUrl.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.menuItemAddNzbFromUrl.Size = new System.Drawing.Size(266, 22);
            this.menuItemAddNzbFromUrl.Text = "Add NZB from &URL...";
            this.menuItemAddNzbFromUrl.Click += new System.EventHandler(this.menuItemAddNzbFromUrl_Click);
            // 
            // menuItemAddNzbFromNewzbinId
            // 
            this.menuItemAddNzbFromNewzbinId.Enabled = false;
            this.menuItemAddNzbFromNewzbinId.Name = "menuItemAddNzbFromNewzbinId";
            this.menuItemAddNzbFromNewzbinId.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuItemAddNzbFromNewzbinId.Size = new System.Drawing.Size(266, 22);
            this.menuItemAddNzbFromNewzbinId.Text = "Add NZB from &Newzbin ID...";
            this.menuItemAddNzbFromNewzbinId.Click += new System.EventHandler(this.menuItemAddNzbFromNewzbinId_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(263, 6);
            // 
            // menuItemDisconnect
            // 
            this.menuItemDisconnect.Enabled = false;
            this.menuItemDisconnect.Name = "menuItemDisconnect";
            this.menuItemDisconnect.Size = new System.Drawing.Size(266, 22);
            this.menuItemDisconnect.Text = "Disconnect";
            this.menuItemDisconnect.Click += new System.EventHandler(this.menuItemDisconnect_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuItemExit.Size = new System.Drawing.Size(266, 22);
            this.menuItemExit.Text = "&Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemOptions
            // 
            this.menuItemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemShowLog,
            this.toolStripSeparator2,
            this.menuItemPreferences});
            this.menuItemOptions.Name = "menuItemOptions";
            this.menuItemOptions.Size = new System.Drawing.Size(61, 20);
            this.menuItemOptions.Text = "&Options";
            // 
            // menuItemShowLog
            // 
            this.menuItemShowLog.Checked = true;
            this.menuItemShowLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItemShowLog.Name = "menuItemShowLog";
            this.menuItemShowLog.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuItemShowLog.Size = new System.Drawing.Size(176, 22);
            this.menuItemShowLog.Text = "Show Log";
            this.menuItemShowLog.Click += new System.EventHandler(this.menuItemShowLog_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // menuItemPreferences
            // 
            this.menuItemPreferences.Name = "menuItemPreferences";
            this.menuItemPreferences.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuItemPreferences.Size = new System.Drawing.Size(176, 22);
            this.menuItemPreferences.Text = "&Preferences";
            this.menuItemPreferences.Click += new System.EventHandler(this.menuItemPreferences_Click);
            // 
            // menuItemOptionsHelpMenuItem
            // 
            this.menuItemOptionsHelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCheckForUpdates,
            this.toolStripSeparator3,
            this.menuItemAbout});
            this.menuItemOptionsHelpMenuItem.Name = "menuItemOptionsHelpMenuItem";
            this.menuItemOptionsHelpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.menuItemOptionsHelpMenuItem.Text = "&Help";
            // 
            // menuItemCheckForUpdates
            // 
            this.menuItemCheckForUpdates.Name = "menuItemCheckForUpdates";
            this.menuItemCheckForUpdates.Size = new System.Drawing.Size(281, 22);
            this.menuItemCheckForUpdates.Text = "Check for Updates";
            this.menuItemCheckForUpdates.Click += new System.EventHandler(this.menuItemCheckForUpdates_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(278, 6);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(281, 22);
            this.menuItemAbout.Text = "About HellaNZB Remote";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonConnect,
            this.toolStripButtonDisconnect,
            this.toolStripSeparator4,
            this.toolStripButtonAddNzbFromFile,
            this.toolStripButtonAddNzbFromWeb,
            this.toolStripSeparator5,
            this.toolStripButtonRemove,
            this.toolStripSeparator6,
            this.toolStripButtonForceStart,
            this.toolStripButtonResume,
            this.toolStripButtonPause,
            this.toolStripButtonCancel,
            this.toolStripSeparator7,
            this.toolStripButtonQueueDown,
            this.toolStripSeparator8,
            this.toolStripButtonQueueUp,
            this.toolStripButtonPreferences,
            this.toolStripButtonReload});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(684, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonConnect
            // 
            this.toolStripButtonConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConnect.Name = "toolStripButtonConnect";
            this.toolStripButtonConnect.Size = new System.Drawing.Size(68, 22);
            this.toolStripButtonConnect.Text = "Connect";
            this.toolStripButtonConnect.ToolTipText = "Connect To Server";
            this.toolStripButtonConnect.ButtonClick += new System.EventHandler(this.toolStripButtonConnect_Click);
            this.toolStripButtonConnect.DropDownOpening += new System.EventHandler(this.toolStripButtonConnect_DropDownClick);
            this.toolStripButtonConnect.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripButtonConnect_DropDownItemClick);
            // 
            // toolStripButtonDisconnect
            // 
            this.toolStripButtonDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDisconnect.Enabled = false;
            this.toolStripButtonDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDisconnect.Name = "toolStripButtonDisconnect";
            this.toolStripButtonDisconnect.Size = new System.Drawing.Size(70, 22);
            this.toolStripButtonDisconnect.Text = "Disconnect";
            this.toolStripButtonDisconnect.ToolTipText = "Disconnect From Server";
            this.toolStripButtonDisconnect.Click += new System.EventHandler(this.toolStripButtonDisconnect_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonAddNzbFromFile
            // 
            this.toolStripButtonAddNzbFromFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddNzbFromFile.Enabled = false;
            this.toolStripButtonAddNzbFromFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddNzbFromFile.Image")));
            this.toolStripButtonAddNzbFromFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddNzbFromFile.Name = "toolStripButtonAddNzbFromFile";
            this.toolStripButtonAddNzbFromFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAddNzbFromFile.Text = "Add NZB From File";
            this.toolStripButtonAddNzbFromFile.Visible = false;
            this.toolStripButtonAddNzbFromFile.Click += new System.EventHandler(this.toolStripButtonAddNzbFromFile_Click);
            // 
            // toolStripButtonAddNzbFromWeb
            // 
            this.toolStripButtonAddNzbFromWeb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddNzbFromWeb.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddNzbFromUrl,
            this.toolStripMenuItemAddNzbFromNewzbinId});
            this.toolStripButtonAddNzbFromWeb.Enabled = false;
            this.toolStripButtonAddNzbFromWeb.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddNzbFromWeb.Image")));
            this.toolStripButtonAddNzbFromWeb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddNzbFromWeb.Name = "toolStripButtonAddNzbFromWeb";
            this.toolStripButtonAddNzbFromWeb.Size = new System.Drawing.Size(32, 22);
            this.toolStripButtonAddNzbFromWeb.Text = "Add NZB From Web";
            this.toolStripButtonAddNzbFromWeb.ButtonClick += new System.EventHandler(this.toolStripButtonAddNzbFromWeb_Click);
            // 
            // toolStripMenuItemAddNzbFromUrl
            // 
            this.toolStripMenuItemAddNzbFromUrl.Checked = true;
            this.toolStripMenuItemAddNzbFromUrl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemAddNzbFromUrl.Name = "toolStripMenuItemAddNzbFromUrl";
            this.toolStripMenuItemAddNzbFromUrl.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItemAddNzbFromUrl.Text = "URL";
            this.toolStripMenuItemAddNzbFromUrl.Click += new System.EventHandler(this.toolStripMenuItemAddNzbFromUrl_Click);
            // 
            // toolStripMenuItemAddNzbFromNewzbinId
            // 
            this.toolStripMenuItemAddNzbFromNewzbinId.Name = "toolStripMenuItemAddNzbFromNewzbinId";
            this.toolStripMenuItemAddNzbFromNewzbinId.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItemAddNzbFromNewzbinId.Text = "Newzbin ID";
            this.toolStripMenuItemAddNzbFromNewzbinId.Click += new System.EventHandler(this.toolStripMenuItemAddNzbFromNewzbinId_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonRemove
            // 
            this.toolStripButtonRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemove.Enabled = false;
            this.toolStripButtonRemove.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemove.Image")));
            this.toolStripButtonRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemove.Name = "toolStripButtonRemove";
            this.toolStripButtonRemove.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRemove.Text = "Remove NZB";
            this.toolStripButtonRemove.Click += new System.EventHandler(this.toolStripButtonRemove_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonForceStart
            // 
            this.toolStripButtonForceStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonForceStart.Enabled = false;
            this.toolStripButtonForceStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonForceStart.Image")));
            this.toolStripButtonForceStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonForceStart.Name = "toolStripButtonForceStart";
            this.toolStripButtonForceStart.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonForceStart.Text = "Force Start Download";
            this.toolStripButtonForceStart.Click += new System.EventHandler(this.toolStripButtonForceStart_Click);
            // 
            // toolStripButtonResume
            // 
            this.toolStripButtonResume.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonResume.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonResume.Image")));
            this.toolStripButtonResume.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonResume.Name = "toolStripButtonResume";
            this.toolStripButtonResume.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonResume.Text = "Resume Download";
            this.toolStripButtonResume.Visible = false;
            this.toolStripButtonResume.Click += new System.EventHandler(this.toolStripButtonResume_Click);
            // 
            // toolStripButtonPause
            // 
            this.toolStripButtonPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPause.Enabled = false;
            this.toolStripButtonPause.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPause.Image")));
            this.toolStripButtonPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPause.Name = "toolStripButtonPause";
            this.toolStripButtonPause.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPause.Text = "Pause Download";
            this.toolStripButtonPause.Click += new System.EventHandler(this.toolStripButtonPause_Click);
            // 
            // toolStripButtonCancel
            // 
            this.toolStripButtonCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCancel.Enabled = false;
            this.toolStripButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancel.Image")));
            this.toolStripButtonCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancel.Name = "toolStripButtonCancel";
            this.toolStripButtonCancel.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCancel.Text = "Cancel Download";
            this.toolStripButtonCancel.Click += new System.EventHandler(this.toolStripButtonCancel_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonQueueDown
            // 
            this.toolStripButtonQueueDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonQueueDown.Enabled = false;
            this.toolStripButtonQueueDown.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonQueueDown.Image")));
            this.toolStripButtonQueueDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonQueueDown.Name = "toolStripButtonQueueDown";
            this.toolStripButtonQueueDown.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonQueueDown.Text = "Move Down Queue";
            this.toolStripButtonQueueDown.Click += new System.EventHandler(this.toolStripButtonQueueDown_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonQueueUp
            // 
            this.toolStripButtonQueueUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonQueueUp.Enabled = false;
            this.toolStripButtonQueueUp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonQueueUp.Image")));
            this.toolStripButtonQueueUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonQueueUp.Name = "toolStripButtonQueueUp";
            this.toolStripButtonQueueUp.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonQueueUp.Text = "Move Up Queue";
            this.toolStripButtonQueueUp.Click += new System.EventHandler(this.toolStripButtonQueueUp_Click);
            // 
            // toolStripButtonPreferences
            // 
            this.toolStripButtonPreferences.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPreferences.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPreferences.Image")));
            this.toolStripButtonPreferences.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPreferences.Name = "toolStripButtonPreferences";
            this.toolStripButtonPreferences.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPreferences.Text = "Preferences";
            this.toolStripButtonPreferences.Click += new System.EventHandler(this.toolStripButtonPreferences_Click);
            // 
            // toolStripButtonReload
            // 
            this.toolStripButtonReload.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReload.Enabled = false;
            this.toolStripButtonReload.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReload.Image")));
            this.toolStripButtonReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReload.Name = "toolStripButtonReload";
            this.toolStripButtonReload.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonReload.Text = "Reload List";
            this.toolStripButtonReload.Click += new System.EventHandler(this.toolStripButtonReload_Click);
            // 
            // splitContainerMainForm
            // 
            this.splitContainerMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMainForm.Location = new System.Drawing.Point(0, 49);
            this.splitContainerMainForm.Name = "splitContainerMainForm";
            this.splitContainerMainForm.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMainForm.Panel1
            // 
            this.splitContainerMainForm.Panel1.Controls.Add(this.listViewTransfers);
            // 
            // splitContainerMainForm.Panel2
            // 
            this.splitContainerMainForm.Panel2.AutoScroll = true;
            this.splitContainerMainForm.Panel2.Controls.Add(this.tabControlMainForm);
            this.splitContainerMainForm.Size = new System.Drawing.Size(684, 290);
            this.splitContainerMainForm.SplitterDistance = 159;
            this.splitContainerMainForm.TabIndex = 3;
            // 
            // listViewTransfers
            // 
            this.listViewTransfers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTransfers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNumber,
            this.columnHeaderName,
            this.columnHeaderSize,
            this.columnHeaderStatus,
            this.columnHeaderProgress,
            this.columnHeaderEta});
            this.listViewTransfers.FullRowSelect = true;
            this.listViewTransfers.Location = new System.Drawing.Point(0, 0);
            this.listViewTransfers.MultiSelect = false;
            this.listViewTransfers.Name = "listViewTransfers";
            this.listViewTransfers.Size = new System.Drawing.Size(684, 159);
            this.listViewTransfers.TabIndex = 0;
            this.listViewTransfers.UseCompatibleStateImageBehavior = false;
            this.listViewTransfers.View = System.Windows.Forms.View.Details;
            this.listViewTransfers.SelectedIndexChanged += new System.EventHandler(this.listViewTransfers_SelectedIndexChanged);
            this.listViewTransfers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewTransfers_MouseDown);
            // 
            // columnHeaderNumber
            // 
            this.columnHeaderNumber.Text = "#";
            this.columnHeaderNumber.Width = 20;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 400;
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Size";
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Status";
            this.columnHeaderStatus.Width = 80;
            // 
            // columnHeaderProgress
            // 
            this.columnHeaderProgress.Text = "Progress";
            // 
            // columnHeaderEta
            // 
            this.columnHeaderEta.Text = "ETA";
            // 
            // tabControlMainForm
            // 
            this.tabControlMainForm.Controls.Add(this.tabPageLog);
            this.tabControlMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMainForm.Location = new System.Drawing.Point(0, 0);
            this.tabControlMainForm.Multiline = true;
            this.tabControlMainForm.Name = "tabControlMainForm";
            this.tabControlMainForm.SelectedIndex = 0;
            this.tabControlMainForm.Size = new System.Drawing.Size(684, 127);
            this.tabControlMainForm.TabIndex = 0;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.listBoxLog);
            this.tabPageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Size = new System.Drawing.Size(676, 101);
            this.tabPageLog.TabIndex = 0;
            this.tabPageLog.Text = "Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // listBoxLog
            // 
            this.listBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.HorizontalScrollbar = true;
            this.listBoxLog.IntegralHeight = false;
            this.listBoxLog.Location = new System.Drawing.Point(0, 0);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.ScrollAlwaysVisible = true;
            this.listBoxLog.Size = new System.Drawing.Size(676, 101);
            this.listBoxLog.TabIndex = 0;
            // 
            // contextMenuTransfers
            // 
            this.contextMenuTransfers.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.contextMenuItemForceStart,
            this.contextMenuItemRemove,
            this.contextMenuItemCancel,
            this.contextMenuItemSeperator1,
            this.contextMenuItemQueueUp,
            this.contextMenuItemQueueDown,
            this.contextMenuItemSeperator2,
            this.contextMenuItemSetRarPassword});
            // 
            // contextMenuItemForceStart
            // 
            this.contextMenuItemForceStart.Index = 0;
            this.contextMenuItemForceStart.Text = "Force Start";
            this.contextMenuItemForceStart.Click += new System.EventHandler(this.contextMenuItemForceStart_Click);
            // 
            // contextMenuItemRemove
            // 
            this.contextMenuItemRemove.Index = 1;
            this.contextMenuItemRemove.Text = "Remove";
            this.contextMenuItemRemove.Click += new System.EventHandler(this.contextMenuItemRemove_Click);
            // 
            // contextMenuItemCancel
            // 
            this.contextMenuItemCancel.Index = 2;
            this.contextMenuItemCancel.Text = "Cancel";
            this.contextMenuItemCancel.Click += new System.EventHandler(this.contextMenuItemCancel_Click);
            // 
            // contextMenuItemSeperator1
            // 
            this.contextMenuItemSeperator1.Index = 3;
            this.contextMenuItemSeperator1.Text = "-";
            // 
            // contextMenuItemQueueUp
            // 
            this.contextMenuItemQueueUp.Index = 4;
            this.contextMenuItemQueueUp.Text = "Move Up Queue";
            this.contextMenuItemQueueUp.Click += new System.EventHandler(this.contextMenuItemQueueUp_Click);
            // 
            // contextMenuItemQueueDown
            // 
            this.contextMenuItemQueueDown.Index = 5;
            this.contextMenuItemQueueDown.Text = "Move Down Queue";
            this.contextMenuItemQueueDown.Click += new System.EventHandler(this.contextMenuItemQueueDown_Click);
            // 
            // contextMenuItemSeperator2
            // 
            this.contextMenuItemSeperator2.Index = 6;
            this.contextMenuItemSeperator2.Text = "-";
            // 
            // contextMenuItemSetRarPassword
            // 
            this.contextMenuItemSetRarPassword.Index = 7;
            this.contextMenuItemSetRarPassword.Text = "Set RAR Password";
            this.contextMenuItemSetRarPassword.Click += new System.EventHandler(this.contextMenuItemSetRarPassword_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = -1;
            this.menuItem5.Text = "-";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "HellaNZB Remote";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            this.notifyIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDown);
            // 
            // contextMenuNotifyIcon
            // 
            this.contextMenuNotifyIcon.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.contextMenuItemOpen,
            this.contextMenuItemSeperator3,
            this.contextMenuItemResume,
            this.contextMenuItemPause,
            this.contextMenuItemAddNzb,
            this.contextMenuItemSeperator4,
            this.contextMenuItemPreferences,
            this.contextMenuItemSeperator5,
            this.contextMenuItemDisconnect,
            this.contextMenuItemExit});
            // 
            // contextMenuItemOpen
            // 
            this.contextMenuItemOpen.Index = 0;
            this.contextMenuItemOpen.Text = "Open";
            this.contextMenuItemOpen.Click += new System.EventHandler(this.contextMenuItemOpen_click);
            // 
            // contextMenuItemSeperator3
            // 
            this.contextMenuItemSeperator3.Index = 1;
            this.contextMenuItemSeperator3.Text = "-";
            // 
            // contextMenuItemResume
            // 
            this.contextMenuItemResume.Index = 2;
            this.contextMenuItemResume.Text = "Resume";
            this.contextMenuItemResume.Visible = false;
            this.contextMenuItemResume.Click += new System.EventHandler(this.contextMenuItemResume_Click);
            // 
            // contextMenuItemPause
            // 
            this.contextMenuItemPause.Enabled = false;
            this.contextMenuItemPause.Index = 3;
            this.contextMenuItemPause.Text = "Pause";
            this.contextMenuItemPause.Click += new System.EventHandler(this.contextMenuItemPause_Click);
            // 
            // contextMenuItemAddNzb
            // 
            this.contextMenuItemAddNzb.Enabled = false;
            this.contextMenuItemAddNzb.Index = 4;
            this.contextMenuItemAddNzb.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.contextMenuItemAddNzbFromFile,
            this.contextMenuItemAddNzbFromUrl,
            this.contextMenuItemAddNzbFromNewzbinId});
            this.contextMenuItemAddNzb.Text = "Add NZB";
            // 
            // contextMenuItemAddNzbFromFile
            // 
            this.contextMenuItemAddNzbFromFile.Index = 0;
            this.contextMenuItemAddNzbFromFile.Text = "From File";
            this.contextMenuItemAddNzbFromFile.Visible = false;
            this.contextMenuItemAddNzbFromFile.Click += new System.EventHandler(this.contextMenuItemAddNzbFromFile_Click);
            // 
            // contextMenuItemAddNzbFromUrl
            // 
            this.contextMenuItemAddNzbFromUrl.Index = 1;
            this.contextMenuItemAddNzbFromUrl.Text = "From URL";
            this.contextMenuItemAddNzbFromUrl.Click += new System.EventHandler(this.contextMenuItemAddNzbFromUrl_Click);
            // 
            // contextMenuItemAddNzbFromNewzbinId
            // 
            this.contextMenuItemAddNzbFromNewzbinId.Index = 2;
            this.contextMenuItemAddNzbFromNewzbinId.Text = "From Newzbin ID";
            this.contextMenuItemAddNzbFromNewzbinId.Click += new System.EventHandler(this.contextMenuItemAddNzbFromNewzbinId_Click);
            // 
            // contextMenuItemSeperator4
            // 
            this.contextMenuItemSeperator4.Index = 5;
            this.contextMenuItemSeperator4.Text = "-";
            // 
            // contextMenuItemPreferences
            // 
            this.contextMenuItemPreferences.Index = 6;
            this.contextMenuItemPreferences.Text = "Preferences...";
            this.contextMenuItemPreferences.Click += new System.EventHandler(this.contextMenuItemPreferences_Click);
            // 
            // contextMenuItemSeperator5
            // 
            this.contextMenuItemSeperator5.Index = 7;
            this.contextMenuItemSeperator5.Text = "-";
            // 
            // contextMenuItemDisconnect
            // 
            this.contextMenuItemDisconnect.Enabled = false;
            this.contextMenuItemDisconnect.Index = 8;
            this.contextMenuItemDisconnect.Text = "Disconnect";
            this.contextMenuItemDisconnect.Click += new System.EventHandler(this.contextMenuItemDisconnect_Click);
            // 
            // contextMenuItemExit
            // 
            this.contextMenuItemExit.Index = 9;
            this.contextMenuItemExit.Text = "Exit";
            this.contextMenuItemExit.Click += new System.EventHandler(this.contextMenuItemExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 362);
            this.Controls.Add(this.splitContainerMainForm);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "HellaNZB Remote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_Close);
            this.Resize += new System.EventHandler(this.form_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitContainerMainForm.Panel1.ResumeLayout(false);
            this.splitContainerMainForm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainForm)).EndInit();
            this.splitContainerMainForm.ResumeLayout(false);
            this.tabControlMainForm.ResumeLayout(false);
            this.tabPageLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddNzbFromFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemPreferences;
        private System.Windows.Forms.ToolStripMenuItem menuItemOptionsHelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonDisconnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddNzbFromFile;
        private System.Windows.Forms.ToolStripSplitButton toolStripButtonConnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButtonForceStart;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButtonQueueUp;
        private System.Windows.Forms.ToolStripButton toolStripButtonQueueDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButtonPreferences;
        private System.Windows.Forms.ToolStripButton toolStripButtonReload;
        private System.Windows.Forms.SplitContainer splitContainerMainForm;
        private System.Windows.Forms.TabControl tabControlMainForm;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.ListView listViewTransfers;
        private System.Windows.Forms.ContextMenu contextMenuTransfers;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripButton toolStripButtonPause;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelSpeed;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelStatus;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelDisconnectedIcon;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelConnectingIcon;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelConnectedIcon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeperator9;
        private System.Windows.Forms.ToolStripSplitButton toolStripButtonAddNzbFromWeb;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddNzbFromUrl;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddNzbFromNewzbinId;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemove;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddNzbFromUrl;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddNzbFromNewzbinId;
        private System.Windows.Forms.ToolStripButton toolStripButtonResume;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.ColumnHeader columnHeaderEta;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.MenuItem contextMenuItemQueueUp;
        private System.Windows.Forms.MenuItem contextMenuItemQueueDown;
        private System.Windows.Forms.MenuItem contextMenuItemForceStart;
        private System.Windows.Forms.MenuItem contextMenuItemSeperator1;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem contextMenuItemSetRarPassword;
        private System.Windows.Forms.MenuItem contextMenuItemCancel;
        private System.Windows.Forms.ColumnHeader columnHeaderProgress;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.ToolStripMenuItem menuItemCheckForUpdates;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ColumnHeader columnHeaderNumber;
        private System.Windows.Forms.ToolStripMenuItem menuItemShowLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ContextMenu contextMenuNotifyIcon;
        private System.Windows.Forms.MenuItem contextMenuItemExit;
        private System.Windows.Forms.MenuItem contextMenuItemSeperator2;
        private System.Windows.Forms.MenuItem contextMenuItemRemove;
        private System.Windows.Forms.MenuItem contextMenuItemOpen;
        private System.Windows.Forms.MenuItem contextMenuItemSeperator3;
        private System.Windows.Forms.MenuItem contextMenuItemResume;
        private System.Windows.Forms.MenuItem contextMenuItemPause;
        private System.Windows.Forms.MenuItem contextMenuItemSeperator5;
        private System.Windows.Forms.MenuItem contextMenuItemDisconnect;
        private System.Windows.Forms.MenuItem contextMenuItemAddNzb;
        private System.Windows.Forms.MenuItem contextMenuItemAddNzbFromFile;
        private System.Windows.Forms.MenuItem contextMenuItemAddNzbFromUrl;
        private System.Windows.Forms.MenuItem contextMenuItemAddNzbFromNewzbinId;
        private System.Windows.Forms.MenuItem contextMenuItemSeperator4;
        private System.Windows.Forms.MenuItem contextMenuItemPreferences;
        private System.Windows.Forms.ToolStripMenuItem menuItemDisconnect;
    }
}

