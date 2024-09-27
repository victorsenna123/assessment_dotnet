using System;

namespace DelegateAnonymousMethods
{
    class Program
    {
        // Definindo um delegate que aceita uma string como parâmetro
        public delegate void StringOperation(string input);

        static void Main(string[] args)
        {
            // Solicitar ao usuário uma frase
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();

            // Delegate para imprimir a frase em letras maiúsculas
            StringOperation upperCaseOperation = delegate (string input)
            {
                Console.WriteLine($"Em maiúsculas: {input.ToUpper()}");
            };

            // Delegate para imprimir a frase em letras minúsculas
            StringOperation lowerCaseOperation = delegate (string input)
            {
                Console.WriteLine($"Em minúsculas: {input.ToLower()}");
            };

            // Executando os delegates
            upperCaseOperation(frase);
            lowerCaseOperation(frase);
        }
    }
}
