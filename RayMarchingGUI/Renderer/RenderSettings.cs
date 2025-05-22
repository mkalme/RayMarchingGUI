using System;
using System.Drawing;
using Newtonsoft.Json.Linq;
using RayMarching;

namespace RayMarchingGUI {
    public class RenderSettings {
        public Color AmbientColor { get; set; } = Color.FromArgb(12, 12, 12);
        public double MaxDistance { get; set; } = 100;
        public double MinDistance { get; set; } = 0.001F;
        public int MaxSteps { get; set; } = 10000;
        public int MaxDepth { get; set; } = 10;
        public double SpecularPow { get; set; } = 100;

        public void ApplySettings(Renderer renderer) {
            renderer.AmbientColor = AmbientColor;
            renderer.MAX_DIST = MaxDistance;
            renderer.MIN_DIST = MinDistance;
            renderer.MAX_STEPS = MaxSteps;
            renderer.MAX_DEPTH = MaxDepth;
            renderer.SPEC_POW = SpecularPow;
        }

        public static RenderSettings FromJson(JToken token) {
            JObject obj = (JObject)token;

            RenderSettings settings = new RenderSettings();

            settings.AmbientColor = ColorExtensions.FromJson(obj["AmbientColor"]);
            settings.MaxDistance = (double)obj["MaxDistance"];
            settings.MinDistance = (double)obj["MinDistance"];
            settings.MaxSteps = (int)obj["MaxSteps"];
            settings.MaxDepth = (int)obj["MaxDepth"];
            settings.SpecularPow = (double)obj["SpecularPow"];

            return settings;
        }
        public JObject ToJson() {
            JObject output = new JObject();

            output.Add("AmbientColor", AmbientColor.ToJson());
            output.Add("MaxDistance", MaxDistance);
            output.Add("MinDistance", MinDistance);
            output.Add("MaxSteps", MaxSteps);
            output.Add("MaxDepth", MaxDepth);
            output.Add("SpecularPow", SpecularPow);

            return output;
        }
    }
}
