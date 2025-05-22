using System;
using System.Windows.Forms;

namespace RayMarchingGUI {
    public partial class RenderSettingsDialog : Form {
        private RenderSettings Settings { get; set; }

        public RenderSettingsDialog(RenderSettings settings) {
            InitializeComponent();

            Settings = settings;

            DisplayDialog();
        }

        private void DisplayDialog() {
            AmbientColorPanel.Color = Settings.AmbientColor;
            MaxDistanceTextBoxPanel.Text = Settings.MaxDistance.ToString();
            MinDistanceTextBoxPanel.Text = Settings.MinDistance.ToString();
            MaxStepsTextBoxPanel.Text = Settings.MaxSteps.ToString();
            MaxDepthTextBoxPanel.Text = Settings.MaxDepth.ToString();
            SpecularPowTextBoxPanel.Text = Settings.SpecularPow.ToString();
        }

        private void DoneButton_Click(object sender, EventArgs e) {
            Settings.AmbientColor = AmbientColorPanel.Color;
            Settings.MaxDistance = MaxDistanceTextBoxPanel.Text.ToDouble();
            Settings.MinDistance = MinDistanceTextBoxPanel.Text.ToDouble();
            Settings.MaxSteps = int.Parse(MaxStepsTextBoxPanel.Text);
            Settings.MaxDepth = int.Parse(MaxDepthTextBoxPanel.Text);
            Settings.SpecularPow = SpecularPowTextBoxPanel.Text.ToDouble();

            Close();
        }
    }
}
