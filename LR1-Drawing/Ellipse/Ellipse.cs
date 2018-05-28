using System;
using System.Drawing;
using FigureClassLibrary;

namespace EllipseClassLibrary {
    public class Ellipse : Figure {
        public Ellipse() : base() { }

        protected override void Draw(Graphics graph) {
            Check_Points(ref firstp, ref secondp);
            float width = Math.Abs(firstp.X - secondp.X);
            float height = Math.Abs(firstp.Y - secondp.Y);
            graph.DrawEllipse(pen, firstp.X, firstp.Y, width, height);
        }
    }
}
