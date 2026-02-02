        /*
        static void kiírat(string nev, int kor, string iskola="Premo")
        {
            Console.WriteLine("Hello " + nev + "! " + "Kor: " + kor + " Iskola: " + iskola);
        }

        static void Main(string[] args)
        {
            kiírat("Rebeka", 17);
            kiírat("Bálint", 17);
            kiírat("Csenge", 19, "Közgáz");
        }*/


        static void Szamol()
        {
            Console.Write("Négyzet 'a' oldala :");
            double a = double.Parse(Console.ReadLine());

            double ker = 4 * a;
            double ter = a * a;

            Console.WriteLine($"Kerület: {ker}");
            Console.WriteLine($"Terület: {ter}");
        }

        static void Main(string[] args)
        {
            Szamol();
        }


        static void Main(string[] args)
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            int b;
            int c = 0;
            int a = 10;
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                b = a / c;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
