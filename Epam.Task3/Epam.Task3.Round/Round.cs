using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Round
{
    public class Roundd
    {
        private double pointX;
        private double pointY;
        private double radius;

        public Roundd()
        {

        }
        public Roundd(double x, double y, double r)
        {
            this.PointX = x;
            this.PointY = y;
            this.Radius = r;
        }

        public double PointX { get; set; }
        public double PointY { get; set; }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new Exception("Радиус должен иметь положительное значение");
                }

            }
        }
        
        public double GetLenght()
        {
            return 2 * Math.PI * radius;
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

    }
}
