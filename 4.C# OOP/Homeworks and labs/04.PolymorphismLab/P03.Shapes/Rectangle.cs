﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height , double width)
        {
            Height = height;
            Width = width;
        }
        public double Height 
        {
            get => height; 
            set
            {
                height = value;
            }
        }
        public double Width
        {
            get => width;
            set
            {
                width = value;
            }
        }
        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override double CalculatePerimeter()
        {
            return (2 * this.Width) + (2 * this.Height);
        }
        public override string Draw()
        {
            return base.Draw() + $" {nameof(Rectangle)}";
        }
    }
}
