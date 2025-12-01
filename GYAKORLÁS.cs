            //Gyakorlás
            //NÉGYZET ker, ter
            Console.WriteLine("Négyzet kerülete:");
            Console.Write("Kérem az a oldalt: ");
            int Na = int.Parse(Console.ReadLine());
            Console.Write("A kerület: ");
            Console.WriteLine(4 * Na);
            Console.Write("A területe: ");
            Console.WriteLine(Na * Na);
            
            //TÉGLALAP ker, ter
            Console.WriteLine("Téglalap kerülete:");
            Console.Write("Kérem az a oldalt: ");
            double Ta = double.Parse(Console.ReadLine());
            Console.Write("Kérem a b oldalt: ");
            double Tb = double.Parse(Console.ReadLine());
            Console.WriteLine("A kerület: " + 2 * Ta + 2 * Tb);
            double ker = 2 * Ta + 2 * Tb;
            double ter = Ta * Tb;
            Console.WriteLine($"A területe: {ter}");

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

            //KOCKA
            Random rnd = new Random();

            Console.WriteLine("Tanár diák kocka játék.");
            int tanar = rnd.Next(1,6);
            Console.WriteLine($"A tanár {tanar} dobott.");
            int diak = rnd.Next(1, 6);
            Console.WriteLine($"A diák {diak} dobott.");
            if ( tanar == diak )
            {
                Console.WriteLine("Döntetlen.");
            }
            else if ( diak > tanar ) 
            {
                Console.WriteLine("Diák nyert.");
            }
            else
            {
                Console.WriteLine("Tanár nyert.");
            }

            //FOR CIKLUS
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
