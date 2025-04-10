namespace CS311MALABON2024_DATABASE_CARREON
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnAbout = new FontAwesome.Sharp.IconButton();
            this.btnReports = new FontAwesome.Sharp.IconButton();
            this.panelMaintenanceSubMenu = new System.Windows.Forms.Panel();
            this.btnCases = new FontAwesome.Sharp.IconButton();
            this.btnViolations = new FontAwesome.Sharp.IconButton();
            this.btnTickets = new FontAwesome.Sharp.IconButton();
            this.btnEvents = new FontAwesome.Sharp.IconButton();
            this.btnStudents = new FontAwesome.Sharp.IconButton();
            this.btnAccounts = new FontAwesome.Sharp.IconButton();
            this.btnMaintenance = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.IconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelMaintenanceSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Firebrick;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 778);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1420, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnAbout);
            this.panelMenu.Controls.Add(this.btnReports);
            this.panelMenu.Controls.Add(this.panelMaintenanceSubMenu);
            this.panelMenu.Controls.Add(this.btnMaintenance);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 778);
            this.panelMenu.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnLogout.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 30;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 581);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogout.Size = new System.Drawing.Size(220, 50);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "&Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAbout.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnAbout.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbout.IconSize = 30;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 531);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAbout.Size = new System.Drawing.Size(220, 50);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "&About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReports.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.btnReports.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReports.IconSize = 30;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 481);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReports.Size = new System.Drawing.Size(220, 50);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "&Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // panelMaintenanceSubMenu
            // 
            this.panelMaintenanceSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            this.panelMaintenanceSubMenu.Controls.Add(this.btnCases);
            this.panelMaintenanceSubMenu.Controls.Add(this.btnViolations);
            this.panelMaintenanceSubMenu.Controls.Add(this.btnTickets);
            this.panelMaintenanceSubMenu.Controls.Add(this.btnEvents);
            this.panelMaintenanceSubMenu.Controls.Add(this.btnStudents);
            this.panelMaintenanceSubMenu.Controls.Add(this.btnAccounts);
            this.panelMaintenanceSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMaintenanceSubMenu.Location = new System.Drawing.Point(0, 206);
            this.panelMaintenanceSubMenu.Name = "panelMaintenanceSubMenu";
            this.panelMaintenanceSubMenu.Size = new System.Drawing.Size(220, 275);
            this.panelMaintenanceSubMenu.TabIndex = 2;
            // 
            // btnCases
            // 
            this.btnCases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.btnCases.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCases.FlatAppearance.BorderSize = 0;
            this.btnCases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCases.ForeColor = System.Drawing.Color.LightGray;
            this.btnCases.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.btnCases.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCases.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCases.IconSize = 25;
            this.btnCases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCases.Location = new System.Drawing.Point(0, 230);
            this.btnCases.Name = "btnCases";
            this.btnCases.Padding = new System.Windows.Forms.Padding(25, 0, 20, 0);
            this.btnCases.Size = new System.Drawing.Size(220, 46);
            this.btnCases.TabIndex = 5;
            this.btnCases.Text = "&Cases";
            this.btnCases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCases.UseVisualStyleBackColor = false;
            this.btnCases.Click += new System.EventHandler(this.btnCases_Click);
            // 
            // btnViolations
            // 
            this.btnViolations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.btnViolations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViolations.FlatAppearance.BorderSize = 0;
            this.btnViolations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViolations.ForeColor = System.Drawing.Color.LightGray;
            this.btnViolations.IconChar = FontAwesome.Sharp.IconChar.FileCircleExclamation;
            this.btnViolations.IconColor = System.Drawing.Color.Gainsboro;
            this.btnViolations.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViolations.IconSize = 25;
            this.btnViolations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViolations.Location = new System.Drawing.Point(0, 184);
            this.btnViolations.Name = "btnViolations";
            this.btnViolations.Padding = new System.Windows.Forms.Padding(25, 0, 20, 0);
            this.btnViolations.Size = new System.Drawing.Size(220, 46);
            this.btnViolations.TabIndex = 4;
            this.btnViolations.Text = "&Violations";
            this.btnViolations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViolations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViolations.UseVisualStyleBackColor = false;
            this.btnViolations.Click += new System.EventHandler(this.btnViolations_Click);
            // 
            // btnTickets
            // 
            this.btnTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.btnTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTickets.FlatAppearance.BorderSize = 0;
            this.btnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTickets.ForeColor = System.Drawing.Color.LightGray;
            this.btnTickets.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.btnTickets.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTickets.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTickets.IconSize = 25;
            this.btnTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTickets.Location = new System.Drawing.Point(0, 138);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Padding = new System.Windows.Forms.Padding(25, 0, 20, 0);
            this.btnTickets.Size = new System.Drawing.Size(220, 46);
            this.btnTickets.TabIndex = 3;
            this.btnTickets.Text = "&Tickets";
            this.btnTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTickets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTickets.UseVisualStyleBackColor = false;
            // 
            // btnEvents
            // 
            this.btnEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.btnEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEvents.FlatAppearance.BorderSize = 0;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.ForeColor = System.Drawing.Color.LightGray;
            this.btnEvents.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnEvents.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEvents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEvents.IconSize = 25;
            this.btnEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvents.Location = new System.Drawing.Point(0, 92);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Padding = new System.Windows.Forms.Padding(25, 0, 20, 0);
            this.btnEvents.Size = new System.Drawing.Size(220, 46);
            this.btnEvents.TabIndex = 2;
            this.btnEvents.Text = "&Events";
            this.btnEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEvents.UseVisualStyleBackColor = false;
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.btnStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.ForeColor = System.Drawing.Color.LightGray;
            this.btnStudents.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnStudents.IconColor = System.Drawing.Color.Gainsboro;
            this.btnStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStudents.IconSize = 25;
            this.btnStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.Location = new System.Drawing.Point(0, 46);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Padding = new System.Windows.Forms.Padding(25, 0, 20, 0);
            this.btnStudents.Size = new System.Drawing.Size(220, 46);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "&Students";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.btnAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccounts.FlatAppearance.BorderSize = 0;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.ForeColor = System.Drawing.Color.LightGray;
            this.btnAccounts.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnAccounts.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAccounts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccounts.IconSize = 25;
            this.btnAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounts.Location = new System.Drawing.Point(0, 0);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Padding = new System.Windows.Forms.Padding(25, 0, 20, 0);
            this.btnAccounts.Size = new System.Drawing.Size(220, 46);
            this.btnAccounts.TabIndex = 0;
            this.btnAccounts.Text = "&Accounts";
            this.btnAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccounts.UseVisualStyleBackColor = false;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaintenance.FlatAppearance.BorderSize = 0;
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaintenance.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.btnMaintenance.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaintenance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaintenance.IconSize = 30;
            this.btnMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaintenance.Location = new System.Drawing.Point(0, 156);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMaintenance.Size = new System.Drawing.Size(220, 50);
            this.btnMaintenance.TabIndex = 1;
            this.btnMaintenance.Text = "&Maintenance";
            this.btnMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaintenance.UseVisualStyleBackColor = true;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 156);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(38, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(145, 126);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.IconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1200, 86);
            this.panelTitleBar.TabIndex = 6;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(1116, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 20);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.btnMaximize.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(1145, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(23, 20);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnExit.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnExit.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 20;
            this.btnExit.Location = new System.Drawing.Point(1174, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 20);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(70, 38);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(44, 16);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // IconCurrentChildForm
            // 
            this.IconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.IconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.IconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.IconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.IconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCurrentChildForm.IconSize = 46;
            this.IconCurrentChildForm.Location = new System.Drawing.Point(18, 22);
            this.IconCurrentChildForm.Name = "IconCurrentChildForm";
            this.IconCurrentChildForm.Size = new System.Drawing.Size(46, 50);
            this.IconCurrentChildForm.TabIndex = 0;
            this.IconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 86);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1200, 8);
            this.panelShadow.TabIndex = 7;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 94);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1200, 684);
            this.panelDesktop.TabIndex = 12;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1420, 800);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.statusStrip1);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(958, 681);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Management System - Main Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMaintenanceSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnMaintenance;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMaintenanceSubMenu;
        private FontAwesome.Sharp.IconButton btnTickets;
        private FontAwesome.Sharp.IconButton btnEvents;
        private FontAwesome.Sharp.IconButton btnStudents;
        private FontAwesome.Sharp.IconButton btnAccounts;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnAbout;
        private FontAwesome.Sharp.IconButton btnReports;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox IconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnViolations;
        private FontAwesome.Sharp.IconButton btnCases;
    }
}