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
    public abstract class FilledFigure : Figure
    {
        protected FillData Fill { get; set; }

        public FilledFigure(int startX, int startY, int endX, int endY) : base(startX, startY, endX, endY)
        {
            Fill = new FillData(Color.White);
        }

        public FilledFigure(int startX, int startY, int endX, int endY, Color strokeColor, int width,
            Color fillColor) : base(startX, startY, endX, endY, strokeColor, width)
        {
            Fill = new FillData(fillColor);
        }
    }

    [Serializable]
    public struct FillData
    {
        private Color color; // fill color in HEX

        public FillData(Color color)
        {
            this.color = color;
        }
    }
}
