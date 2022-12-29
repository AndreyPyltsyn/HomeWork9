Console.WriteLine("Введите M");
int n = int.Parse(Console.ReadLine()!);


Console.Write(PrintNumbers(n));


string PrintNumbers(int n)
{
    if (n == 1)
    {
        return n.ToString();
    }
    else
    {

        return n.ToString() + "," + PrintNumbers(n - 1);

    }
}