namespace RayMarchingGUI {
    partial class TorusDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TorusDialog));
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ChangePropertiesButton = new System.Windows.Forms.Button();
            this.PropertiesLabel = new System.Windows.Forms.Label();
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.SecondRadiusLabel = new System.Windows.Forms.Label();
            this.RadiusTextBoxPanel = new GUI.TextBoxPanel();
            this.SecondRadiusTextBoxPanel = new GUI.TextBoxPanel();
            this.IconSeperatorLabel = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.DoneSeperatorLabel = new System.Windows.Forms.Label();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.CoordinatesLabel = new System.Windows.Forms.Label();
            this.CoordinatesTextBoxPanel = new GUI.TextBoxPanel();
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
            this.TableLayoutPanel.Controls.Add(this.CoordinatesLabel, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.ChangePropertiesButton, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.CoordinatesTextBoxPanel, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.PropertiesLabel, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.RadiusLabel, 0, 2);
            this.TableLayoutPanel.Controls.Add(this.SecondRadiusLabel, 0, 3);
            this.TableLayoutPanel.Controls.Add(this.RadiusTextBoxPanel, 1, 2);
            this.TableLayoutPanel.Controls.Add(this.SecondRadiusTextBoxPanel, 1, 3);
            this.TableLayoutPanel.Location = new System.Drawing.Point(12, 88);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 4;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(268, 147);
            this.TableLayoutPanel.TabIndex = 28;
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
            // RadiusLabel
            // 
            this.RadiusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RadiusLabel.Location = new System.Drawing.Point(4, 84);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(43, 13);
            this.RadiusLabel.TabIndex = 10;
            this.RadiusLabel.Text = "Radius:";
            // 
            // SecondRadiusLabel
            // 
            this.SecondRadiusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SecondRadiusLabel.AutoSize = true;
            this.SecondRadiusLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SecondRadiusLabel.Location = new System.Drawing.Point(4, 121);
            this.SecondRadiusLabel.Name = "SecondRadiusLabel";
            this.SecondRadiusLabel.Size = new System.Drawing.Size(59, 13);
            this.SecondRadiusLabel.TabIndex = 11;
            this.SecondRadiusLabel.Text = "2nd radius:";
            // 
            // RadiusTextBoxPanel
            // 
            this.RadiusTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RadiusTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.RadiusTextBoxPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RadiusTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RadiusTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RadiusTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.RadiusTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.RadiusTextBoxPanel.Location = new System.Drawing.Point(105, 80);
            this.RadiusTextBoxPanel.Name = "RadiusTextBoxPanel";
            this.RadiusTextBoxPanel.ReadOnly = false;
            this.RadiusTextBoxPanel.Size = new System.Drawing.Size(159, 21);
            this.RadiusTextBoxPanel.TabIndex = 13;
            this.RadiusTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.RadiusTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // SecondRadiusTextBoxPanel
            // 
            this.SecondRadiusTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.SecondRadiusTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.SecondRadiusTextBoxPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SecondRadiusTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.SecondRadiusTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondRadiusTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.SecondRadiusTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.SecondRadiusTextBoxPanel.Location = new System.Drawing.Point(105, 117);
            this.SecondRadiusTextBoxPanel.Name = "SecondRadiusTextBoxPanel";
            this.SecondRadiusTextBoxPanel.ReadOnly = false;
            this.SecondRadiusTextBoxPanel.Size = new System.Drawing.Size(159, 21);
            this.SecondRadiusTextBoxPanel.TabIndex = 14;
            this.SecondRadiusTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SecondRadiusTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
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
            this.DoneButton.Location = new System.Drawing.Point(12, 263);
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
            this.DoneSeperatorLabel.Location = new System.Drawing.Point(12, 249);
            this.DoneSeperatorLabel.Name = "DoneSeperatorLabel";
            this.DoneSeperatorLabel.Size = new System.Drawing.Size(268, 1);
            this.DoneSeperatorLabel.TabIndex = 25;
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.IconPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IconPictureBox.Image = global::RayMarchingGUI.Properties.Resources._64pxTorus;
            this.IconPictureBox.Location = new System.Drawing.Point(12, 12);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(50, 50);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPictureBox.TabIndex = 24;
            this.IconPictureBox.TabStop = false;
            // 
            // CoordinatesLabel
            // 
            this.CoordinatesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CoordinatesLabel.AutoSize = true;
            this.CoordinatesLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CoordinatesLabel.Location = new System.Drawing.Point(4, 48);
            this.CoordinatesLabel.Name = "CoordinatesLabel";
            this.CoordinatesLabel.Size = new System.Drawing.Size(66, 13);
            this.CoordinatesLabel.TabIndex = 29;
            this.CoordinatesLabel.Text = "Coordinates:";
            // 
            // CoordinatesTextBoxPanel
            // 
            this.CoordinatesTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CoordinatesTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.CoordinatesTextBoxPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CoordinatesTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CoordinatesTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoordinatesTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CoordinatesTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.CoordinatesTextBoxPanel.Location = new System.Drawing.Point(105, 44);
            this.CoordinatesTextBoxPanel.Name = "CoordinatesTextBoxPanel";
            this.CoordinatesTextBoxPanel.ReadOnly = false;
            this.CoordinatesTextBoxPanel.Size = new System.Drawing.Size(159, 21);
            this.CoordinatesTextBoxPanel.TabIndex = 30;
            this.CoordinatesTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.CoordinatesTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // TorusDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(294, 302);
            this.Controls.Add(this.TableLayoutPanel);
            this.Controls.Add(this.IconSeperatorLabel);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.DoneSeperatorLabel);
            this.Controls.Add(this.IconPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TorusDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Torus";
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Button ChangePropertiesButton;
        private System.Windows.Forms.Label PropertiesLabel;
        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.Label SecondRadiusLabel;
        private GUI.TextBoxPanel RadiusTextBoxPanel;
        private GUI.TextBoxPanel SecondRadiusTextBoxPanel;
        private System.Windows.Forms.Label IconSeperatorLabel;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label DoneSeperatorLabel;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.Label CoordinatesLabel;
        private GUI.TextBoxPanel CoordinatesTextBoxPanel;
    }
}