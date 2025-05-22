using System;
using System.Windows.Forms;
using RayMarching;

namespace RayMarchingGUI {
    public partial class TorusDialog : Form {
        private Torus Torus { get; set; }

        public TorusDialog(Torus torus) {
            InitializeComponent();

            Torus = torus;

            DisplayDialog();
        }

        private void DisplayDialog() {
            CoordinatesTextBoxPanel.Text = Torus.Pos.ConvertToString();
            RadiusTextBoxPanel.Text = Torus.Radius1.ToString();
            SecondRadiusTextBoxPanel.Text = Torus.Radius2.ToString();
        }

        private void ChangePropertiesButton_Click(object sender, EventArgs e) {
            var dialog = new PropertiesDialog(Torus);
            dialog.ShowDialog();
        }

        private void DoneButton_Click(object sender, EventArgs e) {
            Torus.Pos = VectorExtensions.FromString(CoordinatesTextBoxPanel.Text);
            Torus.Radius1 = RadiusTextBoxPanel.Text.ToDouble();
            Torus.Radius2 = SecondRadiusTextBoxPanel.Text.ToDouble();

            Close();
        }
    }
}
