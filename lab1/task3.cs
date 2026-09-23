using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class task3
    {
        private double R, r;

        public double big_r
        {
            get { return R; }
            set { R = value; }
        }

        public double small_r
        {
            get { return r; }
            set { r = value; }
        }

        public task3()
        {
            R = 0;
            r = 0;
        }

        public task3(double R)
        {
            this.R = R;
            r = 0;
        }

        public task3(double R, double r)
        {
            this.R = R;
            this.r = r;
        }

        public double calculateArea()
        {
            if (R <= r || R <= 0 || r <= 0)
                throw
                   new ArgumentOutOfRangeException("Неправильні радіуси");
            else
                return Math.PI * (R * R - r * r);
        }

        public double calculateAvgRadius()
        {
            if (R < 0 || r < 0)
                throw
                   new ArgumentOutOfRangeException("Неправильні радіуси");
            else 
                return (R + r) / 2.0;
        }

        public double calculateWidth()
        {
            if (R < r || R < 0 || r < 0)
                throw
                    new ArgumentOutOfRangeException("Неправильні радіуси");
            if (R == r)
                return 0;
            else 
                return R - r;
        }
    }
}
