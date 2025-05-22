using System;
using System.Windows.Forms;
using RayMarching;

namespace RayMarchingGUI {
    public partial class SphereDialog : Form {
        private Sphere Sphere { get; set; }

        public SphereDialog(Sphere sphere) {
            InitializeComponent();

            Sphere = sphere;

            DisplayDialog();
        }

        private void DisplayDialog() {
            RadiusTextBoxPanel.Text = Sphere.Radius.ToString();
            CoordinatesTextBoxPanel.Text = Sphere.Pos.ConvertToString();
        }

        private void ChangePropertiesButton_Click(object sender, EventArgs e) {
            var dialog = new PropertiesDialog(Sphere);
            dialog.ShowDialog();
        }

        private void DoneButton_Click(object sender, EventArgs e) {
            Sphere.Radius = RadiusTextBoxPanel.Text.ToDouble();
            Sphere.Pos = VectorExtensions.FromString(CoordinatesTextBoxPanel.Text);

            Close();
        }
    }
}
