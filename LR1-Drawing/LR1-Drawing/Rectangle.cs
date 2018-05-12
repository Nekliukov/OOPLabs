using System;
using System.Drawing;

namespace LR1_Drawing {
    public class Rectangle : Figure {
        public Rectangle() : base() { }

        protected override void Draw(Graphics graph) {
            Check_Points(ref firstp, ref secondp);
            float width = Math.Abs(firstp.X - secondp.X);
            float height = Math.Abs(firstp.Y - secondp.Y);
            graph.DrawRectangle(pen, firstp.X, firstp.Y, width, height);
        }
    }
}
