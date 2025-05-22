using System;
using System.Windows.Forms;
using RayMarching;

namespace RayMarchingGUI {
    public partial class LightSourceDialog : Form {
        private LightSource LightSource { get; set; }

        public LightSourceDialog(LightSource lightSource) {
            InitializeComponent();

            LightSource = lightSource;

            DisplayDialog();
        }

        private void DisplayDialog() {
            ColorPanel.Color = LightSource.Color;
            LumensTextBoxPanel.Text = LightSource.Lumens.ToString();
            CoordinatesTextBoxPanel.Text = LightSource.Pos.ConvertToString();
        }

        private void DoneButton_Click(object sender, EventArgs e) {
            LightSource.Color = ColorPanel.Color;
            LightSource.Lumens = LumensTextBoxPanel.Text.ToDouble();
            LightSource.Pos = VectorExtensions.FromString(CoordinatesTextBoxPanel.Text);

            Close();
        }
    }
}
