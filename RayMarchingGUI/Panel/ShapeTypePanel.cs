using System;
using System.Drawing;
using System.Windows.Forms;

namespace RayMarchingGUI {
    public partial class ShapeTypePanel : UserControl {
        private Type _type;
        public Type Type {
            get => _type;
            set {
                _type = value;

                DisplayDialog();
            }
        }

        private Color _backColor = Color.FromArgb(35, 35, 35);
        private Color _hoverColor = Color.FromArgb(50, 50, 50);
        private Color _activeColor = Color.FromArgb(70, 70, 70);

        //Events
        private event EventHandler _mouseClick;
        public new event EventHandler MouseClick {
            add {
                _mouseClick += value;

                Click += OnControlClick;
                IconpPctureBox.Click += OnControlClick;
                HeaderLabel.Click += OnControlClick;
            }
            remove {
                _mouseClick -= value;

                Click -= OnControlClick;
                IconpPctureBox.Click -= OnControlClick;
                HeaderLabel.Click -= OnControlClick;
            }
        }

        private void OnControlClick(object sender, EventArgs e) {
            _mouseClick?.Invoke(this, EventArgs.Empty);
        }

        public ShapeTypePanel() {
            InitializeComponent();
        }

        private void DisplayDialog() {
            IconpPctureBox.Image = _type.GetLargeIcon();
            HeaderLabel.Text = _type.GetName();
        }

        //Panel
        private void ShapeTypePanel_MouseDown(object sender, MouseEventArgs e) {
            BackColor = _activeColor;
        }
        private void ShapeTypePanel_MouseUp(object sender, MouseEventArgs e) {
            BackColor = _hoverColor;
        }

        private void ShapeTypePanel_MouseEnter(object sender, EventArgs e) {
            BackColor = _hoverColor;
        }
        private void ShapeTypePanel_MouseLeave(object sender, EventArgs e) {
            BackColor = _backColor;
        }

        //Label
        private void HeaderLabel_MouseEnter(object sender, EventArgs e) {
            HeaderLabel.BackColor = _hoverColor;
            BackColor = _hoverColor;
        }
        private void HeaderLabel_MouseLeave(object sender, EventArgs e) {
            HeaderLabel.BackColor = Color.Transparent;
            BackColor = _backColor;
        }

        private void HeaderLabel_MouseDown(object sender, MouseEventArgs e) {
            HeaderLabel.BackColor = _activeColor;
            BackColor = _activeColor;
        }
        private void HeaderLabel_MouseUp(object sender, MouseEventArgs e) {
            HeaderLabel.BackColor = _hoverColor;
            BackColor = _hoverColor;
        }

        //IconPictureBox
        private void IconpPctureBox_MouseEnter(object sender, EventArgs e) {
            IconpPctureBox.BackColor = _hoverColor;
            BackColor = _hoverColor;
        }
        private void IconpPctureBox_MouseLeave(object sender, EventArgs e) {
            IconpPctureBox.BackColor = Color.Transparent;
            BackColor = _backColor;
        }

        private void IconpPctureBox_MouseDown(object sender, MouseEventArgs e) {
            IconpPctureBox.BackColor = _activeColor;
            BackColor = _activeColor;
        }
        private void IconpPctureBox_MouseUp(object sender, MouseEventArgs e) {
            IconpPctureBox.BackColor = _hoverColor;
            BackColor = _hoverColor;
        }
    }
}
