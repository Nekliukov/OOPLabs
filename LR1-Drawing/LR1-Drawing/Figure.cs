using System.Windows.Forms;
using System.Drawing;
using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace LR1_Drawing {
    [XmlInclude(typeof(Line))]
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Ellipse))]
    [XmlInclude(typeof(Rhombus))]
    [XmlInclude(typeof(Triangle))]
    public abstract class Figure {
        protected Pen pen;
        // XML cannot convert Color type, so the solution
        // is to convert it to Int32 every time u create figure
        public Int32 color;
        public Int32 thikness;
        public Point firstp, secondp;

        //Number of points for each figure (2 is default)
        public virtual int PatNum { get { return 2; } }

        protected abstract void Draw(Graphics graph);

        //First time when we drawing figures
        public void DoDraw(Graphics g, params Point[] p) {
            pen = new Pen(Color.FromArgb(color), thikness);
            SetPoints(p);
            Draw(g);
        }

        //Drawing method, when we using deserialisation
        //Here we already have all points, just need to draw figures again
        public void DoDraw(Graphics g) {
            pen = new Pen(Color.FromArgb(color), thikness);
            Draw(g);
        }

        protected virtual void SetPoints(params Point[] Points) {
            firstp = Points[0];
            secondp = Points[1];
        }

        //Solving of problem with figure's mirror displaying 
        protected void Check_Points(ref Point P0, ref Point P1) {
            if (P1.X < P0.X) {
                int temp = P1.X;
                P1.X = P0.X;
                P0.X = temp;
            }
            if (P1.Y < P0.Y) {
                int temp = P1.Y;
                P1.Y = P0.Y;
                P0.Y = temp;
            }
        }

        // Constructor without params for XML Serialisation
        public Figure() {}

        public object Clone(Int32 C, Int32 T) {
            color = C;
            thikness = T;
            return this.MemberwiseClone();
        }
    }
}
