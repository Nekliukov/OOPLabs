using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1_Drawing {
    class Rectangle : Figure {
        private float x, y, width, height;
        public Rectangle(PictureBox pic, float X, float Y, float Width, float Height) : base(pic) {
            x = X; y = Y;
            width = Width;
            height = Height;           
        }

        public override void Draw() {
            graph.DrawRectangle(pen, x, y, width, height);
            picture.Image = bmp;
        }
    }
}
