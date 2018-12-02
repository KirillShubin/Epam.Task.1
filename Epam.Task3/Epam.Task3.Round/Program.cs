using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Round
{
    class Program
    {
        static void Main(string[] args)
        {
            Roundd round = new Roundd(2, -2, 10);
            Console.WriteLine("Длина окружности равна: " + round.GetLenght());
            Console.WriteLine("Площадь круга равна: " + round.GetArea());
            Console.WriteLine("Координаты центра: x = {0}, y = {1} ", round.PointX, round.PointY);
        }
    }
}
