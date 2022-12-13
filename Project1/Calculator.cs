﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Calculator
    {
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }
        public int Subtract(int value1, int value2)
        {
            return value1 - value2;
        }
        public int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }
        public int Divide(int value1, int value2)
        {
            return value1 / value2;
        }
        public bool isPrimeNumber(int value1)
        {
            if (value1 <= 0)
            {
                return false;
            }
            else
            {
                for (int i = value1 - 1; i > 1; i--)
                {
                    if (i % 2 == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public int Factorial(int value1)
        {
            if (value1 == 0)
            {
                return 1;
            }
            else if (value1 > 0)
            {
                int mark = 1;
                for (int i = value1; i > 0; i--)
                {
                    mark *= i;
                }
                return mark;
            }
            return 0;
        }
        public bool IsPerfectNumber(int value1)
        {
            int mark = 0;
            for (int i = value1 - 1; i > 0; i--)
            {
                if (value1 % i == 0)
                {
                    mark += i;
                }
            }
            if (value1 == mark)
            {
                return true;
            }
            return false;
        }
        public int AverageNumber(int[] tab)
        {
            int average = 0;
            int counter = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                average += tab[i];
                counter++;
            }
            return average / counter;
        }
        public int MaxValue(int[] tab)
        {
            int max = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > max)
                {
                    max = tab[i];
                }
            }
            return max;
        }
        public int MinValue(int[] tab)
        {
            int min = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] < min)
                {
                    min = tab[i];
                }
            }
            return min;
        }
    }
}
    
