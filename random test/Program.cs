using System;
namespace random_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programmet kommer att försöka gissa fram ett tal som du angett. Följ instruktionerna.");
            Console.WriteLine();
            Console.WriteLine("Bestäm vilka tal programmet ska gissa mellan, exempelvis 0-10. Skriv det första talet");
            int gissamellan1 = int.Parse(Console.ReadLine());
            Console.WriteLine("skriv det andra talet");
            int gissamellan2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Bestäm ett tal du vill att programmet ska försöka gissa fram mellan {gissamellan1} och {gissamellan2}");
            long svar = long.Parse(Console.ReadLine());
            Console.WriteLine("Bestäm hur många gissningar som programmet max får göra");
            long antalgissningar = long.Parse(Console.ReadLine());
            Console.WriteLine("");

            Random random = new Random();

            for (long i = 1; i < antalgissningar+1; i++)
            {
                long tal = random.Next(gissamellan1, gissamellan2+1);
                Console.WriteLine(tal);
                if (tal == svar)
                {
                    double summa = gissamellan2 - gissamellan1;
                    double chans = 1/summa;
                    Console.WriteLine("");
                    Console.WriteLine($"Det tog {i} antal gissningar att få {svar}, det är en chans på {chans*100}% att få detta tal.");
                    break;
                }
                else if (i == antalgissningar && tal!=svar)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Programmet kunde inte gissa fram {svar} med bara {antalgissningar} gissningar, pröva igen");
                }
                else
                {
                    continue;
                }
            }
            Console.ReadKey()
        }
    }
}