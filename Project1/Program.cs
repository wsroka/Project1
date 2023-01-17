using Project1;

internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleOperation consoleColors = new ConsoleOperation();
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
                consoleColors.WriteLineColor("Podaj pierwszą liczbę: ", ConsoleColor.Green);
                int value1 = Convert.ToInt32(Console.ReadLine());
                consoleColors.WriteLineColor("Podaj drugą liczbę: ", ConsoleColor.Magenta);
                int value2 = Convert.ToInt32(Console.ReadLine());
                consoleColors.WriteLineColor("Wynik dodawania: " + calculatorbase.ExecuteAddition(value1, value2), ConsoleColor.DarkRed);
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
        }
        if (baseOption == 3)
        {
            TxtFile txtFile = new TxtFile();
            menu.ShowTxtFilesMenu();
            Console.Write("\nWybierz numer z menu: ");
            int actionOnTxtFile = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (actionOnTxtFile == 11)
            {
                Console.WriteLine("Podaj tekst: ");
                string text = Console.ReadLine();
                txtFile.WriteFile(text);
            }
            else if (actionOnTxtFile == 12)
            {
                Console.WriteLine("\nZawartośc pliku: ");
                txtFile.ReadFile();
            }
            else if (actionOnTxtFile == 13)
            {
                Console.WriteLine("Podaj, którą linie tekstu wyświetlić: ");
                int txtline = Convert.ToInt32(Console.ReadLine());
                txtFile.ReadTheLine(txtline);
            }
        }
    }
}