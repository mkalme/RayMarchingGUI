using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using RayMarching;
using Vectors;
using ComputerGraphicsExtensions;

namespace RayMarchingGUI {
    public partial class SceneDialog : Form {
        private Scene Scene { get; set; }
        private RenderSettings RenderSettings { get; set; } = new RenderSettings();

        public SceneDialog(Scene scene, RenderSettings renderSettings) {
            InitializeComponent();
            InitializeUserComponent();

            Scene = scene;
            RenderSettings = renderSettings;

            DisplayDialog();
        }
        private void InitializeUserComponent() {
            LightSourceGrid.DoubleBuffered(true);
            ObjectGrid.DoubleBuffered(true);

            //OpenFileDialog
            OpenFileDialog.DefaultExt = "json";
            OpenFileDialog.Filter = "Json files (*.json)|*.json|All files (*.*)|*.*";
            OpenFileDialog.AutoUpgradeEnabled = false;

            //SaveFileDialog
            SaveFileDialog.FileName = "Untitled";
            SaveFileDialog.DefaultExt = "json";
            SaveFileDialog.Filter = "Json files (*.json)|*.json|All files (*.*)|*.*";
            SaveFileDialog.AutoUpgradeEnabled = false;
        }

        private void SceneDialog_Load(object sender, EventArgs e) {
            LightSourceGrid.ClearSelection();
            ObjectGrid.ClearSelection();
        }

        private void DisplayDialog() {
            Camera camera = Scene.Camera;

            CoordinatesTextBoxPanel.Text = camera.Pos.ConvertToString();
            FocalLengthTextBoxPanel.Text = camera.FocalLength.ToString();
            ResolutionTextBoxPanel.Text = ViewHelper.ResolutionToString(camera.Width, camera.Height);

            RotationXTextBoxPanel.Text = ((CustomCamera)Scene.Camera).RotationX.ToString();
            RotationYTextBoxPanel.Text = ((CustomCamera)Scene.Camera).RotationY.ToString();

            DisplayLightSourceGrid();
            DisplayObjectGrid();
        }

        private void UpdateScene() {
            Scene.Camera.Pos = VectorExtensions.FromString(CoordinatesTextBoxPanel.Text);
            Scene.Camera.FocalLength = FocalLengthTextBoxPanel.Text.ToDouble();
            ResolutionTextBoxPanel.Text.ToResolution(out Scene.Camera.Width, out Scene.Camera.Height);

            ((CustomCamera)Scene.Camera).RotationX = RotationXTextBoxPanel.Text.ToDouble();
            ((CustomCamera)Scene.Camera).RotationY = RotationYTextBoxPanel.Text.ToDouble();
        }

        //LightSourceGrid
        private void DisplayLightSourceGrid() {
            LightSourceGrid.Rows.Clear();

            for (int i = 0; i < Scene.LightSources.Count; i++) {
                LightSource source = Scene.LightSources[i];

                LightSourceGrid.Rows.Add(i, "Light source", source.Pos.ConvertToString(), source.Lumens.ParseNumber());

                ((TextAndImageCell)LightSourceGrid.Rows[i].Cells[1]).Image = Properties.Resources._22pxLightSource;
            }

            LightSourceGrid.ClearSelection();
        }

        private void LightSourceGrid_SelectionChanged(object sender, EventArgs e) {
            bool selected = LightSourceGrid.SelectedRows.Count > 0;

            EditLightSourceButton.Enabled = selected;
            RemoveLightSourceButton.Enabled = selected;
        }
        private void LightSourceGrid_MouseDown(object sender, MouseEventArgs e) {
            var hitTest = LightSourceGrid.HitTest(e.X, e.Y);

            if (hitTest.Type != DataGridViewHitTestType.Cell &&
                hitTest.Type != DataGridViewHitTestType.ColumnHeader) {
                LightSourceGrid.ClearSelection();
                return;
            }
        }
        private void LightSourceGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            EditLightSource(SelectedLightSource);
        }

        private void LightSourceGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;

            LightSourceGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
        }
        private void LightSourceGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;

            LightSourceGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
        }

        private LightSource SelectedLightSource {
            get {
                if (LightSourceGrid.SelectedRows.Count < 1) return null;

                int index = (int)LightSourceGrid.SelectedRows[0].Cells[0].Value;
                return Scene.LightSources[index];
            }
        }

        private void EditLightSource(LightSource lightSource) {
            if (lightSource == null) return;

            var dialog = new LightSourceDialog(lightSource);
            dialog.ShowDialog();

            DisplayLightSourceGrid();
            LightSourceGrid.SelectItem(lightSource, Scene.LightSources);
        }

        private void AddLightSourceButton_Click(object sender, EventArgs e) {
            var lightSource = new LightSource(new Vec3(0, 0, 0), 0);
            Scene.LightSources.Add(lightSource);

            DisplayLightSourceGrid();
            LightSourceGrid.SelectItem(lightSource, Scene.LightSources);

            EditLightSource(lightSource);
        }
        private void EditLightSourceButton_Click(object sender, EventArgs e) {
            EditLightSource(SelectedLightSource);
        }
        private void RemoveLightSourceButton_Click(object sender, EventArgs e) {
            Scene.LightSources.Remove(SelectedLightSource);
            
            DisplayLightSourceGrid();
        }

        //ObjectGrid
        private void DisplayObjectGrid() {
            ObjectGrid.Rows.Clear();

            for (int i = 0; i < Scene.Shapes.Count; i++) {
                Shape shape = Scene.Shapes[i];

                ObjectGrid.Rows.Add(i, shape.GetName(), shape.Pos.ConvertToString());

                ObjectGrid.Rows[i].Cells[3].Style.BackColor = shape.Properties.Color;
                ((TextAndImageCell)ObjectGrid.Rows[i].Cells[1]).Image = shape.GetIcon();
            }

            ObjectGrid.ClearSelection();
        }

        private void ObjectGrid_SelectionChanged(object sender, EventArgs e) {
            bool selected = ObjectGrid.SelectedRows.Count > 0;

            EditObjectButton.Enabled = selected;
            RemoveObjectButton.Enabled = selected;
        }
        private void ObjectGrid_MouseDown(object sender, MouseEventArgs e) {
            var hitTest = ObjectGrid.HitTest(e.X, e.Y);

            if (hitTest.Type != DataGridViewHitTestType.Cell &&
                hitTest.Type != DataGridViewHitTestType.ColumnHeader) {
                ObjectGrid.ClearSelection();
                return;
            }
        }
        private void ObjectGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            EditShape(SelectedShape);
        }

        private void ObjectGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;

            ObjectGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
        }
        private void ObjectGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;

            ObjectGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
        }

        private Shape SelectedShape {
            get {
                if (ObjectGrid.SelectedRows.Count < 1) return null;

                int index = (int)ObjectGrid.SelectedRows[0].Cells[0].Value;
                return Scene.Shapes[index];
            }
        }

        private void AddShape(Type type) {
            Shape shape;

            if (type == typeof(Sphere)) shape = new Sphere(new Vec3(0, 0, 0), 0);
            else if (type == typeof(RayMarching.Rectangle)) shape = new RayMarching.Rectangle(new Vec2(), new Vec2(), 0);
            else if (type == typeof(Plane)) shape = new Plane(0, PlaneType.Y);
            else if (type == typeof(Torus)) shape = new Torus(new Vec3(0, 0, 0), 0, 0);
            else shape = new Capsule(new Vec3(0, 0, 0), new Vec3(0, 0, 0), 0);

            Scene.Shapes.Add(shape);

            DisplayObjectGrid();
            ObjectGrid.SelectItem(shape, Scene.Shapes);

            EditShape(shape);
        }

        private void EditShape(Shape shape) {
            if (shape == null) return;

            Type type = shape.GetType();

            if (type == typeof(Sphere)) EditSphere(shape as Sphere);
            else if (type == typeof(RayMarching.Rectangle)) EditRectangle(shape as RayMarching.Rectangle);
            else if (type == typeof(Plane)) EditPlane(shape as Plane);
            else if (type == typeof(Torus)) EditTorus(shape as Torus);
            else if (type == typeof(Capsule)) EditCapsule(shape as Capsule);

            DisplayObjectGrid();
            ObjectGrid.SelectItem(shape, Scene.Shapes);
        }
        private void EditSphere(Sphere sphere) {
            var dialog = new SphereDialog(sphere);
            dialog.ShowDialog();
        }
        private void EditRectangle(RayMarching.Rectangle rectangle) {
            var dialog = new RectangleDialog(rectangle);
            dialog.ShowDialog();
        }
        private void EditPlane(Plane plane) {
            var dialog = new PlaneDialog(plane);
            dialog.ShowDialog();
        }
        private void EditTorus(Torus torus) {
            var dialog = new TorusDialog(torus);
            dialog.ShowDialog();
        }
        private void EditCapsule(Capsule capsule) {
            var dialog = new CapsuleDialog(capsule);
            dialog.ShowDialog();
        }

        private void AddObjectButton_Click(object sender, EventArgs e) {
            var dialog = new ShapeTypeDialog();
            dialog.ShowDialog();

            if (!dialog.Selected) return;

            AddShape(dialog.Type);
        }
        private void EditObjectButton_Click(object sender, EventArgs e) {
            EditShape(SelectedShape);
        }
        private void RemoveObjectButton_Click(object sender, EventArgs e) {
            Scene.Shapes.Remove(SelectedShape);
            
            DisplayObjectGrid();
        }

        //Renderer
        private void RenderButton_Click(object sender, EventArgs e) {
            UpdateScene();

            Renderer renderer = new Renderer(Scene);
            RenderSettings.ApplySettings(renderer);

            new RenderDialog(renderer).ShowDialog();
        }
        private void RenderSettingsButton_Click(object sender, EventArgs e) {
            var dialog = new RenderSettingsDialog(RenderSettings);
            dialog.ShowDialog();
        }

        private void OpenFile_Click(object sender, EventArgs e) {
            OpenFileDialog.ShowDialog();
            if (string.IsNullOrEmpty(OpenFileDialog.FileName)) return;

            RenderSettings settings;
            Scene = SceneExtensions.FromJson(File.ReadAllText(OpenFileDialog.FileName), out settings);

            RenderSettings = settings;

            DisplayDialog();
        }
        private void SaveAsButton_Click(object sender, EventArgs e) {
            UpdateScene();

            SaveFileDialog.ShowDialog();
            if (string.IsNullOrEmpty(SaveFileDialog.FileName)) return;

            File.WriteAllText(SaveFileDialog.FileName, Scene.ToJson(RenderSettings).ToString());
        }
    }
}
