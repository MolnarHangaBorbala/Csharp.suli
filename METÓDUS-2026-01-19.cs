//METÓDUS
//1
static void kíirat()
{
    Console.WriteLine("Hello Premo");
}

static void Main(string[] args)
{
    kíirat();
}

//2
static void kíirat(string nev)
{
    Console.WriteLine(nev + "Hello");
}

static void Main(string[] args)
{
    kíirat("Timi ");
    kíirat("Tamás ");
}

//3
static void kíirat(string nev, int kor)
{
    Console.WriteLine(nev + "Hello " + kor + " éves");
}

static void Main(string[] args)
{
    kíirat("Timi ", 20);
    kíirat("Tamás ", 32);
}

//4
static void kíirat(string iskola="Premo")
{
    Console.WriteLine("Hello " + iskola);
}

static void Main(string[] args)
{
    kíirat();
    kíirat("Vajda");
    kíirat();
    kíirat("VSZK");
}

//5
static void szamol()
{
    Console.Write("Kérem a négyzet oldalát: ");
    int szam = int.Parse(Console.ReadLine());
    Console.WriteLine("A négyzet területe: " + szam * szam);
}

static void Main(string[] args)
{
    szamol();
}

//6
static int szamol()
{
    Console.Write("Kérem a négyzet oldalát: ");
    int szam = int.Parse(Console.ReadLine());
    int ter = szam * szam;
    return ter;
}

static void Main(string[] args)
{
    Console.WriteLine("A négyzet területe: " + szamol());
}
