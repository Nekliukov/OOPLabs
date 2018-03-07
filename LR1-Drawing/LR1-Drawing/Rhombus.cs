﻿using System.Drawing;
using System.Windows.Forms;

namespace LR1_Drawing {
    class Rhombus: Figure {
        public Rhombus(PictureBox pic) : base(pic) { }

        public override void Draw(params Point[] points) {
            graph = Graphics.FromImage(bmp);
            graph.DrawLine(pen, points[0], points[1]);
            graph.DrawLine(pen, points[1].X, points[1].Y, points[0].X, points[0].Y-(points[0].Y-points[1].Y)*2);
            graph.DrawLine(pen, points[0].X, points[0].Y - ( points[0].Y - points[1].Y ) * 2,
                                points[1].X - ( points[1].X - points[0].X ) * 2, points[1].Y);
            graph.DrawLine(pen, points[1].X - ( points[1].X - points[0].X ) * 2, points[1].Y,
                                points[0].X, points[0].Y);
            picture.Image = bmp;
        }

        public override void Instructions(RichTextBox info) {
            info.Text= "Choose two points, that will be the edge of the rhomus";
        }
    }
}
    