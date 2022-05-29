/*
 * Figures-1
 * Kotdusov B.M 220
 * 10.04.22
 */

using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Figures
{
    [Serializable]
    public class Circle : FilledFigure
    {
        private System.Drawing.Rectangle rect;
        private int Radius { get; }

        public Circle(int startX, int startY, int endX, int endY)
            : base(startX, startY, endX, endY)
        {

        }

        public override void Draw(System.Windows.Forms.PaintEventArgs e, Pen pen)
        {
            rect = System.Drawing.Rectangle.FromLTRB(
                        Math.Min(startX, endX),
                        Math.Min(startY, endY),
                        Math.Max(startX, endX),
                        Math.Max(startY, endY)
                    );
            e.Graphics.DrawEllipse(pen, rect);
        }

    }
}