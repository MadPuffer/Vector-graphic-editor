/*
 * Figures-1
 * Kotdusov B.M 220
 * 10.04.22
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Figures
{
    [Serializable]
    public abstract class Figure
    {
        public int startX, startY, endX, endY;
        public StrokeData Stroke { get; }

        protected Figure(int startX, int startY, int endX, int endY)
        {
            Stroke = new StrokeData("#000000", 2f);
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
        }

        protected Figure(int startX, int startY, int endX, int endY, string HEXStrokeColor, float strokeWidth)
        {
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
            Stroke = new StrokeData(HEXStrokeColor, strokeWidth);
        }

        public abstract void Draw(PaintEventArgs e, Pen pen);

    }

    [Serializable]
    public struct StrokeData
    {
        private string color; // HEX color
        private float width; // Stroke width

        public StrokeData(string color, float width)
        {
            this.color = color;
            this.width = width;
        }
    }
}