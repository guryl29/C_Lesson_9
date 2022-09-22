Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

int naturalNumbers ( int m, int n)
{
    if ( m == n)
    {
        Console.WriteLine($"{m}");
        return m;
    }
    else
    {
        Console.Write($"{m}  ");
        naturalNumbers(m+1,n);
    }
    return m;

}
naturalNumbers(m,n);






