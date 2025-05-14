
namespace HMI_25024WE
{
    partial class Form_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Settings));
            this.btnAuxFolder = new System.Windows.Forms.Button();
            this.btnPathFiles = new System.Windows.Forms.Button();
            this.txtAuxFolder = new System.Windows.Forms.TextBox();
            this.lbAuxFolder = new System.Windows.Forms.Label();
            this.txtPathFiles = new System.Windows.Forms.TextBox();
            this.lbPathFiles = new System.Windows.Forms.Label();
            this.btnSettingsCancel = new System.Windows.Forms.Button();
            this.btnSettingsSave = new System.Windows.Forms.Button();
            this.lbSettingTitle = new System.Windows.Forms.Label();
            this.lbIPMarker = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lbSerialMarker = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.NumericUpDown();
            this.rbIP = new System.Windows.Forms.RadioButton();
            this.rbUsb = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAuxFolder
            // 
            this.btnAuxFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAuxFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuxFolder.Location = new System.Drawing.Point(347, 83);
            this.btnAuxFolder.Name = "btnAuxFolder";
            this.btnAuxFolder.Size = new System.Drawing.Size(30, 23);
            this.btnAuxFolder.TabIndex = 11;
            this.btnAuxFolder.Text = "...";
            this.btnAuxFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAuxFolder.UseVisualStyleBackColor = true;
            this.btnAuxFolder.Click += new System.EventHandler(this.btnAuxFolder_Click);
            // 
            // btnPathFiles
            // 
            this.btnPathFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPathFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPathFiles.Location = new System.Drawing.Point(347, 45);
            this.btnPathFiles.Name = "btnPathFiles";
            this.btnPathFiles.Size = new System.Drawing.Size(30, 23);
            this.btnPathFiles.TabIndex = 10;
            this.btnPathFiles.Text = "...";
            this.btnPathFiles.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPathFiles.UseVisualStyleBackColor = true;
            this.btnPathFiles.Click += new System.EventHandler(this.btnPathFiles_Click);
            // 
            // txtAuxFolder
            // 
            this.txtAuxFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuxFolder.Location = new System.Drawing.Point(11, 85);
            this.txtAuxFolder.Name = "txtAuxFolder";
            this.txtAuxFolder.Size = new System.Drawing.Size(330, 20);
            this.txtAuxFolder.TabIndex = 9;
            // 
            // lbAuxFolder
            // 
            this.lbAuxFolder.AutoSize = true;
            this.lbAuxFolder.Location = new System.Drawing.Point(8, 69);
            this.lbAuxFolder.Name = "lbAuxFolder";
            this.lbAuxFolder.Size = new System.Drawing.Size(72, 13);
            this.lbAuxFolder.TabIndex = 8;
            this.lbAuxFolder.Text = "Auxiliar Folder";
            // 
            // txtPathFiles
            // 
            this.txtPathFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathFiles.Location = new System.Drawing.Point(10, 47);
            this.txtPathFiles.Name = "txtPathFiles";
            this.txtPathFiles.Size = new System.Drawing.Size(331, 20);
            this.txtPathFiles.TabIndex = 7;
            // 
            // lbPathFiles
            // 
            this.lbPathFiles.AutoSize = true;
            this.lbPathFiles.Location = new System.Drawing.Point(10, 30);
            this.lbPathFiles.Name = "lbPathFiles";
            this.lbPathFiles.Size = new System.Drawing.Size(53, 13);
            this.lbPathFiles.TabIndex = 6;
            this.lbPathFiles.Text = "Path Files";
            // 
            // btnSettingsCancel
            // 
            this.btnSettingsCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnSettingsCancel.Image")));
            this.btnSettingsCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingsCancel.Location = new System.Drawing.Point(196, 166);
            this.btnSettingsCancel.Name = "btnSettingsCancel";
            this.btnSettingsCancel.Size = new System.Drawing.Size(103, 33);
            this.btnSettingsCancel.TabIndex = 43;
            this.btnSettingsCancel.Text = "CANCEL";
            this.btnSettingsCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettingsCancel.UseVisualStyleBackColor = true;
            this.btnSettingsCancel.Click += new System.EventHandler(this.btnSettingsCancel_Click);
            // 
            // btnSettingsSave
            // 
            this.btnSettingsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSettingsSave.Image")));
            this.btnSettingsSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingsSave.Location = new System.Drawing.Point(93, 166);
            this.btnSettingsSave.Name = "btnSettingsSave";
            this.btnSettingsSave.Size = new System.Drawing.Size(97, 33);
            this.btnSettingsSave.TabIndex = 42;
            this.btnSettingsSave.Text = "SAVE";
            this.btnSettingsSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettingsSave.UseVisualStyleBackColor = true;
            this.btnSettingsSave.Click += new System.EventHandler(this.btnSettingsSave_Click);
            // 
            // lbSettingTitle
            // 
            this.lbSettingTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(164)))));
            this.lbSettingTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSettingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSettingTitle.ForeColor = System.Drawing.Color.White;
            this.lbSettingTitle.Location = new System.Drawing.Point(0, 0);
            this.lbSettingTitle.Name = "lbSettingTitle";
            this.lbSettingTitle.Size = new System.Drawing.Size(391, 25);
            this.lbSettingTitle.TabIndex = 44;
            this.lbSettingTitle.Text = "APPLICATION SETTINGS";
            this.lbSettingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIPMarker
            // 
            this.lbIPMarker.AutoSize = true;
            this.lbIPMarker.Location = new System.Drawing.Point(10, 109);
            this.lbIPMarker.Name = "lbIPMarker";
            this.lbIPMarker.Size = new System.Drawing.Size(17, 13);
            this.lbIPMarker.TabIndex = 45;
            this.lbIPMarker.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIP.Location = new System.Drawing.Point(33, 125);
            this.txtIP.MaxLength = 15;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(157, 20);
            this.txtIP.TabIndex = 46;
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbSerialMarker
            // 
            this.lbSerialMarker.AutoSize = true;
            this.lbSerialMarker.Location = new System.Drawing.Point(199, 109);
            this.lbSerialMarker.Name = "lbSerialMarker";
            this.lbSerialMarker.Size = new System.Drawing.Size(29, 13);
            this.lbSerialMarker.TabIndex = 47;
            this.lbSerialMarker.Text = "USB";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(222, 126);
            this.txtSerial.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(155, 20);
            this.txtSerial.TabIndex = 48;
            this.txtSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbIP
            // 
            this.rbIP.AutoSize = true;
            this.rbIP.Location = new System.Drawing.Point(12, 128);
            this.rbIP.Name = "rbIP";
            this.rbIP.Size = new System.Drawing.Size(14, 13);
            this.rbIP.TabIndex = 49;
            this.rbIP.TabStop = true;
            this.rbIP.UseVisualStyleBackColor = true;
            // 
            // rbUsb
            // 
            this.rbUsb.AutoSize = true;
            this.rbUsb.Location = new System.Drawing.Point(202, 128);
            this.rbUsb.Name = "rbUsb";
            this.rbUsb.Size = new System.Drawing.Size(14, 13);
            this.rbUsb.TabIndex = 50;
            this.rbUsb.TabStop = true;
            this.rbUsb.UseVisualStyleBackColor = true;
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(391, 206);
            this.ControlBox = false;
            this.Controls.Add(this.rbUsb);
            this.Controls.Add(this.rbIP);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.lbSerialMarker);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lbIPMarker);
            this.Controls.Add(this.btnSettingsCancel);
            this.Controls.Add(this.btnSettingsSave);
            this.Controls.Add(this.lbSettingTitle);
            this.Controls.Add(this.btnAuxFolder);
            this.Controls.Add(this.btnPathFiles);
            this.Controls.Add(this.txtAuxFolder);
            this.Controls.Add(this.lbAuxFolder);
            this.Controls.Add(this.txtPathFiles);
            this.Controls.Add(this.lbPathFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSerial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuxFolder;
        private System.Windows.Forms.Button btnPathFiles;
        private System.Windows.Forms.TextBox txtAuxFolder;
        private System.Windows.Forms.Label lbAuxFolder;
        private System.Windows.Forms.TextBox txtPathFiles;
        private System.Windows.Forms.Label lbPathFiles;
        private System.Windows.Forms.Button btnSettingsCancel;
        private System.Windows.Forms.Button btnSettingsSave;
        private System.Windows.Forms.Label lbSettingTitle;
        private System.Windows.Forms.Label lbIPMarker;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lbSerialMarker;
        private System.Windows.Forms.NumericUpDown txtSerial;
        private System.Windows.Forms.RadioButton rbIP;
        private System.Windows.Forms.RadioButton rbUsb;
    }
}