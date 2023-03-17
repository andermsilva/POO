// See https://aka.ms/new-console-template for more information
using System;
using Fibonacci;

Console.Clear();

Sequencia sf = new Sequencia();

System.Console.Write("Informe um numero para verificação: ");
int numero = Convert.ToInt32(Console.ReadLine());

sf.Fibon(numero);
int i = 1;
foreach (int item in sf.lista)
{
    System.Console.Write(item + " ");

    if (item == numero)
        System.Console.WriteLine($"\nO Número {numero} pertence a sequencia de Fibonacci {i}º termo");
    else if(item > numero)
        System.Console.WriteLine($"\nO Número {numero} não pertence a sequencia de Fibonacci");
        
    i++;
}