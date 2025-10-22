using System;
using System.Linq;

namespace MHB1001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. feladat");
            Console.Write("Adja meg az aktivitását: ");
            string akt = Console.ReadLine();

            int ossz = 0;

            foreach (char a in akt)
            {
                switch (a)
                {
                    case 'U':
                        ossz += 1;
                        break;
                    case 'G':
                        ossz += 1;
                        break;
                    case 'F':
                        ossz += 2;
                        break;
                    case 'K':
                        ossz += 10;
                        break;
                    default:
                        Console.WriteLine($"Ismeretlen: {a}");
                        break;
                }
            }

            Console.WriteLine("2. feladat");
            Console.WriteLine("Az elért távolság: " + ossz);

            Console.WriteLine("3. feladat");

            bool U = akt.Contains('U');
            bool G = akt.Contains('G');
            bool F = akt.Contains('F');
            bool K = akt.Contains('K');

            if (U && G && F && K)
            {
                Console.WriteLine("Bravó! Jutalma még 10 km.");
                ossz += 10;
            }
            else
            {
                Console.WriteLine("Nem jár jutalom.");
            }

            Console.WriteLine("4. feladat");

            if (ossz > 40)
            {
                Console.WriteLine("Eredménye: " + ossz + " km. Gratulálok, kihívás teljesítve!");
            }
            else
            {
                Console.WriteLine("Eredménye: " + ossz + " km. Legközelebb sikerül!");
            }
        }
    }
}
// https://dload-oktatas.educatio.hu/erettsegi/feladatok_2025tavasz_kozep/k_digkult_25maj_fl.pdf
