namespace RayMarchingGUI {
    partial class SceneDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SceneDialog));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CameraHeaderLabel = new System.Windows.Forms.Label();
            this.SceneHeaderLabel = new System.Windows.Forms.Label();
            this.CameraSeperatorLabel = new System.Windows.Forms.Label();
            this.SceneSeperatorLabel = new System.Windows.Forms.Label();
            this.LightSourceGrid = new System.Windows.Forms.DataGridView();
            this.LightSourceIndexCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LightSourceCol = new RayMarchingGUI.TextAndImageColumn();
            this.LightSourcePosCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LumensCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectGrid = new System.Windows.Forms.DataGridView();
            this.ObjectIndexCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectCol = new RayMarchingGUI.TextAndImageColumn();
            this.ObjectPosCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectColorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RenderSeperatorLabel = new System.Windows.Forms.Label();
            this.RenderButton = new System.Windows.Forms.Button();
            this.CoordinatesLabel = new System.Windows.Forms.Label();
            this.FocalLengthLabel = new System.Windows.Forms.Label();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.ScenePictureBox = new System.Windows.Forms.PictureBox();
            this.CameraPictureBox = new System.Windows.Forms.PictureBox();
            this.RemoveLightSourceButton = new System.Windows.Forms.Button();
            this.AddLightSourceButton = new System.Windows.Forms.Button();
            this.EditLightSourceButton = new System.Windows.Forms.Button();
            this.RemoveObjectButton = new System.Windows.Forms.Button();
            this.AddObjectButton = new System.Windows.Forms.Button();
            this.EditObjectButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textAndImageColumn1 = new RayMarchingGUI.TextAndImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textAndImageColumn2 = new RayMarchingGUI.TextAndImageColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResolutionTextBoxPanel = new GUI.TextBoxPanel();
            this.FocalLengthTextBoxPanel = new GUI.TextBoxPanel();
            this.CoordinatesTextBoxPanel = new GUI.TextBoxPanel();
            this.SaveAsButton = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFile = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.RotationXTextBoxPanel = new GUI.TextBoxPanel();
            this.RotationXLabel = new System.Windows.Forms.Label();
            this.RotationYTextBoxPanel = new GUI.TextBoxPanel();
            this.RotationYLabel = new System.Windows.Forms.Label();
            this.RenderSettingsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LightSourceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScenePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CameraHeaderLabel
            // 
            this.CameraHeaderLabel.AutoSize = true;
            this.CameraHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.CameraHeaderLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CameraHeaderLabel.Location = new System.Drawing.Point(36, 23);
            this.CameraHeaderLabel.Name = "CameraHeaderLabel";
            this.CameraHeaderLabel.Size = new System.Drawing.Size(49, 15);
            this.CameraHeaderLabel.TabIndex = 0;
            this.CameraHeaderLabel.Text = "Camera";
            // 
            // SceneHeaderLabel
            // 
            this.SceneHeaderLabel.AutoSize = true;
            this.SceneHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SceneHeaderLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SceneHeaderLabel.Location = new System.Drawing.Point(35, 130);
            this.SceneHeaderLabel.Name = "SceneHeaderLabel";
            this.SceneHeaderLabel.Size = new System.Drawing.Size(41, 15);
            this.SceneHeaderLabel.TabIndex = 1;
            this.SceneHeaderLabel.Text = "Scene";
            // 
            // CameraSeperatorLabel
            // 
            this.CameraSeperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CameraSeperatorLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CameraSeperatorLabel.Location = new System.Drawing.Point(15, 43);
            this.CameraSeperatorLabel.Name = "CameraSeperatorLabel";
            this.CameraSeperatorLabel.Size = new System.Drawing.Size(583, 1);
            this.CameraSeperatorLabel.TabIndex = 2;
            // 
            // SceneSeperatorLabel
            // 
            this.SceneSeperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SceneSeperatorLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SceneSeperatorLabel.Location = new System.Drawing.Point(15, 151);
            this.SceneSeperatorLabel.Name = "SceneSeperatorLabel";
            this.SceneSeperatorLabel.Size = new System.Drawing.Size(583, 1);
            this.SceneSeperatorLabel.TabIndex = 3;
            // 
            // LightSourceGrid
            // 
            this.LightSourceGrid.AllowUserToAddRows = false;
            this.LightSourceGrid.AllowUserToDeleteRows = false;
            this.LightSourceGrid.AllowUserToResizeColumns = false;
            this.LightSourceGrid.AllowUserToResizeRows = false;
            this.LightSourceGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LightSourceGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LightSourceGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.LightSourceGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LightSourceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.LightSourceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LightSourceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LightSourceIndexCol,
            this.LightSourceCol,
            this.LightSourcePosCol,
            this.LumensCol});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LightSourceGrid.DefaultCellStyle = dataGridViewCellStyle24;
            this.LightSourceGrid.EnableHeadersVisualStyles = false;
            this.LightSourceGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.LightSourceGrid.Location = new System.Drawing.Point(15, 166);
            this.LightSourceGrid.MultiSelect = false;
            this.LightSourceGrid.Name = "LightSourceGrid";
            this.LightSourceGrid.ReadOnly = true;
            this.LightSourceGrid.RowHeadersVisible = false;
            this.LightSourceGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LightSourceGrid.Size = new System.Drawing.Size(283, 174);
            this.LightSourceGrid.TabIndex = 4;
            this.LightSourceGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LightSourceGrid_CellDoubleClick);
            this.LightSourceGrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.LightSourceGrid_CellMouseEnter);
            this.LightSourceGrid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.LightSourceGrid_CellMouseLeave);
            this.LightSourceGrid.SelectionChanged += new System.EventHandler(this.LightSourceGrid_SelectionChanged);
            this.LightSourceGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LightSourceGrid_MouseDown);
            // 
            // LightSourceIndexCol
            // 
            this.LightSourceIndexCol.HeaderText = "";
            this.LightSourceIndexCol.Name = "LightSourceIndexCol";
            this.LightSourceIndexCol.ReadOnly = true;
            this.LightSourceIndexCol.Visible = false;
            // 
            // LightSourceCol
            // 
            this.LightSourceCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LightSourceCol.HeaderText = "Light Sources";
            this.LightSourceCol.Image = null;
            this.LightSourceCol.Name = "LightSourceCol";
            this.LightSourceCol.ReadOnly = true;
            // 
            // LightSourcePosCol
            // 
            this.LightSourcePosCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.LightSourcePosCol.DefaultCellStyle = dataGridViewCellStyle22;
            this.LightSourcePosCol.HeaderText = "Pos";
            this.LightSourcePosCol.Name = "LightSourcePosCol";
            this.LightSourcePosCol.ReadOnly = true;
            this.LightSourcePosCol.Width = 60;
            // 
            // LumensCol
            // 
            this.LumensCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.LumensCol.DefaultCellStyle = dataGridViewCellStyle23;
            this.LumensCol.HeaderText = "Lumens";
            this.LumensCol.Name = "LumensCol";
            this.LumensCol.ReadOnly = true;
            this.LumensCol.Width = 60;
            // 
            // ObjectGrid
            // 
            this.ObjectGrid.AllowUserToAddRows = false;
            this.ObjectGrid.AllowUserToDeleteRows = false;
            this.ObjectGrid.AllowUserToResizeColumns = false;
            this.ObjectGrid.AllowUserToResizeRows = false;
            this.ObjectGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ObjectGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ObjectGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ObjectGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ObjectGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.ObjectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ObjectGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObjectIndexCol,
            this.ObjectCol,
            this.ObjectPosCol,
            this.ObjectColorCol});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ObjectGrid.DefaultCellStyle = dataGridViewCellStyle27;
            this.ObjectGrid.EnableHeadersVisualStyles = false;
            this.ObjectGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ObjectGrid.Location = new System.Drawing.Point(315, 166);
            this.ObjectGrid.MultiSelect = false;
            this.ObjectGrid.Name = "ObjectGrid";
            this.ObjectGrid.ReadOnly = true;
            this.ObjectGrid.RowHeadersVisible = false;
            this.ObjectGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ObjectGrid.Size = new System.Drawing.Size(283, 174);
            this.ObjectGrid.TabIndex = 5;
            this.ObjectGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ObjectGrid_CellDoubleClick);
            this.ObjectGrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ObjectGrid_CellMouseEnter);
            this.ObjectGrid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.ObjectGrid_CellMouseLeave);
            this.ObjectGrid.SelectionChanged += new System.EventHandler(this.ObjectGrid_SelectionChanged);
            this.ObjectGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectGrid_MouseDown);
            // 
            // ObjectIndexCol
            // 
            this.ObjectIndexCol.HeaderText = "";
            this.ObjectIndexCol.Name = "ObjectIndexCol";
            this.ObjectIndexCol.ReadOnly = true;
            this.ObjectIndexCol.Visible = false;
            // 
            // ObjectCol
            // 
            this.ObjectCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ObjectCol.HeaderText = "Objects";
            this.ObjectCol.Image = null;
            this.ObjectCol.Name = "ObjectCol";
            this.ObjectCol.ReadOnly = true;
            // 
            // ObjectPosCol
            // 
            this.ObjectPosCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.ObjectPosCol.DefaultCellStyle = dataGridViewCellStyle26;
            this.ObjectPosCol.HeaderText = "Pos";
            this.ObjectPosCol.Name = "ObjectPosCol";
            this.ObjectPosCol.ReadOnly = true;
            this.ObjectPosCol.Width = 80;
            // 
            // ObjectColorCol
            // 
            this.ObjectColorCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ObjectColorCol.HeaderText = "";
            this.ObjectColorCol.MinimumWidth = 2;
            this.ObjectColorCol.Name = "ObjectColorCol";
            this.ObjectColorCol.ReadOnly = true;
            this.ObjectColorCol.Width = 2;
            // 
            // RenderSeperatorLabel
            // 
            this.RenderSeperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RenderSeperatorLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RenderSeperatorLabel.Location = new System.Drawing.Point(16, 380);
            this.RenderSeperatorLabel.Name = "RenderSeperatorLabel";
            this.RenderSeperatorLabel.Size = new System.Drawing.Size(583, 1);
            this.RenderSeperatorLabel.TabIndex = 6;
            // 
            // RenderButton
            // 
            this.RenderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RenderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RenderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RenderButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RenderButton.Image = ((System.Drawing.Image)(resources.GetObject("RenderButton.Image")));
            this.RenderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RenderButton.Location = new System.Drawing.Point(18, 394);
            this.RenderButton.Name = "RenderButton";
            this.RenderButton.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RenderButton.Size = new System.Drawing.Size(75, 23);
            this.RenderButton.TabIndex = 7;
            this.RenderButton.Text = "Render";
            this.RenderButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RenderButton.UseVisualStyleBackColor = false;
            this.RenderButton.Click += new System.EventHandler(this.RenderButton_Click);
            // 
            // CoordinatesLabel
            // 
            this.CoordinatesLabel.AutoSize = true;
            this.CoordinatesLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CoordinatesLabel.Location = new System.Drawing.Point(15, 59);
            this.CoordinatesLabel.Name = "CoordinatesLabel";
            this.CoordinatesLabel.Size = new System.Drawing.Size(63, 13);
            this.CoordinatesLabel.TabIndex = 8;
            this.CoordinatesLabel.Text = "Coordinates";
            // 
            // FocalLengthLabel
            // 
            this.FocalLengthLabel.AutoSize = true;
            this.FocalLengthLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FocalLengthLabel.Location = new System.Drawing.Point(310, 59);
            this.FocalLengthLabel.Name = "FocalLengthLabel";
            this.FocalLengthLabel.Size = new System.Drawing.Size(69, 13);
            this.FocalLengthLabel.TabIndex = 10;
            this.FocalLengthLabel.Text = "Focal Length";
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ResolutionLabel.Location = new System.Drawing.Point(310, 89);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(57, 13);
            this.ResolutionLabel.TabIndex = 12;
            this.ResolutionLabel.Text = "Resolution";
            // 
            // ScenePictureBox
            // 
            this.ScenePictureBox.Image = global::RayMarchingGUI.Properties.Resources._64pxScene;
            this.ScenePictureBox.Location = new System.Drawing.Point(14, 127);
            this.ScenePictureBox.Name = "ScenePictureBox";
            this.ScenePictureBox.Size = new System.Drawing.Size(19, 19);
            this.ScenePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScenePictureBox.TabIndex = 14;
            this.ScenePictureBox.TabStop = false;
            // 
            // CameraPictureBox
            // 
            this.CameraPictureBox.Image = global::RayMarchingGUI.Properties.Resources._64pxCamera;
            this.CameraPictureBox.Location = new System.Drawing.Point(15, 20);
            this.CameraPictureBox.Name = "CameraPictureBox";
            this.CameraPictureBox.Size = new System.Drawing.Size(19, 19);
            this.CameraPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CameraPictureBox.TabIndex = 15;
            this.CameraPictureBox.TabStop = false;
            // 
            // RemoveLightSourceButton
            // 
            this.RemoveLightSourceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RemoveLightSourceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.RemoveLightSourceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.RemoveLightSourceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.RemoveLightSourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveLightSourceButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveLightSourceButton.Image = global::RayMarchingGUI.Properties.Resources._16pxTrash;
            this.RemoveLightSourceButton.Location = new System.Drawing.Point(275, 348);
            this.RemoveLightSourceButton.Name = "RemoveLightSourceButton";
            this.RemoveLightSourceButton.Size = new System.Drawing.Size(23, 23);
            this.RemoveLightSourceButton.TabIndex = 21;
            this.RemoveLightSourceButton.UseVisualStyleBackColor = false;
            this.RemoveLightSourceButton.Click += new System.EventHandler(this.RemoveLightSourceButton_Click);
            // 
            // AddLightSourceButton
            // 
            this.AddLightSourceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AddLightSourceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.AddLightSourceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.AddLightSourceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.AddLightSourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLightSourceButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddLightSourceButton.Image = global::RayMarchingGUI.Properties.Resources._16pxAdd;
            this.AddLightSourceButton.Location = new System.Drawing.Point(217, 348);
            this.AddLightSourceButton.Name = "AddLightSourceButton";
            this.AddLightSourceButton.Size = new System.Drawing.Size(23, 23);
            this.AddLightSourceButton.TabIndex = 20;
            this.AddLightSourceButton.UseVisualStyleBackColor = false;
            this.AddLightSourceButton.Click += new System.EventHandler(this.AddLightSourceButton_Click);
            // 
            // EditLightSourceButton
            // 
            this.EditLightSourceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.EditLightSourceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.EditLightSourceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.EditLightSourceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.EditLightSourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditLightSourceButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.EditLightSourceButton.Image = global::RayMarchingGUI.Properties.Resources._16pxEdit;
            this.EditLightSourceButton.Location = new System.Drawing.Point(246, 348);
            this.EditLightSourceButton.Name = "EditLightSourceButton";
            this.EditLightSourceButton.Size = new System.Drawing.Size(23, 23);
            this.EditLightSourceButton.TabIndex = 19;
            this.EditLightSourceButton.UseVisualStyleBackColor = false;
            this.EditLightSourceButton.Click += new System.EventHandler(this.EditLightSourceButton_Click);
            // 
            // RemoveObjectButton
            // 
            this.RemoveObjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RemoveObjectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.RemoveObjectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.RemoveObjectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.RemoveObjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveObjectButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveObjectButton.Image = global::RayMarchingGUI.Properties.Resources._16pxTrash;
            this.RemoveObjectButton.Location = new System.Drawing.Point(573, 348);
            this.RemoveObjectButton.Name = "RemoveObjectButton";
            this.RemoveObjectButton.Size = new System.Drawing.Size(23, 23);
            this.RemoveObjectButton.TabIndex = 24;
            this.RemoveObjectButton.UseVisualStyleBackColor = false;
            this.RemoveObjectButton.Click += new System.EventHandler(this.RemoveObjectButton_Click);
            // 
            // AddObjectButton
            // 
            this.AddObjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AddObjectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.AddObjectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.AddObjectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.AddObjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddObjectButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddObjectButton.Image = global::RayMarchingGUI.Properties.Resources._16pxAdd;
            this.AddObjectButton.Location = new System.Drawing.Point(515, 348);
            this.AddObjectButton.Name = "AddObjectButton";
            this.AddObjectButton.Size = new System.Drawing.Size(23, 23);
            this.AddObjectButton.TabIndex = 23;
            this.AddObjectButton.UseVisualStyleBackColor = false;
            this.AddObjectButton.Click += new System.EventHandler(this.AddObjectButton_Click);
            // 
            // EditObjectButton
            // 
            this.EditObjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.EditObjectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.EditObjectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.EditObjectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.EditObjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditObjectButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.EditObjectButton.Image = global::RayMarchingGUI.Properties.Resources._16pxEdit;
            this.EditObjectButton.Location = new System.Drawing.Point(544, 348);
            this.EditObjectButton.Name = "EditObjectButton";
            this.EditObjectButton.Size = new System.Drawing.Size(23, 23);
            this.EditObjectButton.TabIndex = 22;
            this.EditObjectButton.UseVisualStyleBackColor = false;
            this.EditObjectButton.Click += new System.EventHandler(this.EditObjectButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // textAndImageColumn1
            // 
            this.textAndImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.textAndImageColumn1.HeaderText = "Light Sources";
            this.textAndImageColumn1.Image = null;
            this.textAndImageColumn1.Name = "textAndImageColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle28.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewTextBoxColumn2.HeaderText = "Pos";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle29.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridViewTextBoxColumn3.HeaderText = "Lumens";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // textAndImageColumn2
            // 
            this.textAndImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.textAndImageColumn2.HeaderText = "Objects";
            this.textAndImageColumn2.Image = null;
            this.textAndImageColumn2.Name = "textAndImageColumn2";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle30.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridViewTextBoxColumn5.HeaderText = "Pos";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.HeaderText = "";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 2;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 2;
            // 
            // ResolutionTextBoxPanel
            // 
            this.ResolutionTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ResolutionTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.ResolutionTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ResolutionTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResolutionTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ResolutionTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ResolutionTextBoxPanel.Location = new System.Drawing.Point(382, 85);
            this.ResolutionTextBoxPanel.Name = "ResolutionTextBoxPanel";
            this.ResolutionTextBoxPanel.ReadOnly = false;
            this.ResolutionTextBoxPanel.Size = new System.Drawing.Size(115, 21);
            this.ResolutionTextBoxPanel.TabIndex = 13;
            this.ResolutionTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ResolutionTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // FocalLengthTextBoxPanel
            // 
            this.FocalLengthTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FocalLengthTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.FocalLengthTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FocalLengthTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FocalLengthTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.FocalLengthTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.FocalLengthTextBoxPanel.Location = new System.Drawing.Point(382, 55);
            this.FocalLengthTextBoxPanel.Name = "FocalLengthTextBoxPanel";
            this.FocalLengthTextBoxPanel.ReadOnly = false;
            this.FocalLengthTextBoxPanel.Size = new System.Drawing.Size(115, 21);
            this.FocalLengthTextBoxPanel.TabIndex = 11;
            this.FocalLengthTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.FocalLengthTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // CoordinatesTextBoxPanel
            // 
            this.CoordinatesTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CoordinatesTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.CoordinatesTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CoordinatesTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoordinatesTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CoordinatesTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.CoordinatesTextBoxPanel.Location = new System.Drawing.Point(84, 55);
            this.CoordinatesTextBoxPanel.Name = "CoordinatesTextBoxPanel";
            this.CoordinatesTextBoxPanel.ReadOnly = false;
            this.CoordinatesTextBoxPanel.Size = new System.Drawing.Size(214, 21);
            this.CoordinatesTextBoxPanel.TabIndex = 9;
            this.CoordinatesTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.CoordinatesTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.SaveAsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SaveAsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.SaveAsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SaveAsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAsButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveAsButton.Image = global::RayMarchingGUI.Properties.Resources._16pxSaveAs;
            this.SaveAsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveAsButton.Location = new System.Drawing.Point(407, 394);
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.SaveAsButton.Size = new System.Drawing.Size(90, 23);
            this.SaveAsButton.TabIndex = 25;
            this.SaveAsButton.Text = "Save As...";
            this.SaveAsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveAsButton.UseVisualStyleBackColor = false;
            this.SaveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.OpenFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.OpenFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.OpenFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OpenFile.Image = global::RayMarchingGUI.Properties.Resources._16pxOpenFile;
            this.OpenFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OpenFile.Location = new System.Drawing.Point(506, 394);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.OpenFile.Size = new System.Drawing.Size(90, 23);
            this.OpenFile.TabIndex = 26;
            this.OpenFile.Text = "Open File";
            this.OpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenFile.UseVisualStyleBackColor = false;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // RotationXTextBoxPanel
            // 
            this.RotationXTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RotationXTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.RotationXTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RotationXTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RotationXTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.RotationXTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.RotationXTextBoxPanel.Location = new System.Drawing.Point(563, 55);
            this.RotationXTextBoxPanel.Name = "RotationXTextBoxPanel";
            this.RotationXTextBoxPanel.ReadOnly = false;
            this.RotationXTextBoxPanel.Size = new System.Drawing.Size(33, 21);
            this.RotationXTextBoxPanel.TabIndex = 28;
            this.RotationXTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.RotationXTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // RotationXLabel
            // 
            this.RotationXLabel.AutoSize = true;
            this.RotationXLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RotationXLabel.Location = new System.Drawing.Point(503, 59);
            this.RotationXLabel.Name = "RotationXLabel";
            this.RotationXLabel.Size = new System.Drawing.Size(54, 13);
            this.RotationXLabel.TabIndex = 27;
            this.RotationXLabel.Text = "RotationX";
            // 
            // RotationYTextBoxPanel
            // 
            this.RotationYTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RotationYTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.RotationYTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RotationYTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RotationYTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.RotationYTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.RotationYTextBoxPanel.Location = new System.Drawing.Point(563, 85);
            this.RotationYTextBoxPanel.Name = "RotationYTextBoxPanel";
            this.RotationYTextBoxPanel.ReadOnly = false;
            this.RotationYTextBoxPanel.Size = new System.Drawing.Size(33, 21);
            this.RotationYTextBoxPanel.TabIndex = 30;
            this.RotationYTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.RotationYTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // RotationYLabel
            // 
            this.RotationYLabel.AutoSize = true;
            this.RotationYLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RotationYLabel.Location = new System.Drawing.Point(503, 89);
            this.RotationYLabel.Name = "RotationYLabel";
            this.RotationYLabel.Size = new System.Drawing.Size(54, 13);
            this.RotationYLabel.TabIndex = 29;
            this.RotationYLabel.Text = "RotationY";
            // 
            // RenderSettingsButton
            // 
            this.RenderSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RenderSettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RenderSettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.RenderSettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.RenderSettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.RenderSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RenderSettingsButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RenderSettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RenderSettingsButton.Location = new System.Drawing.Point(111, 394);
            this.RenderSettingsButton.Name = "RenderSettingsButton";
            this.RenderSettingsButton.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RenderSettingsButton.Size = new System.Drawing.Size(96, 23);
            this.RenderSettingsButton.TabIndex = 31;
            this.RenderSettingsButton.Text = "Render Settings";
            this.RenderSettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RenderSettingsButton.UseVisualStyleBackColor = false;
            this.RenderSettingsButton.Click += new System.EventHandler(this.RenderSettingsButton_Click);
            // 
            // SceneDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(613, 434);
            this.Controls.Add(this.RenderSettingsButton);
            this.Controls.Add(this.RotationYTextBoxPanel);
            this.Controls.Add(this.RotationYLabel);
            this.Controls.Add(this.RotationXTextBoxPanel);
            this.Controls.Add(this.RotationXLabel);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.SaveAsButton);
            this.Controls.Add(this.RemoveObjectButton);
            this.Controls.Add(this.AddObjectButton);
            this.Controls.Add(this.EditObjectButton);
            this.Controls.Add(this.RemoveLightSourceButton);
            this.Controls.Add(this.AddLightSourceButton);
            this.Controls.Add(this.EditLightSourceButton);
            this.Controls.Add(this.CameraPictureBox);
            this.Controls.Add(this.ScenePictureBox);
            this.Controls.Add(this.ResolutionTextBoxPanel);
            this.Controls.Add(this.ResolutionLabel);
            this.Controls.Add(this.FocalLengthTextBoxPanel);
            this.Controls.Add(this.FocalLengthLabel);
            this.Controls.Add(this.CoordinatesTextBoxPanel);
            this.Controls.Add(this.CoordinatesLabel);
            this.Controls.Add(this.RenderButton);
            this.Controls.Add(this.RenderSeperatorLabel);
            this.Controls.Add(this.ObjectGrid);
            this.Controls.Add(this.LightSourceGrid);
            this.Controls.Add(this.SceneSeperatorLabel);
            this.Controls.Add(this.CameraSeperatorLabel);
            this.Controls.Add(this.SceneHeaderLabel);
            this.Controls.Add(this.CameraHeaderLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SceneDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scene";
            this.Load += new System.EventHandler(this.SceneDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LightSourceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScenePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CameraHeaderLabel;
        private System.Windows.Forms.Label SceneHeaderLabel;
        private System.Windows.Forms.Label CameraSeperatorLabel;
        private System.Windows.Forms.Label SceneSeperatorLabel;
        private System.Windows.Forms.DataGridView LightSourceGrid;
        private System.Windows.Forms.DataGridView ObjectGrid;
        private System.Windows.Forms.Label RenderSeperatorLabel;
        private System.Windows.Forms.Button RenderButton;
        private System.Windows.Forms.Label CoordinatesLabel;
        private GUI.TextBoxPanel CoordinatesTextBoxPanel;
        private GUI.TextBoxPanel FocalLengthTextBoxPanel;
        private System.Windows.Forms.Label FocalLengthLabel;
        private System.Windows.Forms.Label ResolutionLabel;
        private GUI.TextBoxPanel ResolutionTextBoxPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn LightSourceIndexCol;
        private RayMarchingGUI.TextAndImageColumn LightSourceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LightSourcePosCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LumensCol;
        private System.Windows.Forms.PictureBox ScenePictureBox;
        private System.Windows.Forms.PictureBox CameraPictureBox;
        private System.Windows.Forms.Button RemoveLightSourceButton;
        private System.Windows.Forms.Button AddLightSourceButton;
        private System.Windows.Forms.Button EditLightSourceButton;
        private System.Windows.Forms.Button RemoveObjectButton;
        private System.Windows.Forms.Button AddObjectButton;
        private System.Windows.Forms.Button EditObjectButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectIndexCol;
        private RayMarchingGUI.TextAndImageColumn ObjectCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectPosCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectColorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TextAndImageColumn textAndImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private TextAndImageColumn textAndImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button SaveAsButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private GUI.TextBoxPanel RotationXTextBoxPanel;
        private System.Windows.Forms.Label RotationXLabel;
        private GUI.TextBoxPanel RotationYTextBoxPanel;
        private System.Windows.Forms.Label RotationYLabel;
        private System.Windows.Forms.Button RenderSettingsButton;
    }
}

