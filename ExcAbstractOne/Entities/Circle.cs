using System;
using System.Collections.Generic;
using System.Text;
using ExcAbstractOne.Entities.Enums;
using System.M
namespace ExcAbstractOne.Entities
{
    class Circle : Shape
    {
        public double Rad { get; set; }

        public Circle(double rad, Color color) : base (color)
        {
            Rad = rad;
        }

        public override double Area()
        {
            return Math.PI * Math.Sqrt(Rad);
                
        }
    }
}
