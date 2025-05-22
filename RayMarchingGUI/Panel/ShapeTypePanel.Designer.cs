namespace RayMarchingGUI {
    partial class ShapeTypePanel {
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.IconpPctureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IconpPctureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.HeaderLabel.Location = new System.Drawing.Point(42, 7);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(49, 17);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Sphere";
            this.HeaderLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderLabel_MouseDown);
            this.HeaderLabel.MouseEnter += new System.EventHandler(this.HeaderLabel_MouseEnter);
            this.HeaderLabel.MouseLeave += new System.EventHandler(this.HeaderLabel_MouseLeave);
            this.HeaderLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeaderLabel_MouseUp);
            // 
            // IconpPctureBox
            // 
            this.IconpPctureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IconpPctureBox.Image = global::RayMarchingGUI.Properties.Resources._64pxSphere;
            this.IconpPctureBox.Location = new System.Drawing.Point(6, 6);
            this.IconpPctureBox.Name = "IconpPctureBox";
            this.IconpPctureBox.Size = new System.Drawing.Size(30, 30);
            this.IconpPctureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconpPctureBox.TabIndex = 0;
            this.IconpPctureBox.TabStop = false;
            this.IconpPctureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IconpPctureBox_MouseDown);
            this.IconpPctureBox.MouseEnter += new System.EventHandler(this.IconpPctureBox_MouseEnter);
            this.IconpPctureBox.MouseLeave += new System.EventHandler(this.IconpPctureBox_MouseLeave);
            this.IconpPctureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.IconpPctureBox_MouseUp);
            // 
            // ShapeTypePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.IconpPctureBox);
            this.Name = "ShapeTypePanel";
            this.Size = new System.Drawing.Size(211, 42);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShapeTypePanel_MouseDown);
            this.MouseEnter += new System.EventHandler(this.ShapeTypePanel_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ShapeTypePanel_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShapeTypePanel_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.IconpPctureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IconpPctureBox;
        private System.Windows.Forms.Label HeaderLabel;
    }
}
