using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; 
using System.Windows.Forms;

namespace LR1_Drawing {
    class Ellipse : Figure {
        public Ellipse(PictureBox pic) : base(pic) {
        }
        public int par_num = 2;
        private float width, height;

        public override void Draw(params Point[] points) {

            width = Math.Abs(points[0].X - points[1].X);
            height = Math.Abs(points[0].Y - points[1].Y);
            graph.DrawEllipse(pen, points[0].X, points[0].Y, width, height);
            picture.Image = bmp;
        }

        public override void Instructions(RichTextBox info) => info.Text = "Imagine that you are drawing a rectangle: Choose two points,"+
                       " starting from the left top of the rectangle to the right bottom. Around this rectangle will be circumscribed ellipse.";
    }
}
