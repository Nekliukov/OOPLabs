using System;
using System.Drawing;
using FigureClassLibrary;

namespace TriangleClassLibrary
{
    public class Triangle: Figure  {
        public Triangle() : base() { }
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
