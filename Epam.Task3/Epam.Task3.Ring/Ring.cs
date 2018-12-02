using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task3.Round;

namespace Epam.Task3.Ring
{
    internal class Ring : Roundd
    {
        public Ring(double x, double y, double innerR, double outerR)
        {
            this.PointX = x;
            this.PointY = y;
            if (innerR <= 0 || outerR <= 0)
            {
                throw new Exception("Радиус должен быть положительным");
            }
            if (innerR >= outerR)
            {
                throw new Exception("Внешний радиус должен быть больше, чем внутренний");
            }
            this.Inner = new Roundd(x, y, innerR);
            this.Outer = new Roundd(x, y, outerR);
        }

        public Roundd Inner { get; set; }
        public Roundd Outer { get; set; }
        public double GetRingArea()
        {
            return Outer.GetArea() - Inner.GetArea();
        }
        public double GetSumRingLenght()
        {
            return Outer.GetLenght() + Inner.GetLenght();
        }
    }
}
