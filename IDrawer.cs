using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public interface IDrawer
    {
        public void DrawLine(Section obj);
        public void DrawRectangle(Rectangle obj);
        public void DrawCircle(Circle obj);
        public void DrawTriangle(Triangle obj);
    }
}
