int[] dobasok = { 3, 1, 1, 2, 1, 5, 5, 4, 4, 4, 1, 2, 3, 6, 4, 6, 1, 4 };
List<int> mezoallapot = new List<int>();
int mezo = 0;
int letra = 0;

foreach (int dob in dobasok)
{
    mezo += dob;

    if (mezo % 10 == 0)
    {
        mezo -= 3;
        letra += 1;
    }
    mezoallapot.Add(mezo);
}

Console.WriteLine("2. feladat");
Console.WriteLine(string.Join(" ", mezoallapot));

Console.WriteLine("3. feladat");
Console.WriteLine("A játék során " + letra + " alkalommal lépett létrára.");

Console.WriteLine("4. feladat");
if (mezo >= 45)
{
    Console.WriteLine("A játékot befejezte.");
}
else
{
    Console.WriteLine("A játékot abbahagyta.");
}

//https://dload-oktatas.educatio.hu/erettsegi/feladatok_2024tavasz_kozep/k_digkult_24maj_fl.pdf
