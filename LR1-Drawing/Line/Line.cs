using System;
using System.Drawing;
using FigureClassLibrary;

namespace LineClassLibrary
{
    public class Line: Figure {

    public Line(): base() { }

        protected override void Draw(Graphics graph) {
            graph.DrawLine(pen, firstp, secondp);
        }
    }
}
