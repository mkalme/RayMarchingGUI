using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using RayMarching;
using Vectors;
using ComputerGraphicsExtensions;

namespace RayMarchingGUI {
    public static class ViewHelper {
        public static Image GetIcon(this Shape shape) {
            Type type = shape.GetType();

            if (type == typeof(Sphere)) return Properties.Resources._22pxSphere;
            if (type == typeof(Plane)) return Properties.Resources._22pxPlane;
            if (type == typeof(Torus)) return Properties.Resources._22pxTorus;
            if (type == typeof(Capsule)) return Properties.Resources._22pxCapsule;

            return Properties.Resources._22pxRectangle;
        }
        
        public static Image GetLargeIcon(this Shape shape) {
            return GetLargeIcon(shape.GetType());
        }
        public static Image GetLargeIcon(this Type type) {
            if (type == typeof(Sphere)) return Properties.Resources._64pxSphere;
            if (type == typeof(Plane)) return Properties.Resources._64pxPlane;
            if (type == typeof(Torus)) return Properties.Resources._64pxTorus;
            if (type == typeof(Capsule)) return Properties.Resources._64pxCapsule;

            return Properties.Resources._64pxRectangle;
        }

        public static string GetName(this Shape shape) {
            return GetName(shape.GetType());
        }
        public static string GetName(this Type type) {
            if (type == typeof(Sphere)) return "Sphere";
            if (type == typeof(Plane)) return "Plane";
            if (type == typeof(Torus)) return "Torus";
            if (type == typeof(Capsule)) return "Capsule";

            return "Rectangle";
        }

        public static string ResolutionToString(int width, int height) {
            return $"{width}; {height}";
        }
        public static void ToResolution(this string value, out int width, out int height) {
            string[] values = Regex.Replace(value, @"\s+", "").Split(';');

            width = int.Parse(values[0]);
            height = int.Parse(values[1]);
        }
        public static string ParseNumber(this double value) {
            string[] suffix = { "", "K", "M", "B", "T" };
            int log = (int)(uint)Math.Min(Math.Log(value, 1000), suffix.Length - 1);

            return $"{value / Math.Pow(1000, log)}{suffix[log]}".Replace(",", ".");
        }
        public static double ToDouble(this string value) {
            return double.Parse(value.Replace(".", ","));
        }

        public static void SelectItem<T>(this DataGridView gridView, T item, IList<T> list) {
            if (item == null) return;

            for (int i = 0; i < gridView.Rows.Count; i++) {
                var row = gridView.Rows[i];

                int index = (int)row.Cells[0].Value;
                if (!Object.ReferenceEquals(item, list[i])) continue;

                row.Selected = true;
                return;
            }
        }
    }

    public static class SceneExtensions {
        //Load
        public static Scene FromJson(string json, out RenderSettings settings) {
            JObject obj = JObject.Parse(json);

            Scene scene = Scene.FromJSON(json);

            //Camera
            scene.Camera = new CustomCamera(scene.Camera);

            JObject cameraObj = (JObject)obj["Camera"];

            JToken rotationXToken;
            if (cameraObj.TryGetValue("RotationX", out rotationXToken)) {
                ((CustomCamera)scene.Camera).RotationX = (double)rotationXToken;

            }

            JToken rotationYToken;
            if (cameraObj.TryGetValue("RotationY", out rotationYToken)) {
                ((CustomCamera)scene.Camera).RotationY = (double)rotationYToken;
            }

            JToken renderSettingsToken;
            if (obj.TryGetValue("RenderSettings", out renderSettingsToken)) {
                settings = RenderSettings.FromJson(renderSettingsToken);
            } else {
                settings = new RenderSettings();
            }

            return scene;
        }

        //Scene
        public static JObject ToJson(this Scene scene, RenderSettings settings) {
            JObject output = new JObject();

            JArray lightSources = new JArray();
            foreach (var lightSource in scene.LightSources) {
                lightSources.Add(lightSource.ToJson());
            }

            JArray shapes = new JArray();
            foreach (var shape in scene.Shapes) {
                shapes.Add(shape.ToJson());
            }

            output.Add("LightSources", lightSources);
            output.Add("Shapes", shapes);
            output.Add("Camera", ((CustomCamera)scene.Camera).ToJson());
            output.Add("RenderSettings", settings.ToJson());

            return output;
        }
        public static JObject ToJson(this CustomCamera camera) {
            JObject output = new JObject();

            output.Add("Width", camera.Width);
            output.Add("Height", camera.Height);
            output.Add("FocalLength", camera.FocalLength);
            output.Add("RotationX", camera.RotationX);
            output.Add("RotationY", camera.RotationY);
            output.Add("Pos", camera.Pos.ToJson());

            return output;
        }

        //LightSource
        public static JObject ToJson(this LightSource lightSource) {
            JObject output = new JObject();

            output.Add("Pos", lightSource.Pos.ToJson());
            output.Add("Lumens", lightSource.Lumens);

            return output;
        }

        //Shape
        public static JObject ToJson(this Shape shape) {
            Type type = shape.GetType();

            if (type == typeof(Sphere)) return (shape as Sphere).ToJson();
            if (type == typeof(Plane)) return (shape as Plane).ToJson();
            if (type == typeof(Torus)) return (shape as Torus).ToJson();
            if (type == typeof(RayMarching.Rectangle)) return (shape as RayMarching.Rectangle).ToJson();
            if (type == typeof(Capsule)) return (shape as Capsule).ToJson();

            return null;
        }
        public static JObject ToJson(this ShapeProperties properties) {
            JObject output = new JObject();

            output.Add("Color", properties.Color.ToJson());
            output.Add("ReflectionIndex", properties.ReflectionIndex);
            output.Add("RefractionIndex", properties.RefractionIndex);
            output.Add("DiffusionIndex", properties.DiffusionIndex);

            return output;
        }

        public static JObject ToJson(this Sphere sphere) {
            JObject output = new JObject();

            output.Add("ShapeType", "Sphere");

            output.Add("Pos", sphere.Pos.ToJson());
            output.Add("Radius", sphere.Radius);

            output.Add("Properties", sphere.Properties.ToJson());

            return output;
        }
        public static JObject ToJson(this Plane plane) {
            JObject output = new JObject();

            output.Add("ShapeType", "Plane");

            output.Add("W", plane.Pos.GetPlaneW(plane.Type));
            output.Add("PlaneType", plane.Type.ToString());

            output.Add("Properties", plane.Properties.ToJson());

            return output;
        }
        public static JObject ToJson(this Torus torus) {
            JObject output = new JObject();

            output.Add("ShapeType", "Torus");

            output.Add("Pos", torus.Pos.ToJson());
            output.Add("Radius1", torus.Radius1);
            output.Add("Radius2", torus.Radius2);

            output.Add("Properties", torus.Properties.ToJson());

            return output;
        }
        public static JObject ToJson(this RayMarching.Rectangle rectangle) {
            JObject output = new JObject();

            output.Add("ShapeType", "Rectangle");

            output.Add("Pos1", new Vec2(rectangle.Pos.X, rectangle.Pos.Z).ToJson());
            output.Add("Pos2", new Vec2(rectangle.Pos2.X, rectangle.Pos2.Z).ToJson());
            output.Add("W", rectangle.Pos.Y);

            output.Add("Properties", rectangle.Properties.ToJson());

            return output;
        }
        public static JObject ToJson(this Capsule capsule) {
            JObject output = new JObject();

            output.Add("ShapeType", "Capsule");

            output.Add("Pos1", capsule.Pos.ToJson());
            output.Add("Pos2", capsule.Pos2.ToJson());
            output.Add("Radius", capsule.Radius);

            output.Add("Properties", capsule.Properties.ToJson());

            return output;
        }
    }

    public static class ColorExtensions {
        public static JObject ToJson(this Color color) {
            JObject output = new JObject();

            output.Add("R", color.R);
            output.Add("G", color.G);
            output.Add("B", color.B);

            return output;
        }
        public static Color FromJson(JToken token) {
            JObject obj = (JObject)token;

            return Color.FromArgb((int)obj["R"], (int)obj["G"], (int)obj["B"]);
        }
    }

    public static class VectorExtensions {
        public static string ConvertToString(this Vec3 vector) {
            return ($"{vector.X}; {vector.Y}; {vector.Z}").Replace(",", ".");
        }
        public static Vec3 FromString(string value) {
            value = value.Replace(".", ",");

            string[] values = Regex.Replace(value, @"\s+", "").Split(';');

            return new Vec3(double.Parse(values[0]), double.Parse(values[1]), double.Parse(values[2]));
        }

        public static JObject ToJson(this Vec3 vector) {
            JObject output = new JObject();

            output.Add("X", vector.X);
            output.Add("Y", vector.Y);
            output.Add("Z", vector.Z);

            return output;
        }
        public static JObject ToJson(this Vec2 vector) {
            JObject output = new JObject();

            output.Add("X", vector.X);
            output.Add("Y", vector.Y);

            return output;
        }

        public static Vec3 GetPlaneVector(double w, PlaneType type) {
            if (type == PlaneType.X)
                return new Vec3(w, 0, 0);
            else if (type == PlaneType.Z)
                return new Vec3(0, 0, w);

            return new Vec3(0, w, 0);
        }
        public static double GetPlaneW(this Vec3 vec, PlaneType type) {
            if (type == PlaneType.X)
                return vec.X;
            else if (type == PlaneType.Z)
                return vec.Z;

            return vec.Y;
        }
    }
}
