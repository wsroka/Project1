using Project1;

internal class Program
{
    private static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.ShowMainMenu();
        Console.Write("\nWybierz numer z manu głównego: ");
        int numberMainMenu = Convert.ToInt32(Console.ReadLine());

        int value1;
        int value2;
        if (numberMainMenu == 1)
        {
            Console.WriteLine();
            CalculatorBase calculatorbase = new CalculatorBase();
            menu.ShowBaseCalculatorMenu();
            Console.Write("\nWybierz numer z menu prostego kalkulatora: ");
            int result = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (result == 1)
            {
                Console.Write("Podaj pierwszą liczbę: ");
                value1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj drugą liczbę: ");
                value2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wynik dodawania: " + calculatorbase.ExecuteAddition(value1, value2));
            }
            else if (result == 2)
            {
                Console.Write("Podaj pierwszą liczbę: ");
                value1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj drugą liczbę: ");
                value2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wynik odejmowania: " + calculatorbase.ExecuteSubtraction(value1, value2));
            }
            else if (result == 3)
            {
                Console.Write("Podaj pierwszą liczbę: ");
                value1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj drugą liczbę: ");
                value2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wynik mnożenia: " + calculatorbase.ExecuteMultiplication(value1, value2));
            }
            else if (result == 4)
            {
                Console.Write("Podaj pierwszą liczbę: ");
                value1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj drugą liczbę: ");
                value2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wynik dzielenia: " + calculatorbase.ExecuteDivision(value1, value2));
            }
        }
    }
}