using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace LR1_Drawing {
    static class FigureList {

        public static List<Object> figures = new List<Object>();

        public static void LoadFigures(PictureBox picture, Bitmap bm) {
            figures.Add(new Line(picture, bm));
            figures.Add(new Rectangle(picture, bm));
            figures.Add(new Circle(picture, bm));
            figures.Add(new Ellipse(picture, bm));
            figures.Add(new Triangle(picture, bm));
            figures.Add(new Rhombus(picture,bm));
        }
    }
}
