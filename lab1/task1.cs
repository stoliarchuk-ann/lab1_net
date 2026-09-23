using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class task1
    {
        private double a, b, c;

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public task1()
        {
            a = 0;
            b = 0;
            c = 0;
        }

        public task1(double a)
        {
            this.a = a;
            b = 0;
            c = 0;
        }

        public task1(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double calculate()
        {
            if (a % 2 == 0 && b % 2 == 0 && c % 2 == 0)
                return a * b * c;
            else
                return Math.Pow((a + b + c), 2);
        }
    }
}