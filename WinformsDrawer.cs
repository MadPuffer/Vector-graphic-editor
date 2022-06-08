using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    [Serializable]
    internal class WinformsDrawer : IDrawer
    {
        private readonly PaintEventArgs _e;

        public WinformsDrawer(PaintEventArgs e)
        {
            _e = e;
        }

        void IDrawer.DrawLine(Section obj)
        {
            Pen pen = new Pen(obj.Stroke.color, obj.Stroke.width);
            _e.Graphics.DrawLine(pen, obj.startX, obj.startY, obj.endX, obj.endY);
        }

        void IDrawer.DrawCircle(Circle obj)
        {
            Pen pen = new Pen(obj.Stroke.color, obj.Stroke.width);
            float radius = (float)Math.Sqrt(Math.Pow((obj.endX - obj.startX), 2) + Math.Pow((obj.endY - obj.startY), 2));
            _e.Graphics.DrawEllipse(pen, obj.startX - radius, obj.startY - radius, radius * 2, radius * 2);
        }

        void IDrawer.DrawRectangle(Rectangle obj)
        {
            Pen pen = new Pen(obj.Stroke.color, obj.Stroke.width);
            _e.Graphics.DrawRectangle(
                pen, 
                System.Drawing.Rectangle.FromLTRB(
                    Math.Min(obj.startX, obj.endX),
                    Math.Min(obj.startY, obj.endY),
                    Math.Max(obj.startX, obj.endX),
                    Math.Max(obj.startY, obj.endY)
                ));
        }

        void IDrawer.DrawTriangle(Triangle obj)
        {
            Pen pen = new Pen(obj.Stroke.color, obj.Stroke.width);
            _e.Graphics.DrawPolygon(pen, new System.Drawing.Point[]
                {
                    new System.Drawing.Point(obj.startX, obj.startY),
                    new System.Drawing.Point((obj.endX + obj.startX) / 2, obj.endY),
                    new System.Drawing.Point(obj.endX, obj.startY)
                });
        }
    }
}
