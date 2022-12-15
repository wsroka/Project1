namespace Project1
{
    internal class CalculatorBase
    {
        public int ExecuteAddition(int value1, int value2) => value1 + value2;
        public int ExecuteSubtraction(int value1, int value2) => value1 - value2;
        public int ExecuteMultiplication(int value1, int value2) => value1 * value2;
        public int ExecuteDivision(int value1, int value2) => value1 / value2;
    }
}
