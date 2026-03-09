string mappaUtvonal = @"C:\Users\user\Documents\Molnár Hanga Borbála\C#\";
string fileNév = "elso.txt";
string teljesUtvonal = Path.Combine(mappaUtvonal, fileNév);

Directory.CreateDirectory(mappaUtvonal);

Console.WriteLine("Írj be sorokat (Vége:'vege'):");
using (StreamWriter sw = new StreamWriter(teljesUtvonal))
{
    string sor;
    while ((sor = Console.ReadLine()) != "vege")
    {
        sw.WriteLine(sor);
    }
}

Console.WriteLine("--- A fájl tartalma: ---");
if(File.Exists(teljesUtvonal))
{
    using (StreamReader sr = new StreamReader(teljesUtvonal))
    {
        string tartalom = sr.ReadToEnd();
        Console.WriteLine(tartalom);
    }
}

Console.WriteLine("Nyomj egy gombot a kilépéshez...");
Console.ReadKey();
