/*
 * Figures-4
 * Kotdusov B.M 220
 * 30.05.22
 */

using System;
using System.Drawing;

namespace Figures
{
    [Serializable]
    public class Circle : FilledFigure
    {
        public Circle(int startX, int startY, int endX, int endY)
            : base(startX, startY, endX, endY)
        {

        }

        public override void Draw(System.Windows.Forms.PaintEventArgs e)
        {
            Pen pen = new Pen(this.Stroke.color, this.Stroke.width);
            float radius = (float) Math.Sqrt(Math.Pow((endX - startX), 2) + Math.Pow((endY - startY), 2));
            e.Graphics.DrawEllipse(pen, startX - radius, startY - radius, radius * 2, radius * 2);
        }

    }
}