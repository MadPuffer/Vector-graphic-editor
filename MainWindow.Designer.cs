/*
 * Figures-4
 * Kotdusov B.M 220
 * 30.05.22
 */

namespace Shapes
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnChooseTriangle = new System.Windows.Forms.Button();
            this.btnChooseRectangle = new System.Windows.Forms.Button();
            this.btnChooseCircle = new System.Windows.Forms.Button();
            this.btnChooseLine = new System.Windows.Forms.Button();
            this.DrawCanvas = new System.Windows.Forms.Panel();
            this.Splitter = new System.Windows.Forms.Splitter();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnColorChoise = new System.Windows.Forms.Button();
            this.labelStrokeWidth = new System.Windows.Forms.Label();
            this.textStrokeWidth = new System.Windows.Forms.TextBox();
            this.labelChosenColor = new System.Windows.Forms.Label();
            this.labelChosenShape = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnLoad = new System.Windows.Forms.ToolStripButton();
            this.btnCreateNew = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.DrawCanvas.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChooseTriangle
            // 
            this.btnChooseTriangle.Location = new System.Drawing.Point(1055, 349);
            this.btnChooseTriangle.Name = "btnChooseTriangle";
            this.btnChooseTriangle.Size = new System.Drawing.Size(75, 23);
            this.btnChooseTriangle.TabIndex = 4;
            this.btnChooseTriangle.Text = "Triangle";
            this.btnChooseTriangle.UseVisualStyleBackColor = true;
            this.btnChooseTriangle.Click += new System.EventHandler(this.btnChooseTriangle_Click);
            // 
            // btnChooseRectangle
            // 
            this.btnChooseRectangle.Location = new System.Drawing.Point(1055, 378);
            this.btnChooseRectangle.Name = "btnChooseRectangle";
            this.btnChooseRectangle.Size = new System.Drawing.Size(75, 23);
            this.btnChooseRectangle.TabIndex = 5;
            this.btnChooseRectangle.Text = "Rectangle";
            this.btnChooseRectangle.UseVisualStyleBackColor = true;
            this.btnChooseRectangle.Click += new System.EventHandler(this.btnChooseRectangle_Click);
            // 
            // btnChooseCircle
            // 
            this.btnChooseCircle.Location = new System.Drawing.Point(1055, 320);
            this.btnChooseCircle.Name = "btnChooseCircle";
            this.btnChooseCircle.Size = new System.Drawing.Size(75, 23);
            this.btnChooseCircle.TabIndex = 7;
            this.btnChooseCircle.Text = "Circle";
            this.btnChooseCircle.UseVisualStyleBackColor = true;
            this.btnChooseCircle.Click += new System.EventHandler(this.btnChooseCircle_Click);
            // 
            // btnChooseLine
            // 
            this.btnChooseLine.Location = new System.Drawing.Point(1055, 291);
            this.btnChooseLine.Name = "btnChooseLine";
            this.btnChooseLine.Size = new System.Drawing.Size(75, 23);
            this.btnChooseLine.TabIndex = 8;
            this.btnChooseLine.Text = "Line";
            this.btnChooseLine.UseVisualStyleBackColor = true;
            this.btnChooseLine.Click += new System.EventHandler(this.btnChooseLine_Click);
            // 
            // DrawCanvas
            // 
            this.DrawCanvas.Controls.Add(this.Splitter);
            this.DrawCanvas.Location = new System.Drawing.Point(12, 41);
            this.DrawCanvas.Name = "DrawCanvas";
            this.DrawCanvas.Size = new System.Drawing.Size(1037, 586);
            this.DrawCanvas.TabIndex = 9;
            this.DrawCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCanvas_Paint);
            this.DrawCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawCanvas_MouseDown);
            this.DrawCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawCanvas_MouseMove);
            this.DrawCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawCanvas_MouseUp);
            // 
            // Splitter
            // 
            this.Splitter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Splitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.Splitter.Location = new System.Drawing.Point(1032, 0);
            this.Splitter.Name = "Splitter";
            this.Splitter.Size = new System.Drawing.Size(5, 586);
            this.Splitter.TabIndex = 0;
            this.Splitter.TabStop = false;
            // 
            // btnColorChoise
            // 
            this.btnColorChoise.Location = new System.Drawing.Point(1055, 193);
            this.btnColorChoise.Name = "btnColorChoise";
            this.btnColorChoise.Size = new System.Drawing.Size(75, 39);
            this.btnColorChoise.TabIndex = 10;
            this.btnColorChoise.Text = "Choose color";
            this.btnColorChoise.UseVisualStyleBackColor = true;
            this.btnColorChoise.Click += new System.EventHandler(this.btnColorChoise_Click);
            // 
            // labelStrokeWidth
            // 
            this.labelStrokeWidth.AutoSize = true;
            this.labelStrokeWidth.Location = new System.Drawing.Point(1055, 244);
            this.labelStrokeWidth.Name = "labelStrokeWidth";
            this.labelStrokeWidth.Size = new System.Drawing.Size(78, 15);
            this.labelStrokeWidth.TabIndex = 11;
            this.labelStrokeWidth.Text = "Stroke Width:";
            // 
            // textStrokeWidth
            // 
            this.textStrokeWidth.Location = new System.Drawing.Point(1055, 262);
            this.textStrokeWidth.MaxLength = 10;
            this.textStrokeWidth.Name = "textStrokeWidth";
            this.textStrokeWidth.PlaceholderText = "2";
            this.textStrokeWidth.Size = new System.Drawing.Size(75, 23);
            this.textStrokeWidth.TabIndex = 12;
            // 
            // labelChosenColor
            // 
            this.labelChosenColor.AutoSize = true;
            this.labelChosenColor.BackColor = System.Drawing.SystemColors.Control;
            this.labelChosenColor.Location = new System.Drawing.Point(1136, 205);
            this.labelChosenColor.Name = "labelChosenColor";
            this.labelChosenColor.Size = new System.Drawing.Size(111, 15);
            this.labelChosenColor.TabIndex = 13;
            this.labelChosenColor.Text = "Chosen color: Black";
            // 
            // labelChosenShape
            // 
            this.labelChosenShape.AutoSize = true;
            this.labelChosenShape.Location = new System.Drawing.Point(1138, 295);
            this.labelChosenShape.Name = "labelChosenShape";
            this.labelChosenShape.Size = new System.Drawing.Size(109, 15);
            this.labelChosenShape.TabIndex = 14;
            this.labelChosenShape.Text = "Chosen shape: Line";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnLoad,
            this.btnCreateNew});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1270, 25);
            this.toolStrip.TabIndex = 15;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(35, 22);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(37, 22);
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCreateNew.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateNew.Image")));
            this.btnCreateNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(35, 22);
            this.btnCreateNew.Text = "New";
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "bin";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 632);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.labelChosenShape);
            this.Controls.Add(this.labelChosenColor);
            this.Controls.Add(this.textStrokeWidth);
            this.Controls.Add(this.labelStrokeWidth);
            this.Controls.Add(this.btnColorChoise);
            this.Controls.Add(this.DrawCanvas);
            this.Controls.Add(this.btnChooseLine);
            this.Controls.Add(this.btnChooseCircle);
            this.Controls.Add(this.btnChooseRectangle);
            this.Controls.Add(this.btnChooseTriangle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Editor";
            this.DrawCanvas.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChooseTriangle;
        private System.Windows.Forms.Button btnChooseRectangle;
        private System.Windows.Forms.Button btnChooseCircle;
        private System.Windows.Forms.Button btnChooseLine;
        private System.Windows.Forms.Panel DrawCanvas;
        private System.Windows.Forms.Splitter Splitter;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnColorChoise;
        private System.Windows.Forms.Label labelStrokeWidth;
        private System.Windows.Forms.TextBox textStrokeWidth;
        private System.Windows.Forms.Label labelChosenColor;
        private System.Windows.Forms.Label labelChosenShape;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnLoad;
        private System.Windows.Forms.ToolStripButton btnCreateNew;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

