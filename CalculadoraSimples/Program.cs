using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("CALCULADORA SIMPLES");
                Console.WriteLine("Escolha uma operação");
                Console.WriteLine("1 = Soma");
                Console.WriteLine("2 = Subtração");
                Console.WriteLine("3 = Multiplicação");
                Console.WriteLine("4 = Divisão");
                Console.WriteLine("0 = Sair");
                string opcao = Console.ReadLine();

                if (opcao == "0")
                {
                    Console.WriteLine("\nEncerrando...");
                    break;
                }

                Console.Write("\nDigite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                double resultado = 0;

                switch (opcao)
                {
                    case "1":
                        resultado = num1 + num2;
                        Console.WriteLine($"\nResultado: {num1} + {num2} = {resultado}");
                        break;

                    case "2":
                        resultado = num1 - num2;
                        Console.WriteLine($"\nResultado: {num1} - {num2} = {resultado}");
                        break;

                    case "3":
                        resultado = num1 * num2;
                        Console.WriteLine($"\nResultado: {num1} * {num2} = {resultado}");
                        break;

                    case "4":
                        resultado = num1 / num2;
                        Console.WriteLine($"\nResultado: {num1} / {num2} = {resultado}");
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida!");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

        }
    }
}
