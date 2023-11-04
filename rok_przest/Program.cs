namespace rok_przest
{
    internal class Program
    {
            static bool czyPrzest(int rok)
            {
                return (rok % 4 == 0 && rok % 100 != 0) || rok % 400 == 0;
            }

            static void Main()
            {
                    Console.Write("Podaj rok: ");
                    int rok = int.Parse(Console.ReadLine()!);

                    if (czyPrzest(rok))
                    {
                        Console.WriteLine("Rok jest przestepny");
                    }
                    else
                    {
                        Console.WriteLine("Rok nie jest przestepny");
                    }  
            }

    }
}