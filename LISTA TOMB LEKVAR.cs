using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MHB0929
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            //5 elemű tömb
            int[] szamok = new int[5];

            //Értékadás
            szamok[0] = 10;
            szamok[1] = 20;

            //Inisializálás
            int[] szamok2 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(szamok2[1]);
            Console.WriteLine(string.Join(", ", szamok2));
            Console.WriteLine(szamok.GetType());

            //LISTA
            //Üres lista létrehozása
            List<int> szamok3 = new List<int>();

            //Elem hozzáadása
            szamok3.Add(10);
            szamok3.Add(20);

            //Inicializálás elemekkel
            List<int> szamok4 = new List<int>{1, 2, 3, 4, 5, 6, 7};
            Console.WriteLine(szamok4[0]);
            Console.WriteLine(string.Join(", ", szamok4));
            Console.WriteLine(szamok4.GetType());

            //LEGNAGYOBB ELEM
            int[] szamok5 = { 1, 12, 3, 4, 5, 9 };
            int max1 = szamok5.Max();
            int max2 = szamok5[0];

            foreach (int szam in szamok5)
            {
                if (szam > max2)
                {
                    max2 = szam;
                }
            }
            Console.WriteLine(max1);
            Console.WriteLine(max2);

            //ÖSSZEG KISZÁMOLÁSA
            int[] szamok6 = { 1, 12, 3, 4, 5, 9 };
            int sum1 = szamok6.Sum();
            int sum2 = 0;

            foreach (int szam in szamok6)
            {
                sum2 += szam;
            }
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);

            //ÖSSZEG - LEGNAGYOBB ELEM
            int[] szamok7 = { 1, 12, 3, 4, 5, 9 };
            int sum3 = 0;

            foreach (int szam in szamok6)
            {
                sum3 += szam;
            }
            int max3 = szamok7.Max();

            Console.WriteLine(sum3-max3);
            */

            List<int> uveg = new List<int> { 5, 2, 2, 4, 3, 2, 4, 10, 5, 5, 3, 5, 4, 3, 3 };
            Console.Write("Kérem hogy Mari néni hány liter lekvárt főzött be: ");
            int L = int.Parse(Console.ReadLine());
            string dl = L + "0"; 

            Console.WriteLine("2. feladat");
            Console.WriteLine("Mari néni lekvárja (dl): " + dl);

            Console.WriteLine("3. feladat");
            int max = uveg.Max();
            int index = uveg.IndexOf(max) + 1;
            Console.WriteLine("A legnagyobb üveg: " + max + "dl és " + index + ". a sorban.");

            Console.WriteLine("4. feladat");
            int összuveg = uveg.Sum();
            Console.WriteLine("Üvegek összes kapacitása: " + összuveg);

            if (összuveg > L)
            {
                Console.WriteLine("Elegendő üveg volt.");
            } 
            else if (összuveg < L)
            {
                Console.WriteLine("Maradt lekvár.");
            }
            else if (összuveg == L)
            {
                Console.WriteLine("Pont elég üveg volt.");
            }

        }
    }
}
