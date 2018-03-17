using System;
using System.Drawing;
using System.Windows.Forms;

namespace LR1_Drawing {
    class Rectangle : Figure {
        public Rectangle(PictureBox pic) : base(pic) { }

        protected override void Draw(params Point[] points) {
            points = Check_Points(points[0], points[1]);
            float width = Math.Abs(points[0].X - points[1].X);
            float height = Math.Abs(points[0].Y - points[1].Y);
            graph.DrawRectangle(pen, points[0].X, points[0].Y, width, height);
        }

        public override void Instructions(RichTextBox info) => info.Text =
            "Choose two points, starting from the left top of the rectangle to the right bottom.";
    }
}
