using System;
using System.Drawing;

namespace LR1_Drawing {
    public class Line: Figure {

    public Line(): base() { }

        protected override void Draw(Graphics graph) {
            graph.DrawLine(pen, firstp, secondp);
        }
    }
}
