using Project1;

internal class Program
{
    private static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.ShowMainMenu();
        Console.Write("\nWybierz numer z menu głównego: ");
        int baseOption = Convert.ToInt32(Console.ReadLine());

        if (baseOption == 1)
        {
            CalculatorBase calculatorbase = new CalculatorBase();
            menu.ShowBaseCalculatorMenu();
            Console.Write("\nWybierz numer z menu prostego kalkulatora: ");
            int baseCalculatorOption = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (baseCalculatorOption == 1)
            {
                Console.Write("Podaj pierwszą liczbę: ");
                int value1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj drugą liczbę: ");
                int value2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wynik dodawania: " + calculatorbase.ExecuteAddition(value1, value2));
            }
            else if (baseCalculatorOption == 2)
            {
                Console.Write("Podaj pierwszą liczbę: ");
                int value1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj drugą liczbę: ");
                int value2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wynik odejmowania: " + calculatorbase.ExecuteSubtraction(value1, value2));
            }
            else if (baseCalculatorOption == 3)
            {
                Console.Write("Podaj pierwszą liczbę: ");
                int value1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj drugą liczbę: ");
                int value2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wynik mnożenia: " + calculatorbase.ExecuteMultiplication(value1, value2));
            }
            else if (baseCalculatorOption == 4)
            {
                Console.Write("Podaj pierwszą liczbę: ");
                int value1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj drugą liczbę: ");
                int value2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wynik dzielenia: " + calculatorbase.ExecuteDivision(value1, value2));
            }
        }
    }
}