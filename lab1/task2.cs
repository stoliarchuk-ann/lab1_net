using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class task2
    {
        private int a, b;

        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }

        public task2()
        {
            a = 0;
            b = 0;
        }

        public task2(int a)
        {
            this.a = a;
            b = 0;
        }

        public task2(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int calculateSum()
        {
            int sum = 0;

            if (a > b)
                throw
                    new ArgumentOutOfRangeException("а повинно бути менше за b");
            if (a == b)
                return 0;
            else
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 15 == 0 && i % 7 == 5)
                        sum += i;
                }
                return sum;
            }
        }
    }
}
