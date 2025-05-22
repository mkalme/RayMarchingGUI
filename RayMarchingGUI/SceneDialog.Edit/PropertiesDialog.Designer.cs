namespace RayMarchingGUI {
    partial class PropertiesDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertiesDialog));
            this.ColorLabel = new System.Windows.Forms.Label();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.DoneSeperatorLabel = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.IconSeperatorLabel = new System.Windows.Forms.Label();
            this.ReflectionLabel = new System.Windows.Forms.Label();
            this.RefractionLabel = new System.Windows.Forms.Label();
            this.DiffusionLabel = new System.Windows.Forms.Label();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ReflectionTextBoxPanel = new GUI.TextBoxPanel();
            this.DiffusionTextBoxPanel = new GUI.TextBoxPanel();
            this.RefractionTextBoxPanel = new GUI.TextBoxPanel();
            this.ColorPanel = new RayMarchingGUI.ColorPanel();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorLabel
            // 
            this.ColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ColorLabel.Location = new System.Drawing.Point(4, 12);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(34, 13);
            this.ColorLabel.TabIndex = 0;
            this.ColorLabel.Text = "Color:";
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.IconPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IconPictureBox.Location = new System.Drawing.Point(12, 12);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(50, 50);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPictureBox.TabIndex = 1;
            this.IconPictureBox.TabStop = false;
            // 
            // DoneSeperatorLabel
            // 
            this.DoneSeperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoneSeperatorLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DoneSeperatorLabel.Location = new System.Drawing.Point(12, 249);
            this.DoneSeperatorLabel.Name = "DoneSeperatorLabel";
            this.DoneSeperatorLabel.Size = new System.Drawing.Size(268, 1);
            this.DoneSeperatorLabel.TabIndex = 7;
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DoneButton.Location = new System.Drawing.Point(12, 263);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 8;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // IconSeperatorLabel
            // 
            this.IconSeperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IconSeperatorLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.IconSeperatorLabel.Location = new System.Drawing.Point(12, 74);
            this.IconSeperatorLabel.Name = "IconSeperatorLabel";
            this.IconSeperatorLabel.Size = new System.Drawing.Size(268, 1);
            this.IconSeperatorLabel.TabIndex = 9;
            // 
            // ReflectionLabel
            // 
            this.ReflectionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReflectionLabel.AutoSize = true;
            this.ReflectionLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReflectionLabel.Location = new System.Drawing.Point(4, 48);
            this.ReflectionLabel.Name = "ReflectionLabel";
            this.ReflectionLabel.Size = new System.Drawing.Size(86, 13);
            this.ReflectionLabel.TabIndex = 10;
            this.ReflectionLabel.Text = "Reflection index:";
            // 
            // RefractionLabel
            // 
            this.RefractionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RefractionLabel.AutoSize = true;
            this.RefractionLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RefractionLabel.Location = new System.Drawing.Point(4, 84);
            this.RefractionLabel.Name = "RefractionLabel";
            this.RefractionLabel.Size = new System.Drawing.Size(87, 13);
            this.RefractionLabel.TabIndex = 11;
            this.RefractionLabel.Text = "Refraction index:";
            // 
            // DiffusionLabel
            // 
            this.DiffusionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DiffusionLabel.AutoSize = true;
            this.DiffusionLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DiffusionLabel.Location = new System.Drawing.Point(4, 121);
            this.DiffusionLabel.Name = "DiffusionLabel";
            this.DiffusionLabel.Size = new System.Drawing.Size(79, 13);
            this.DiffusionLabel.TabIndex = 12;
            this.DiffusionLabel.Text = "Diffusion index:";
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Controls.Add(this.ColorLabel, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.DiffusionLabel, 0, 3);
            this.TableLayoutPanel.Controls.Add(this.ReflectionLabel, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.RefractionLabel, 0, 2);
            this.TableLayoutPanel.Controls.Add(this.ReflectionTextBoxPanel, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.DiffusionTextBoxPanel, 1, 2);
            this.TableLayoutPanel.Controls.Add(this.RefractionTextBoxPanel, 1, 3);
            this.TableLayoutPanel.Controls.Add(this.ColorPanel, 1, 0);
            this.TableLayoutPanel.Location = new System.Drawing.Point(12, 88);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 4;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(268, 147);
            this.TableLayoutPanel.TabIndex = 13;
            // 
            // ReflectionTextBoxPanel
            // 
            this.ReflectionTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ReflectionTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReflectionTextBoxPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReflectionTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ReflectionTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReflectionTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ReflectionTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ReflectionTextBoxPanel.Location = new System.Drawing.Point(105, 44);
            this.ReflectionTextBoxPanel.Name = "ReflectionTextBoxPanel";
            this.ReflectionTextBoxPanel.ReadOnly = false;
            this.ReflectionTextBoxPanel.Size = new System.Drawing.Size(159, 21);
            this.ReflectionTextBoxPanel.TabIndex = 13;
            this.ReflectionTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ReflectionTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // DiffusionTextBoxPanel
            // 
            this.DiffusionTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DiffusionTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.DiffusionTextBoxPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DiffusionTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DiffusionTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiffusionTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.DiffusionTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.DiffusionTextBoxPanel.Location = new System.Drawing.Point(105, 80);
            this.DiffusionTextBoxPanel.Name = "DiffusionTextBoxPanel";
            this.DiffusionTextBoxPanel.ReadOnly = false;
            this.DiffusionTextBoxPanel.Size = new System.Drawing.Size(159, 21);
            this.DiffusionTextBoxPanel.TabIndex = 14;
            this.DiffusionTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.DiffusionTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // RefractionTextBoxPanel
            // 
            this.RefractionTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RefractionTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.RefractionTextBoxPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RefractionTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RefractionTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RefractionTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.RefractionTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.RefractionTextBoxPanel.Location = new System.Drawing.Point(105, 117);
            this.RefractionTextBoxPanel.Name = "RefractionTextBoxPanel";
            this.RefractionTextBoxPanel.ReadOnly = false;
            this.RefractionTextBoxPanel.Size = new System.Drawing.Size(159, 21);
            this.RefractionTextBoxPanel.TabIndex = 15;
            this.RefractionTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.RefractionTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ColorPanel.Color = System.Drawing.Color.Empty;
            this.ColorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorPanel.Location = new System.Drawing.Point(102, 1);
            this.ColorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(165, 35);
            this.ColorPanel.TabIndex = 16;
            // 
            // PropertiesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(292, 302);
            this.Controls.Add(this.TableLayoutPanel);
            this.Controls.Add(this.IconSeperatorLabel);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.DoneSeperatorLabel);
            this.Controls.Add(this.IconPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PropertiesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Properties";
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.Label DoneSeperatorLabel;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label IconSeperatorLabel;
        private System.Windows.Forms.Label ReflectionLabel;
        private System.Windows.Forms.Label RefractionLabel;
        private System.Windows.Forms.Label DiffusionLabel;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private GUI.TextBoxPanel ReflectionTextBoxPanel;
        private GUI.TextBoxPanel RefractionTextBoxPanel;
        private GUI.TextBoxPanel DiffusionTextBoxPanel;
        private ColorPanel ColorPanel;
    }
}