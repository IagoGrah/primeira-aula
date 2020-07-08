using System;

namespace primeira_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            string myText = "salve";
            int myNumber = 8;
            float myPrice = 4.099f;
            bool myBoolean = myPrice == myNumber;

            Console.WriteLine("Você é maior de idade?");
            var result = Console.ReadLine();

            myBoolean = result == "sim";

            Console.WriteLine(myText);
            Console.WriteLine(myBoolean);
            Console.WriteLine(myBoolean);
        }
    }
}
