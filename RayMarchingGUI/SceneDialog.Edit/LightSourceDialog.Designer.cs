namespace RayMarchingGUI {
    partial class LightSourceDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LightSourceDialog));
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.LumensLabel = new System.Windows.Forms.Label();
            this.CoordinatesLabel = new System.Windows.Forms.Label();
            this.LumensTextBoxPanel = new GUI.TextBoxPanel();
            this.CoordinatesTextBoxPanel = new GUI.TextBoxPanel();
            this.ColorPanel = new RayMarchingGUI.ColorPanel();
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
            this.TableLayoutPanel.Controls.Add(this.ColorLabel, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.LumensLabel, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.CoordinatesLabel, 0, 2);
            this.TableLayoutPanel.Controls.Add(this.LumensTextBoxPanel, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.CoordinatesTextBoxPanel, 1, 2);
            this.TableLayoutPanel.Controls.Add(this.ColorPanel, 1, 0);
            this.TableLayoutPanel.Location = new System.Drawing.Point(12, 88);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 3;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(268, 110);
            this.TableLayoutPanel.TabIndex = 18;
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
            // LumensLabel
            // 
            this.LumensLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LumensLabel.AutoSize = true;
            this.LumensLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LumensLabel.Location = new System.Drawing.Point(4, 48);
            this.LumensLabel.Name = "LumensLabel";
            this.LumensLabel.Size = new System.Drawing.Size(47, 13);
            this.LumensLabel.TabIndex = 10;
            this.LumensLabel.Text = "Lumens:";
            // 
            // CoordinatesLabel
            // 
            this.CoordinatesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CoordinatesLabel.AutoSize = true;
            this.CoordinatesLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CoordinatesLabel.Location = new System.Drawing.Point(4, 84);
            this.CoordinatesLabel.Name = "CoordinatesLabel";
            this.CoordinatesLabel.Size = new System.Drawing.Size(66, 13);
            this.CoordinatesLabel.TabIndex = 11;
            this.CoordinatesLabel.Text = "Coordinates:";
            // 
            // LumensTextBoxPanel
            // 
            this.LumensTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LumensTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.LumensTextBoxPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LumensTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LumensTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LumensTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.LumensTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.LumensTextBoxPanel.Location = new System.Drawing.Point(105, 44);
            this.LumensTextBoxPanel.Name = "LumensTextBoxPanel";
            this.LumensTextBoxPanel.ReadOnly = false;
            this.LumensTextBoxPanel.Size = new System.Drawing.Size(159, 21);
            this.LumensTextBoxPanel.TabIndex = 13;
            this.LumensTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LumensTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
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
            this.CoordinatesTextBoxPanel.Location = new System.Drawing.Point(105, 80);
            this.CoordinatesTextBoxPanel.Name = "CoordinatesTextBoxPanel";
            this.CoordinatesTextBoxPanel.ReadOnly = false;
            this.CoordinatesTextBoxPanel.Size = new System.Drawing.Size(159, 21);
            this.CoordinatesTextBoxPanel.TabIndex = 14;
            this.CoordinatesTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.CoordinatesTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
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
            // IconSeperatorLabel
            // 
            this.IconSeperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IconSeperatorLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.IconSeperatorLabel.Location = new System.Drawing.Point(12, 74);
            this.IconSeperatorLabel.Name = "IconSeperatorLabel";
            this.IconSeperatorLabel.Size = new System.Drawing.Size(268, 1);
            this.IconSeperatorLabel.TabIndex = 17;
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DoneButton.Location = new System.Drawing.Point(12, 227);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 16;
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
            this.DoneSeperatorLabel.TabIndex = 15;
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.IconPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IconPictureBox.Image = global::RayMarchingGUI.Properties.Resources._64pxLightSource;
            this.IconPictureBox.Location = new System.Drawing.Point(12, 12);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(50, 50);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPictureBox.TabIndex = 14;
            this.IconPictureBox.TabStop = false;
            // 
            // LightSourceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(292, 267);
            this.Controls.Add(this.TableLayoutPanel);
            this.Controls.Add(this.IconSeperatorLabel);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.DoneSeperatorLabel);
            this.Controls.Add(this.IconPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LightSourceDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Light source";
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label LumensLabel;
        private System.Windows.Forms.Label CoordinatesLabel;
        private GUI.TextBoxPanel LumensTextBoxPanel;
        private GUI.TextBoxPanel CoordinatesTextBoxPanel;
        private ColorPanel ColorPanel;
        private System.Windows.Forms.Label IconSeperatorLabel;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label DoneSeperatorLabel;
        private System.Windows.Forms.PictureBox IconPictureBox;
    }
}