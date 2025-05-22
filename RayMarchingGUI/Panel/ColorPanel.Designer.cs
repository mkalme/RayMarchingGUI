namespace RayMarchingGUI {
    partial class ColorPanel {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ChangeColorButton = new System.Windows.Forms.Button();
            this.BackColorPanel = new System.Windows.Forms.Panel();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // ChangeColorButton
            // 
            this.ChangeColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ChangeColorButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ChangeColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeColorButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChangeColorButton.Location = new System.Drawing.Point(34, 7);
            this.ChangeColorButton.Name = "ChangeColorButton";
            this.ChangeColorButton.Size = new System.Drawing.Size(89, 23);
            this.ChangeColorButton.TabIndex = 19;
            this.ChangeColorButton.Text = "Change Color";
            this.ChangeColorButton.UseVisualStyleBackColor = false;
            this.ChangeColorButton.Click += new System.EventHandler(this.ChangeColorButton_Click);
            // 
            // BackColorPanel
            // 
            this.BackColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BackColorPanel.Location = new System.Drawing.Point(5, 7);
            this.BackColorPanel.Name = "BackColorPanel";
            this.BackColorPanel.Size = new System.Drawing.Size(23, 23);
            this.BackColorPanel.TabIndex = 18;
            this.BackColorPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackColorPanel_MouseDown);
            // 
            // ColorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.ChangeColorButton);
            this.Controls.Add(this.BackColorPanel);
            this.Name = "ColorPanel";
            this.Size = new System.Drawing.Size(165, 35);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChangeColorButton;
        private System.Windows.Forms.Panel BackColorPanel;
        private System.Windows.Forms.ColorDialog ColorDialog;
    }
}
