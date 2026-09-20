using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class arrays2d
    {
        public bool error = false;
        private int[,] matrix;
        private int size = 5;

        public arrays2d()
        {
            matrix = new int[size, size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rand.Next(-10, 11);
                }
            }
        }

        public int this[int i, int j]
        {
            get
            {
                if (i >= 0 && i < size && j >= 0 && j < size) 
                    return matrix[i, j];
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (i >= 0 && i < size && j >= 0 && j < size)
                    matrix[i, j] = value;
                else
                    error = true;
            }
        }

        public int calculateSumAboveMainDiagobal()
        {
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j > i)
                        sum += matrix[i, j];
                }
            }
            return sum;
        }
    }
}
