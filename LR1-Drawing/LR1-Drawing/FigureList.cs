using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LR1_Drawing {
    static class FigureList {

        public static List<Object> figures = new List<Object>();

        public static void LoadFigures(PictureBox picture) {
            figures.Add(new Line(picture));
            figures.Add(new Rectangle(picture));
            figures.Add(new Circle(picture));
            figures.Add(new Ellipse(picture));
            figures.Add(new Triangle(picture));
            figures.Add(new Rhombus(picture));
        }
    }
}
