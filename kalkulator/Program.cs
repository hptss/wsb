using System;

class Calculator
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Prosty kalkulator konsolowy");
            Console.WriteLine("Wybierz działanie:");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            Console.WriteLine("5. Wyjście");

            // Odczyt wyboru użytkownika
            int choice = int.Parse(Console.ReadLine());

            if (choice == 5)
            {
                Console.WriteLine("Dziękujemy za skorzystanie z kalkulatora. Do widzenia!");
                break;
            }

            Console.WriteLine("Podaj pierwszą liczbę: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Nie można dzielić przez zero.");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór.");
                    continue;
            }

            Console.WriteLine("Wynik: " + result);
        }
    }
}