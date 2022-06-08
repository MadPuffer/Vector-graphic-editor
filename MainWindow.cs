/*
 * Figures-4
 * Kotdusov B.M 220
 * 30.05.22
 */

using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Figures;

namespace Shapes
{
    public partial class MainWindow : Form
    {
        bool IsInDrawMode;
        string currentFigureType;
        Color currentStrokeColor = Color.Black;
        Figure currentFigure = new Section(0, 0, 0, 0);
        Canvas canvas; //figures container
        public MainWindow()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance |
                BindingFlags.NonPublic,
                null, DrawCanvas, new object[] { true });
            canvas = new Canvas();

            openFileDialog.FileOk += delegate
            {
                currentFigure = new Section(0, 0, 0, 0);
                canvas.Load(openFileDialog.FileName);
            };
        }


        void DrawCanvas_Paint(object sender, PaintEventArgs e)
        {
            WinformsDrawer drawer = new WinformsDrawer(e);

            if (canvas.GetCount() != 0)
                canvas.Draw(drawer);
            currentFigure.Draw(drawer);

        }

        private void btnChooseLine_Click(object sender, EventArgs e)
        {
            currentFigureType = "Section";
            labelChosenShape.Text = "Chosen shape: Line";
        }

        private void btnChooseCircle_Click(object sender, EventArgs e)
        {
            currentFigureType = "Circle";
            labelChosenShape.Text = $"Chosen shape: {currentFigureType}";
        }

        private void btnChooseTriangle_Click(object sender, EventArgs e)
        {
            currentFigureType = "Triangle";
            labelChosenShape.Text = $"Chosen shape: {currentFigureType}";
        }

        private void btnChooseRectangle_Click(object sender, EventArgs e)
        {
            currentFigureType = "Rectangle";
            labelChosenShape.Text = $"Chosen shape: {currentFigureType}";
        }

        void DrawCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    IsInDrawMode = false;
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
            DrawCanvas.Invalidate();
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (!IsInDrawMode) return;
                    currentFigure.endX = e.X;
                    currentFigure.endY = e.Y;
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
                    currentFigure = new Section(e.X, e.Y, e.X, e.Y);
                    break;
                case "Circle":
                    currentFigure = new Circle(e.X, e.Y, e.X, e.Y);
                    break;
                case "Triangle":
                    currentFigure = new Triangle(e.X, e.Y, e.X, e.Y);
                    break;
                case "Rectangle":
                    currentFigure = new Figures.Rectangle(e.X, e.Y, e.X, e.Y);
                    break;
                default:
                    currentFigure = new Section(e.X, e.Y, e.X, e.Y);
                    break;

            }

            float width;
            if (!float.TryParse(textStrokeWidth.Text, out width))
                width = 2f;
            currentFigure.Stroke = new StrokeData(currentStrokeColor, width);

            switch (e.Button)
            {
                case MouseButtons.Left:
                    currentFigure.startX = e.X;
                    currentFigure.startY = e.Y;
                    IsInDrawMode = true;
                    this.Refresh();
                    break;
                case MouseButtons.Right:
                    break;
                default:
                    break;
            }
        }

        private void btnColorChoise_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            currentStrokeColor = colorDialog.Color;
            labelChosenColor.Text = $"Chosen color: {colorDialog.Color.Name}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (openFileDialog.FileName.Length > 0)
                canvas.Save(openFileDialog.FileName);
            else if (saveFileDialog.ShowDialog() == DialogResult.OK)
                canvas.Save(saveFileDialog.FileName);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // check delegate in constructor for more information
            openFileDialog.ShowDialog();    
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            saveFileDialog.FileName = "New Image";
            canvas.Clear();
            this.currentFigure = new Section(0, 0, 0, 0);
        }
    }
}
