            //PreKeszthely@2018
            //Gyakorlás
            //NÉGYZET ker, ter
            /*
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
            int tanar = rnd.Next(1, 6);
            Console.WriteLine($"A tanár {tanar} dobott.");
            int diak = rnd.Next(1, 6);
            Console.WriteLine($"A diák {diak} dobott.");
            if (tanar == diak)
            {
                Console.WriteLine("Döntetlen.");
            }
            else if (diak > tanar)
            {
                Console.WriteLine("Diák nyert.");
            }
            else
            {
                Console.WriteLine("Tanár nyert.");
            }
            
            //FOR CIKLUS
            for (int i1 = 1; i1 <= 5; i1++)
            {
                Console.WriteLine(i1);
            }

            //
            for (int b = 1; b <= 5; b++)
            {
                Console.WriteLine("Hajrá ZTE");
            }
            for (int b = 1; b <= 3; b++)
            {
                Console.WriteLine("Fújpest");
            }

            //
            string[] nevek = { "Anna", "Béla", "Csaba" };
            for (int c = 0; c < nevek.Length; c++)
            {
                Console.WriteLine(nevek[c]);
            }

            //
            string[] nevek2 = { "Anna", "Béla", "Csaba" };
            foreach (string nev in nevek2)
            {
                Console.WriteLine(nev);
            }

            //
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            //
            int i2 = 0;
            do
            {
                Console.WriteLine(i);
                i2++;
            } while (i2 < 5);
*/
            //MIN
            int[] szamok = { 12, 5, 8, -3, 15, 0 };
            //kezdő minimum az első elem
            int min = szamok[0];
            //végigmegyünk a tömbön for ciklussal
            for (int i3 = 1; i3 < szamok.Length; i3++)
            {
                if (szamok[i3] < min)
                {
                    min = szamok[i3];
                }
            }
            Console.WriteLine($"A legkisebb szám: {min}");

            //MIN2
            int[] szamok2 = { 12, 5, 8, -3, 15, 0 };
            //kezdő minimum az első elem
            int min2 = szamok[0];
            foreach (int szam in szamok2)
            {
                if (szam < min2)
                {
                    min2 = szam;
                }
            }
            Console.WriteLine($"A legkisebb szám: {min2}");

            //MIN3
            int[] szamok3 = { 12, 5, 8, -3, 15, 0 };
            //kezdő minimum az első elem
            int min3 = szamok3[0];
            int i4 = 1;  //a 0. elemet már betettük a min-be
            while (i4 < szamok3.Length)
            {
                if (szamok3[i4] < min3)
                {
                    min3 = szamok3[i4];
                }
            }
            Console.WriteLine($"A legkisebb szám: {min3}");

            //MIN4
            int[] szamok4 = { 12, 5, 8, -3, 15, 0 };
            
            int min4 = szamok4[0]; //kezdő minimum az első elem
            int i5 = 1;  //a 0. elemet már betettük a min-be
            do
            {
                if (szamok4[i5] < min4)
                {
                    min4 = szamok4[i5];
                }
                i5++;
            }
            while (i5 < szamok4.Length);
            Console.WriteLine($"A legkisebb szám: {min4}");

            //MIN5
            int[] szamok5 = { 12, 5, 8, -3, 15, 0 };
            int min5 = szamok5.Min();
            Console.WriteLine($"A legkisebb szám: {min5}");
