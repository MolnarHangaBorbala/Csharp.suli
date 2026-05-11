using System;
using System.Collections.Generic;
using System.IO;

namespace MHB2
{
    internal class Program
    {
        class Ember
        {
            public string Nev { get; set; }
            public int Kor { get; set; }

            public Ember(string nev, int kor)
            {
                Nev = nev;
                Kor = kor;
            }

            public void Kiir()
            {
                Console.WriteLine($"Név: {Nev}, Kor: {Kor}");
            }
        }

        static void Main(string[] args)
        {
            List<Ember> emberek = new List<Ember>();

            emberek.Add(new Ember("Anna", 20));
            emberek.Add(new Ember("Béla", 25));
            emberek.Add(new Ember("Csaba", 30));

            string fajlNev = "emberek.txt";

            // Fájlba írás
            using (StreamWriter sw = new StreamWriter(fajlNev))
            {
                foreach (Ember ember in emberek)
                {
                    sw.WriteLine($"{ember.Nev};{ember.Kor}");
                }
            }

            Console.WriteLine("Adatok elmentve.");

            // Fájlból olvasás
            List<Ember> beolvasottEmberek = new List<Ember>();

            using (StreamReader sr = new StreamReader(fajlNev))
            {
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();

                    string[] adatok = sor.Split(';');

                    string nev = adatok[0];
                    int kor = int.Parse(adatok[1]);

                    beolvasottEmberek.Add(new Ember(nev, kor));
                }
            }

            Console.WriteLine("\nBeolvasott adatok:");

            foreach (Ember ember in beolvasottEmberek)
            {
                ember.Kiir();
            }

            Console.ReadKey();
        }
    }
}
