using System.Windows.Forms;
using System.Drawing;

namespace LR1_Drawing {
    class Circle : Figure {
        public Circle(PictureBox pic) : base(pic) { }

        public override void Draw(params Point[] points) {
            graph = Graphics.FromImage(bmp);
            int radius = GetHypo(points[1].X - points[0].X, points[1].Y - points[0].Y);
            graph.DrawEllipse(pen, points[0].X - radius, points[0].Y - radius, radius * 2, radius * 2);
            picture.Image = bmp;
        }

        public override void Instructions(RichTextBox info) => info.Text = "Choose two points. Left one will"+
            "be the center of the circle, length between left && right = radius";
    }
}
