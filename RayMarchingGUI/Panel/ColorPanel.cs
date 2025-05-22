using System;
using System.Drawing;
using System.Windows.Forms;

namespace RayMarchingGUI {
    public partial class ColorPanel : UserControl {
        private Color _color;
        public Color Color {
            get => _color;
            set {
                _color = value;
                ColorDialog.Color = value;
                BackColorPanel.BackColor = value;
            }
        }

        public ColorPanel() {
            InitializeComponent();
        }

        private void ChangeColorButton_Click(object sender, EventArgs e) {
            ColorDialog.ShowDialog();

            Color = ColorDialog.Color;
        }
        private void BackColorPanel_MouseDown(object sender, MouseEventArgs e) {
            ColorDialog.ShowDialog();

            Color = ColorDialog.Color;
        }
    }
}
