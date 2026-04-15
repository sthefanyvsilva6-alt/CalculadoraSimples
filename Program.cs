using System;

// namespace organiza nosso codigo
namespace CalculadoraSimples
{
    class Program
    {
        
        static void Main(string[]args)
        {
            
            Console.WriteLine("---Calculadora Senai---");

            Console.Write("Digite o primeiro numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double soma = num1 + num2;
            Console.WriteLine($"O resultado da soma é: {soma}");
        }
    }
}