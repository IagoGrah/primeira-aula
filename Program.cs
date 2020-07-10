using System;

namespace primeira_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira sua idade:");
        input:
            if (Int32.TryParse(Console.ReadLine(), out int userAge) == false)
            {
                Console.WriteLine("ERRO, insira um número inteiro.");
                goto input;
            }
            Console.WriteLine(userAge > 15 && userAge < 51 ? "Pode participar." : "NÃO pode participar.");
        }
    }
}