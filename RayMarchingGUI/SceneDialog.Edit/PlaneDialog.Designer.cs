namespace RayMarchingGUI {
    partial class PlaneDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaneDialog));
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.ChangePropertiesButton = new System.Windows.Forms.Button();
            this.PropertiesLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.WLabel = new System.Windows.Forms.Label();
            this.WTextBoxPanel = new GUI.TextBoxPanel();
            this.IconSeperatorLabel = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.DoneSeperatorLabel = new System.Windows.Forms.Label();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Controls.Add(this.TypeComboBox, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.ChangePropertiesButton, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.PropertiesLabel, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.TypeLabel, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.WLabel, 0, 2);
            this.TableLayoutPanel.Controls.Add(this.WTextBoxPanel, 1, 2);
            this.TableLayoutPanel.Location = new System.Drawing.Point(12, 88);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 3;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(268, 110);
            this.TableLayoutPanel.TabIndex = 28;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TypeComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.TypeComboBox.Location = new System.Drawing.Point(105, 43);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(159, 23);
            this.TypeComboBox.TabIndex = 29;
            // 
            // ChangePropertiesButton
            // 
            this.ChangePropertiesButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ChangePropertiesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ChangePropertiesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ChangePropertiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePropertiesButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChangePropertiesButton.Location = new System.Drawing.Point(105, 7);
            this.ChangePropertiesButton.Name = "ChangePropertiesButton";
            this.ChangePropertiesButton.Size = new System.Drawing.Size(106, 23);
            this.ChangePropertiesButton.TabIndex = 20;
            this.ChangePropertiesButton.Text = "Change Properties";
            this.ChangePropertiesButton.UseVisualStyleBackColor = false;
            this.ChangePropertiesButton.Click += new System.EventHandler(this.ChangePropertiesButton_Click);
            // 
            // PropertiesLabel
            // 
            this.PropertiesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PropertiesLabel.AutoSize = true;
            this.PropertiesLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PropertiesLabel.Location = new System.Drawing.Point(4, 12);
            this.PropertiesLabel.Name = "PropertiesLabel";
            this.PropertiesLabel.Size = new System.Drawing.Size(57, 13);
            this.PropertiesLabel.TabIndex = 0;
            this.PropertiesLabel.Text = "Properties:";
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TypeLabel.Location = new System.Drawing.Point(4, 48);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(34, 13);
            this.TypeLabel.TabIndex = 10;
            this.TypeLabel.Text = "Type:";
            // 
            // WLabel
            // 
            this.WLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WLabel.AutoSize = true;
            this.WLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.WLabel.Location = new System.Drawing.Point(4, 84);
            this.WLabel.Name = "WLabel";
            this.WLabel.Size = new System.Drawing.Size(21, 13);
            this.WLabel.TabIndex = 11;
            this.WLabel.Text = "W:";
            // 
            // WTextBoxPanel
            // 
            this.WTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.WTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.WTextBoxPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.WTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.WTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.WTextBoxPanel.Location = new System.Drawing.Point(105, 80);
            this.WTextBoxPanel.Name = "WTextBoxPanel";
            this.WTextBoxPanel.ReadOnly = false;
            this.WTextBoxPanel.Size = new System.Drawing.Size(159, 21);
            this.WTextBoxPanel.TabIndex = 14;
            this.WTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.WTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // IconSeperatorLabel
            // 
            this.IconSeperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IconSeperatorLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.IconSeperatorLabel.Location = new System.Drawing.Point(12, 74);
            this.IconSeperatorLabel.Name = "IconSeperatorLabel";
            this.IconSeperatorLabel.Size = new System.Drawing.Size(268, 1);
            this.IconSeperatorLabel.TabIndex = 27;
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DoneButton.Location = new System.Drawing.Point(12, 224);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 26;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // DoneSeperatorLabel
            // 
            this.DoneSeperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoneSeperatorLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DoneSeperatorLabel.Location = new System.Drawing.Point(12, 211);
            this.DoneSeperatorLabel.Name = "DoneSeperatorLabel";
            this.DoneSeperatorLabel.Size = new System.Drawing.Size(268, 1);
            this.DoneSeperatorLabel.TabIndex = 25;
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.IconPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IconPictureBox.Image = global::RayMarchingGUI.Properties.Resources._64pxPlane;
            this.IconPictureBox.Location = new System.Drawing.Point(12, 12);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(50, 50);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPictureBox.TabIndex = 24;
            this.IconPictureBox.TabStop = false;
            // 
            // PlaneDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(294, 261);
            this.Controls.Add(this.TableLayoutPanel);
            this.Controls.Add(this.IconSeperatorLabel);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.DoneSeperatorLabel);
            this.Controls.Add(this.IconPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PlaneDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Plane";
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Button ChangePropertiesButton;
        private System.Windows.Forms.Label PropertiesLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label WLabel;
        private GUI.TextBoxPanel WTextBoxPanel;
        private System.Windows.Forms.Label IconSeperatorLabel;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label DoneSeperatorLabel;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
    }
}