using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace LR1_Drawing {
    static class FigureList {

        public static List<Object> figures = new List<Object>();

        public static void LoadFigures() {
            figures.Add(new Line());
            figures.Add(new Rectangle());
            figures.Add(new Circle());
            figures.Add(new Ellipse());
            figures.Add(new Triangle());
            figures.Add(new Rhombus());
        }
    }
}
