using System;
using RayMarching;
using Vectors;

namespace ComputerGraphicsExtensions {
    public class CustomCamera : Camera {
        public double RotationX { get; set; } = 0;
        public double RotationY { get; set; } = 0;

        public CustomCamera(Camera camera) : base(camera.Width, camera.Height) {
            FocalLength = camera.FocalLength;
            Pos = camera.Pos;
        }
        public CustomCamera(int width, int height) : base(width, height) {
            FocalLength = 1;
        }

        protected override Ray[,] GetRays() {
            Ray[,] rays = base.GetRays();

            for (int y = 0; y < rays.GetLength(1); y++) {
                for (int x = 0; x < rays.GetLength(0); x++) {
                    Ray ray = rays[x, y];

                    ray.Point2 = ray.Origin + (ray.Point2 - ray.Origin).RotateY(RotationY).RotateX(RotationX);
                }
            }

            return rays;
        }
    }
}
