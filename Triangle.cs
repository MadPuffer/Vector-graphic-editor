/*
 * Figures-1
 * Kotdusov B.M 220
 * 10.04.22
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Figures
{
    [Serializable]     
    public class Triangle : FilledFigure
    {
        public Triangle(int startX, int startY, int endX, int endY)
            : base(startX, startY, endX, endY)
        {

        }

        public override void Draw(System.Windows.Forms.PaintEventArgs e, Pen pen)
        {
            e.Graphics.DrawPolygon(pen, new System.Drawing.Point[]
                {
                    new System.Drawing.Point(startX, startY),
                    new System.Drawing.Point((endX + startX) / 2, endY),
                    new System.Drawing.Point(endX, startY)
                });
        }

    }
}