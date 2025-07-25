﻿using System;
using System.Windows.Forms;
using System.Drawing;

namespace RayMarchingGUI {
    public class TextAndImageColumn : DataGridViewTextBoxColumn {
        private Image imageValue;
        private Size imageSize;

        public TextAndImageColumn()
        {
            this.CellTemplate = new TextAndImageCell();
        }

        public override object Clone()
        {
            TextAndImageColumn c = base.Clone() as TextAndImageColumn;
            c.imageValue = this.imageValue;
            c.imageSize = this.imageSize;
            return c;
        }

        public Image Image {
            get { return this.imageValue; }
            set {
                if (this.Image != value) {
                    this.imageValue = value;
                    this.imageSize = value.Size;

                    if (this.InheritedStyle != null) {
                        Padding inheritedPadding = this.InheritedStyle.Padding;
                        this.DefaultCellStyle.Padding = new Padding(imageSize.Width,
                     inheritedPadding.Top, inheritedPadding.Right,
                     inheritedPadding.Bottom);
                    }
                }
            }
        }
        private TextAndImageCell TextAndImageCellTemplate {
            get { return this.CellTemplate as TextAndImageCell; }
        }
        internal Size ImageSize {
            get { return imageSize; }
        }
    }

    public class TextAndImageCell : DataGridViewTextBoxCell {
        private Image imageValue;
        private Size imageSize;

        public override object Clone()
        {
            TextAndImageCell c = base.Clone() as TextAndImageCell;
            c.imageValue = this.imageValue;
            c.imageSize = this.imageSize;
            return c;
        }

        public Image Image {
            get {
                if (this.OwningColumn == null ||
            this.OwningTextAndImageColumn == null) {

                    return imageValue;
                } else if (this.imageValue != null) {
                    return this.imageValue;
                } else {
                    return this.OwningTextAndImageColumn.Image;
                }
            }
            set {
                if (this.imageValue != value) {
                    this.imageValue = value;
                    this.imageSize = value.Size;

                    Padding inheritedPadding = this.InheritedStyle.Padding;
                    this.Style.Padding = new Padding(imageSize.Width,
                    inheritedPadding.Top, inheritedPadding.Right,
                    inheritedPadding.Bottom);
                }
            }
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds,
            Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState,
            object value, object formattedValue, string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            cellStyle.Padding = new Padding(cellStyle.Padding.Left + 6, 0, 0, 0);

            // Paint the base content
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState,
               value, formattedValue, errorText, cellStyle,
               advancedBorderStyle, paintParts);

            if (Image != null) {
                int xAdd = (22 - Image.Width) / 2; 
                int yAdd = (22 - Image.Height) / 2; 

                // Draw the image clipped to the cell.
                System.Drawing.Drawing2D.GraphicsContainer container =
                graphics.BeginContainer();

                graphics.SetClip(cellBounds);
                cellBounds.X += 5;
                graphics.DrawImageUnscaled(Image, new Point(cellBounds.X, cellBounds.Y + yAdd));

                graphics.EndContainer(container);
            }
        }

        private TextAndImageColumn OwningTextAndImageColumn {
            get { return this.OwningColumn as TextAndImageColumn; }
        }
    }
}