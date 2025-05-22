using System;
using System.Windows.Forms;
using RayMarching;

namespace RayMarchingGUI {
    public partial class PropertiesDialog : Form {
        private Shape Shape { get; set; }

        public PropertiesDialog(Shape shape) {
            InitializeComponent();

            Shape = shape;

            DisplayDialog();
        }

        private void DisplayDialog() {
            IconPictureBox.Image = Shape.GetLargeIcon();

            ColorPanel.Color = Shape.Properties.Color;
            ReflectionTextBoxPanel.Text = Shape.Properties.ReflectionIndex.ToString();
            RefractionTextBoxPanel.Text = Shape.Properties.RefractionIndex.ToString();
            DiffusionTextBoxPanel.Text = Shape.Properties.DiffusionIndex.ToString();
        }

        private void DoneButton_Click(object sender, EventArgs e) {
            Shape.Properties.Color = ColorPanel.Color;

            Shape.Properties.ReflectionIndex = ReflectionTextBoxPanel.Text.ToDouble();
            Shape.Properties.RefractionIndex = RefractionTextBoxPanel.Text.ToDouble();
            Shape.Properties.DiffusionIndex = DiffusionTextBoxPanel.Text.ToDouble();

            Close();
        }
    }
}
