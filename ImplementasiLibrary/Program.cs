using System;
using AljabarLibraries;

namespace ImplementasiLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] akar = Kuadrat.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
            Console.WriteLine("Akar dari persamaan kuadrat x^2 - 3x - 10 = 0 adalah {0} dan {1}", 
                akar[0], akar[1]);

            double[] hasilKuadrat = Kuadrat.HasilKuadrat(new double[] { 2, -3 });
            Console.WriteLine("Hasil kuadrat dari persamaan 2x - 3 adalah {0}x^2 + {1}x + {2}", 
                hasilKuadrat[0], hasilKuadrat[1], hasilKuadrat[2]);

            Console.ReadKey();
        }
    }
}
