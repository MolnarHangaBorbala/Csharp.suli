using System;
using System.Collections.Generic;
using System.IO;

namespace MHB1001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileel = @"C:\Users\user\Documents\Molnár Hanga Borbála\C#\Forras\3_Sebesseg\ut.txt";

                List<List<object>> határok = new List<List<object>>();
                using (var bemenet = new StreamReader(@"C:\Users\user\Documents\Molnár Hanga Borbála\C#\Forras\3_Sebesseg\ut.txt"))
                {
                    int hossz = int.Parse(bemenet.ReadLine().Trim());
                    string sor;
                    while ((sor = bemenet.ReadLine()) != null)
                    {
                        var határ = new List<object>();
                        var parts = sor.Trim().Split();
                        határ.Add(int.Parse(parts[0]));
                        határ.Add(parts[1]);
                        határok.Add(határ);
                    }

                    Console.WriteLine("2. Feladat:");
                    Console.WriteLine("A települések neve:");
                    foreach (var határ in határok)
                    {
                        string nev = (string)határ[1];
                        if (nev.Length > 3)
                        {
                            Console.WriteLine(nev);
                        }
                    }

                    Console.WriteLine("3. Feladat::");
                    Console.Write("Adja meg a vizsgált szakasz hosszát km-ben! ");
                    double vizsgált = double.Parse(Console.ReadLine());
                    int minsebesség = 90;
                    foreach (var határ in határok)
                    {
                        int h0 = (int)határ[0];
                        string h1 = (string)határ[1];
                        if (h0 <= vizsgált * 1000)
                        {
                            if (h1.Length > 3)
                            {
                                minsebesség = Math.Min(minsebesség, 50);
                            }
                            if (h1.Length == 2)
                            {
                                if (int.TryParse(h1, out int val))
                                {
                                    minsebesség = Math.Min(val, minsebesség);
                                }
                            }
                        }
                    }
                    Console.WriteLine($"Az első {vizsgált} km-en {minsebesség} km/h volt a legalacsonyabb megengedett sebesség.");

                    Console.WriteLine("4. Feladat:");
                    int bent = 0;
                    foreach (var határ in határok)
                    {
                        string h1 = (string)határ[1];
                        int h0 = (int)határ[0];
                        if (h1.Length > 3)
                        {
                            bent -= h0;
                        }
                        else if (h1 == "]")
                        {
                            bent += h0;
                        }
                    }
                    double arány = 100.0 * bent / hossz;
                    Console.WriteLine($"Az út {arány:F2} százaléka vezet településen belül.");

                    Console.WriteLine("5. Feladat:");
                    Console.Write("Adja meg egy település nevét! ");
                    string keresett = Console.ReadLine();
                    int táblákszáma = 0;
                    int i = 0;
                    while ((string)határok[i][1] != keresett)
                    {
                        i++;
                    }
                    int kezdet = (int)határok[i][0];
                    while ((string)határok[i][1] != "]")
                    {
                        i++;
                        if (((string)határok[i][1]).Length == 2)
                        {
                            táblákszáma++;
                        }
                    }
                    int vég = (int)határok[i][0];
                    Console.WriteLine($"A sebességkorlátozó táblák száma: {táblákszáma}");
                    Console.WriteLine($"Az út hossza a településen belül {vég - kezdet} méter.");

                    Console.WriteLine("6. Feladat:");
                    i = 0;
                    int előzővége = -1;
                    int következőkezdet = -1;
                    string előzőneve = null;
                    string következőneve = null;
                    while ((string)határok[i][1] != keresett)
                    {
                        if (((string)határok[i][1]).Length > 3)
                        {
                            előzőneve = (string)határok[i][1];
                        }
                        if ((string)határok[i][1] == "]")
                        {
                            előzővége = (int)határok[i][0];
                        }
                        i++;
                    }
                    kezdet = (int)határok[i][0];
                    while ((string)határok[i][1] != "]")
                    {
                        i++;
                    }
                    vég = (int)határok[i][0];
                    i++;
                    while (i < határok.Count && ((string)határok[i][1]).Length <= 3)
                    {
                        i++;
                    }
                    if (i < határok.Count)
                    {
                        következőneve = (string)határok[i][1];
                        következőkezdet = (int)határok[i][0];
                    }
                    string legközelebbineve;
                    if (előzővége == -1)
                    {
                        legközelebbineve = következőneve;
                    }
                    else if (következőkezdet == -1)
                    {
                        legközelebbineve = előzőneve;
                    }
                    else
                    {
                        if (kezdet - előzővége <= következőkezdet - vég)
                        {
                            legközelebbineve = előzőneve;
                        }
                        else
                        {
                            legközelebbineve = következőneve;
                        }
                    }
                    Console.WriteLine($"A legközelebbi település: {legközelebbineve}");
                }
            }
        }
}

//https://dload-oktatas.educatio.hu/erettsegi/feladatok_2025osz_emelt/e_digkult_25okt_fl.pdf
