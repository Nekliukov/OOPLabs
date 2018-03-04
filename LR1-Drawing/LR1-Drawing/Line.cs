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
        public Line(PictureBox pic, Point P1, Point P2) : base(pic) {
            p1 = P1;
            p2 = P2;
        }

        public override void Draw() {
            graph.DrawLine(pen, p1, p2);
            picture.Image = bmp;
        }
    }
}
