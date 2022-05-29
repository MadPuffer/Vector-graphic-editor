/*
 * Figures-4
 * Kotdusov B.M 220
 * 30.05.22
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Figures
{
    class Canvas
    {
        private List<Figure> figures = new();

        public void Add(Figure figure)
        {
            figures.Add(figure);
        }

        public void Add(List<Figure> figures)
        {
            foreach (var figure in figures)
            {
                this.figures.Add(figure);
            }
        }

        public int GetCount()
        {
            return this.figures.Count;
        }

        public void Draw(PaintEventArgs e)
        {
            foreach (var figure in this.figures)
            {
                figure.Draw(e);
            }
        }

        public void Clear()
        {
            this.figures.Clear();
        }

        public void Save(string filePath)
        {
            try
            {
                using (Stream stream = File.Open(filePath, FileMode.Create))
                {
                    var binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(stream, figures);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Load(string filePath)
        {
            try
            {
                using (Stream stream = File.Open(filePath, FileMode.Open))
                {
                    var binaryFormatter = new BinaryFormatter();
                    figures = (List<Figure>) binaryFormatter.Deserialize(stream);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<Figure> GetFigures()
        {
            return figures;
        }
    }
}