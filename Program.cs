using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Operacoes op = new Operacoes();

                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("Opção 1: Adição");
                Console.WriteLine("Opção 2: Subtração");
                Console.WriteLine("Opção 3: Multiplicação");
                Console.WriteLine("Opção4: Divizão");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite linha a linha os números que deseja somar");
                        op.num1 = int.Parse(Console.ReadLine());
                        op.num2 = int.Parse(Console.ReadLine());

                        Console.WriteLine($"O resultado da sua soma é: {op.Somar()}");
                        break;

                    case 2:
                        Console.WriteLine("Digite linha a linha os números que deseja subtrair");
                        op.num1 = int.Parse(Console.ReadLine());
                        op.num2 = int.Parse(Console.ReadLine());

                        Console.WriteLine($"O resultado da sua subtração é: {op.Subtrair()}");
                        break;

                        case 3:
                        Console.WriteLine("Digite linha a linha os números que deseja multiplicar");
                        op.num1 = int.Parse(Console.ReadLine());
                        op.num2= int.Parse(Console.ReadLine());

                        Console.WriteLine($"O resultado da sua multiplicação é de: {op.Multiplicar()}");
                        break;

                    case 4:
                        Console.WriteLine("Digite linha a linha os números que deseja dividir");
                        op.num1 = int.Parse(Console.ReadLine());
                        op.num2 = int.Parse(Console.ReadLine());

                        Console.WriteLine($"O resultado da sua divizão é: {op.Dividir()}");
                        break;
                }
            }


        }
    }
}
