using System;
using System.Windows.Forms;
using RayMarching;

namespace RayMarchingGUI {
    public partial class ShapeTypeDialog : Form {
        public Type Type { get; private set; }
        public bool Selected { get; private set; } = false;

        public ShapeTypeDialog() {
            InitializeComponent();
            InitializeUserComponent();
        }
        private void InitializeUserComponent() {
            SphereTypePanel.Type = typeof(Sphere);
            PlaneTypePanel.Type = typeof(Plane);
            TorusTypePanel.Type = typeof(Torus);
            RectangleTypePanel.Type = typeof(Rectangle);
            CapsuleTypePanel.Type = typeof(Capsule);

            SphereTypePanel.MouseClick += ShapeClick;
            PlaneTypePanel.MouseClick += ShapeClick;
            TorusTypePanel.MouseClick += ShapeClick;
            RectangleTypePanel.MouseClick += ShapeClick;
            CapsuleTypePanel.MouseClick += ShapeClick;
        }

        private void ShapeClick(object sender, EventArgs e) {
            Selected = true;
            Type = ((ShapeTypePanel)sender).Type;

            Close();
        }
    }
}
