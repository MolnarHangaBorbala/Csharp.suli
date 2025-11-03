using System;
using System.Collections.Generic;
using System.IO;

namespace MHB1001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileel = @"C:\Users\user\Documents\Molnár Hanga Borbála\C#\Csharp.suli-main\C#\Forras\3_Sebesseg\ut.txt";

            List<List<string>> hatarok = new List<List<string>>();

            using (StreamReader bemenet = new StreamReader(fileel))
            {
                int hossz = int.Parse(bemenet.ReadLine().Trim());

                string sor;
                while ((sor = bemenet.ReadLine()) != null)
                {
                    string[] reszek = sor.Trim().Split(' ');
                    reszek[0] = int.Parse(reszek[0]).ToString(); // Első elemet számra alakítjuk

                    hatarok.Add(new List<string>(reszek));
                }
            }

            // Például kiíratjuk a határokat
            Console.WriteLine("A fájl adatai:");
            foreach (var lista in hatarok)
            {
                Console.WriteLine(string.Join(" ", lista));
            }

            // Kérjünk be egy gombnyomást, hogy a konzol ne záródjon be azonnal
            Console.WriteLine("Nyomj meg egy billentyűt a kilépéshez...");
            Console.ReadKey();
        }
    }
}
