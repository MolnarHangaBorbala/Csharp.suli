//DOBÁS
Console.Write("Hány alkalommal legyen feldobás? ");
int N = int.Parse(Console.ReadLine());

Random kocka = new Random();
int M = 0;

int A = 0;
int P = 0;

while (M < N)
{
    int dob1 = kocka.Next(1, 6);
    int dob2 = kocka.Next(1, 6);
    int dob3 = kocka.Next(1, 6);

    int összeg = dob1 + dob2 + dob3;
    Console.Write("Dobás: " + dob1 + " + " + dob2 + " + " + dob3 + " = " + összeg);

    if (összeg < 10)
    {
        Console.WriteLine("     Nyertes: Anni");
        A++;
    } else if (összeg > 10)
    {
        Console.WriteLine("    Nyertes: Panni");
        P++;
    } else
    {
        Console.WriteLine("    Nyertes: Panni");
        P++;
    }
    M++;
}

Console.WriteLine("A játék során " + A + " alkalommal Anni, " + P + " alkalommal Panni nyert. ");

//https://dload-oktatas.educatio.hu/erettsegi/feladatok_2022osz_kozep/k_digkult_22okt_fl.pdf
