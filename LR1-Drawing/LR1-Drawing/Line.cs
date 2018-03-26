using System.Drawing;
using System.Windows.Forms;

namespace LR1_Drawing {
    class Line: Figure {

        public Line(PictureBox pic, Bitmap bmp) : base(pic, bmp) { }

        protected override void Draw(params Point[] points) {
            graph.DrawLine(pen, points[0], points[1]);
        }

        public override void Instructions(RichTextBox info) => info.Text =
            "Just choose two points :) A line will appear between their";
    }
}
