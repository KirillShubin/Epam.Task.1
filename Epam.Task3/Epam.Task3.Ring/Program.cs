using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task3.Round;

namespace Epam.Task3.Ring
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Ring ring = new Ring(5, 3, 10, 20);
                Console.WriteLine("Площадь кольца равна: " + ring.GetRingArea());
                Console.WriteLine("Суммарная длина равна: " + ring.GetSumRingLenght());
                Console.WriteLine("Координаты центра: x = {0}, y = {1} ", ring.PointX, ring.PointY);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
