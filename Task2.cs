Console.WriteLine("Введите M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine()!);

Console.Write(SumNumbers(m, n));


int SumNumbers(int m, int n)
{
    if (n == m)
    {
        return n;
    }
    else
    {

        return n + SumNumbers(m, n - 1);

    }
}