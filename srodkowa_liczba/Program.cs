namespace srodkowa_liczba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = new int[3];
            
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Liczba {i + 1}:  ");
                liczby[i] = int.Parse(Console.ReadLine()!);
            }

            Array.Sort(liczby);

            bool takieSame = true;

            for(int i = 1; i < liczby.Length; i++)
            {
                if (liczby[i] != liczby[0])
                {
                    takieSame = false;
                    break;
                }
            }

            if (takieSame)
            {
                Console.WriteLine("Wszystkie liczby są takie same.");
            }
            else
            {
                Console.WriteLine($"Środkowa liczba w tablicy to {liczby[1]}");
            }

        }
    }
}