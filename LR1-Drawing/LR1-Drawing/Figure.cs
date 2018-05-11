using System.Windows.Forms;
using System.Drawing;
using System;

namespace LR1_Drawing {
    public abstract class Figure {
        protected Pen pen;

        public virtual int PatNum { get { return 2; } }
        
        protected abstract void Draw(Graphics graph, params Point[] points);

        public void Do_Draw(Graphics graph, params Point[] points) {
            //graph = Graphics.FromImage(bmp);
            Draw(graph, points);
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

        public Figure(Pen P) {
            pen = P;
        }

        public void Clear() {  }
    }
}
