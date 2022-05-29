
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
            this.components = new System.ComponentModel.Container();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChooseTriangle = new System.Windows.Forms.Button();
            this.btnChooseRectangle = new System.Windows.Forms.Button();
            this.btnChooseCircle = new System.Windows.Forms.Button();
            this.btnChooseLine = new System.Windows.Forms.Button();
            this.DrawCanvas = new System.Windows.Forms.Panel();
            this.Splitter = new System.Windows.Forms.Splitter();
            this.DrawCanvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1055, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1055, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnChooseTriangle
            // 
            this.btnChooseTriangle.Location = new System.Drawing.Point(1055, 251);
            this.btnChooseTriangle.Name = "btnChooseTriangle";
            this.btnChooseTriangle.Size = new System.Drawing.Size(75, 23);
            this.btnChooseTriangle.TabIndex = 4;
            this.btnChooseTriangle.Text = "Triangle";
            this.btnChooseTriangle.UseVisualStyleBackColor = true;
            this.btnChooseTriangle.Click += new System.EventHandler(this.btnChooseTriangle_Click);
            // 
            // btnChooseRectangle
            // 
            this.btnChooseRectangle.Location = new System.Drawing.Point(1055, 280);
            this.btnChooseRectangle.Name = "btnChooseRectangle";
            this.btnChooseRectangle.Size = new System.Drawing.Size(75, 23);
            this.btnChooseRectangle.TabIndex = 5;
            this.btnChooseRectangle.Text = "Rectangle";
            this.btnChooseRectangle.UseVisualStyleBackColor = true;
            this.btnChooseRectangle.Click += new System.EventHandler(this.btnChooseRectangle_Click);
            // 
            // btnChooseCircle
            // 
            this.btnChooseCircle.Location = new System.Drawing.Point(1055, 222);
            this.btnChooseCircle.Name = "btnChooseCircle";
            this.btnChooseCircle.Size = new System.Drawing.Size(75, 23);
            this.btnChooseCircle.TabIndex = 7;
            this.btnChooseCircle.Text = "Circle";
            this.btnChooseCircle.UseVisualStyleBackColor = true;
            this.btnChooseCircle.Click += new System.EventHandler(this.btnChooseCircle_Click);
            // 
            // btnChooseLine
            // 
            this.btnChooseLine.Location = new System.Drawing.Point(1055, 193);
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
            this.DrawCanvas.Location = new System.Drawing.Point(12, 12);
            this.DrawCanvas.Name = "DrawCanvas";
            this.DrawCanvas.Size = new System.Drawing.Size(1037, 566);
            this.DrawCanvas.TabIndex = 9;
            this.DrawCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCanvas_Paint);
            this.DrawCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawCanvas_MouseUp);
            this.DrawCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawCanvas_MouseDown);
            this.DrawCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawCanvas_MouseMove);
            // 
            // Splitter
            // 
            this.Splitter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Splitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.Splitter.Location = new System.Drawing.Point(1032, 0);
            this.Splitter.Name = "Splitter";
            this.Splitter.Size = new System.Drawing.Size(5, 566);
            this.Splitter.TabIndex = 0;
            this.Splitter.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 590);
            this.Controls.Add(this.DrawCanvas);
            this.Controls.Add(this.btnChooseLine);
            this.Controls.Add(this.btnChooseCircle);
            this.Controls.Add(this.btnChooseRectangle);
            this.Controls.Add(this.btnChooseTriangle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Name = "MainWindow";
            this.Text = "Editor";
            this.DrawCanvas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChooseTriangle;
        private System.Windows.Forms.Button btnChooseRectangle;
        private System.Windows.Forms.Button btnChooseCircle;
        private System.Windows.Forms.Button btnChooseLine;
        private System.Windows.Forms.Panel DrawCanvas;
        private System.Windows.Forms.Splitter Splitter;
    }
}

