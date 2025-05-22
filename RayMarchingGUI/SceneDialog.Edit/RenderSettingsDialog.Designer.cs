namespace RayMarchingGUI {
    partial class RenderSettingsDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenderSettingsDialog));
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MaxDepthLabel = new System.Windows.Forms.Label();
            this.SpecularPowLabel = new System.Windows.Forms.Label();
            this.MaxDepthTextBoxPanel = new GUI.TextBoxPanel();
            this.SpecularPowTextBoxPanel = new GUI.TextBoxPanel();
            this.AmbientColorLabel = new System.Windows.Forms.Label();
            this.MaxStepsLabel = new System.Windows.Forms.Label();
            this.MaxDistaneLabel = new System.Windows.Forms.Label();
            this.MinDistanceLabel = new System.Windows.Forms.Label();
            this.MaxDistanceTextBoxPanel = new GUI.TextBoxPanel();
            this.MinDistanceTextBoxPanel = new GUI.TextBoxPanel();
            this.MaxStepsTextBoxPanel = new GUI.TextBoxPanel();
            this.AmbientColorPanel = new RayMarchingGUI.ColorPanel();
            this.DoneButton = new System.Windows.Forms.Button();
            this.DoneSeperatorLabel = new System.Windows.Forms.Label();
            this.TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Controls.Add(this.MaxDepthLabel, 0, 4);
            this.TableLayoutPanel.Controls.Add(this.SpecularPowLabel, 0, 5);
            this.TableLayoutPanel.Controls.Add(this.MaxDepthTextBoxPanel, 1, 4);
            this.TableLayoutPanel.Controls.Add(this.SpecularPowTextBoxPanel, 0, 5);
            this.TableLayoutPanel.Controls.Add(this.AmbientColorLabel, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.MaxStepsLabel, 0, 3);
            this.TableLayoutPanel.Controls.Add(this.MaxDistaneLabel, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.MinDistanceLabel, 0, 2);
            this.TableLayoutPanel.Controls.Add(this.MaxDistanceTextBoxPanel, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.MinDistanceTextBoxPanel, 1, 2);
            this.TableLayoutPanel.Controls.Add(this.MaxStepsTextBoxPanel, 1, 3);
            this.TableLayoutPanel.Controls.Add(this.AmbientColorPanel, 1, 0);
            this.TableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 6;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.21763F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.21763F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.21763F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.21763F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.21763F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.91185F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(268, 220);
            this.TableLayoutPanel.TabIndex = 18;
            // 
            // MaxDepthLabel
            // 
            this.MaxDepthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaxDepthLabel.AutoSize = true;
            this.MaxDepthLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MaxDepthLabel.Location = new System.Drawing.Point(4, 160);
            this.MaxDepthLabel.Name = "MaxDepthLabel";
            this.MaxDepthLabel.Size = new System.Drawing.Size(60, 13);
            this.MaxDepthLabel.TabIndex = 19;
            this.MaxDepthLabel.Text = "Max depth:";
            // 
            // SpecularPowLabel
            // 
            this.SpecularPowLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SpecularPowLabel.AutoSize = true;
            this.SpecularPowLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SpecularPowLabel.Location = new System.Drawing.Point(4, 196);
            this.SpecularPowLabel.Name = "SpecularPowLabel";
            this.SpecularPowLabel.Size = new System.Drawing.Size(75, 13);
            this.SpecularPowLabel.TabIndex = 17;
            this.SpecularPowLabel.Text = "Specular pow:";
            // 
            // MaxDepthTextBoxPanel
            // 
            this.MaxDepthTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MaxDepthTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.MaxDepthTextBoxPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaxDepthTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MaxDepthTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxDepthTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.MaxDepthTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.MaxDepthTextBoxPanel.Location = new System.Drawing.Point(105, 156);
            this.MaxDepthTextBoxPanel.Name = "MaxDepthTextBoxPanel";
            this.MaxDepthTextBoxPanel.ReadOnly = false;
            this.MaxDepthTextBoxPanel.Size = new System.Drawing.Size(159, 21);
            this.MaxDepthTextBoxPanel.TabIndex = 20;
            this.MaxDepthTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MaxDepthTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // SpecularPowTextBoxPanel
            // 
            this.SpecularPowTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.SpecularPowTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.SpecularPowTextBoxPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SpecularPowTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.SpecularPowTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpecularPowTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.SpecularPowTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.SpecularPowTextBoxPanel.Location = new System.Drawing.Point(105, 192);
            this.SpecularPowTextBoxPanel.Name = "SpecularPowTextBoxPanel";
            this.SpecularPowTextBoxPanel.ReadOnly = false;
            this.SpecularPowTextBoxPanel.Size = new System.Drawing.Size(159, 21);
            this.SpecularPowTextBoxPanel.TabIndex = 18;
            this.SpecularPowTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SpecularPowTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // AmbientColorLabel
            // 
            this.AmbientColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AmbientColorLabel.AutoSize = true;
            this.AmbientColorLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AmbientColorLabel.Location = new System.Drawing.Point(4, 12);
            this.AmbientColorLabel.Name = "AmbientColorLabel";
            this.AmbientColorLabel.Size = new System.Drawing.Size(74, 13);
            this.AmbientColorLabel.TabIndex = 0;
            this.AmbientColorLabel.Text = "Ambient color:";
            // 
            // MaxStepsLabel
            // 
            this.MaxStepsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaxStepsLabel.AutoSize = true;
            this.MaxStepsLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MaxStepsLabel.Location = new System.Drawing.Point(4, 123);
            this.MaxStepsLabel.Name = "MaxStepsLabel";
            this.MaxStepsLabel.Size = new System.Drawing.Size(58, 13);
            this.MaxStepsLabel.TabIndex = 12;
            this.MaxStepsLabel.Text = "Max steps:";
            // 
            // MaxDistaneLabel
            // 
            this.MaxDistaneLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaxDistaneLabel.AutoSize = true;
            this.MaxDistaneLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MaxDistaneLabel.Location = new System.Drawing.Point(4, 49);
            this.MaxDistaneLabel.Name = "MaxDistaneLabel";
            this.MaxDistaneLabel.Size = new System.Drawing.Size(73, 13);
            this.MaxDistaneLabel.TabIndex = 10;
            this.MaxDistaneLabel.Text = "Max distance:";
            // 
            // MinDistanceLabel
            // 
            this.MinDistanceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MinDistanceLabel.AutoSize = true;
            this.MinDistanceLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MinDistanceLabel.Location = new System.Drawing.Point(4, 86);
            this.MinDistanceLabel.Name = "MinDistanceLabel";
            this.MinDistanceLabel.Size = new System.Drawing.Size(70, 13);
            this.MinDistanceLabel.TabIndex = 11;
            this.MinDistanceLabel.Text = "Min distance:";
            // 
            // MaxDistanceTextBoxPanel
            // 
            this.MaxDistanceTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MaxDistanceTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.MaxDistanceTextBoxPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaxDistanceTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MaxDistanceTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxDistanceTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.MaxDistanceTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.MaxDistanceTextBoxPanel.Location = new System.Drawing.Point(105, 45);
            this.MaxDistanceTextBoxPanel.Name = "MaxDistanceTextBoxPanel";
            this.MaxDistanceTextBoxPanel.ReadOnly = false;
            this.MaxDistanceTextBoxPanel.Size = new System.Drawing.Size(159, 21);
            this.MaxDistanceTextBoxPanel.TabIndex = 13;
            this.MaxDistanceTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MaxDistanceTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // MinDistanceTextBoxPanel
            // 
            this.MinDistanceTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MinDistanceTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.MinDistanceTextBoxPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MinDistanceTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MinDistanceTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinDistanceTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.MinDistanceTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.MinDistanceTextBoxPanel.Location = new System.Drawing.Point(105, 82);
            this.MinDistanceTextBoxPanel.Name = "MinDistanceTextBoxPanel";
            this.MinDistanceTextBoxPanel.ReadOnly = false;
            this.MinDistanceTextBoxPanel.Size = new System.Drawing.Size(159, 21);
            this.MinDistanceTextBoxPanel.TabIndex = 14;
            this.MinDistanceTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MinDistanceTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // MaxStepsTextBoxPanel
            // 
            this.MaxStepsTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MaxStepsTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.MaxStepsTextBoxPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaxStepsTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MaxStepsTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxStepsTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.MaxStepsTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.MaxStepsTextBoxPanel.Location = new System.Drawing.Point(105, 119);
            this.MaxStepsTextBoxPanel.Name = "MaxStepsTextBoxPanel";
            this.MaxStepsTextBoxPanel.ReadOnly = false;
            this.MaxStepsTextBoxPanel.Size = new System.Drawing.Size(159, 21);
            this.MaxStepsTextBoxPanel.TabIndex = 15;
            this.MaxStepsTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MaxStepsTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // AmbientColorPanel
            // 
            this.AmbientColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.AmbientColorPanel.Color = System.Drawing.Color.Empty;
            this.AmbientColorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AmbientColorPanel.Location = new System.Drawing.Point(102, 1);
            this.AmbientColorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.AmbientColorPanel.Name = "AmbientColorPanel";
            this.AmbientColorPanel.Size = new System.Drawing.Size(165, 36);
            this.AmbientColorPanel.TabIndex = 16;
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DoneButton.Location = new System.Drawing.Point(12, 260);
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
            this.DoneSeperatorLabel.Location = new System.Drawing.Point(12, 246);
            this.DoneSeperatorLabel.Name = "DoneSeperatorLabel";
            this.DoneSeperatorLabel.Size = new System.Drawing.Size(268, 1);
            this.DoneSeperatorLabel.TabIndex = 15;
            // 
            // RenderSettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(292, 296);
            this.Controls.Add(this.TableLayoutPanel);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.DoneSeperatorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RenderSettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Render Settings";
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Label AmbientColorLabel;
        private System.Windows.Forms.Label MaxStepsLabel;
        private System.Windows.Forms.Label MaxDistaneLabel;
        private System.Windows.Forms.Label MinDistanceLabel;
        private GUI.TextBoxPanel MaxDistanceTextBoxPanel;
        private GUI.TextBoxPanel MinDistanceTextBoxPanel;
        private GUI.TextBoxPanel MaxStepsTextBoxPanel;
        private ColorPanel AmbientColorPanel;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label DoneSeperatorLabel;
        private System.Windows.Forms.Label MaxDepthLabel;
        private System.Windows.Forms.Label SpecularPowLabel;
        private GUI.TextBoxPanel MaxDepthTextBoxPanel;
        private GUI.TextBoxPanel SpecularPowTextBoxPanel;
    }
}