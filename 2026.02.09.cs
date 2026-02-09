//Téglalap ker ter
static void Szamol()
{
    Console.Write("Téglalap 'a' oldala: ");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Téglalap 'b' oldala: ");
    double b = double.Parse(Console.ReadLine());

    double ker = 2*a+2*b;
    double ter = a * b;

    Console.WriteLine($"Kerület: {ker}");
    Console.WriteLine($"Terület: {ter}");
}

//Négyzet ker ter
static void Szamol2()
{
    Console.Write("Négyzet 'a' oldala: ");
    double a2 = double.Parse(Console.ReadLine());

    double ker2 = 4 * a2;
    double ter2 = a2 * a2;

    Console.WriteLine($"Kerület: {ker2}");
    Console.WriteLine($"Terület: {ter2}");
}

//Kör ker ter
static void Szamol3()
{
    Console.Write("Kör 'r' sugara: ");
    double r = double.Parse(Console.ReadLine());

    double ker3 = 2 * r * Math.PI;
    double ter3 = r * r * Math.PI;

    Console.WriteLine($"Kerület: {ker3}");
    Console.WriteLine($"Terület: {ter3}");
}

static void Main(string[] args)
{
    Szamol();
    Szamol2();
    Szamol3();
}
