using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace LR1_Drawing {
    static class FigureList {

        public static List<Object> figures = new List<Object>();

        public static void LoadFigures(Pen p) {
            figures.Add(new Line(p));
            figures.Add(new Rectangle(p));
            figures.Add(new Circle(p));
            figures.Add(new Ellipse(p));
            figures.Add(new Triangle(p));
            figures.Add(new Rhombus(p));
        }
    }
}
