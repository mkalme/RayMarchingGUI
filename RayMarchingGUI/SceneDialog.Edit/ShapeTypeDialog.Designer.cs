namespace RayMarchingGUI {
    partial class ShapeTypeDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShapeTypeDialog));
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SphereTypePanel = new RayMarchingGUI.ShapeTypePanel();
            this.PlaneTypePanel = new RayMarchingGUI.ShapeTypePanel();
            this.TorusTypePanel = new RayMarchingGUI.ShapeTypePanel();
            this.RectangleTypePanel = new RayMarchingGUI.ShapeTypePanel();
            this.CapsuleTypePanel = new RayMarchingGUI.ShapeTypePanel();
            this.TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 1;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Controls.Add(this.SphereTypePanel, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.PlaneTypePanel, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.TorusTypePanel, 0, 2);
            this.TableLayoutPanel.Controls.Add(this.RectangleTypePanel, 0, 3);
            this.TableLayoutPanel.Controls.Add(this.CapsuleTypePanel, 0, 4);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(8, 8);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 5;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(232, 235);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // SphereTypePanel
            // 
            this.SphereTypePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SphereTypePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SphereTypePanel.Location = new System.Drawing.Point(3, 3);
            this.SphereTypePanel.Name = "SphereTypePanel";
            this.SphereTypePanel.Size = new System.Drawing.Size(226, 41);
            this.SphereTypePanel.TabIndex = 0;
            this.SphereTypePanel.Type = null;
            // 
            // PlaneTypePanel
            // 
            this.PlaneTypePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PlaneTypePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlaneTypePanel.Location = new System.Drawing.Point(3, 50);
            this.PlaneTypePanel.Name = "PlaneTypePanel";
            this.PlaneTypePanel.Size = new System.Drawing.Size(226, 41);
            this.PlaneTypePanel.TabIndex = 1;
            this.PlaneTypePanel.Type = null;
            // 
            // TorusTypePanel
            // 
            this.TorusTypePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TorusTypePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TorusTypePanel.Location = new System.Drawing.Point(3, 97);
            this.TorusTypePanel.Name = "TorusTypePanel";
            this.TorusTypePanel.Size = new System.Drawing.Size(226, 41);
            this.TorusTypePanel.TabIndex = 2;
            this.TorusTypePanel.Type = null;
            // 
            // RectangleTypePanel
            // 
            this.RectangleTypePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RectangleTypePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectangleTypePanel.Location = new System.Drawing.Point(3, 144);
            this.RectangleTypePanel.Name = "RectangleTypePanel";
            this.RectangleTypePanel.Size = new System.Drawing.Size(226, 41);
            this.RectangleTypePanel.TabIndex = 3;
            this.RectangleTypePanel.Type = null;
            // 
            // CapsuleTypePanel
            // 
            this.CapsuleTypePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CapsuleTypePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CapsuleTypePanel.Location = new System.Drawing.Point(3, 191);
            this.CapsuleTypePanel.Name = "CapsuleTypePanel";
            this.CapsuleTypePanel.Size = new System.Drawing.Size(226, 41);
            this.CapsuleTypePanel.TabIndex = 4;
            this.CapsuleTypePanel.Type = null;
            // 
            // ShapeTypeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(248, 251);
            this.Controls.Add(this.TableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ShapeTypeDialog";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select shape";
            this.TableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private ShapeTypePanel SphereTypePanel;
        private ShapeTypePanel PlaneTypePanel;
        private ShapeTypePanel TorusTypePanel;
        private ShapeTypePanel RectangleTypePanel;
        private ShapeTypePanel CapsuleTypePanel;
    }
}