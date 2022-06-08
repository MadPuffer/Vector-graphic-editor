/*
 * Figures-4
 * Kotdusov B.M 220
 * 30.05.22
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
        public StrokeData Stroke { get; set; }

        protected Figure(int startX, int startY, int endX, int endY)
        {
            Stroke = new StrokeData(Color.Black, 2f);
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
        }

        protected Figure(int startX, int startY, int endX, int endY, Color strokeColor, float strokeWidth)
        {
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
            Stroke = new StrokeData(strokeColor, strokeWidth);
        }

        public abstract void Draw(IDrawer drawer);

    }

    [Serializable]
    public struct StrokeData
    {
        public Color color; //stroke color
        public float width; // Stroke width

        public StrokeData(Color color, float width)
        {
            this.color = color;
            this.width = width;
        }
    }
}