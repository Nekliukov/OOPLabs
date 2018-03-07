﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1_Drawing {
    class Rectangle : Figure {
        private float width, height;
        public int par_num = 2;

        public Rectangle(PictureBox pic) : base(pic) { }

        public override void Draw(params Point[] points) {
            graph = Graphics.FromImage(bmp); width = Math.Abs(points[0].X - points[1].X);
            height = Math.Abs(points[0].Y - points[1].Y);
            graph.DrawRectangle(pen, points[0].X, points[0].Y, width, height);
            picture.Image = bmp;
        }

        public override void Instructions(RichTextBox info) => info.Text = "Choose two points, starting from the left top of the rectangle to the right bottom.";
    }
}
