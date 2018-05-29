﻿using System.Drawing;
using System;
using FigureClassLibrary;
using System.Xml.Serialization;

namespace CircleClassLibrary {
    [XmlInclude(typeof(Circle))]
    public class Circle : Figure {
        public Circle() : base() { }

        protected override void Draw(Graphics graph) {
            int radius = GetHypo(secondp.X - firstp.X, secondp.Y - firstp.Y);
            graph.DrawEllipse(pen, firstp.X - radius, firstp.Y - radius, radius * 2, radius * 2);
        }

        private int GetHypo(int a, int b)
        {
            return (int)Math.Sqrt(Math.Pow(Math.Abs(a), 2) + Math.Pow(Math.Abs(b), 2));
        }
    }
}
