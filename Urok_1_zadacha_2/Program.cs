Console.Clear();

Console.Write(">>> ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write(">>> ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine($"max = {a}");
}
else
{
    Console.WriteLine($"max = {b}");
}