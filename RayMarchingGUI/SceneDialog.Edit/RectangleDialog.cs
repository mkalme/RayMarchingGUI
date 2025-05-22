using System;
using System.Drawing;
using System.Windows.Forms;

namespace RayMarchingGUI {
    public partial class RectangleDialog : Form {
        private RayMarching.Rectangle Rectangle { get; set; }
        
        public RectangleDialog(RayMarching.Rectangle rectangle) {
            InitializeComponent();

            Rectangle = rectangle;

            DisplayDialog();
        }

        private void DisplayDialog() {
            CoordinatesTextBoxPanel.Text = Rectangle.Pos.ConvertToString();
            SecondCoordinatesTextBoxPanel.Text = Rectangle.Pos2.ConvertToString();
        }

        private void ChangePropertiesButton_Click(object sender, EventArgs e) {
            var dialog = new PropertiesDialog(Rectangle);
            dialog.ShowDialog();
        }

        private void DoneButton_Click(object sender, EventArgs e) {
            Rectangle.Pos = VectorExtensions.FromString(CoordinatesTextBoxPanel.Text);
            Rectangle.Pos2 = VectorExtensions.FromString(SecondCoordinatesTextBoxPanel.Text);

            Close();
        }
    }
}
