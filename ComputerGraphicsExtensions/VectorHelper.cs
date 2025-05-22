using System;
using Vectors;

namespace ComputerGraphicsExtensions {
    static class VectorExtensions {
        public static Vec3 RotateX(this Vec3 vector, double degrees) {
            if (degrees == 0) return vector;

            degrees += vector.GetXAngle();
            degrees = degrees.ToRadians();

            double hLength = Math.Sqrt(vector.X * vector.X + vector.Z * vector.Z);

            double x = Math.Sin(degrees) * hLength;
            double z = Math.Cos(degrees) * hLength;

            return new Vec3(x, vector.Y, z);
        }
        public static double GetXAngle(this Vec3 vector) {
            return Math.Atan2(vector.X, vector.Z).ToDegrees();
        }

        public static Vec3 RotateY(this Vec3 vector, double degrees) {
            if (degrees == 0) return vector;

            degrees += Math.Atan2(vector.Y, vector.Z).ToDegrees();
            degrees = degrees.ToRadians();

            double y = Math.Sin(degrees) * vector.Z;
            double h = Math.Cos(degrees);

            return new Vec3(vector.X, y, vector.Z * h);
        }

        private static double ToDegrees(this double radians) {
            return (180 / Math.PI * radians);
        }
        private static double ToRadians(this double degrees) {
            return degrees / 180 * Math.PI;
        }
    }
}
