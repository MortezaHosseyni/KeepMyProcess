namespace KeepMyProcess
{
    partial class AddGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGameForm));
            this.btn_SelectGameLocation = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SelectSaveLocation = new DevExpress.XtraEditors.SimpleButton();
            this.btn_FindSaveLocation = new DevExpress.XtraEditors.SimpleButton();
            this.txt_GameName = new DevExpress.XtraEditors.TextEdit();
            this.txt_GameLocation = new DevExpress.XtraEditors.TextEdit();
            this.txt_SaveLocation = new DevExpress.XtraEditors.TextEdit();
            this.lbl_GameName = new DevExpress.XtraEditors.LabelControl();
            this.lbl_GameLocation = new DevExpress.XtraEditors.LabelControl();
            this.lbl_SaveLocation = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GameName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GameLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SaveLocation.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SelectGameLocation
            // 
            this.btn_SelectGameLocation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btn_SelectGameLocation.Location = new System.Drawing.Point(584, 87);
            this.btn_SelectGameLocation.Name = "btn_SelectGameLocation";
            this.btn_SelectGameLocation.Size = new System.Drawing.Size(39, 29);
            this.btn_SelectGameLocation.TabIndex = 4;
            this.btn_SelectGameLocation.Click += new System.EventHandler(this.btn_SelectGameLocation_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btn_Add.Location = new System.Drawing.Point(120, 189);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(189, 36);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add Game";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(373, 189);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(189, 36);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_SelectSaveLocation
            // 
            this.btn_SelectSaveLocation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.btn_SelectSaveLocation.Location = new System.Drawing.Point(584, 127);
            this.btn_SelectSaveLocation.Name = "btn_SelectSaveLocation";
            this.btn_SelectSaveLocation.Size = new System.Drawing.Size(39, 29);
            this.btn_SelectSaveLocation.TabIndex = 9;
            this.btn_SelectSaveLocation.Click += new System.EventHandler(this.btn_SelectSaveLocation_Click);
            // 
            // btn_FindSaveLocation
            // 
            this.btn_FindSaveLocation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btn_FindSaveLocation.Location = new System.Drawing.Point(629, 127);
            this.btn_FindSaveLocation.Name = "btn_FindSaveLocation";
            this.btn_FindSaveLocation.Size = new System.Drawing.Size(39, 29);
            this.btn_FindSaveLocation.TabIndex = 10;
            // 
            // txt_GameName
            // 
            this.txt_GameName.Location = new System.Drawing.Point(184, 46);
            this.txt_GameName.Name = "txt_GameName";
            this.txt_GameName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_GameName.Properties.Appearance.Options.UseFont = true;
            this.txt_GameName.Size = new System.Drawing.Size(394, 30);
            this.txt_GameName.TabIndex = 11;
            // 
            // txt_GameLocation
            // 
            this.txt_GameLocation.Location = new System.Drawing.Point(184, 86);
            this.txt_GameLocation.Name = "txt_GameLocation";
            this.txt_GameLocation.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_GameLocation.Properties.Appearance.Options.UseFont = true;
            this.txt_GameLocation.Size = new System.Drawing.Size(394, 30);
            this.txt_GameLocation.TabIndex = 12;
            // 
            // txt_SaveLocation
            // 
            this.txt_SaveLocation.Location = new System.Drawing.Point(184, 126);
            this.txt_SaveLocation.Name = "txt_SaveLocation";
            this.txt_SaveLocation.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_SaveLocation.Properties.Appearance.Options.UseFont = true;
            this.txt_SaveLocation.Size = new System.Drawing.Size(394, 30);
            this.txt_SaveLocation.TabIndex = 13;
            // 
            // lbl_GameName
            // 
            this.lbl_GameName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl_GameName.Appearance.Options.UseFont = true;
            this.lbl_GameName.Location = new System.Drawing.Point(68, 49);
            this.lbl_GameName.Name = "lbl_GameName";
            this.lbl_GameName.Size = new System.Drawing.Size(110, 24);
            this.lbl_GameName.TabIndex = 14;
            this.lbl_GameName.Text = "Game Name";
            // 
            // lbl_GameLocation
            // 
            this.lbl_GameLocation.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl_GameLocation.Appearance.Options.UseFont = true;
            this.lbl_GameLocation.Location = new System.Drawing.Point(45, 89);
            this.lbl_GameLocation.Name = "lbl_GameLocation";
            this.lbl_GameLocation.Size = new System.Drawing.Size(133, 24);
            this.lbl_GameLocation.TabIndex = 15;
            this.lbl_GameLocation.Text = "Game Location";
            // 
            // lbl_SaveLocation
            // 
            this.lbl_SaveLocation.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl_SaveLocation.Appearance.Options.UseFont = true;
            this.lbl_SaveLocation.Location = new System.Drawing.Point(54, 129);
            this.lbl_SaveLocation.Name = "lbl_SaveLocation";
            this.lbl_SaveLocation.Size = new System.Drawing.Size(124, 24);
            this.lbl_SaveLocation.TabIndex = 16;
            this.lbl_SaveLocation.Text = "Save Location";
            // 
            // AddGameForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 263);
            this.Controls.Add(this.lbl_SaveLocation);
            this.Controls.Add(this.lbl_GameLocation);
            this.Controls.Add(this.lbl_GameName);
            this.Controls.Add(this.txt_SaveLocation);
            this.Controls.Add(this.txt_GameLocation);
            this.Controls.Add(this.txt_GameName);
            this.Controls.Add(this.btn_FindSaveLocation);
            this.Controls.Add(this.btn_SelectSaveLocation);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_SelectGameLocation);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(698, 303);
            this.Name = "AddGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Game";
            this.Load += new System.EventHandler(this.AddGameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_GameName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GameLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SaveLocation.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_SelectGameLocation;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_SelectSaveLocation;
        private DevExpress.XtraEditors.SimpleButton btn_FindSaveLocation;
        private DevExpress.XtraEditors.TextEdit txt_GameName;
        private DevExpress.XtraEditors.TextEdit txt_GameLocation;
        private DevExpress.XtraEditors.TextEdit txt_SaveLocation;
        private DevExpress.XtraEditors.LabelControl lbl_GameName;
        private DevExpress.XtraEditors.LabelControl lbl_GameLocation;
        private DevExpress.XtraEditors.LabelControl lbl_SaveLocation;
    }
}