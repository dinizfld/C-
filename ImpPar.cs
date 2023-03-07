using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = 0;
        int r = 0;
Console.WriteLine("Determine se o número é par ou impar");
Console.Write("Informe um número: ");
n = Convert.ToInt32(Console.ReadLine());
r = n % 2;
se (r == 1)
{
Console.WriteLine("O número informado é impar");
}
outro
{
Console.WriteLine("O número informado é par");
}
Console.ReadKey();
    }
}
