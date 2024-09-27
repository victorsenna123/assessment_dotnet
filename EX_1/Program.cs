using System;

namespace DelegateExample
{
    // Definindo um delegate que aceita dois inteiros e retorna um inteiro
    public delegate int Operation(int x, int y);

    class Program
    {
        // Métodos que implementam o delegate
        public static int Soma(int x, int y)
        {
            return x + y;
        }

        public static int Subtracao(int x, int y)
        {
            return x - y;
        }

        public static int Multiplicacao(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            // Solicitar dois números ao usuário
            Console.WriteLine("Digite o primeiro número:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Mostrar opções de operação
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1: Soma");
            Console.WriteLine("2: Subtração");
            Console.WriteLine("3: Multiplicação");

            // Ler a escolha do usuário
            int choice = Convert.ToInt32(Console.ReadLine());

            // Instanciando o delegate
            Operation operation = null;

            // Determinar qual operação executar
            switch (choice)
            {
                case 1:
                    operation = Soma;
                    break;
                case 2:
                    operation = Subtracao;
                    break;
                case 3:
                    operation = Multiplicacao;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    return;
            }

            // Executar a operação escolhida e exibir o resultado
            int resultado = operation(num1, num2);
            Console.WriteLine($"O resultado é: {resultado}");
        }
    }
}
