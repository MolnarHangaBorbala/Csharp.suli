using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            bool U = akt.Contains("U");
            bool G = akt.Contains("G");
            bool F = akt.Contains("F");
            bool K = akt.Contains("K");

            if (U)
            {
                ossz += 1;
            }
            else if (G)
            {
                ossz += 1;
            }
            else if (F)
            {
                ossz += 2;
            }
            else if (K)
            {
                ossz += 10;
            }


            Console.WriteLine("2. feladat");

            Console.WriteLine("Az elért távolság: " + ossz);

            Console.WriteLine("3. feladat");

            if (U && G && F && K)
            {
                Console.WriteLine("Bravó! Jutalma még 10 km.");
                ossz += 10;
            }

            Console.WriteLine("4. feladat");
            Console.WriteLine("Eredménye: " + ossz + " Gratulálok, kihívás teljesítve!");
        }
    }
}
