using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LR1_Drawing {
    class Triangle: Figure  {
        public Triangle(PictureBox pic) : base(pic) {
        }

        public override int GetParNum()
        {
            return 3;
        }

        public override void Draw(params Point[] points) {
            graph = Graphics.FromImage(bmp);
            graph.DrawLine(pen, points[0], points[1]);
            graph.DrawLine(pen, points[1], points[2]);
            graph.DrawLine(pen, points[2], points[0]);
            picture.Image = bmp;
        }
    }
}
