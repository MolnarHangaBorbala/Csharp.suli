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
            //Teljes elérési út a fájlhoz
            string filePath = @"C:\Users\user\Documents\Molnár Hanga Borbála\csoki.txt";

            //Faájl soronként beolvasása
            List<string> sorok = new List<string>(File.ReadAllLines(filePath));
            
            //Teszt kiíratás
            foreach (var sor in sorok)
            {
                Console.WriteLine(sor);
            }
        }
    }
}
