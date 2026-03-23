string mappaUtvonal = @"C:\premo\harom\";
string fajlNev = "jatekos.txt";
string teljesUtvonal = Path.Combine(mappaUtvonal, fajlNev);
List<string> jatekosok = new List<string>();

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"{i}. Játékosok adatai:");
    Console.WriteLine("Név: "); string nev = Console.ReadLine();
    Console.WriteLine("Születési év (4 karakter): "); string szuletesiev = Console.ReadLine();
    Console.WriteLine("Magasság (3 karakter): "); string magassag = Console.ReadLine();
    Console.WriteLine("Dobott pontok száma (3 karakter): "); string dobottpontok = Console.ReadLine();
    jatekosok.Add($"{nev} {szuletesiev} {magassag} {dobottpontok}");
}

try
{
    Directory.CreateDirectory(mappaUtvonal);
    File.WriteAllLines(teljesUtvonal, jatekosok);
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
