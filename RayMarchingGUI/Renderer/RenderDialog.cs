using System;
using System.Drawing;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using RayMarching;

namespace RayMarchingGUI {
    public partial class RenderDialog : Form {
        private BackgroundWorker BackgroundWorker = new BackgroundWorker();

        private Renderer Renderer { get; set; }

        private ProgressPanel ProgressPanel;

        public RenderDialog(Scene scene) : this(new Renderer(scene)) { 
        }
        public RenderDialog(Renderer renderer) {
            InitializeComponent();
            InitializeUserComponent();

            Renderer = renderer;
            Renderer.RenderFinished += Renderer_Finished;
        }
        private void InitializeUserComponent() {
            //BackgroundWorker
            BackgroundWorker.WorkerReportsProgress = true;
            BackgroundWorker.WorkerSupportsCancellation = true;
            BackgroundWorker.DoWork += new DoWorkEventHandler(BackgroundWorker_DoWork);
            BackgroundWorker.ProgressChanged += new ProgressChangedEventHandler(BackgroundWorker_ProgressChanged);

            //ProgressPanel
            ProgressPanel = new ProgressPanel(CreateGraphics());
            ProgressPanelContainer.Controls.Add(ProgressPanel);

            //MenuStrip
            MenuStrip.Renderer = new MyToolStripRenderer(Color.Gray, Color.Gray, Color.LightGray);

            //PictureBox
            PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            CenterPictureBox();
        }

        private void RenderDialog_Load(object sender, EventArgs e) {
            StartRender();
            //CenterPictureBox();
        }
        private void RenderDialog_FormClosing(object sender, FormClosingEventArgs e) {
            if (Renderer.Progress.Type != RenderProgressType.Finished) {
                BackgroundWorker.CancelAsync();
                _renderingThread.Abort();
            }
        }

        private void CenterPictureBox() {
            int x = (PictureBoxPanel.Width - PictureBox.Width) / 2;
            int y = (PictureBoxPanel.Height - PictureBox.Height) / 2;

            x = x < 0 ? 0 : x;
            y = y < 0 ? 0 : y;

            PictureBox.Location = new Point(x, y);
        }

        private void PictureBox_SizeChanged(object sender, EventArgs e) {
            CenterPictureBox();
        }
        private void PictureBoxPanel_SizeChanged(object sender, EventArgs e) {
            CenterPictureBox();
        }

        //Render
        private Thread _renderingThread;

        private void StartRender() {
            _renderingThread = new Thread(() => {
                Renderer.RenderScene();
            });
            _renderingThread.Start();

            BackgroundWorker.RunWorkerAsync();
        }
        private void StopRender() {
            BackgroundWorker.CancelAsync();

            PictureBox.Image = Renderer.Progress.RenderedImage;
            ProgressPanel.UpdatePanel(Renderer.Progress);

            Clipboard.SetImage(Renderer.Progress.RenderedImage);
        }

        private void Renderer_Finished(object sender, EventArgs e) {
            Invoke(new Action(StopRender));
        }

        //BackgroundWorker
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
            while (!BackgroundWorker.CancellationPending) {
                BackgroundWorker.ReportProgress(0);

                Thread.Sleep(50);
            }
        }
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            PictureBox.Image = Renderer.Progress.CurrentImage;

            if ((DateTime.Now - _lastUpdated).TotalMilliseconds < 100) return;
            _lastUpdated = DateTime.Now;

            ProgressPanel.UpdatePanel(Renderer.Progress);
        }
        private DateTime _lastUpdated = DateTime.MinValue;

        //MenuStrip
        private void ClipboardMenuItem_Click(object sender, EventArgs e) {
            if (Renderer.Progress.Type != RenderProgressType.Finished) {
                Clipboard.SetImage(GetRendererImage(Renderer.Progress.CurrentImage, BackColor));
            } else {
                Clipboard.SetImage(Renderer.Progress.RenderedImage);
            }
        }

        private static Bitmap GetRendererImage(Image image, Color backColor) {
            Bitmap output = new Bitmap(image.Width, image.Height);

            using (Graphics graphics = Graphics.FromImage(output)) {
                graphics.Clear(backColor);

                graphics.DrawImageUnscaled(image, 0, 0);
            }

            return output;
        }
    }
}
