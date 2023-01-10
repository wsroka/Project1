using Project1;
using System;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleColors consoleColors = new ConsoleColors();
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
                consoleColors.ColorObject("Podaj pierwszą liczbę: ", ConsoleColor.Green);
                int value1 = Convert.ToInt32(Console.ReadLine());
                consoleColors.ColorObject("Podaj drugą liczbę: ", ConsoleColor.Magenta);
                int value2 = Convert.ToInt32(Console.ReadLine());
                consoleColors.ColorObject("Wynik dodawania: " + calculatorbase.ExecuteAddition(value1, value2), ConsoleColor.DarkRed);
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
                while (true)
                {
                    Console.Write("Podaj pierwszą liczbę: ");
                    int value1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    int value2 = Convert.ToInt32(Console.ReadLine());
                }
                try
                {

                }
                catch (DivideByZeroException e)
                {

                    throw;
                }
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
                txtFile.SaveText(text);
            }
            else if (actionOnTxtFile == 12)
            {
                Console.WriteLine("\nZawartośc pliku: ");
                txtFile.ViewTheFile();
            }
            else if (actionOnTxtFile == 13)
            {
                Console.WriteLine("Podaj, którą linie tekstu wyświetlić: ");
                int txtline = Convert.ToInt32(Console.ReadLine());
                txtFile.ViewTheLine(txtline);
            }
        }
    }
}