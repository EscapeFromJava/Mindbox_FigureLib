using System;

namespace FigureLib
{
    public class Triangle : Figure
    {
        public double Edge1 { get; set; }
        public double Edge2 { get; set; }
        public double Edge3 { get; set; }

        public Triangle(double edge1, double edge2, double edge3)
        {
            if (edge1 + edge2 > edge3 && edge2 + edge3 > edge1 && edge1 + edge3 > edge2)
            {
                Edge1 = edge1;
                Edge2 = edge2;
                Edge3 = edge3;
            }
        }

        public override double getArea()
        {
            double p = (Edge1 + Edge2 + Edge3) / 2;
            return Math.Sqrt(p * (p - Edge1) * (p - Edge2) * (p - Edge3));
        }

        public bool isRight()
        {
            return Math.Pow(Edge1, 2) == (Math.Pow(Edge2, 2) + Math.Pow(Edge3, 2)) ||
                   Math.Pow(Edge2, 2) == (Math.Pow(Edge3, 2) + Math.Pow(Edge1, 2)) ||
                   Math.Pow(Edge3, 2) == (Math.Pow(Edge1, 2) + Math.Pow(Edge2, 2));
        }
    }
}
