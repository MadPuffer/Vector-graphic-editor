/*
 * Figures-4
 * Kotdusov B.M 220
 * 30.05.22
 */

using System;

namespace Figures
{
    [Serializable]     
    public class Triangle : FilledFigure
    {
        public Triangle(int startX, int startY, int endX, int endY)
            : base(startX, startY, endX, endY)
        {

        }

        public override void Draw(IDrawer drawer)
        {
            drawer.DrawTriangle(this);
        }

    }
}