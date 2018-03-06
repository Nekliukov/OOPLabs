using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1_Drawing {
    class Line: Figure {

        public Line(PictureBox pic) : base(pic) { }


        public override void Draw(params Point[] points) {
            graph.DrawLine(pen, points[0], points[1]);
            picture.Image = bmp;
        }

        public override void Instructions(RichTextBox info) => info.Text = "Just choose two points :) A line will appear between their";
    }
}
