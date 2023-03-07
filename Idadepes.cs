using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int qtde = 0;
 int idade = 0;
 Console.WriteLine("Exercício 2 - Verifica maior idade");
 int i = 0;
 while (i < 10)
 {
 i = i + 1;
 Console.Write("Informe a idade da pessoa: ");
 idade = Convert.ToInt32(Console.ReadLine());
 if (idade >= 18)
 {
 qtde = qtde + 1;
 }
 }
 Console.WriteLine("Existem " + qtde + " pessoas com mais de 18 anos");
 Console.ReadKey();
    }
}
