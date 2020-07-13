using System;
using System.Linq;

namespace primeira_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new string[3];

            Console.WriteLine("Digite três nomes:");
            while (names.Count(s => s != null) < 3)
            {
                names[names.Count(s => s != null)] = Console.ReadLine();
            }
            
            Console.WriteLine($"Olá, {names[0]}, {names[1]} e {names[2]}.");
        }
    }
}