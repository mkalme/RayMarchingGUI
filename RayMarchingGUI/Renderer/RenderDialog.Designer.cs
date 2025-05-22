namespace RayMarchingGUI {
    partial class RenderDialog {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenderDialog));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.ProgressPanelContainer = new System.Windows.Forms.Panel();
            this.PictureBoxPanel = new System.Windows.Forms.Panel();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClipboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.PictureBoxPanel.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(1240, 712);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.SizeChanged += new System.EventHandler(this.PictureBox_SizeChanged);
            // 
            // ProgressPanelContainer
            // 
            this.ProgressPanelContainer.AutoSize = true;
            this.ProgressPanelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProgressPanelContainer.Location = new System.Drawing.Point(12, 12);
            this.ProgressPanelContainer.Name = "ProgressPanelContainer";
            this.ProgressPanelContainer.Size = new System.Drawing.Size(0, 0);
            this.ProgressPanelContainer.TabIndex = 1;
            // 
            // PictureBoxPanel
            // 
            this.PictureBoxPanel.AutoScroll = true;
            this.PictureBoxPanel.ContextMenuStrip = this.MenuStrip;
            this.PictureBoxPanel.Controls.Add(this.PictureBox);
            this.PictureBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBoxPanel.Name = "PictureBoxPanel";
            this.PictureBoxPanel.Size = new System.Drawing.Size(1240, 712);
            this.PictureBoxPanel.TabIndex = 2;
            this.PictureBoxPanel.SizeChanged += new System.EventHandler(this.PictureBoxPanel_SizeChanged);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClipboardMenuItem});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(170, 26);
            // 
            // ClipboardMenuItem
            // 
            this.ClipboardMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClipboardMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ClipboardMenuItem.Image = global::RayMarchingGUI.Properties.Resources._16pxCopy;
            this.ClipboardMenuItem.Name = "ClipboardMenuItem";
            this.ClipboardMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ClipboardMenuItem.Text = "Copy to clipboard";
            this.ClipboardMenuItem.Click += new System.EventHandler(this.ClipboardMenuItem_Click);
            // 
            // RenderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1240, 712);
            this.Controls.Add(this.ProgressPanelContainer);
            this.Controls.Add(this.PictureBoxPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RenderDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Renderer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RenderDialog_FormClosing);
            this.Load += new System.EventHandler(this.RenderDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.PictureBoxPanel.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Panel ProgressPanelContainer;
        private System.Windows.Forms.Panel PictureBoxPanel;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ClipboardMenuItem;
    }
}