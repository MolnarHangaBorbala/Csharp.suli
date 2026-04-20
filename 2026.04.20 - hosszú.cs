List<string> nev = new List<string>();
List<int> nap = new List<int>();
List<int> sorszam = new List<int>();
List<int> hossz = new List<int>();
List<string> cím = new List<string>();

//1. feladat: Beolvasás
Console.WriteLine("1. feladat: Fájl beolvasása");
string[] sorok = File.ReadAllLines("C:\\Users\\user\\Documents\\Molnár Hanga Borbála\\C#\\eloadasok.txt");

foreach (string sor in sorok)
{
    string[] t = sor.Split('\t');
    nev.Add(t[0]);
    nap.Add(int.Parse(t[2]));
    sorszam.Add(int.Parse(t[3]));
    hossz.Add(int.Parse(t[4]));
    cím.Add(t[5]);
}

//2. feladat
Console.WriteLine("\n2. feladat:");
for (int n = 5; n <= 8; n++)
{
    Console.WriteLine($"november {n}");

    for (int i = 0; i < nev.Count; i++)
    {
        if (nap[i] == n)
        {
            Console.WriteLine($"{sorszam[i]}. {nev[i]}: {cím[i]}");
        }
    }
}

//3. feladat
Console.WriteLine("\n3. feladat:");
for (int n = 5; n <= 8; n++)
{
    int ossz = 0;
    for (int i = 0; i < hossz.Count; i++)
    {
        if (nap[i] == n)
        {
            ossz += hossz[i];
        }
    }
    Console.WriteLine($"{n - 4}. nap: {ossz / 60}:{ossz % 60:D2}");
}

//4. feladat
Console.WriteLine("\n4. feladat:");
int max = 0;

for (int i = 0; i < nev.Count; i++)
{
    if (nap[i] == 6 && hossz[i] > max)
    {
        max = hossz[i];
    }
}
for (int i = 0; i < nev.Count; i++)
{
    if (nap[i] == 6 && hossz[i] == max)
    {
        Console.WriteLine($"{nev[i]} - {hossz[i]} perc");
    }
}

//5. feladat
Console.WriteLine("\n5. feladat:");
for (int n = 5; n <= 8; n++)
{
    int ido = 8 * 60;
    bool voltEbed = false;
    for (int i = 0; i < nev.Count; i++)
    {
        if (nap[i] == n)
        {
            ido += hossz[i];
            ido += 20;
            if (!voltEbed && ido >= 12 * 60)
            {
                ido += 60;
                voltEbed = true;
            }
        }
    }
    Console.WriteLine($"november {n}: {ido / 60}:{ido % 60:D2}");
}

//6. feladat
Console.WriteLine("\n6. feladat:");
int ido2 = 8 * 60;
for (int i = 0; i < nev.Count; i++)
{
    if (nap[i] == 7)
    {
        ido2 += hossz[i];
        if (ido2 >= 12 * 60)
        {
            Console.WriteLine($"Az ebédszünet {ido2 / 60}:{ido2 % 60:D2}-kor kezdődik.");
            break;
        }
        ido2 += 20;
    }
}

//7. feladat

//8. feladat
Console.WriteLine("\n8. feladat:");
Console.Write("Nap (5-8): ");
int keresettNap = int.Parse(Console.ReadLine());

Console.Write("Óra: ");
int ora = int.Parse(Console.ReadLine());

Console.Write("Perc: ");
int perc = int.Parse(Console.ReadLine());

int keresettIdo = ora * 60 + perc;

int ido = 8 * 60;
bool voltEbed = false;
bool talalt = false;

for (int i = 0; i < nev.Count; i++)
{
    if (nap[i] == keresettNap)
    {
        int eloStart = ido;
        int eloEnd = ido + hossz[i];

        // előadás
        if (keresettIdo >= eloStart && keresettIdo < eloEnd)
        {
            Console.WriteLine("Előadás");
            talalt = true;
            break;
        }

        ido = eloEnd;

        // vita
        int vitaEnd = ido + 20;

        if (keresettIdo >= ido && keresettIdo < vitaEnd)
        {
            Console.WriteLine("Vita");
            talalt = true;
            break;
        }

        ido = vitaEnd;

        // ebéd
        if (!voltEbed && ido >= 12 * 60)
        {
            int ebedEnd = ido + 60;

            if (keresettIdo >= ido && keresettIdo < ebedEnd)
            {
                Console.WriteLine("Ebédszünet");
                talalt = true;
                break;
            }

            ido = ebedEnd;
            voltEbed = true;
        }
    }
}

if (!talalt)
{
    if (keresettIdo < 8 * 60)
        Console.WriteLine("Még nem kezdődött el");
    else
        Console.WriteLine("Már véget ért");
}

//9. feladat
