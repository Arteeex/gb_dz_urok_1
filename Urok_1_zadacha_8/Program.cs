Console.Clear();

int i = 1;
Console.Write(">>> ");
int a = Convert.ToInt32(Console.ReadLine());

while (i < a)
{
i++;
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
        
    }
    
}