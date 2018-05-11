﻿using System.Drawing;
using System.Windows.Forms;

namespace LR1_Drawing {
    public class Triangle: Figure  {
        public Triangle() : base() { }
        public Triangle(Pen P) : base(P) { }
        public Point thirdp;

        public override int PatNum { get { return 3; }  }
        protected override void SetPoints(Point[] Points) {
            firstp =  Points[0];
            secondp = Points[1];
            thirdp =  Points[2];
        }

        protected override void Draw(Graphics graph) {
            graph.DrawLine(pen, firstp, secondp);
            graph.DrawLine(pen, secondp, thirdp);
            graph.DrawLine(pen, thirdp, firstp);
        }
    }
}
