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

        public override void Draw(IDrawer drawer)
        {
            drawer.DrawCircle(this);
        }

    }
}