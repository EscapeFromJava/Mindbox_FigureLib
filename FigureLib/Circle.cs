using System;

namespace FigureLib
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double getArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
