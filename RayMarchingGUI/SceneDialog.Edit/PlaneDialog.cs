using System;
using System.Windows.Forms;
using RayMarching;

namespace RayMarchingGUI {
    public partial class PlaneDialog : Form {
        private Plane Plane { get; set; }

        public PlaneDialog(Plane plane) {
            InitializeComponent();

            Plane = plane;

            DisplayDialog();
        }

        private void DisplayDialog() {
            TypeComboBox.SelectedIndex = (int)Plane.Type;
            WTextBoxPanel.Text = Plane.Pos.GetPlaneW(Plane.Type).ToString();
        }

        private void ChangePropertiesButton_Click(object sender, EventArgs e) {
            var dialog = new PropertiesDialog(Plane);
            dialog.ShowDialog();
        }

        private void DoneButton_Click(object sender, EventArgs e) {
            Plane.Type = (PlaneType)TypeComboBox.SelectedIndex;
            Plane.Pos = VectorExtensions.GetPlaneVector(WTextBoxPanel.Text.ToDouble(), Plane.Type);

            Close();
        }
    }
}
