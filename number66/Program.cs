Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

int sum = 0;
void sumNumbers( int m, int n, int sum)
{
    if (m==n)
    {
        sum = m + n;
        Console.WriteLine($"{sum}");
        return;
    }
    else
    {
        sum+=m;
        sumNumbers(m+1,n,sum);
    }
}


sumNumbers(m,n,sum);



 