//Téglalap terület, kerület
Console.WriteLine("Téglalap terület, kerület.");
Console.Write("Kérem az 'a' oldalt: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Kérem a 'b' oldalt: ");
int b = int.Parse(Console.ReadLine());
int ker = 2 * a + 2 * b;
int ter = a * b;
Console.WriteLine($"A kerület: {ker}");
Console.WriteLine($"A terület: {ter}");
if (ker > ter)
{
    Console.WriteLine("A kerület a nagyobb.");
} 
else if (ker < ter)
{
    Console.WriteLine("A terület a nagyobb.");
} 
else
{
    Console.WriteLine("Egyenlő.");
}
Console.WriteLine(" ");

//Kör terület, kerület
Console.WriteLine("Kör terület, kerület.");
Console.Write("Kérem a kör sugarát: ");
int r = int.Parse(Console.ReadLine());
double kker = 2 * r * Math.PI;
double kter = r * r * Math.PI;

Console.WriteLine($"A kerület: {kker}");
Console.WriteLine($"A terület: {kter}");
if (kker > kter)
{
    Console.WriteLine("A kerület a nagyobb.");
}
else if (kker < kter)
{
    Console.WriteLine("A terület a nagyobb.");
}
else
{
    Console.WriteLine("Egyenlő.");
}
Console.WriteLine(" ");

//Pitagorasz tétel
Console.WriteLine("Pitagorasz tétel.");
Console.Write("Kérem az 'a' számot: ");
int pa = int.Parse(Console.ReadLine());
Console.Write("Kérem az 'b' számot: ");
int pb = int.Parse(Console.ReadLine());
int pc = pa * pa + pb * pb;
Console.WriteLine($"{pa}^2 + {pb}^2 = {pc}^2");

double c = pc * pc;
Console.WriteLine($"c = {c}");
