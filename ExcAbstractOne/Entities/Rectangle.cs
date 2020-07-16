﻿using System;
using System.Collections.Generic;
using System.Text;
using ExcAbstractOne.Entities.Enums;

namespace ExcAbstractOne.Entities
{
    class Rectangle : Shape
    {

        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base (color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            throw new NotImplementedException();
        }
    }
}
