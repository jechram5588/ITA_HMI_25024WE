
namespace HMI_25024WE
{
    partial class Form_TemplateEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TemplateEditor));
            this.lbTemplates = new System.Windows.Forms.ListBox();
            this.lbTemplateEditor_Templates = new System.Windows.Forms.Label();
            this.btnTemplateEditor_Add = new System.Windows.Forms.Button();
            this.btnTemplateEditor_Edit = new System.Windows.Forms.Button();
            this.btnTemplateEditor_Delete = new System.Windows.Forms.Button();
            this.dgvCoords = new System.Windows.Forms.DataGridView();
            this.lbTemplateEditorWidth = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.lbTemplateEditor_Height = new System.Windows.Forms.Label();
            this.nudCharWidth = new System.Windows.Forms.NumericUpDown();
            this.lbTemplateEditor_CharWidth = new System.Windows.Forms.Label();
            this.nudCharHeight = new System.Windows.Forms.NumericUpDown();
            this.lbTemplateEditor_CharHeight = new System.Windows.Forms.Label();
            this.nudCharAngle = new System.Windows.Forms.NumericUpDown();
            this.lbTemplateEditor_TextAngle = new System.Windows.Forms.Label();
            this.nudCharFullWidth = new System.Windows.Forms.NumericUpDown();
            this.lbTemplateEditor_CharFullWidth = new System.Windows.Forms.Label();
            this.gbTemplateEditor_Labels = new System.Windows.Forms.GroupBox();
            this.lbTemplateEditor_LabelAngle = new System.Windows.Forms.Label();
            this.nudAngle = new System.Windows.Forms.NumericUpDown();
            this.gbTemplateEditor_TextData = new System.Windows.Forms.GroupBox();
            this.lbTemplates_Title = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbTemplateEditor_TemplateName = new System.Windows.Forms.Label();
            this.btnTemplateEditor_AddNode = new System.Windows.Forms.Button();
            this.btnTemplateEditor_DeleteNode = new System.Windows.Forms.Button();
            this.btnTemplateEditor_Close = new System.Windows.Forms.Button();
            this.btnTemplateEditor_ImportNodes = new System.Windows.Forms.Button();
            this.axMBActX1 = new AxMBPLib2.AxMBActX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharFullWidth)).BeginInit();
            this.gbTemplateEditor_Labels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).BeginInit();
            this.gbTemplateEditor_TextData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMBActX1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTemplates
            // 
            this.lbTemplates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemplates.FormattingEnabled = true;
            this.lbTemplates.ItemHeight = 20;
            this.lbTemplates.Location = new System.Drawing.Point(12, 49);
            this.lbTemplates.Name = "lbTemplates";
            this.lbTemplates.Size = new System.Drawing.Size(204, 184);
            this.lbTemplates.TabIndex = 0;
            this.lbTemplates.SelectedIndexChanged += new System.EventHandler(this.lbTemplates_SelectedIndexChanged);
            // 
            // lbTemplateEditor_Templates
            // 
            this.lbTemplateEditor_Templates.AutoSize = true;
            this.lbTemplateEditor_Templates.Location = new System.Drawing.Point(12, 33);
            this.lbTemplateEditor_Templates.Name = "lbTemplateEditor_Templates";
            this.lbTemplateEditor_Templates.Size = new System.Drawing.Size(56, 13);
            this.lbTemplateEditor_Templates.TabIndex = 1;
            this.lbTemplateEditor_Templates.Text = "Templates";
            // 
            // btnTemplateEditor_Add
            // 
            this.btnTemplateEditor_Add.FlatAppearance.BorderSize = 0;
            this.btnTemplateEditor_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemplateEditor_Add.Image = ((System.Drawing.Image)(resources.GetObject("btnTemplateEditor_Add.Image")));
            this.btnTemplateEditor_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemplateEditor_Add.Location = new System.Drawing.Point(12, 239);
            this.btnTemplateEditor_Add.Name = "btnTemplateEditor_Add";
            this.btnTemplateEditor_Add.Size = new System.Drawing.Size(82, 23);
            this.btnTemplateEditor_Add.TabIndex = 2;
            this.btnTemplateEditor_Add.Text = "New";
            this.btnTemplateEditor_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemplateEditor_Add.UseVisualStyleBackColor = true;
            this.btnTemplateEditor_Add.Click += new System.EventHandler(this.btnTemplateEditor_Add_Click);
            // 
            // btnTemplateEditor_Edit
            // 
            this.btnTemplateEditor_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemplateEditor_Edit.FlatAppearance.BorderSize = 0;
            this.btnTemplateEditor_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemplateEditor_Edit.Image = ((System.Drawing.Image)(resources.GetObject("btnTemplateEditor_Edit.Image")));
            this.btnTemplateEditor_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemplateEditor_Edit.Location = new System.Drawing.Point(1048, 625);
            this.btnTemplateEditor_Edit.Name = "btnTemplateEditor_Edit";
            this.btnTemplateEditor_Edit.Size = new System.Drawing.Size(84, 23);
            this.btnTemplateEditor_Edit.TabIndex = 3;
            this.btnTemplateEditor_Edit.Text = "Save";
            this.btnTemplateEditor_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemplateEditor_Edit.UseVisualStyleBackColor = true;
            this.btnTemplateEditor_Edit.Click += new System.EventHandler(this.btnTemplateEditor_Edit_Click);
            // 
            // btnTemplateEditor_Delete
            // 
            this.btnTemplateEditor_Delete.FlatAppearance.BorderSize = 0;
            this.btnTemplateEditor_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemplateEditor_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btnTemplateEditor_Delete.Image")));
            this.btnTemplateEditor_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemplateEditor_Delete.Location = new System.Drawing.Point(134, 239);
            this.btnTemplateEditor_Delete.Name = "btnTemplateEditor_Delete";
            this.btnTemplateEditor_Delete.Size = new System.Drawing.Size(82, 23);
            this.btnTemplateEditor_Delete.TabIndex = 4;
            this.btnTemplateEditor_Delete.Text = "Delete";
            this.btnTemplateEditor_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemplateEditor_Delete.UseVisualStyleBackColor = true;
            this.btnTemplateEditor_Delete.Click += new System.EventHandler(this.btnTemplateEditor_Delete_Click);
            // 
            // dgvCoords
            // 
            this.dgvCoords.AllowUserToAddRows = false;
            this.dgvCoords.AllowUserToDeleteRows = false;
            this.dgvCoords.AllowUserToResizeRows = false;
            this.dgvCoords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCoords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoords.Location = new System.Drawing.Point(222, 49);
            this.dgvCoords.MultiSelect = false;
            this.dgvCoords.Name = "dgvCoords";
            this.dgvCoords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoords.Size = new System.Drawing.Size(922, 570);
            this.dgvCoords.TabIndex = 5;
            this.dgvCoords.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvCoords_CellBeginEdit);
            this.dgvCoords.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoords_CellEndEdit);
            // 
            // lbTemplateEditorWidth
            // 
            this.lbTemplateEditorWidth.AutoSize = true;
            this.lbTemplateEditorWidth.Location = new System.Drawing.Point(9, 21);
            this.lbTemplateEditorWidth.Name = "lbTemplateEditorWidth";
            this.lbTemplateEditorWidth.Size = new System.Drawing.Size(35, 13);
            this.lbTemplateEditorWidth.TabIndex = 6;
            this.lbTemplateEditorWidth.Text = "Width";
            // 
            // nudWidth
            // 
            this.nudWidth.DecimalPlaces = 2;
            this.nudWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nudWidth.Location = new System.Drawing.Point(122, 19);
            this.nudWidth.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(69, 20);
            this.nudWidth.TabIndex = 7;
            this.nudWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudHeight
            // 
            this.nudHeight.DecimalPlaces = 2;
            this.nudHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nudHeight.Location = new System.Drawing.Point(122, 45);
            this.nudHeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(69, 20);
            this.nudHeight.TabIndex = 9;
            this.nudHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbTemplateEditor_Height
            // 
            this.lbTemplateEditor_Height.AutoSize = true;
            this.lbTemplateEditor_Height.Location = new System.Drawing.Point(9, 47);
            this.lbTemplateEditor_Height.Name = "lbTemplateEditor_Height";
            this.lbTemplateEditor_Height.Size = new System.Drawing.Size(38, 13);
            this.lbTemplateEditor_Height.TabIndex = 8;
            this.lbTemplateEditor_Height.Text = "Height";
            // 
            // nudCharWidth
            // 
            this.nudCharWidth.DecimalPlaces = 2;
            this.nudCharWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nudCharWidth.Location = new System.Drawing.Point(124, 19);
            this.nudCharWidth.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudCharWidth.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            this.nudCharWidth.Name = "nudCharWidth";
            this.nudCharWidth.Size = new System.Drawing.Size(69, 20);
            this.nudCharWidth.TabIndex = 13;
            this.nudCharWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCharWidth.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            // 
            // lbTemplateEditor_CharWidth
            // 
            this.lbTemplateEditor_CharWidth.AutoSize = true;
            this.lbTemplateEditor_CharWidth.Location = new System.Drawing.Point(11, 21);
            this.lbTemplateEditor_CharWidth.Name = "lbTemplateEditor_CharWidth";
            this.lbTemplateEditor_CharWidth.Size = new System.Drawing.Size(57, 13);
            this.lbTemplateEditor_CharWidth.TabIndex = 12;
            this.lbTemplateEditor_CharWidth.Text = "CharWidth";
            // 
            // nudCharHeight
            // 
            this.nudCharHeight.DecimalPlaces = 2;
            this.nudCharHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nudCharHeight.Location = new System.Drawing.Point(124, 45);
            this.nudCharHeight.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudCharHeight.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            this.nudCharHeight.Name = "nudCharHeight";
            this.nudCharHeight.Size = new System.Drawing.Size(69, 20);
            this.nudCharHeight.TabIndex = 11;
            this.nudCharHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCharHeight.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            // 
            // lbTemplateEditor_CharHeight
            // 
            this.lbTemplateEditor_CharHeight.AutoSize = true;
            this.lbTemplateEditor_CharHeight.Location = new System.Drawing.Point(11, 47);
            this.lbTemplateEditor_CharHeight.Name = "lbTemplateEditor_CharHeight";
            this.lbTemplateEditor_CharHeight.Size = new System.Drawing.Size(60, 13);
            this.lbTemplateEditor_CharHeight.TabIndex = 10;
            this.lbTemplateEditor_CharHeight.Text = "CharHeight";
            // 
            // nudCharAngle
            // 
            this.nudCharAngle.DecimalPlaces = 2;
            this.nudCharAngle.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nudCharAngle.Location = new System.Drawing.Point(124, 71);
            this.nudCharAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudCharAngle.Name = "nudCharAngle";
            this.nudCharAngle.Size = new System.Drawing.Size(69, 20);
            this.nudCharAngle.TabIndex = 17;
            this.nudCharAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCharAngle.ValueChanged += new System.EventHandler(this.nudCharAngle_ValueChanged);
            // 
            // lbTemplateEditor_TextAngle
            // 
            this.lbTemplateEditor_TextAngle.AutoSize = true;
            this.lbTemplateEditor_TextAngle.Location = new System.Drawing.Point(11, 73);
            this.lbTemplateEditor_TextAngle.Name = "lbTemplateEditor_TextAngle";
            this.lbTemplateEditor_TextAngle.Size = new System.Drawing.Size(55, 13);
            this.lbTemplateEditor_TextAngle.TabIndex = 16;
            this.lbTemplateEditor_TextAngle.Text = "TextAngle";
            // 
            // nudCharFullWidth
            // 
            this.nudCharFullWidth.DecimalPlaces = 2;
            this.nudCharFullWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nudCharFullWidth.Location = new System.Drawing.Point(124, 97);
            this.nudCharFullWidth.Name = "nudCharFullWidth";
            this.nudCharFullWidth.Size = new System.Drawing.Size(69, 20);
            this.nudCharFullWidth.TabIndex = 15;
            this.nudCharFullWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTemplateEditor_CharFullWidth
            // 
            this.lbTemplateEditor_CharFullWidth.Location = new System.Drawing.Point(11, 99);
            this.lbTemplateEditor_CharFullWidth.Name = "lbTemplateEditor_CharFullWidth";
            this.lbTemplateEditor_CharFullWidth.Size = new System.Drawing.Size(107, 34);
            this.lbTemplateEditor_CharFullWidth.TabIndex = 14;
            this.lbTemplateEditor_CharFullWidth.Text = "CharFullWidth";
            // 
            // gbTemplateEditor_Labels
            // 
            this.gbTemplateEditor_Labels.Controls.Add(this.lbTemplateEditor_LabelAngle);
            this.gbTemplateEditor_Labels.Controls.Add(this.nudAngle);
            this.gbTemplateEditor_Labels.Controls.Add(this.nudWidth);
            this.gbTemplateEditor_Labels.Controls.Add(this.lbTemplateEditorWidth);
            this.gbTemplateEditor_Labels.Controls.Add(this.lbTemplateEditor_Height);
            this.gbTemplateEditor_Labels.Controls.Add(this.nudHeight);
            this.gbTemplateEditor_Labels.Location = new System.Drawing.Point(12, 327);
            this.gbTemplateEditor_Labels.Name = "gbTemplateEditor_Labels";
            this.gbTemplateEditor_Labels.Size = new System.Drawing.Size(201, 103);
            this.gbTemplateEditor_Labels.TabIndex = 18;
            this.gbTemplateEditor_Labels.TabStop = false;
            this.gbTemplateEditor_Labels.Text = "Label Data";
            // 
            // lbTemplateEditor_LabelAngle
            // 
            this.lbTemplateEditor_LabelAngle.AutoSize = true;
            this.lbTemplateEditor_LabelAngle.Location = new System.Drawing.Point(9, 75);
            this.lbTemplateEditor_LabelAngle.Name = "lbTemplateEditor_LabelAngle";
            this.lbTemplateEditor_LabelAngle.Size = new System.Drawing.Size(34, 13);
            this.lbTemplateEditor_LabelAngle.TabIndex = 20;
            this.lbTemplateEditor_LabelAngle.Text = "Angle";
            // 
            // nudAngle
            // 
            this.nudAngle.DecimalPlaces = 2;
            this.nudAngle.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nudAngle.Location = new System.Drawing.Point(122, 73);
            this.nudAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudAngle.Name = "nudAngle";
            this.nudAngle.Size = new System.Drawing.Size(69, 20);
            this.nudAngle.TabIndex = 19;
            this.nudAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbTemplateEditor_TextData
            // 
            this.gbTemplateEditor_TextData.Controls.Add(this.nudCharWidth);
            this.gbTemplateEditor_TextData.Controls.Add(this.lbTemplateEditor_CharHeight);
            this.gbTemplateEditor_TextData.Controls.Add(this.nudCharAngle);
            this.gbTemplateEditor_TextData.Controls.Add(this.lbTemplateEditor_TextAngle);
            this.gbTemplateEditor_TextData.Controls.Add(this.nudCharHeight);
            this.gbTemplateEditor_TextData.Controls.Add(this.nudCharFullWidth);
            this.gbTemplateEditor_TextData.Controls.Add(this.lbTemplateEditor_CharWidth);
            this.gbTemplateEditor_TextData.Controls.Add(this.lbTemplateEditor_CharFullWidth);
            this.gbTemplateEditor_TextData.Location = new System.Drawing.Point(10, 438);
            this.gbTemplateEditor_TextData.Name = "gbTemplateEditor_TextData";
            this.gbTemplateEditor_TextData.Size = new System.Drawing.Size(201, 147);
            this.gbTemplateEditor_TextData.TabIndex = 19;
            this.gbTemplateEditor_TextData.TabStop = false;
            this.gbTemplateEditor_TextData.Text = "Text Data";
            // 
            // lbTemplates_Title
            // 
            this.lbTemplates_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(164)))));
            this.lbTemplates_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTemplates_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemplates_Title.ForeColor = System.Drawing.Color.White;
            this.lbTemplates_Title.Location = new System.Drawing.Point(0, 0);
            this.lbTemplates_Title.Name = "lbTemplates_Title";
            this.lbTemplates_Title.Size = new System.Drawing.Size(1156, 25);
            this.lbTemplates_Title.TabIndex = 43;
            this.lbTemplates_Title.Text = "TEMPLATE EDITOR";
            this.lbTemplates_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 301);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 20);
            this.txtName.TabIndex = 44;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lbTemplateEditor_TemplateName
            // 
            this.lbTemplateEditor_TemplateName.AutoSize = true;
            this.lbTemplateEditor_TemplateName.Location = new System.Drawing.Point(12, 285);
            this.lbTemplateEditor_TemplateName.Name = "lbTemplateEditor_TemplateName";
            this.lbTemplateEditor_TemplateName.Size = new System.Drawing.Size(82, 13);
            this.lbTemplateEditor_TemplateName.TabIndex = 21;
            this.lbTemplateEditor_TemplateName.Text = "Template Name";
            // 
            // btnTemplateEditor_AddNode
            // 
            this.btnTemplateEditor_AddNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTemplateEditor_AddNode.FlatAppearance.BorderSize = 0;
            this.btnTemplateEditor_AddNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemplateEditor_AddNode.Image = ((System.Drawing.Image)(resources.GetObject("btnTemplateEditor_AddNode.Image")));
            this.btnTemplateEditor_AddNode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemplateEditor_AddNode.Location = new System.Drawing.Point(224, 625);
            this.btnTemplateEditor_AddNode.Name = "btnTemplateEditor_AddNode";
            this.btnTemplateEditor_AddNode.Size = new System.Drawing.Size(133, 23);
            this.btnTemplateEditor_AddNode.TabIndex = 45;
            this.btnTemplateEditor_AddNode.Text = "Add Node";
            this.btnTemplateEditor_AddNode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemplateEditor_AddNode.UseVisualStyleBackColor = true;
            this.btnTemplateEditor_AddNode.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTemplateEditor_DeleteNode
            // 
            this.btnTemplateEditor_DeleteNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTemplateEditor_DeleteNode.FlatAppearance.BorderSize = 0;
            this.btnTemplateEditor_DeleteNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemplateEditor_DeleteNode.Image = ((System.Drawing.Image)(resources.GetObject("btnTemplateEditor_DeleteNode.Image")));
            this.btnTemplateEditor_DeleteNode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemplateEditor_DeleteNode.Location = new System.Drawing.Point(368, 625);
            this.btnTemplateEditor_DeleteNode.Name = "btnTemplateEditor_DeleteNode";
            this.btnTemplateEditor_DeleteNode.Size = new System.Drawing.Size(133, 23);
            this.btnTemplateEditor_DeleteNode.TabIndex = 46;
            this.btnTemplateEditor_DeleteNode.Text = "Delete Node";
            this.btnTemplateEditor_DeleteNode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemplateEditor_DeleteNode.UseVisualStyleBackColor = true;
            this.btnTemplateEditor_DeleteNode.Click += new System.EventHandler(this.btnTemplateEditor_DeleteNode_Click);
            // 
            // btnTemplateEditor_Close
            // 
            this.btnTemplateEditor_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemplateEditor_Close.BackColor = System.Drawing.Color.Maroon;
            this.btnTemplateEditor_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemplateEditor_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemplateEditor_Close.ForeColor = System.Drawing.Color.White;
            this.btnTemplateEditor_Close.Location = new System.Drawing.Point(1118, 0);
            this.btnTemplateEditor_Close.Name = "btnTemplateEditor_Close";
            this.btnTemplateEditor_Close.Size = new System.Drawing.Size(38, 25);
            this.btnTemplateEditor_Close.TabIndex = 47;
            this.btnTemplateEditor_Close.Text = "X";
            this.btnTemplateEditor_Close.UseVisualStyleBackColor = false;
            this.btnTemplateEditor_Close.Click += new System.EventHandler(this.btnTemplateEditor_Close_Click);
            // 
            // btnTemplateEditor_ImportNodes
            // 
            this.btnTemplateEditor_ImportNodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTemplateEditor_ImportNodes.FlatAppearance.BorderSize = 0;
            this.btnTemplateEditor_ImportNodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemplateEditor_ImportNodes.Image = ((System.Drawing.Image)(resources.GetObject("btnTemplateEditor_ImportNodes.Image")));
            this.btnTemplateEditor_ImportNodes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemplateEditor_ImportNodes.Location = new System.Drawing.Point(512, 625);
            this.btnTemplateEditor_ImportNodes.Name = "btnTemplateEditor_ImportNodes";
            this.btnTemplateEditor_ImportNodes.Size = new System.Drawing.Size(133, 23);
            this.btnTemplateEditor_ImportNodes.TabIndex = 48;
            this.btnTemplateEditor_ImportNodes.Text = "Import Labels";
            this.btnTemplateEditor_ImportNodes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemplateEditor_ImportNodes.UseVisualStyleBackColor = true;
            this.btnTemplateEditor_ImportNodes.Click += new System.EventHandler(this.btnTemplateEditor_ImportNodes_Click);
            // 
            // axMBActX1
            // 
            this.axMBActX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.axMBActX1.Enabled = true;
            this.axMBActX1.Location = new System.Drawing.Point(635, 231);
            this.axMBActX1.Name = "axMBActX1";
            this.axMBActX1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMBActX1.OcxState")));
            this.axMBActX1.Size = new System.Drawing.Size(509, 388);
            this.axMBActX1.TabIndex = 49;
            this.axMBActX1.Visible = false;
            // 
            // Form_TemplateEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1156, 652);
            this.Controls.Add(this.axMBActX1);
            this.Controls.Add(this.btnTemplateEditor_ImportNodes);
            this.Controls.Add(this.btnTemplateEditor_Close);
            this.Controls.Add(this.btnTemplateEditor_DeleteNode);
            this.Controls.Add(this.btnTemplateEditor_AddNode);
            this.Controls.Add(this.lbTemplateEditor_TemplateName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbTemplates_Title);
            this.Controls.Add(this.gbTemplateEditor_TextData);
            this.Controls.Add(this.gbTemplateEditor_Labels);
            this.Controls.Add(this.dgvCoords);
            this.Controls.Add(this.btnTemplateEditor_Delete);
            this.Controls.Add(this.btnTemplateEditor_Edit);
            this.Controls.Add(this.btnTemplateEditor_Add);
            this.Controls.Add(this.lbTemplateEditor_Templates);
            this.Controls.Add(this.lbTemplates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_TemplateEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4";
            this.Load += new System.EventHandler(this.Form_TemplateEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharFullWidth)).EndInit();
            this.gbTemplateEditor_Labels.ResumeLayout(false);
            this.gbTemplateEditor_Labels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).EndInit();
            this.gbTemplateEditor_TextData.ResumeLayout(false);
            this.gbTemplateEditor_TextData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMBActX1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTemplates;
        private System.Windows.Forms.Label lbTemplateEditor_Templates;
        private System.Windows.Forms.Button btnTemplateEditor_Add;
        private System.Windows.Forms.Button btnTemplateEditor_Edit;
        private System.Windows.Forms.Button btnTemplateEditor_Delete;
        private System.Windows.Forms.DataGridView dgvCoords;
        private System.Windows.Forms.Label lbTemplateEditorWidth;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label lbTemplateEditor_Height;
        private System.Windows.Forms.NumericUpDown nudCharWidth;
        private System.Windows.Forms.Label lbTemplateEditor_CharWidth;
        private System.Windows.Forms.NumericUpDown nudCharHeight;
        private System.Windows.Forms.Label lbTemplateEditor_CharHeight;
        private System.Windows.Forms.NumericUpDown nudCharAngle;
        private System.Windows.Forms.Label lbTemplateEditor_TextAngle;
        private System.Windows.Forms.NumericUpDown nudCharFullWidth;
        private System.Windows.Forms.Label lbTemplateEditor_CharFullWidth;
        private System.Windows.Forms.GroupBox gbTemplateEditor_Labels;
        private System.Windows.Forms.Label lbTemplateEditor_LabelAngle;
        private System.Windows.Forms.NumericUpDown nudAngle;
        private System.Windows.Forms.GroupBox gbTemplateEditor_TextData;
        private System.Windows.Forms.Label lbTemplates_Title;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbTemplateEditor_TemplateName;
        private System.Windows.Forms.Button btnTemplateEditor_AddNode;
        private System.Windows.Forms.Button btnTemplateEditor_DeleteNode;
        private System.Windows.Forms.Button btnTemplateEditor_Close;
        private System.Windows.Forms.Button btnTemplateEditor_ImportNodes;
        private AxMBPLib2.AxMBActX axMBActX1;
    }
}