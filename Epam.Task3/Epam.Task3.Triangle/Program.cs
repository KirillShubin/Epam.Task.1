using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение стороны а:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение стороны b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение стороны c:");
            double c = double.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(a, b, c);

            Console.WriteLine("Периметр треугольника равен: {0}", triangle.Perimeter());
            Console.WriteLine("Площадь треугольника равна: {0}", triangle.Square());
        }
    }
}
