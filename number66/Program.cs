Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
int sum = 0;
for( int a = m; a<=n; a++)
{
    sum+=a;
}
Console.WriteLine(sum);