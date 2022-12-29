namespace Project1
{
    internal class AdvancedCalculator
    {
        public bool IsPrimeNumber(int value)
        {
            if (value < 2)
                return false;

            for (int i = 2; i < value; i++)
            {
                if (i % 2 == 0)
                {
                    return false;

                }
            }
            return true;
        }
        public int GetFactorial(int value)
        {
            int factorial = 1;
            for (int i = value; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
        public bool IsPerfectNumber(int value)
        {
            int sumOfDivisors = 0;
            for (int i = 1; i < value; i++)
            {
                if (value % i == 0)
                {
                    sumOfDivisors += i;
                }
            }
            if (value == sumOfDivisors)
            {
                return true;
            }
            return false;
        }
        public int GetAverageNumber(int[] array)
        {
            int average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                average += array[i];
            }
            return average / array.Length;
        }
        public int GetMaxValue(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        public int GetMinValue(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
    }
}

