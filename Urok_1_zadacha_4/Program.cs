Console.Clear();

Console.Write(">>> ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(">>> ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write(">>> ");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b && a > c)
{
    Console.WriteLine($"Максимальное из трёх: {a}");
}
else if (b > a && b > c)
{
    Console.WriteLine($"Максимальное из трёх: {b}");
}
else 
{
    Console.WriteLine($"Масимальное из трёх: {c}");
}