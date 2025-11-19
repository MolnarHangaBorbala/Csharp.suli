using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MHB11122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fajl = @"C:\Users\user\Documents\Molnár Hanga Borbála\C#\Könyv\kiadas.txt";

            List<List<string>> adatok = new List<List<string>>();

            using (StreamReader r = new StreamReader(fajl))
            {
                string sor;
                while ((sor = r.ReadLine()) != null)
                {
                    // év;negyed;eredet;leiras;peldany
                    string[] v = sor.Split(';');

                    // Konvertálás beolvasáskor
                    v[0] = int.Parse(v[0]).ToString(); // év
                    v[1] = int.Parse(v[1]).ToString(); // negyedév
                    v[4] = int.Parse(v[4]).ToString(); // példányszám
                    
                    adatok.Add(new List<string>(v));
                }
            }
            Console.WriteLine("Beolvasva.\n");

            // 2. Feladat
            Console.WriteLine("2. Feladat:");
            Console.Write("Írja be a szerző nevét: ");
            string szerzo = Console.ReadLine();

            int db = 0;
            foreach (var sor in adatok)
            {
                string leiras = sor[3];
                if (leiras.Contains(szerzo))
                {
                    db++;
                }
            }

            if (db == 0)
            {
                Console.WriteLine("Nem adtak ki.");
            } 
            else
            {
                Console.WriteLine($"A szerzőtől {db} mű szerepel.\n");
            }

            // 3. Feladat
            Console.WriteLine("3. Feladat:");
            
            List<int> peldanyok = new List<int>();
            foreach (var s in adatok)
            {
                peldanyok.Add(int.Parse(s[4]));
            }
            int maxPel = peldanyok.Max();
            int darab = peldanyok.Count(x  => x == maxPel);

            Console.WriteLine($"A legnagyobb példányszám: {maxPel}");
            Console.WriteLine($"Ennyi könyvnél fordult elő: {darab}");
        }
    }
}
