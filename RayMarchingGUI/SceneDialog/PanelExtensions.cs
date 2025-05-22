using System;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;

namespace RayMarchingGUI {
    public static class PanelExtensions {
        public static void DoubleBuffered(this DataGridView dgv, bool setting){
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }
        public static void StripSeparator_Paint(object sender, PaintEventArgs e){
            ToolStripSeparator stripSeparator = sender as ToolStripSeparator;
            ContextMenuStrip menuStrip = stripSeparator.Owner as ContextMenuStrip;

            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(45, 45, 45)), new Rectangle(0, 0, stripSeparator.Width, stripSeparator.Height));
            using (Pen pen = new Pen(Color.LightGray, 1)) {
                e.Graphics.DrawLine(pen, new Point(0, stripSeparator.Height / 2), new Point(menuStrip.Width, stripSeparator.Height / 2));
            }
        }
    }

    class MyToolStripRenderer : ToolStripProfessionalRenderer {
        public MyToolStripRenderer(Color selectionColor, Color itemBorderColor, Color arrowColor )
            : base(new MyColorTable(selectionColor, itemBorderColor)) {

            ArrowColor = arrowColor;
        }

        public Color ArrowColor { get; set; }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            var tsMenuItem = e.Item as ToolStripMenuItem;
            if (tsMenuItem != null)
                e.ArrowColor = ArrowColor;
            base.OnRenderArrow(e);
        }
    }
    class MyColorTable : ProfessionalColorTable {
        public Color _selectionColor;
        public Color _itemBorderColor;

        public MyColorTable(Color selectionColor, Color itemBorderColor) {
            _selectionColor = selectionColor;
            _itemBorderColor = itemBorderColor;
        }

        public override Color MenuItemSelected => _selectionColor;
        public override Color MenuItemBorder => _itemBorderColor;
    }
}
