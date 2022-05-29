/*
 * Figures-1
 * Kotdusov B.M 220
 * 10.04.22
 */

using System;

namespace Figures
{
    [Serializable]
    public abstract class FilledFigure : Figure
    {
        protected FillData Fill { get; set; }

        public FilledFigure(int startX, int startY, int endX, int endY) : base(startX, startY, endX, endY)
        {
            Fill = new FillData("#000000");
        }

        public FilledFigure(int startX, int startY, int endX, int endY, string HEXStrokeColor, int width,
            string HEXFillColor) : base(startX, startY, endX, endY, HEXStrokeColor, width)
        {
            Fill = new FillData(HEXFillColor);
        }
    }

    [Serializable]
    public struct FillData
    {
        private string color; // fill color in HEX

        public FillData(string HEXColor)
        {
            color = HEXColor;
        }
    }
}
