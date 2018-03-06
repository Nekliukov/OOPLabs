using System;
using System.Windows.Forms;
using System.Drawing;

namespace LR1_Drawing
{
    class Circle : Figure {
        int radius;
        public int par_num = 2;

        public Circle(PictureBox pic) : base(pic) { }

        public override void Draw(params Point[] points) {
            radius = (int)Math.Sqrt(Math.Pow(points[1].X - points[0].X, 2)
                                  + Math.Pow(points[1].Y - points[0].Y, 2));
            graph.DrawEllipse(pen, points[0].X - radius, points[0].Y - radius, radius * 2, radius * 2);
            picture.Image = bmp;
        }
           public override void Instructions(RichTextBox info) => info.Text = "Choose two points. Left one will"+
            "be the center of the circle, length between left && right = radius";
    }
}
