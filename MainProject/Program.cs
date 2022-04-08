using FigureLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle(3, 4, 5);
            Console.WriteLine(t.getArea());
            Console.WriteLine(t.isRight());
            Console.ReadLine();
        }
    }
}
