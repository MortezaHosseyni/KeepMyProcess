namespace KeepMyProcess
{
    partial class MainPage
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
            DevExpress.XtraBars.Bar bar_TopBar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.bbi_Data = new DevExpress.XtraBars.BarButtonItem();
            this.ppm_Data = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btn_BackupLocations = new DevExpress.XtraBars.BarButtonItem();
            this.btn_OnlineStorages = new DevExpress.XtraBars.BarButtonItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar_BottomBar = new DevExpress.XtraBars.Bar();
            this.ctx_Status = new DevExpress.XtraBars.BarStaticItem();
            this.pgb_StatusProgress = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.bbi_Help = new DevExpress.XtraBars.BarButtonItem();
            this.ppm_Help = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btn_About = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.rtb_Logs = new System.Windows.Forms.RichTextBox();
            this.ilb_GamesList = new DevExpress.XtraEditors.ImageListBoxControl();
            this.htmlTemplate1 = new DevExpress.Utils.Html.HtmlTemplate();
            this.pnl_Buttons = new DevExpress.XtraEditors.SidePanel();
            this.btn_Restore = new DevExpress.XtraEditors.SimpleButton();
            this.btn_UploadBackups = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SaveBackups = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_AddGame = new DevExpress.XtraEditors.SimpleButton();
            bar_TopBar = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.ppm_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppm_Help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilb_GamesList)).BeginInit();
            this.pnl_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar_TopBar
            // 
            bar_TopBar.BarName = "TopBar";
            bar_TopBar.DockCol = 0;
            bar_TopBar.DockRow = 0;
            bar_TopBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar_TopBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Data),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Help)});
            bar_TopBar.OptionsBar.AllowQuickCustomization = false;
            bar_TopBar.OptionsBar.MultiLine = true;
            bar_TopBar.OptionsBar.UseWholeRow = true;
            bar_TopBar.Text = "TopBar";
            // 
            // bbi_Data
            // 
            this.bbi_Data.ActAsDropDown = true;
            this.bbi_Data.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.bbi_Data.Caption = "Data";
            this.bbi_Data.DropDownControl = this.ppm_Data;
            this.bbi_Data.Id = 0;
            this.bbi_Data.Name = "bbi_Data";
            // 
            // ppm_Data
            // 
            this.ppm_Data.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_BackupLocations),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_OnlineStorages)});
            this.ppm_Data.Manager = this.barManager;
            this.ppm_Data.Name = "ppm_Data";
            // 
            // btn_BackupLocations
            // 
            this.btn_BackupLocations.Caption = "Backup Locations";
            this.btn_BackupLocations.Id = 9;
            this.btn_BackupLocations.Name = "btn_BackupLocations";
            // 
            // btn_OnlineStorages
            // 
            this.btn_OnlineStorages.Caption = "Online Storages";
            this.btn_OnlineStorages.Id = 10;
            this.btn_OnlineStorages.Name = "btn_OnlineStorages";
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            bar_TopBar,
            this.bar_BottomBar});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbi_Data,
            this.barSubItem1,
            this.bbi_Help,
            this.ctx_Status,
            this.pgb_StatusProgress,
            this.barButtonItem3,
            this.btn_BackupLocations,
            this.btn_OnlineStorages,
            this.btn_About,
            this.barButtonItem7});
            this.barManager.MainMenu = bar_TopBar;
            this.barManager.MaxItemId = 17;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBar1,
            this.repositoryItemPopupContainerEdit1});
            this.barManager.StatusBar = this.bar_BottomBar;
            // 
            // bar_BottomBar
            // 
            this.bar_BottomBar.BarName = "Status bar";
            this.bar_BottomBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar_BottomBar.DockCol = 0;
            this.bar_BottomBar.DockRow = 0;
            this.bar_BottomBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar_BottomBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ctx_Status),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.pgb_StatusProgress, "", false, true, true, 136)});
            this.bar_BottomBar.OptionsBar.AllowQuickCustomization = false;
            this.bar_BottomBar.OptionsBar.DrawDragBorder = false;
            this.bar_BottomBar.OptionsBar.UseWholeRow = true;
            this.bar_BottomBar.Text = "Status bar";
            // 
            // ctx_Status
            // 
            this.ctx_Status.Caption = "Status";
            this.ctx_Status.Id = 4;
            this.ctx_Status.Name = "ctx_Status";
            // 
            // pgb_StatusProgress
            // 
            this.pgb_StatusProgress.Caption = "Progress";
            this.pgb_StatusProgress.Edit = this.repositoryItemProgressBar1;
            this.pgb_StatusProgress.Id = 5;
            this.pgb_StatusProgress.Name = "pgb_StatusProgress";
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1155, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 736);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1155, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 711);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1155, 25);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 711);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Help";
            this.barSubItem1.Id = 1;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // bbi_Help
            // 
            this.bbi_Help.ActAsDropDown = true;
            this.bbi_Help.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.bbi_Help.Caption = "Help";
            this.bbi_Help.DropDownControl = this.ppm_Help;
            this.bbi_Help.Id = 2;
            this.bbi_Help.Name = "bbi_Help";
            // 
            // ppm_Help
            // 
            this.ppm_Help.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_About)});
            this.ppm_Help.Manager = this.barManager;
            this.ppm_Help.Name = "ppm_Help";
            // 
            // btn_About
            // 
            this.btn_About.Caption = "About";
            this.btn_About.Id = 11;
            this.btn_About.Name = "btn_About";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "s";
            this.barButtonItem3.Id = 6;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Exit";
            this.barButtonItem7.Id = 12;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // repositoryItemPopupContainerEdit1
            // 
            this.repositoryItemPopupContainerEdit1.AutoHeight = false;
            this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            // 
            // rtb_Logs
            // 
            this.rtb_Logs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Logs.Location = new System.Drawing.Point(14, 548);
            this.rtb_Logs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb_Logs.Name = "rtb_Logs";
            this.rtb_Logs.Size = new System.Drawing.Size(1126, 180);
            this.rtb_Logs.TabIndex = 4;
            this.rtb_Logs.Text = "";
            // 
            // ilb_GamesList
            // 
            this.ilb_GamesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ilb_GamesList.HtmlTemplates.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            this.htmlTemplate1});
            this.ilb_GamesList.Location = new System.Drawing.Point(14, 32);
            this.ilb_GamesList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ilb_GamesList.Name = "ilb_GamesList";
            this.ilb_GamesList.Size = new System.Drawing.Size(844, 508);
            this.ilb_GamesList.TabIndex = 5;
            // 
            // htmlTemplate1
            // 
            this.htmlTemplate1.Name = "htmlTemplate1";
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Buttons.Controls.Add(this.btn_Restore);
            this.pnl_Buttons.Controls.Add(this.btn_UploadBackups);
            this.pnl_Buttons.Controls.Add(this.btn_SaveBackups);
            this.pnl_Buttons.Controls.Add(this.btn_Refresh);
            this.pnl_Buttons.Controls.Add(this.btn_AddGame);
            this.pnl_Buttons.Location = new System.Drawing.Point(864, 32);
            this.pnl_Buttons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(276, 508);
            this.pnl_Buttons.TabIndex = 6;
            this.pnl_Buttons.Text = "sidePanel1";
            // 
            // btn_Restore
            // 
            this.btn_Restore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Restore.ImageOptions.Image")));
            this.btn_Restore.Location = new System.Drawing.Point(58, 449);
            this.btn_Restore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(147, 43);
            this.btn_Restore.TabIndex = 4;
            this.btn_Restore.Text = "Restore";
            // 
            // btn_UploadBackups
            // 
            this.btn_UploadBackups.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_UploadBackups.ImageOptions.Image")));
            this.btn_UploadBackups.Location = new System.Drawing.Point(58, 399);
            this.btn_UploadBackups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_UploadBackups.Name = "btn_UploadBackups";
            this.btn_UploadBackups.Size = new System.Drawing.Size(147, 43);
            this.btn_UploadBackups.TabIndex = 3;
            this.btn_UploadBackups.Text = "Upload Backups";
            // 
            // btn_SaveBackups
            // 
            this.btn_SaveBackups.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_SaveBackups.ImageOptions.Image")));
            this.btn_SaveBackups.Location = new System.Drawing.Point(58, 348);
            this.btn_SaveBackups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SaveBackups.Name = "btn_SaveBackups";
            this.btn_SaveBackups.Size = new System.Drawing.Size(147, 43);
            this.btn_SaveBackups.TabIndex = 2;
            this.btn_SaveBackups.Text = "Save Backups";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.ImageOptions.Image")));
            this.btn_Refresh.Location = new System.Drawing.Point(58, 78);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(147, 43);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            // 
            // btn_AddGame
            // 
            this.btn_AddGame.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddGame.ImageOptions.Image")));
            this.btn_AddGame.Location = new System.Drawing.Point(58, 27);
            this.btn_AddGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AddGame.Name = "btn_AddGame";
            this.btn_AddGame.Size = new System.Drawing.Size(147, 43);
            this.btn_AddGame.TabIndex = 0;
            this.btn_AddGame.Text = "Add Game";
            this.btn_AddGame.Click += new System.EventHandler(this.btn_AddGame_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 763);
            this.Controls.Add(this.pnl_Buttons);
            this.Controls.Add(this.ilb_GamesList);
            this.Controls.Add(this.rtb_Logs);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("MainPage.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(992, 652);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keep My Process";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ppm_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppm_Help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilb_GamesList)).EndInit();
            this.pnl_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar_BottomBar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbi_Data;
        private DevExpress.XtraBars.PopupMenu ppm_Data;
        private DevExpress.XtraBars.BarButtonItem bbi_Help;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarStaticItem ctx_Status;
        private DevExpress.XtraBars.BarEditItem pgb_StatusProgress;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private DevExpress.XtraBars.BarButtonItem btn_BackupLocations;
        private DevExpress.XtraBars.BarButtonItem btn_OnlineStorages;
        private DevExpress.XtraBars.PopupMenu ppm_Help;
        private DevExpress.XtraBars.BarButtonItem btn_About;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private System.Windows.Forms.RichTextBox rtb_Logs;
        private DevExpress.XtraEditors.ImageListBoxControl ilb_GamesList;
        private DevExpress.Utils.Html.HtmlTemplate htmlTemplate1;
        private DevExpress.XtraEditors.SidePanel pnl_Buttons;
        private DevExpress.XtraEditors.SimpleButton btn_AddGame;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
        private DevExpress.XtraEditors.SimpleButton btn_SaveBackups;
        private DevExpress.XtraEditors.SimpleButton btn_UploadBackups;
        private DevExpress.XtraEditors.SimpleButton btn_Restore;
    }
}

