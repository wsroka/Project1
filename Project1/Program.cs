using Project1;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

Menu menu = new Menu();
Console.WriteLine();
Console.Write("Wybierz numer z menu: ");
int result = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int value1;
int value2;
string path = @"pli.txt";
string s = "";
int counter = 1;
StreamReader sr;
Calculator calculator = new Calculator();
if (result == 1)
{
    Console.ForegroundColor= ConsoleColor.Red;
    Console.Write("Podaj pierwszą liczbę: ");
    value1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Podaj drugą liczbę: ");
    value2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Wynik dodawania: " + calculator.Add(value1, value2));
}
else if (result == 2)
{
    Console.Write("Podaj pierwszą liczbę: ");
    value1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Podaj drugą liczbę: ");
    value2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Wynik odejmowania: " + calculator.Subtract(value1, value2));
}
else if (result == 3)
{
    Console.Write("Podaj pierwszą liczbę: ");
    value1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Podaj drugą liczbę: ");
    value2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Wynik mnożenia: " + calculator.Multiply(value1, value2));
}
else if (result == 4)
{
    Console.Write("Podaj pierwszą liczbę: ");
    value1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Podaj drugą liczbę: ");
    value2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Wynik dzielenia: " + calculator.Divide(value1, value2));
}
else if (result == 5)
{
    Console.Write("Podaj liczbę: ");
    value1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (calculator.isPrimeNumber(value1))
    {
        Console.WriteLine("Liczba jest pierwsza");
    }
    else
    {
        Console.WriteLine("Liczba nie jest pierwsza");
    }
}
else if (result == 6)
{
    Console.Write("Podaj liczbę naturalną: ");
    value1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (value1 < 0)
    {
        while (value1 < 0)
        {
            Console.Write("Liczba nie jest naturalna, podaj liczbę naturalną: ");
            value1 = Convert.ToInt32(Console.ReadLine());
        }
    }
    else
    {
        Console.WriteLine("Silnia z liczby " + value1 + " to " + calculator.Factorial(value1));
    }
}
else if (result == 7)
{
    Console.Write("Podaj liczbę: ");
    value1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (calculator.IsPerfectNumber(value1))
    {
        Console.WriteLine("Liczba jest liczbą doskonałą");
    }
    else
    {
        Console.WriteLine("Liczba nie jest liczbą doskonałą");
    }
}
else if (result == 8)
{
    Console.WriteLine("Podaj długośc tablicy:");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] tab = new int[n];
    Console.WriteLine("Dodaj wartości do tablicy: ");
    for (int i = 0; i < n; i++)
    {
        tab[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Średnia wartość elementów tablicy to: " + calculator.AverageNumber(tab));
}
else if (result == 9)
{
    Console.WriteLine("Podaj długośc tablicy:");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] tab = new int[n];
    Console.WriteLine("Dodaj wartości do tablicy: ");
    for (int i = 0; i < n; i++)
    {
        tab[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Największy element tablicy to: " + calculator.MaxValue(tab));
}
else if (result == 10)
{
    Console.WriteLine("Podaj długośc tablicy:");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] tab = new int[n];
    Console.WriteLine("Dodaj wartości do tablicy: ");
    for (int i = 0; i < n; i++)
    {
        tab[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Najmniejszy element tablicy to: " + calculator.MinValue(tab));
}
else if (result == 11)
{
    StreamWriter sw;
    if (!File.Exists(path))
    {
        sw = File.CreateText(path);
        Console.WriteLine("Plik został utworzony");
    }
    else
    {
        sw = new StreamWriter(path, true);
        Console.WriteLine("Plik już istnieje");
    }

    Console.WriteLine("Podaj tekst: ");
    string text = Console.ReadLine();
    sw.WriteLine(text);
    sw.Close();
}
else if (result == 12)
{
    Console.WriteLine("Zawartość pliku: ");
    sr = File.OpenText(path);
    while ((s = sr.ReadLine()) != null)
    {
        Console.WriteLine(s);
    }
    sr.Close();
}
else if (result == 13)
{
    Console.Write("Podaj którą linie tekstu wyświetlić: ");
    int textline = Convert.ToInt32(Console.ReadLine());
    sr = File.OpenText(path);
    while ((s = sr.ReadLine()) != null)
    {
        if (counter == textline)
        {
            Console.WriteLine(s);
        }
        else if (counter < textline)
        {
            Console.WriteLine("Taka linia nie istnieje");
            break;
        }
        counter++;
    }
    sr.Close();
}
