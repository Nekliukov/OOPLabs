using System.Windows.Forms;
using System.Drawing;
using System;

namespace LR1_Drawing {
    public abstract class Figure {
        protected PictureBox picture;
        protected Graphics graph;
        protected Pen pen;
        protected Bitmap bmp;

        public virtual int PatNum { get { return 2; } }
        
        protected abstract void Draw(params Point[] points);

        public void Do_Draw(params Point[] points) {
            graph = Graphics.FromImage(bmp);
            Draw(points);
            picture.Image = bmp;
        }

        protected Point[] Check_Points(params Point[] P)
        {
            if (P[1].X < P[0].X)
            {
                int temp = P[1].X;
                P[1].X = P[0].X;
                P[0].X = temp;
            }
            if (P[1].Y < P[0].Y)
            {
                int temp = P[1].Y;
                P[1].Y = P[0].Y;
                P[0].Y = temp;
            }
            return P; 
        }

        public abstract void Instructions(RichTextBox info);

        public Figure(PictureBox Pic, Bitmap Bm) {
            bmp = Bm;
            picture = Pic;
            pen = new Pen(Color.Black,4);
        }

        public void Clear() { graph.Clear(Color.White); }
    }
}
