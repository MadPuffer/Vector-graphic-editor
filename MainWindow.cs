/*
 * Figures-4
 * Kotdusov B.M 220
 * 30.05.22
 */

using System;
using System.Drawing;
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
            canvas = new Canvas();

            openFileDialog.FileOk += delegate
            {
                currentFigure = new Section(0, 0, 0, 0);
                canvas.Load(openFileDialog.FileName);
                this.Refresh();
            };
        }


        void DrawCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (canvas.GetCount() != 0)
                canvas.Draw(e);
            currentFigure.Draw(e);

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
            openFileDialog.ShowDialog();    
            this.Refresh();
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            saveFileDialog.FileName = "New Image";
            canvas.Clear();
            this.currentFigure = new Section(0, 0, 0, 0);
            this.Refresh();
        }
    }
}
