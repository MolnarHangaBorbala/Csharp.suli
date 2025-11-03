using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MHB1001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileel = @"C:\Users\user\Documents\Molnár Hanga Borbála\C#\Forras\3_Sebesseg\ut.txt";

            List<List<string>> hatarok = new List<List<string>>();

            using (StreamReader bemenet = new StreamReader(fileel))
            {
                int hossz = int.Parse(bemenet.ReadLine().Trim());

                string sor;
                while ((sor = bemenet.ReadLine()) != null)
                {
                    string[] reszek = sor.Trim().Split(' ');
                    // Az első elemet számra alakítjuk
                    reszek[0] = int.Parse(reszek[0]).ToString();

                    // Lista formában adjuk hozzá
                    hatarok.Add(new List<string>(reszek));
                }
            }
        }
    }
}
