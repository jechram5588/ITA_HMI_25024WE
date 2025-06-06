
namespace HMI_25024WE
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
            this.trvPathFiles = new System.Windows.Forms.TreeView();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.rbSearchByString = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rbSearchByFolder = new System.Windows.Forms.RadioButton();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLanguage_English = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLanguage_Spanish = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLanguage_Portuguese = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings_Parameters = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings_AppSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings_TemplateEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSetting_About = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.txtModeAutPDF = new System.Windows.Forms.TextBox();
            this.lbModeAutPDF = new System.Windows.Forms.Label();
            this.nudModAutQuantityRequired = new System.Windows.Forms.NumericUpDown();
            this.txtAuxPath = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.lbModAutTemplate = new System.Windows.Forms.Label();
            this.txtModeAutMaterial = new System.Windows.Forms.TextBox();
            this.lbModeAutMaterial = new System.Windows.Forms.Label();
            this.cbModAutTemplate = new System.Windows.Forms.ComboBox();
            this.txtModAutQuantityCompleted = new System.Windows.Forms.TextBox();
            this.lbModeAutStarSerial = new System.Windows.Forms.Label();
            this.txtModeAutStartSerial = new System.Windows.Forms.TextBox();
            this.lbModeAutEndSerial = new System.Windows.Forms.Label();
            this.txtModAutEndingSerial = new System.Windows.Forms.TextBox();
            this.lbModAutQuantityRequired = new System.Windows.Forms.Label();
            this.lbModeAutDate = new System.Windows.Forms.Label();
            this.txtModeAutDate = new System.Windows.Forms.TextBox();
            this.lbModAutQuantityCompleted = new System.Windows.Forms.Label();
            this.gbPreview = new System.Windows.Forms.GroupBox();
            this.btnClearError = new System.Windows.Forms.Button();
            this.btnZoom1 = new System.Windows.Forms.Button();
            this.btnZoomAll = new System.Windows.Forms.Button();
            this.axMBActX1 = new AxMBPLib2.AxMBActX();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.lbDisplayMode = new System.Windows.Forms.Label();
            this.btnMode = new System.Windows.Forms.Button();
            this.btnOpenPDF = new System.Windows.Forms.Button();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.rtbLogger = new System.Windows.Forms.RichTextBox();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.btnLogClear = new System.Windows.Forms.Button();
            this.btnStopMarking = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSendtoMarker = new System.Windows.Forms.Button();
            this.btnRefreshdgv = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lbFilterDgv = new System.Windows.Forms.Label();
            this.gbXMLFiles = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.gbSearch.SuspendLayout();
            this.menu.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudModAutQuantityRequired)).BeginInit();
            this.gbPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMBActX1)).BeginInit();
            this.gbMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.gbLog.SuspendLayout();
            this.gbXMLFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvPathFiles
            // 
            this.trvPathFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvPathFiles.Location = new System.Drawing.Point(7, 69);
            this.trvPathFiles.Name = "trvPathFiles";
            this.trvPathFiles.Size = new System.Drawing.Size(312, 270);
            this.trvPathFiles.TabIndex = 7;
            this.trvPathFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvPathFiles_AfterSelect);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.trvPathFiles);
            this.gbSearch.Controls.Add(this.rbSearchByString);
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Controls.Add(this.rbSearchByFolder);
            this.gbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.Location = new System.Drawing.Point(12, 23);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(325, 346);
            this.gbSearch.TabIndex = 8;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // rbSearchByString
            // 
            this.rbSearchByString.AutoSize = true;
            this.rbSearchByString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSearchByString.Location = new System.Drawing.Point(190, 46);
            this.rbSearchByString.Name = "rbSearchByString";
            this.rbSearchByString.Size = new System.Drawing.Size(129, 20);
            this.rbSearchByString.TabIndex = 1;
            this.rbSearchByString.Text = "Search For String";
            this.rbSearchByString.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(7, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(312, 22);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // rbSearchByFolder
            // 
            this.rbSearchByFolder.AutoSize = true;
            this.rbSearchByFolder.Checked = true;
            this.rbSearchByFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSearchByFolder.Location = new System.Drawing.Point(7, 46);
            this.rbSearchByFolder.Name = "rbSearchByFolder";
            this.rbSearchByFolder.Size = new System.Drawing.Size(134, 20);
            this.rbSearchByFolder.TabIndex = 0;
            this.rbSearchByFolder.TabStop = true;
            this.rbSearchByFolder.Text = "Search For Folder";
            this.rbSearchByFolder.UseVisualStyleBackColor = true;
            this.rbSearchByFolder.CheckedChanged += new System.EventHandler(this.rbSearchByFile_CheckedChanged);
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.menuLanguage,
            this.menuSettings,
            this.menuExit});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1318, 24);
            this.menu.TabIndex = 9;
            this.menu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // menuLanguage
            // 
            this.menuLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLanguage_English,
            this.menuLanguage_Spanish,
            this.menuLanguage_Portuguese});
            this.menuLanguage.Image = ((System.Drawing.Image)(resources.GetObject("menuLanguage.Image")));
            this.menuLanguage.Name = "menuLanguage";
            this.menuLanguage.Size = new System.Drawing.Size(97, 20);
            this.menuLanguage.Text = "Language";
            // 
            // menuLanguage_English
            // 
            this.menuLanguage_English.Image = ((System.Drawing.Image)(resources.GetObject("menuLanguage_English.Image")));
            this.menuLanguage_English.Name = "menuLanguage_English";
            this.menuLanguage_English.Size = new System.Drawing.Size(145, 22);
            this.menuLanguage_English.Text = "English";
            this.menuLanguage_English.Click += new System.EventHandler(this.menuLanguage_English_Click);
            // 
            // menuLanguage_Spanish
            // 
            this.menuLanguage_Spanish.Image = ((System.Drawing.Image)(resources.GetObject("menuLanguage_Spanish.Image")));
            this.menuLanguage_Spanish.Name = "menuLanguage_Spanish";
            this.menuLanguage_Spanish.Size = new System.Drawing.Size(145, 22);
            this.menuLanguage_Spanish.Text = "Spanish";
            this.menuLanguage_Spanish.Click += new System.EventHandler(this.menuLanguage_Spanish_Click);
            // 
            // menuLanguage_Portuguese
            // 
            this.menuLanguage_Portuguese.Image = ((System.Drawing.Image)(resources.GetObject("menuLanguage_Portuguese.Image")));
            this.menuLanguage_Portuguese.Name = "menuLanguage_Portuguese";
            this.menuLanguage_Portuguese.Size = new System.Drawing.Size(145, 22);
            this.menuLanguage_Portuguese.Text = "Portuguese";
            this.menuLanguage_Portuguese.Click += new System.EventHandler(this.menuLanguage_Portuguese_Click);
            // 
            // menuSettings
            // 
            this.menuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSettings_Parameters,
            this.menuSettings_AppSettings,
            this.menuSettings_TemplateEditor,
            this.menuSetting_About});
            this.menuSettings.Image = ((System.Drawing.Image)(resources.GetObject("menuSettings.Image")));
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(82, 20);
            this.menuSettings.Text = "Options";
            // 
            // menuSettings_Parameters
            // 
            this.menuSettings_Parameters.Image = ((System.Drawing.Image)(resources.GetObject("menuSettings_Parameters.Image")));
            this.menuSettings_Parameters.Name = "menuSettings_Parameters";
            this.menuSettings_Parameters.Size = new System.Drawing.Size(197, 22);
            this.menuSettings_Parameters.Text = "Marking Parameters";
            this.menuSettings_Parameters.Click += new System.EventHandler(this.menuParameters_Click);
            // 
            // menuSettings_AppSettings
            // 
            this.menuSettings_AppSettings.Image = ((System.Drawing.Image)(resources.GetObject("menuSettings_AppSettings.Image")));
            this.menuSettings_AppSettings.Name = "menuSettings_AppSettings";
            this.menuSettings_AppSettings.Size = new System.Drawing.Size(197, 22);
            this.menuSettings_AppSettings.Text = "Settings";
            this.menuSettings_AppSettings.Click += new System.EventHandler(this.menuSettings_AppSettings_Click);
            // 
            // menuSettings_TemplateEditor
            // 
            this.menuSettings_TemplateEditor.Image = ((System.Drawing.Image)(resources.GetObject("menuSettings_TemplateEditor.Image")));
            this.menuSettings_TemplateEditor.Name = "menuSettings_TemplateEditor";
            this.menuSettings_TemplateEditor.Size = new System.Drawing.Size(197, 22);
            this.menuSettings_TemplateEditor.Text = "Template Editor";
            this.menuSettings_TemplateEditor.Click += new System.EventHandler(this.menuSettings_TemplateEditor_Click);
            // 
            // menuSetting_About
            // 
            this.menuSetting_About.Image = ((System.Drawing.Image)(resources.GetObject("menuSetting_About.Image")));
            this.menuSetting_About.Name = "menuSetting_About";
            this.menuSetting_About.Size = new System.Drawing.Size(197, 22);
            this.menuSetting_About.Text = "About";
            this.menuSetting_About.Click += new System.EventHandler(this.menuSetting_About_Click);
            // 
            // menuExit
            // 
            this.menuExit.Image = ((System.Drawing.Image)(resources.GetObject("menuExit.Image")));
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(57, 20);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.txtModeAutPDF);
            this.gbData.Controls.Add(this.lbModeAutPDF);
            this.gbData.Controls.Add(this.nudModAutQuantityRequired);
            this.gbData.Controls.Add(this.txtAuxPath);
            this.gbData.Controls.Add(this.btnReload);
            this.gbData.Controls.Add(this.lbModAutTemplate);
            this.gbData.Controls.Add(this.txtModeAutMaterial);
            this.gbData.Controls.Add(this.lbModeAutMaterial);
            this.gbData.Controls.Add(this.cbModAutTemplate);
            this.gbData.Controls.Add(this.txtModAutQuantityCompleted);
            this.gbData.Controls.Add(this.lbModeAutStarSerial);
            this.gbData.Controls.Add(this.txtModeAutStartSerial);
            this.gbData.Controls.Add(this.lbModeAutEndSerial);
            this.gbData.Controls.Add(this.txtModAutEndingSerial);
            this.gbData.Controls.Add(this.lbModAutQuantityRequired);
            this.gbData.Controls.Add(this.lbModeAutDate);
            this.gbData.Controls.Add(this.txtModeAutDate);
            this.gbData.Controls.Add(this.lbModAutQuantityCompleted);
            this.gbData.Location = new System.Drawing.Point(343, 23);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(415, 346);
            this.gbData.TabIndex = 11;
            this.gbData.TabStop = false;
            // 
            // txtModeAutPDF
            // 
            this.txtModeAutPDF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModeAutPDF.Enabled = false;
            this.txtModeAutPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeAutPDF.Location = new System.Drawing.Point(21, 228);
            this.txtModeAutPDF.Name = "txtModeAutPDF";
            this.txtModeAutPDF.Size = new System.Drawing.Size(372, 22);
            this.txtModeAutPDF.TabIndex = 19;
            this.txtModeAutPDF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbModeAutPDF
            // 
            this.lbModeAutPDF.AutoSize = true;
            this.lbModeAutPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModeAutPDF.Location = new System.Drawing.Point(18, 207);
            this.lbModeAutPDF.Name = "lbModeAutPDF";
            this.lbModeAutPDF.Size = new System.Drawing.Size(55, 16);
            this.lbModeAutPDF.TabIndex = 18;
            this.lbModeAutPDF.Text = "PDF file";
            // 
            // nudModAutQuantityRequired
            // 
            this.nudModAutQuantityRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nudModAutQuantityRequired.Location = new System.Drawing.Point(21, 180);
            this.nudModAutQuantityRequired.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudModAutQuantityRequired.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudModAutQuantityRequired.Name = "nudModAutQuantityRequired";
            this.nudModAutQuantityRequired.Size = new System.Drawing.Size(186, 22);
            this.nudModAutQuantityRequired.TabIndex = 17;
            this.nudModAutQuantityRequired.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudModAutQuantityRequired.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtAuxPath
            // 
            this.txtAuxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuxPath.Enabled = false;
            this.txtAuxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuxPath.Location = new System.Drawing.Point(21, 316);
            this.txtAuxPath.Name = "txtAuxPath";
            this.txtAuxPath.Size = new System.Drawing.Size(372, 22);
            this.txtAuxPath.TabIndex = 16;
            this.txtAuxPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAuxPath.Visible = false;
            // 
            // btnReload
            // 
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Location = new System.Drawing.Point(302, 276);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(93, 26);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Reload Template";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReloadTemplate_Click);
            // 
            // lbModAutTemplate
            // 
            this.lbModAutTemplate.AutoSize = true;
            this.lbModAutTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModAutTemplate.Location = new System.Drawing.Point(18, 255);
            this.lbModAutTemplate.Name = "lbModAutTemplate";
            this.lbModAutTemplate.Size = new System.Drawing.Size(66, 16);
            this.lbModAutTemplate.TabIndex = 15;
            this.lbModAutTemplate.Text = "Template";
            // 
            // txtModeAutMaterial
            // 
            this.txtModeAutMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModeAutMaterial.Enabled = false;
            this.txtModeAutMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeAutMaterial.Location = new System.Drawing.Point(19, 36);
            this.txtModeAutMaterial.Name = "txtModeAutMaterial";
            this.txtModeAutMaterial.Size = new System.Drawing.Size(374, 22);
            this.txtModeAutMaterial.TabIndex = 3;
            this.txtModeAutMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbModeAutMaterial
            // 
            this.lbModeAutMaterial.AutoSize = true;
            this.lbModeAutMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModeAutMaterial.Location = new System.Drawing.Point(16, 15);
            this.lbModeAutMaterial.Name = "lbModeAutMaterial";
            this.lbModeAutMaterial.Size = new System.Drawing.Size(56, 16);
            this.lbModeAutMaterial.TabIndex = 2;
            this.lbModeAutMaterial.Text = "Material";
            // 
            // cbModAutTemplate
            // 
            this.cbModAutTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModAutTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModAutTemplate.FormattingEnabled = true;
            this.cbModAutTemplate.Location = new System.Drawing.Point(21, 276);
            this.cbModAutTemplate.Name = "cbModAutTemplate";
            this.cbModAutTemplate.Size = new System.Drawing.Size(271, 24);
            this.cbModAutTemplate.TabIndex = 14;
            // 
            // txtModAutQuantityCompleted
            // 
            this.txtModAutQuantityCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModAutQuantityCompleted.Enabled = false;
            this.txtModAutQuantityCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModAutQuantityCompleted.Location = new System.Drawing.Point(215, 180);
            this.txtModAutQuantityCompleted.Name = "txtModAutQuantityCompleted";
            this.txtModAutQuantityCompleted.Size = new System.Drawing.Size(178, 22);
            this.txtModAutQuantityCompleted.TabIndex = 11;
            this.txtModAutQuantityCompleted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbModeAutStarSerial
            // 
            this.lbModeAutStarSerial.AutoSize = true;
            this.lbModeAutStarSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModeAutStarSerial.Location = new System.Drawing.Point(16, 63);
            this.lbModeAutStarSerial.Name = "lbModeAutStarSerial";
            this.lbModeAutStarSerial.Size = new System.Drawing.Size(91, 16);
            this.lbModeAutStarSerial.TabIndex = 4;
            this.lbModeAutStarSerial.Text = "Starting Serial";
            // 
            // txtModeAutStartSerial
            // 
            this.txtModeAutStartSerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModeAutStartSerial.Enabled = false;
            this.txtModeAutStartSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeAutStartSerial.Location = new System.Drawing.Point(19, 84);
            this.txtModeAutStartSerial.MaxLength = 10;
            this.txtModeAutStartSerial.Name = "txtModeAutStartSerial";
            this.txtModeAutStartSerial.Size = new System.Drawing.Size(189, 22);
            this.txtModeAutStartSerial.TabIndex = 5;
            this.txtModeAutStartSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtModeAutStartSerial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModeAutStartSerial_KeyPress);
            // 
            // lbModeAutEndSerial
            // 
            this.lbModeAutEndSerial.AutoSize = true;
            this.lbModeAutEndSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModeAutEndSerial.Location = new System.Drawing.Point(210, 65);
            this.lbModeAutEndSerial.Name = "lbModeAutEndSerial";
            this.lbModeAutEndSerial.Size = new System.Drawing.Size(88, 16);
            this.lbModeAutEndSerial.TabIndex = 6;
            this.lbModeAutEndSerial.Text = "Ending Serial";
            // 
            // txtModAutEndingSerial
            // 
            this.txtModAutEndingSerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModAutEndingSerial.Enabled = false;
            this.txtModAutEndingSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModAutEndingSerial.Location = new System.Drawing.Point(211, 84);
            this.txtModAutEndingSerial.MaxLength = 10;
            this.txtModAutEndingSerial.Name = "txtModAutEndingSerial";
            this.txtModAutEndingSerial.Size = new System.Drawing.Size(182, 22);
            this.txtModAutEndingSerial.TabIndex = 7;
            this.txtModAutEndingSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbModAutQuantityRequired
            // 
            this.lbModAutQuantityRequired.AutoSize = true;
            this.lbModAutQuantityRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModAutQuantityRequired.Location = new System.Drawing.Point(18, 159);
            this.lbModAutQuantityRequired.Name = "lbModAutQuantityRequired";
            this.lbModAutQuantityRequired.Size = new System.Drawing.Size(115, 16);
            this.lbModAutQuantityRequired.TabIndex = 12;
            this.lbModAutQuantityRequired.Text = "Quantity Required";
            // 
            // lbModeAutDate
            // 
            this.lbModeAutDate.AutoSize = true;
            this.lbModeAutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModeAutDate.Location = new System.Drawing.Point(18, 111);
            this.lbModeAutDate.Name = "lbModeAutDate";
            this.lbModeAutDate.Size = new System.Drawing.Size(37, 16);
            this.lbModeAutDate.TabIndex = 8;
            this.lbModeAutDate.Text = "Date";
            // 
            // txtModeAutDate
            // 
            this.txtModeAutDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModeAutDate.Enabled = false;
            this.txtModeAutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeAutDate.Location = new System.Drawing.Point(21, 132);
            this.txtModeAutDate.MaxLength = 9;
            this.txtModeAutDate.Name = "txtModeAutDate";
            this.txtModeAutDate.Size = new System.Drawing.Size(187, 22);
            this.txtModeAutDate.TabIndex = 9;
            this.txtModeAutDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbModAutQuantityCompleted
            // 
            this.lbModAutQuantityCompleted.AutoSize = true;
            this.lbModAutQuantityCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModAutQuantityCompleted.Location = new System.Drawing.Point(214, 159);
            this.lbModAutQuantityCompleted.Name = "lbModAutQuantityCompleted";
            this.lbModAutQuantityCompleted.Size = new System.Drawing.Size(125, 16);
            this.lbModAutQuantityCompleted.TabIndex = 10;
            this.lbModAutQuantityCompleted.Text = "Quantity Completed";
            // 
            // gbPreview
            // 
            this.gbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPreview.Controls.Add(this.btnClearError);
            this.gbPreview.Controls.Add(this.btnZoom1);
            this.gbPreview.Controls.Add(this.btnZoomAll);
            this.gbPreview.Controls.Add(this.axMBActX1);
            this.gbPreview.Location = new System.Drawing.Point(767, 23);
            this.gbPreview.Name = "gbPreview";
            this.gbPreview.Size = new System.Drawing.Size(539, 560);
            this.gbPreview.TabIndex = 12;
            this.gbPreview.TabStop = false;
            // 
            // btnClearError
            // 
            this.btnClearError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearError.Image = ((System.Drawing.Image)(resources.GetObject("btnClearError.Image")));
            this.btnClearError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearError.Location = new System.Drawing.Point(423, 16);
            this.btnClearError.Name = "btnClearError";
            this.btnClearError.Size = new System.Drawing.Size(110, 38);
            this.btnClearError.TabIndex = 22;
            this.btnClearError.Text = "Clear";
            this.btnClearError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearError.UseVisualStyleBackColor = true;
            this.btnClearError.Click += new System.EventHandler(this.btnClearError_Click);
            // 
            // btnZoom1
            // 
            this.btnZoom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoom1.Image = ((System.Drawing.Image)(resources.GetObject("btnZoom1.Image")));
            this.btnZoom1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZoom1.Location = new System.Drawing.Point(124, 16);
            this.btnZoom1.Name = "btnZoom1";
            this.btnZoom1.Size = new System.Drawing.Size(89, 38);
            this.btnZoom1.TabIndex = 21;
            this.btnZoom1.Text = "Zoom";
            this.btnZoom1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZoom1.UseVisualStyleBackColor = true;
            this.btnZoom1.Click += new System.EventHandler(this.btnZoom1_Click);
            // 
            // btnZoomAll
            // 
            this.btnZoomAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomAll.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomAll.Image")));
            this.btnZoomAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZoomAll.Location = new System.Drawing.Point(9, 16);
            this.btnZoomAll.Name = "btnZoomAll";
            this.btnZoomAll.Size = new System.Drawing.Size(109, 38);
            this.btnZoomAll.TabIndex = 20;
            this.btnZoomAll.Text = "Zoom All";
            this.btnZoomAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZoomAll.UseVisualStyleBackColor = true;
            this.btnZoomAll.Click += new System.EventHandler(this.btnZoomAll_Click);
            // 
            // axMBActX1
            // 
            this.axMBActX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axMBActX1.Enabled = true;
            this.axMBActX1.Location = new System.Drawing.Point(9, 60);
            this.axMBActX1.Name = "axMBActX1";
            this.axMBActX1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMBActX1.OcxState")));
            this.axMBActX1.Size = new System.Drawing.Size(524, 490);
            this.axMBActX1.TabIndex = 0;
            this.axMBActX1.EvMarkingEnd += new AxMBPLib2._DMBActXEvents_EvMarkingEndEventHandler(this.axMBActX1_EvMarkingEnd);
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.lbDisplayMode);
            this.gbMode.Controls.Add(this.btnMode);
            this.gbMode.Controls.Add(this.btnOpenPDF);
            this.gbMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMode.Location = new System.Drawing.Point(13, 368);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(745, 49);
            this.gbMode.TabIndex = 13;
            this.gbMode.TabStop = false;
            // 
            // lbDisplayMode
            // 
            this.lbDisplayMode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDisplayMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplayMode.Location = new System.Drawing.Point(375, 12);
            this.lbDisplayMode.Name = "lbDisplayMode";
            this.lbDisplayMode.Size = new System.Drawing.Size(364, 27);
            this.lbDisplayMode.TabIndex = 2;
            this.lbDisplayMode.Text = "DisplayMode";
            this.lbDisplayMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMode
            // 
            this.btnMode.AutoSize = true;
            this.btnMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMode.Image = ((System.Drawing.Image)(resources.GetObject("btnMode.Image")));
            this.btnMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMode.Location = new System.Drawing.Point(221, 11);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(148, 32);
            this.btnMode.TabIndex = 1;
            this.btnMode.Text = "Manual Mode";
            this.btnMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMode.UseVisualStyleBackColor = true;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // btnOpenPDF
            // 
            this.btnOpenPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenPDF.Image")));
            this.btnOpenPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenPDF.Location = new System.Drawing.Point(6, 13);
            this.btnOpenPDF.Name = "btnOpenPDF";
            this.btnOpenPDF.Size = new System.Drawing.Size(108, 30);
            this.btnOpenPDF.TabIndex = 0;
            this.btnOpenPDF.Text = "Open PDF";
            this.btnOpenPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenPDF.UseVisualStyleBackColor = true;
            this.btnOpenPDF.Click += new System.EventHandler(this.btnOpenPDF_Click);
            // 
            // dgvJobs
            // 
            this.dgvJobs.AllowUserToAddRows = false;
            this.dgvJobs.AllowUserToDeleteRows = false;
            this.dgvJobs.AllowUserToResizeColumns = false;
            this.dgvJobs.AllowUserToResizeRows = false;
            this.dgvJobs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvJobs.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvJobs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvJobs.Location = new System.Drawing.Point(6, 39);
            this.dgvJobs.MultiSelect = false;
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobs.Size = new System.Drawing.Size(733, 119);
            this.dgvJobs.TabIndex = 14;
            this.dgvJobs.Click += new System.EventHandler(this.dgvJobs_Click);
            // 
            // rtbLogger
            // 
            this.rtbLogger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLogger.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbLogger.Location = new System.Drawing.Point(6, 10);
            this.rtbLogger.Name = "rtbLogger";
            this.rtbLogger.Size = new System.Drawing.Size(991, 75);
            this.rtbLogger.TabIndex = 15;
            this.rtbLogger.Text = "";
            // 
            // gbLog
            // 
            this.gbLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLog.Controls.Add(this.btnLogClear);
            this.gbLog.Controls.Add(this.rtbLogger);
            this.gbLog.Location = new System.Drawing.Point(12, 583);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(1119, 91);
            this.gbLog.TabIndex = 16;
            this.gbLog.TabStop = false;
            // 
            // btnLogClear
            // 
            this.btnLogClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogClear.Image = ((System.Drawing.Image)(resources.GetObject("btnLogClear.Image")));
            this.btnLogClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogClear.Location = new System.Drawing.Point(1015, 26);
            this.btnLogClear.Name = "btnLogClear";
            this.btnLogClear.Size = new System.Drawing.Size(86, 44);
            this.btnLogClear.TabIndex = 19;
            this.btnLogClear.Text = "Clear";
            this.btnLogClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogClear.UseVisualStyleBackColor = true;
            this.btnLogClear.Click += new System.EventHandler(this.btnLogClear_Click);
            // 
            // btnStopMarking
            // 
            this.btnStopMarking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopMarking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopMarking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopMarking.Image = ((System.Drawing.Image)(resources.GetObject("btnStopMarking.Image")));
            this.btnStopMarking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopMarking.Location = new System.Drawing.Point(1137, 636);
            this.btnStopMarking.Name = "btnStopMarking";
            this.btnStopMarking.Size = new System.Drawing.Size(169, 38);
            this.btnStopMarking.TabIndex = 18;
            this.btnStopMarking.Text = "Stop Marking";
            this.btnStopMarking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStopMarking.UseVisualStyleBackColor = true;
            this.btnStopMarking.Click += new System.EventHandler(this.btnStopMarking_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.ico");
            // 
            // btnSendtoMarker
            // 
            this.btnSendtoMarker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendtoMarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendtoMarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendtoMarker.Image = ((System.Drawing.Image)(resources.GetObject("btnSendtoMarker.Image")));
            this.btnSendtoMarker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendtoMarker.Location = new System.Drawing.Point(1137, 589);
            this.btnSendtoMarker.Name = "btnSendtoMarker";
            this.btnSendtoMarker.Size = new System.Drawing.Size(169, 38);
            this.btnSendtoMarker.TabIndex = 19;
            this.btnSendtoMarker.Text = "Send to Marker";
            this.btnSendtoMarker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendtoMarker.UseVisualStyleBackColor = true;
            this.btnSendtoMarker.Click += new System.EventHandler(this.btnSendtoMarker_Click);
            // 
            // btnRefreshdgv
            // 
            this.btnRefreshdgv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshdgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshdgv.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshdgv.Image")));
            this.btnRefreshdgv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshdgv.Location = new System.Drawing.Point(6, 13);
            this.btnRefreshdgv.Name = "btnRefreshdgv";
            this.btnRefreshdgv.Size = new System.Drawing.Size(37, 20);
            this.btnRefreshdgv.TabIndex = 19;
            this.btnRefreshdgv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshdgv.UseVisualStyleBackColor = true;
            this.btnRefreshdgv.Click += new System.EventHandler(this.btnRefreshdgv_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(569, 13);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(170, 20);
            this.txtFilter.TabIndex = 20;
            this.txtFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyUp);
            // 
            // lbFilterDgv
            // 
            this.lbFilterDgv.AutoSize = true;
            this.lbFilterDgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterDgv.Location = new System.Drawing.Point(507, 13);
            this.lbFilterDgv.Name = "lbFilterDgv";
            this.lbFilterDgv.Size = new System.Drawing.Size(56, 16);
            this.lbFilterDgv.TabIndex = 18;
            this.lbFilterDgv.Text = "Material";
            // 
            // gbXMLFiles
            // 
            this.gbXMLFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbXMLFiles.Controls.Add(this.button6);
            this.gbXMLFiles.Controls.Add(this.button5);
            this.gbXMLFiles.Controls.Add(this.button4);
            this.gbXMLFiles.Controls.Add(this.button3);
            this.gbXMLFiles.Controls.Add(this.button2);
            this.gbXMLFiles.Controls.Add(this.txtFilter);
            this.gbXMLFiles.Controls.Add(this.btnRefreshdgv);
            this.gbXMLFiles.Controls.Add(this.lbFilterDgv);
            this.gbXMLFiles.Controls.Add(this.dgvJobs);
            this.gbXMLFiles.Location = new System.Drawing.Point(13, 419);
            this.gbXMLFiles.Name = "gbXMLFiles";
            this.gbXMLFiles.Size = new System.Drawing.Size(745, 164);
            this.gbXMLFiles.TabIndex = 21;
            this.gbXMLFiles.TabStop = false;
            this.gbXMLFiles.Text = "XML Files";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1022, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 23;
            this.button1.Text = "pruebas";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Conectar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(146, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "ready";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(227, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "sendJob";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(308, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "readJob";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(388, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 25;
            this.button6.Text = "fit shape";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 679);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbXMLFiles);
            this.Controls.Add(this.btnSendtoMarker);
            this.Controls.Add(this.btnStopMarking);
            this.Controls.Add(this.gbLog);
            this.Controls.Add(this.gbMode);
            this.Controls.Add(this.gbPreview);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WEG MARKING SYSTEM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudModAutQuantityRequired)).EndInit();
            this.gbPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axMBActX1)).EndInit();
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.gbLog.ResumeLayout(false);
            this.gbXMLFiles.ResumeLayout(false);
            this.gbXMLFiles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView trvPathFiles;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.RadioButton rbSearchByString;
        private System.Windows.Forms.RadioButton rbSearchByFolder;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuLanguage;
        private System.Windows.Forms.ToolStripMenuItem menuLanguage_English;
        private System.Windows.Forms.ToolStripMenuItem menuLanguage_Spanish;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.GroupBox gbPreview;
        private AxMBPLib2.AxMBActX axMBActX1;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Button btnOpenPDF;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.RichTextBox rtbLogger;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.Button btnLogClear;
        private System.Windows.Forms.Button btnStopMarking;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbModAutQuantityRequired;
        private System.Windows.Forms.Label lbModAutQuantityCompleted;
        private System.Windows.Forms.TextBox txtModeAutDate;
        private System.Windows.Forms.Label lbModeAutDate;
        private System.Windows.Forms.TextBox txtModAutEndingSerial;
        private System.Windows.Forms.Label lbModeAutEndSerial;
        private System.Windows.Forms.TextBox txtModeAutStartSerial;
        private System.Windows.Forms.Label lbModeAutStarSerial;
        private System.Windows.Forms.TextBox txtModeAutMaterial;
        private System.Windows.Forms.Label lbModeAutMaterial;
        private System.Windows.Forms.ComboBox cbModAutTemplate;
        private System.Windows.Forms.Label lbModAutTemplate;
        private System.Windows.Forms.ToolStripMenuItem menuSettings_Parameters;
        private System.Windows.Forms.ToolStripMenuItem menuSettings_AppSettings;
        private System.Windows.Forms.Label lbDisplayMode;
        private System.Windows.Forms.Button btnSendtoMarker;
        private System.Windows.Forms.Button btnZoom1;
        private System.Windows.Forms.Button btnZoomAll;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TextBox txtAuxPath;
        private System.Windows.Forms.NumericUpDown nudModAutQuantityRequired;
        private System.Windows.Forms.TextBox txtModAutQuantityCompleted;
        private System.Windows.Forms.Button btnClearError;
        private System.Windows.Forms.ToolStripMenuItem menuLanguage_Portuguese;
        private System.Windows.Forms.Button btnRefreshdgv;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lbFilterDgv;
        private System.Windows.Forms.ToolStripMenuItem menuSettings_TemplateEditor;
        private System.Windows.Forms.GroupBox gbXMLFiles;
        private System.Windows.Forms.ToolStripMenuItem menuSetting_About;
        private System.Windows.Forms.TextBox txtModeAutPDF;
        private System.Windows.Forms.Label lbModeAutPDF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}