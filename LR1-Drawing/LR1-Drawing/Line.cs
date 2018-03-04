using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1_Drawing {
    class Line: Figure {
        private Point p1,p2;

        public Line(PictureBox pic) : base(pic) { }


        public override void Draw(Point P1, Point P2) {
            graph.DrawLine(pen, P1, P2);
            picture.Image = bmp;
        }

        public override void Instructions(Label l)
        {
            l.Text = "Starting from the left side, click on the board twice to choose points of the line.";
        }
    }
}
