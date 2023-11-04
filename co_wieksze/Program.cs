namespace co_wieksze
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double wynik1 = Math.Pow(Math.Sqrt(2), Math.Sqrt(3));
            double wynik2 = Math.Pow(Math.Sqrt(3), Math.Sqrt(2));

            Console.WriteLine($"Pierwsze wyrażenie: pierwiastek z 2 ^ pierwiastek z 3 = {wynik1}");
            Console.WriteLine($"Drugie wyrażenie: pierwiastek z 3 ^ pierwiastek z 2 = {wynik2}");

            if (wynik1 > wynik2)
            {
                Console.WriteLine("Pierwsze wyrażenie jest większe.");
            }
            else if (wynik1 < wynik2)
            {
                Console.WriteLine("Drugie wyrażenie jest większe.");
            }
            else
            {
                Console.WriteLine("Oba wyrażenia są równe.");
            }

        }
    }
}