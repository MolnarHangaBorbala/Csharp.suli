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
            List<List<object>> automata = new List<List<object>>();
            string file = @"C:\Users\user\Documents\Molnár Hanga Borbála\C#\automata.txt";

            foreach (string sor in File.ReadLines(file))
            {
                string[] darabok = sor.Trim().Split(' ');

                List<object> adatsor = new List<object>();

                adatsor.Add(int.Parse(darabok[0]));
                adatsor.Add(int.Parse(darabok[1]));
                adatsor.Add(int.Parse(darabok[2]));
                adatsor.Add(int.Parse(darabok[3]));
                adatsor.Add((darabok[4]));

                automata.Add(adatsor);
            }

            foreach (var sor in automata)
            {
                Console.WriteLine(string.Join(", ", sor));
            }

            // # 1 feladat Határozd meg hány fajta termék van az automatában!
            Console.WriteLine("Hány fajta termék van az automatában?");
            Console.WriteLine($"Az automatában {automata.Count} féle termék van.");

            // # 2 feladat Irasd ki, hogy milyen termékek vannak!
            Console.WriteLine("Milyen termékek vannak?");
            for (int i = 0; i < automata.Count; i++)
            {
                Console.WriteLine(automata[i][4]);
            }

            // # 3 feladat Határozd meg hánydarab termék van!
            Console.WriteLine("Hánydarab termék van?");
            int db = 0;

            for (int i1 = 0; i1 < automata.Count; i1++)
            {
                db = db + (int)automata[i1][0];
            }

            Console.WriteLine(db);

            // # 4 feladat Határozd meg min
            Console.WriteLine("Határozd meg min.");
            int min1 = (int)automata[0][0];

            for(int i1 = 0; i1 < automata.Count; i1++)
            {
                if(min1 < (int)automata[i1][0])
                {
                    min1 = (int)automata[i1][0];
                }
            }
            Console.WriteLine(min1);
        }
    }
}
