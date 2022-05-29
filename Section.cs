/*
 * Figures-4
 * Kotdusov B.M 220
 * 30.05.22
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Figures
{
    [Serializable]
    public class Section : Figure
    {
        public Section(int startX, int startY, int endX, int endY)
            : base(startX, startY, endX, endY)
        {

        }

        public override void Draw(System.Windows.Forms.PaintEventArgs e)
        {
            Pen pen = new Pen(this.Stroke.color, this.Stroke.width);
            e.Graphics.DrawLine(pen, startX, startY, endX, endY);
        }

    }
}