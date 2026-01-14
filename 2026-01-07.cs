/*
//Páros számok
List<int> szamok = new List<int>{1, 2, 3, 4, 5, 6, 7, 8};
List<int> parosszamok = new List<int>();

foreach (int szam in szamok)
{
    if (szam % 2 == 0)
    {
        parosszamok.Add(szam);
    }
}
Console.WriteLine("2-vel osztható számok: " + string.Join(", ", parosszamok));

//Switch
Console.WriteLine("Adj meg eg számot (1-7): ");
int nap = int.Parse(Console.ReadLine());

switch (nap)
{
    case 1:
        Console.WriteLine("Hétfő");
        break;
    case 2:
        Console.WriteLine("Kedd");
        break;
    case 3:
        Console.WriteLine("Szerda");
        break;
    case 4:
        Console.WriteLine("Csütörtök");
        break;
    case 5:
        Console.WriteLine("Péntek");
        break;
    case 6:
        Console.WriteLine("Szombat");
        break;
    case 7:
        Console.WriteLine("Vasárnap");
        break;
    default:
        Console.WriteLine("Nincs ilyen nap.");
        break;
}*/

//1. feladat: Uszás
Console.WriteLine("1. feladat: Kérem adja meg a heti aktivitást (MAX 250 karakter.): ");
string aktivitas = Console.ReadLine();

//2. feladat - távolság kiszámítása
int osszKm = 0;
bool voltU = false, voltG = false, voltF = false, voltK = false;

foreach (char c in aktivitas)
{
    switch (c)
    {
        case 'U': osszKm += 1; voltU = true; break;
        case 'G': osszKm += 1; voltG = true; break;
        case 'F': osszKm += 2; voltF = true; break;
        case 'K': osszKm += 10; voltK = true; break;
    }
}
Console.WriteLine("2. feladat: A felhasználó által megtett távolság: {0} km", osszKm);
int jutalom = 0;
if (voltU && voltG && voltK && voltF)
{
    jutalom = 10;
    Console.WriteLine("3. feladat: Bravo! Jutalma még 10 km.");
}
else
{
    Console.WriteLine("3. feladat: Nem jár jutalom.");
}
//4. feladat - végső teljesítmény + kiértékelés
int vegsokm = osszKm + jutalom;
Console.WriteLine("4. feladat: Összesített teljesítmény: {0} km", vegsokm);

if (vegsokm >= 40)
{
    Console.WriteLine("Gratulálok, kihívás teljesítve!");
}
else
{
    Console.WriteLine("Nem sikerült a kihívás.");
}

https://www.decathlon.hu/p/mp/hms/pro-hantli-sulyzo-kettlebell-keszlet-pro-hms-sgn/_/R-p-ee27ce40-0780-4a92-b1f2-144fcc04b106?mc=ee27ce40-0780-4a92-b1f2-144fcc04b106_c1c14
https://www.decathlon.hu/p/mp/hms/kompozit-sulyzok-rud-sulyzo-hms-sgc/_/R-p-baefa38e-4e51-4228-a3a6-348df2eef7ef?mc=baefa38e-4e51-4228-a3a6-348df2eef7ef_c1c14
