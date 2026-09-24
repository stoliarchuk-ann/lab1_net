using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class arrays
    {
        public bool error = false;
        private int[] temperatures;
        private int size = 10;

        public int length
        {
            get { return size; }
        }

        public arrays()
        {
            temperatures = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                temperatures[i] = rand.Next(15, 26);
            }
        }

        public arrays(int customSize)
        {
            size = customSize;
            temperatures = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                temperatures[i] = rand.Next(15, 26);
            }
        }

        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < size)
                    return temperatures[i];
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (i >= 0 && i < size)
                    temperatures[i] = value;
                else
                    error = true;
            }
        }

        public int countWarmDays()
        {
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (temperatures[i] >= 20)
                    count++;
            }
            return count;
        }
    }
}
