string mappaUtvonal = @"C:\Users\user\Documents\Molnár Hanga Borbála\C#";
string fajlNev = "Autok.txt";
string teljesUtvonal = Path.Combine(mappaUtvonal, fajlNev);
List<string> autok = new List<string>();

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"{i}. autó adatai:");
    Console.WriteLine("Név: "); string nev = Console.ReadLine();
    Console.WriteLine("Ajtók: "); string ajtok = Console.ReadLine();
    Console.WriteLine("LE: "); string loero = Console.ReadLine();
    autok.Add($"{nev} {ajtok} {loero}");
}

try
{
    Directory.CreateDirectory(mappaUtvonal);
    File.WriteAllLines(teljesUtvonal, autok);
    Console.WriteLine("--- Mentés Sikeres ---");

    Console.WriteLine("A fájl tartalma:");
    string[] beolvasottSorok = File.ReadAllLines(teljesUtvonal);
    foreach (string sor in beolvasottSorok)
    {
        Console.WriteLine(sor);
    }
}
catch (Exception e)
{
    Console.WriteLine("Hiba: " + e.Message);
}
Console.ReadKey();
