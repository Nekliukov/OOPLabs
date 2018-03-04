using System.Windows.Forms;
using System.Drawing;

namespace LR1_Drawing
{
    class Circle : Figure {
        int radius;

        public Circle(PictureBox pic) : base(pic) { }

        public override void Draw(Point p1, Point p2) {
            radius = p2.X - p1.X;
            graph.DrawEllipse(pen, p1.X - radius, p1.Y - radius, radius * 2, radius * 2);
            picture.Image = bmp;
        }
    }
}
