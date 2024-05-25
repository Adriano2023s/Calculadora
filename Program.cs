using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nun1;
            double nun2;
            int resultado = 0;

            Console.WriteLine("Digite um número \n");
            nun1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número \n");
            nun2 = double.Parse(Console.ReadLine());

            Console.Clear();

            while (resultado != 5)
            {
                Console.WriteLine("Para somar digite 1:");
                Console.WriteLine("Para subtrair digite 2:");
                Console.WriteLine("Para multiplicar digite 3:");
                Console.WriteLine("Para dividir digite 4:");
                Console.WriteLine("Para sair digite 5:");
                resultado = int.Parse(Console.ReadLine());

                if (resultado == 1)
                {
                    Console.WriteLine("Soma = {0}", nun1 + nun2);
                }
                if (resultado == 2)
                {
                    Console.WriteLine("Subtração = {0}", nun1 + nun2);
                }
                if(resultado == 3)
                {
                    Console.WriteLine("Multiplicação = {0}", nun1 + nun2);
                }
                if (resultado == 4)
                {
                    Console.WriteLine("Divizão = {0}", nun1 + nun2);
                }
                if (resultado == 5)
                {
                    Console.WriteLine("Programa enserrado");
                }
            }
        }
    }
}
