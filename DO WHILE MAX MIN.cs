using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHB3
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("Téglalap kerülete és területe");
            Console.Write("Kérem az a oldalt: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Kérem a b oldalt: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("A kerület: "+ 2 * a + 2 * b);
            double ker = 2 * a + 2 * b;
            double ter = a * b;
            Console.WriteLine($"A terület: {ter}");
            if (ker == ter)
            {
                Console.WriteLine("Egyenlő.");
            }
            else if (ker > ter) 
            {
                Console.WriteLine("A kerület a nagyobb.");
            }
            else
            {
                Console.WriteLine("A terület a nagyobb.");
            }
        



            Random rnd = new Random();

            Console.WriteLine("Tanár-diák kocka játék.");
            int tanar = rnd.Next(1, 6);
            Console.WriteLine($"A tanár {tanar} dobott!");
            int diak = rnd.Next(1, 6);
            Console.WriteLine($"A diák {diak} dobott!");
            if (tanar == diak)
            {
                Console.WriteLine("Egyenlő.");
            } 
            else if (tanar > diak)
            {
                Console.WriteLine("Tanár úr nyert!");
            }
            else
            {
                Console.WriteLine("Diák nyert!");
            }
        


            //for ciklus

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }


            for (int i = 1; i <=5; i++)
            {
                Console.WriteLine("Hajrá ZTE!");
                for (int a = 1; a <= 3; a++)
                {
                    Console.WriteLine("Fujpest.");
                }
            }



            //Tömbök
            string[] nevek = { "Anna", "Béla", "Csaba" };

            for (int i = 0; i < nevek.Length; i++)
            {
                Console.WriteLine(nevek[i]);
            }

            foreach (string nev in nevek)
            {
                Console.WriteLine(nev);
            }
            

            string[] auto = { "Opel", "Ford", "Volkswagen" };

            for (int i = 0; i < auto.Length; i++)
            {
                Console.WriteLine(auto[0]);
                Console.WriteLine(auto[1]);


            //WHILE
            int[] w = {0, 1, 2, 3, 4, 5, 6, 7, 8};

            int i = 0;
            while (i < w.Length)
            {
                Console.WriteLine(w[0]);
                i++;
            }
            


            //DO
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);



            //MIN
            int[] szamok1 = { 12, 5, 8, -3, 15, 0 };

            //kezdő minimum az első elem
            int min1 = szamok[0];

            //végigmegyünk a tömbön for cilkussal
            for (int i = 1; i < szamok1.Length; i++)
            {
                if (szamok1[i] < min1)
                {
                    min1 = szamok1[i];
                }
            }
            Console.WriteLine($"A legkisebb szám: {min1}");

            //FOREACH
            int[] szamok2 = { 12, 5, 8, -3, 15, 0 };

            //kezdő minimum az első elem
            int min2 = szamok2[0];

            //foreach ciklus minden elemen végigmegy 
            foreach (int szam in szamok2)
            {
                if (szam < min2)
                {
                    min2 = szam;
                }
            }
            Console.WriteLine($"A legkisebb szám: {min2}");
            
            //WHILE
            int[] szamok3 = { 12, 5, 8, -3, 15, 0 };

            //kezdő minimum az első elem
            int min3 = szamok3[0];

            int i = 1; //A 0. elemet már betettük a min-be
            while (i < szamok3.Length)
            {
                if (szamok3[i] < min3)
                {
                    min3 = szamok3[i];
                }
                i++;
            }
            Console.WriteLine($"A legkisebb szám: {min3}");

            //DO WHILE
            int[] szamok4 = { 12, 5, 8, -3, 15, 0 };

            int min4 = szamok4[0]; //kezdő minimum az első elem

            int i = 1; //A 0. elemet már betettük a min-be
            do
            {
                if (szamok4[i] < min4) 
                {
                    min4 = szamok4[i];
                }
                i++;
            } while (i < szamok4.Length);
            Console.WriteLine($"A legkisebb szám: {min4}");

            //EGY SOROS
            int[] szamok5 = { 12, 5, 8, -3, 15, 0 };

            int min = szamok5.Min();
            Console.WriteLine($"A legkisebb szám: {min}.");

            //MAX 
            //FOR

            int[] szamokm1 = { 12, 5, 8, -3, 15, 0 };

            int max1 = szamokm1[0];

            for (int i = 1; i < szamokm1.Length; i++)
            {
                if (szamokm1[i] > max1)
                {
                    max1 = szamokm1[i];
                }
            }
            Console.WriteLine($"A legnagyobb szám: {max1}");

            //FOREACH
            int[] szamokm2 = { 12, 5, 8, -3, 15, 0 };

            int max2 = szamokm2[0];

            foreach(int szam2 in szamokm2)
            {
                if (szam2 > max2)
                {
                    max2 = szam2;
                }
            }
            Console.WriteLine($"A legnagyobb szám: {max2}");

            //WHILE
            int[] szamokm3 = { 12, 5, 8, -3, 15, 0 };

            int max3 = szamokm3[0];

            int i = 1;
            while (i < szamokm3.Length)
            {
                if (szamokm3[i] < max3)
                {
                    max3 = szamokm3[i];
                }
            }
            Console.WriteLine($"A legnagyobb szám: {max3}");

            //DO WHILE
            int[] szamokm4 = { 12, 5, 8, -3, 15, 0 };

            int max4 = szamokm4[0];

            int i = 1;
            do
            {
                if (szamokm4[i] > max4)
                {
                    max4 = szamokm4[i];
                }
                i++;
            } 
            while (i < szamokm4.Length);
            Console.WriteLine($"A legnagyobb szám: {max4}");

            //EGY SOROS
            int[] szamokm5 = { 12, 5, 8, -3, 15, 0 };

            int max5 = szamokm5.Max();
            Console.WriteLine($"A legnagyobb szám: {max5}");
*/

            //KERESETT SZÁM
            //FOR
            List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
            int keresett = 42;
            bool megtalalva = false;

            for (int i = 0; i < szamok.Count; i++)
            {
                if (szamok[i] == keresett)
                {
                    Console.WriteLine($"A keresett szám ({keresett}) megtalálva a(z) {i}. indexen.");
                    megtalalva = true;
                    break; // Kilépünk, mert megtaláltuk
                }
            }
            if (!megtalalva)
            {
                Console.WriteLine($"A ({keresett}) szám nincs a listában.");
            }

            //FOREACH
            List<int> szamok2 = new List<int> { 4, 8, 15, 16, 23, 42 };
            int keresett2 = 42;
            bool megtalalva2 = false;
            int index = 0; 

            foreach (int szam2 in szamok2)
            {
                if (szam2 == keresett2)
                {
                    Console.WriteLine($"A keresett szám ({keresett2}) megtalálva a(z) {index}. indexen.");
                    megtalalva2 = true;
                    break; //Kilépünk, mert megtaláltuk
                }
                index++;
            }
            if (!megtalalva2)
            {
                Console.WriteLine($"A ({keresett2}) szám nincs a listában.");
            }

            //WHILE
            List<int> szamok3 = new List<int> { 4, 8, 15, 16, 32, 42 };
            int keresett3 = 16;
            bool megtalalva3 = false;
            int a = 0;

            while (a < szamok3.Count)
            {
                if (szamok3[a] == keresett3)
                {
                    Console.WriteLine($"A keresett szám ({keresett3}) megtalálva a(z) {a}. indexen.");
                    megtalalva3 = true;
                    break; // Kilépünk, mert megtaláltuk
                }
                a++;
            }
            if (!megtalalva3)
            {
                Console.WriteLine($"A ({keresett3}) szám nincs a listában.");
            }

            //DO WHILE
            List<int> szamok4 = new List<int> { 4, 8, 15, 16, 32, 42 };
            int keresett4 = 16;
            bool megtalalva4 = false;
            int b = 0;

            if (szamok4.Count > 0) //Ellenőrizzük hogy a lista ne legyen üres
            {
                do
                {
                    if (szamok4[b] == keresett4) 
                    {
                        Console.WriteLine($"A keresett szám ({keresett4}) megtalálva a(z) {b}. indexen.");
                        megtalalva4 = true;
                        break; // Kilépünk, mert megtaláltuk
                    }
                    b++;
                } while (b < szamok4.Count);
            }
            if (!megtalalva4)
            {
                Console.WriteLine($"A ({keresett4}) szám nincs a listában.");
            }

            //IF ELSE
            List<int> szamok5 = new List<int> { 4, 8, 15, 16, 32, 42 };
            int keresett5 = 16;

            if (szamok.Contains(keresett5))
            {
                Console.WriteLine($"A keresett szám ({keresett5}) megtalálva a listában.");
            }
            else
            {
                Console.WriteLine($"A ({keresett5}) szám nincs a listában.");
            }


            //IF ELSE (+index)
            List<int> szamok6 = new List<int> { 4, 8, 15, 16, 32, 42 };
            int keresett6 = 16;

            int index2 = szamok.IndexOf(keresett6);

            if (index2 != -1)
            {

                Console.WriteLine($"A keresett szám ({keresett6}) megtalálva a(z) {index2}. indexen.");
            }
            else
            {
                Console.WriteLine($"A ({keresett6}) szám nincs a listában.");
            }










            /*
            //Calc

            Console.WriteLine("Számológép");
            Console.WriteLine("Choose an operator: ");
            Console.WriteLine("1. <3 Addition (+)");
            Console.WriteLine("2. <3 Subtraction (-)");

            int a = int.Parse(Console.ReadLine());

            Console.Write("1st number: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("2nd number: ");
            int c = int.Parse(Console.ReadLine());


            if (a == 1)
            {
                int add = a + b;
                Console.WriteLine($"{a} + {b} = {add}");
            } 
            else if (a == 2)
            {
                int sub = a - b;
                Console.WriteLine($"{a} - {b} = {sub}");
            }*/

        }
    }
}
