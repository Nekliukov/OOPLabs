using System.Windows.Forms;
using System.Drawing;
using System;

namespace LR1_Drawing {
    public class Figure {
        protected PictureBox picture;
        protected Graphics graph;
        protected Pen pen;
        public Bitmap bmp;

        public virtual void Draw(params Point[] points) {
            if (points == null) {
                throw new System.ArgumentNullException(nameof(points));
            }
        }

        public virtual void Instructions(RichTextBox info) {}

        public Figure(PictureBox pic) {
            picture = pic;
            pen = new Pen(Color.Black,4);
        }

        protected int GetHypo(int a, int b) { 
            return (int)Math.Sqrt(Math.Pow(Math.Abs(a), 2) + Math.Pow(Math.Abs(b), 2));
        }

        public virtual int GetParNum() { return 2; }

        public void Clear() { graph.Clear(Color.White); }
    }
}
