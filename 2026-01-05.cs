            //Téglalap kerülete és területe
            Console.WriteLine("Téglalap kerülete és területe.");
            Console.Write("Kérem az 'a' oldalt: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Kérem a 'b' oldalt: ");
            int b = int.Parse(Console.ReadLine());

            int ker = 2 * a + 2 * b;
            int ter = a * b;

            Console.WriteLine($"Kerület: {ker}");
            Console.WriteLine($"Terület: {ter}");
            if (ker > ter)
            {
                Console.WriteLine("A terület a nagyobb.");
            }
            else if (ker < ter)
            {
                Console.WriteLine("A kerület a nagyobb.");
            }
            else
            {
                Console.WriteLine("Egyenlő.");
            }
            Console.WriteLine("--------------------------------------------------");

            //Kör kerülete és területe
            Console.WriteLine("Kör kerülete és területe.");
            Console.WriteLine("Kérem a kör sugarát: ");
            int r = int.Parse(Console.ReadLine());
            double kker = 2 * r * Math.PI;
            double kter = r * r * Math.PI;

            Console.WriteLine($"Kerület: {kker}");
            Console.WriteLine($"Terület: {kter}");
            if (kker > kter)
            {
                Console.WriteLine("A terület a nagyobb.");
            }
            else if (kker < kter)
            {
                Console.WriteLine("A kerület a nagyobb.");
            }
            else
            {
                Console.WriteLine("Egyenlő.");
            }
            Console.WriteLine("--------------------------------------------------");

            //Négyzet kerülete és területe
            Console.WriteLine("Négyzet kerülete és területe.");
            Console.Write("Kérem az 'a' oldalt: ");
            int na = int.Parse(Console.ReadLine());

            int nker = 2 * na;
            int nter = na * na;

            Console.WriteLine($"Kerület: {nker}");
            Console.WriteLine($"Terület: {nter}");
            if (nker > nter)
            {
                Console.WriteLine("A terület a nagyobb.");
            }
            else if (nker < nter)
            {
                Console.WriteLine("A kerület a nagyobb.");
            }
            else
            {
                Console.WriteLine("Egyenlő.");
            }
            Console.WriteLine("--------------------------------------------------");
