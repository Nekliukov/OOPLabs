using System.Drawing;
using System.Windows.Forms;

namespace LR1_Drawing {
    public class Rhombus: Figure {
        public Rhombus() : base() { }
        public Rhombus(Pen P) : base(P) { }

        protected override void Draw(Graphics graph) {
            Check_Points(ref firstp, ref secondp);
            graph.DrawLine(pen, firstp, secondp);
            graph.DrawLine(pen, secondp.X, secondp.Y, firstp.X, firstp.Y-(firstp.Y-secondp.Y)*2);
            graph.DrawLine(pen, firstp.X, firstp.Y - ( firstp.Y - secondp.Y ) * 2,
                                secondp.X - ( secondp.X - firstp.X ) * 2, secondp.Y);
            graph.DrawLine(pen, secondp.X - ( secondp.X - firstp.X ) * 2, secondp.Y,
                                firstp.X, firstp.Y);
        }     
    }
}
    