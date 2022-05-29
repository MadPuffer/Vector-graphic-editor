using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figures;

namespace Shapes
{
    public partial class MainWindow : Form
    {
        bool IsInDrawMode;
        string currentFigureType;
        Figure currentFigure = new Section(0, 0, 0, 0);
        Pen solidpen = new Pen(Color.Black, 2f);
        Canvas canvas;//figures container
        public MainWindow()
        {
            InitializeComponent();
            canvas = new Canvas();
        }


        void DrawCanvas_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = solidpen;
            if (canvas.GetCount() != 0)
                canvas.Draw(e, pen);

            currentFigure.Draw(e, pen);
            
        }

        private void btnChooseLine_Click(object sender, EventArgs e)
        {
            currentFigureType = "Section";
        }

        private void btnChooseCircle_Click(object sender, EventArgs e)
        {
            currentFigureType = "Circle";
        }

        private void btnChooseTriangle_Click(object sender, EventArgs e)
        {
            currentFigureType = "Triangle";
        }

        private void btnChooseRectangle_Click(object sender, EventArgs e)
        {
            currentFigureType = "Rectangle";
        }

        void DrawCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    IsInDrawMode = false;
                    this.Refresh();
                    canvas.Add(currentFigure);
                    break;
                case MouseButtons.Right:
                    break;
                default:
                    break;
            }
        }

        void DrawCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (!IsInDrawMode) return;
                    currentFigure.endX = e.X;
                    currentFigure.endY = e.Y;
                    this.Refresh();
                    break;
                case MouseButtons.Right:
                    break;
                default:
                    break;
            }
        }

        void DrawCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            switch (currentFigureType)
            {
                case "Line":
                    currentFigure = new Section(0, 0, 0, 0);
                    break;
                case "Circle":
                    currentFigure = new Circle(0, 0, 0, 0);
                    break;
                case "Triangle":
                    currentFigure = new Triangle(0, 0, 0, 0);
                    break;
                case "Rectangle":
                    currentFigure = new Figures.Rectangle(0, 0, 0, 0);
                    break;
                default:
                    currentFigure = new Section(0, 0, 0, 0);
                    break;

            }


            switch (e.Button)
            {
                case MouseButtons.Left:
                    currentFigure.startX = e.X;
                    currentFigure.startY = e.Y;
                    IsInDrawMode = true;
                   
                    break;
                case MouseButtons.Right:
                    break;
                default:
                    break;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
