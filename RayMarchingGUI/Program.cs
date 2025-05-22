using System;
using System.IO;
using System.Windows.Forms;
using RayMarching;
using Vectors;
using ComputerGraphicsExtensions;

namespace RayMarchingGUI {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Scene scene;
            RenderSettings settings;

            if (args.Length > 0) {
                scene = SceneExtensions.FromJson(File.ReadAllText(args[0]), out settings);
            } else {
                scene = new Scene();
                scene.Camera = new Camera(850, 750);
                scene.Camera.FocalLength = 1;

                scene.Camera = new CustomCamera(scene.Camera);

                settings = new RenderSettings();
            }

            Application.Run(new SceneDialog(scene, settings));
        }
    }
}
