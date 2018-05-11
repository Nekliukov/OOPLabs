using System;
using System.Drawing;
using System.Windows.Forms;

namespace LR1_Drawing {
    class Ellipse : Figure {
        public Ellipse(Pen P) : base(P) { }

        protected override void Draw(Graphics graph, params Point[] points) {
            points = Check_Points(points[0], points[1]);
            float width = Math.Abs(points[0].X - points[1].X);
            float height = Math.Abs(points[0].Y - points[1].Y);
            graph.DrawEllipse(pen, points[0].X, points[0].Y, width, height);
        }

        public override void Instructions(RichTextBox info) => info.Text = "Imagine that you are drawing a rectangle: Choose two points,"+
                       " starting from the left top of the rectangle to the right bottom. Around this rectangle will be circumscribed ellipse.";
    }
}
