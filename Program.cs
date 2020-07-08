using System;

namespace primeira_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira sua idade:");
            string input = Console.ReadLine();

            int userAge = Int32.Parse(input);

            string msg = "";
            if (userAge > 15 & userAge < 51) {
                msg = "Você pode participar.";
            } else {
                msg = "Você NÃO pode participar.";
            }

            Console.WriteLine(msg);
        }
    }
}
