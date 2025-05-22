using System;
using System.Windows.Forms;
using RayMarching;

namespace RayMarchingGUI {
    public partial class CapsuleDialog : Form {
        private Capsule Capsule { get; set; }

        public CapsuleDialog(Capsule capsule) {
            InitializeComponent();

            Capsule = capsule;

            DisplayDialog();
        }

        private void DisplayDialog() {
            RadiusTextBoxPanel.Text = Capsule.Radius.ToString();
            CoordinatesTextBoxPanel.Text = Capsule.Pos.ConvertToString();
            SecondCoordinatesTextBoxPanel.Text = Capsule.Pos2.ConvertToString();
        }

        private void ChangePropertiesButton_Click(object sender, EventArgs e) {
            var dialog = new PropertiesDialog(Capsule);
            dialog.ShowDialog();
        }

        private void DoneButton_Click(object sender, EventArgs e) {
            Capsule.Radius = RadiusTextBoxPanel.Text.ToDouble();
            Capsule.Pos = VectorExtensions.FromString(CoordinatesTextBoxPanel.Text);
            Capsule.Pos2 = VectorExtensions.FromString(SecondCoordinatesTextBoxPanel.Text);

            Close();
        }
    }
}
