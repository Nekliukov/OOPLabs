using System.Drawing;
using System.Windows.Forms;

namespace LR1_Drawing {
    class Triangle: Figure  {
        public Triangle(PictureBox pic) : base(pic) { }

        public override int PatNum { get { return 3; }  }

        public override void Instructions(RichTextBox info) => info.Text =
           "Choose three points, lines will be connect with them";

        protected override void Draw(params Point[] points) {
            graph.DrawLine(pen, points[0], points[1]);
            graph.DrawLine(pen, points[1], points[2]);
            graph.DrawLine(pen, points[2], points[0]);
        }
    }
}
