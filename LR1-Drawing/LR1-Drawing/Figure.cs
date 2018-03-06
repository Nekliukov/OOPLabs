using System.Windows.Forms;
using System.Drawing;
using System;

namespace LR1_Drawing {
    public class Figure {
        protected PictureBox picture;
        protected Graphics graph;
        protected Pen pen;
        protected Bitmap bmp;

        public virtual void Draw(params Point[] points) {
            if (points == null) {
                throw new System.ArgumentNullException(nameof(points));
            }
        }

        public virtual void Instructions(RichTextBox info) {}

        public Figure(PictureBox pic) {
            picture = pic;
            bmp = new Bitmap(picture.Width, picture.Height);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.Black,4);
        }

        public void Clear() {
            graph.Clear(Color.White);
        }

        public int GetGipo(int a, int b) { 
            return (int)Math.Sqrt(Math.Pow(Math.Abs(a), 2) + Math.Pow(Math.Abs(b), 2));
        }

        public virtual int GetParNum() { return 2; }
    }
}
