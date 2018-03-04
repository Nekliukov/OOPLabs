using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1_Drawing {
    class Rectangle : Figure {
        private float width, height;

        public Rectangle(PictureBox pic) : base(pic) { }

        public override void Draw(Point p1, Point p2) {
            width = Math.Abs(p1.X - p2.X);
            height = Math.Abs(p1.Y - p2.Y);
            height = p2.Y - p1.Y;
            graph.DrawRectangle(pen, p1.X, p1.Y, width, height);
            picture.Image = bmp;
        }
    }
}
