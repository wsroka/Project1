namespace Project1
{
    internal class Menu
    {
        public void ShowMainMenu()
        {
            Console.WriteLine("1. Prosty kalkulator");
            Console.WriteLine("2. Zaawansowany kalkulator");
            Console.WriteLine("3. Działania na plikach txt");
        }
        public void ShowBasicMain()
        {
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
        }
        public void ShowAdvancedMenu()
        {
            Console.WriteLine("5. Liczba pierwsza");
            Console.WriteLine("6. Silnia");
            Console.WriteLine("7. Liczba doskonała");
            Console.WriteLine("8. Średnia liczba elementów tablicy");
            Console.WriteLine("9. Największa element tablicy");
            Console.WriteLine("10. Najmniejszy element tablicy");
        }
        public void ShowTxtFilesMenu()
        {
            Console.WriteLine("11. Zapisz tekst do pliku txt");
            Console.WriteLine("12. Wyświetl tekst z pliku txt");
            Console.WriteLine("13. Wyświetl konkretną linie z pliku txt");
        }
    }
}
