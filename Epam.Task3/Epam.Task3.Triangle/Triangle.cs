using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Triangle
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            get { return a; }
            set
            {
                if (value > 0)
                {
                    a = value;
                }
                else
                {
                    throw new Exception("Значение должно быть положительным числом");
                }
            }
        }

        public double B
        {
            get { return b; }
            set
            {
                if (value > 0)
                {
                    b = value;
                }
                else
                {
                    throw new Exception("Значение должно быть положительным числом");
                }
            }
        }
        public double C
        {
            get { return c; }
            set
            {
                if (value > 0)
                {
                    c = value;
                }
                else
                {
                    throw new Exception("Значение должно быть положительным числом");
                }
            }
        }

        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public double Perimeter()
        {
            return (a + b + c);
        }

        public double Square()
        {
            //pp - полупериметр, вспомогательная величина для вычисления площади
            double pp = (a + b + c) / 2;
            return Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
        }
    }
}
