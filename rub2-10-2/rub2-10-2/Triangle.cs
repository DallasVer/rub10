using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace rub2_10_2
{
    internal class Triangle
    {
        public double[] Side { get; set; }

        public Triangle(double[] first)
        {
            Side = first;
        }

        public double Perimeter()
        {
            double sum = 0;
            foreach (var item in Side)
            {
                sum = sum + item;
            }
            return sum;
        }

        public void Squares()
        {
            double p = Perimeter();
            double squares = Math.Sqrt(p * (p - Side[0]) * (p - Side[1]) * (p - Side[2]));
            Console.WriteLine(squares);
        }
        public void MedianIntersectionPoint()
        {
            double x = Perimeter() / 3;
            double y = Math.Sqrt(2 * Math.Pow(Side[0], 2) - 2 * Math.Pow(Side[1], 2) - Math.Pow(Side[2], 2)) / 4;
            Console.WriteLine($"Точка {x} и {y}, являются точками пересеченяи.");
        }
    }
}
