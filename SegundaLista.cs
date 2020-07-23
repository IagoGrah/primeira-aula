using System;

namespace primeira_aula
{
    class X2
    {
        public static void yUm()
        {
            double[] A = {5,8,13,75,32,98,34,12,76,1278,87,123,246,745,998};
            double[] B = {7,543,31,54,134,123,765,345,23,7,3,9,3,2,169};
            double[] C = new double[15];

            for (int i = 0; i < 15; i++)
            {
                C[i] = A[i]-B[i];
            }
            
            Console.WriteLine("C: {0}", string.Join(", ", C));
        }

        public static void yDois()
        {
            int[] input = new int[10];
            int[] output = new int[10];

            Console.Clear();
            Console.WriteLine("Insira 10 inteiros:");
            for (int i=0; i<10; i++)
            {
                input[i] = Int32.Parse(Console.ReadLine());
            }
            
            int c = 0;
            for (int x=9; x>=0; x--)
            {
                output[x] = input[c];
                c++;
            }

            Console.WriteLine("REVERSE: {0}", string.Join(", ", output));
        }

        public static void yTres()
        {
            double[] input = new double[10];

            Console.Clear();
            Console.WriteLine("Insira 10 números:");
            for (int i=0; i<10; i++)
            {
                input[i] = Double.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("Insira um número para procurar no array:");
            double userNum = Double.Parse(Console.ReadLine());
            foreach (double item in input)
            {
                if (item == userNum)
                {
                    Console.WriteLine("O número se encontra no array na posição "+ Array.IndexOf(input, item)+".");
                    break;
                }
            }
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("EXERCÍCIOS DE ARRAY");
            Console.WriteLine("Escolha um exercício de 1 a 6:");
            switch (Console.ReadLine())
            {
                case "1": yUm(); break;
                case "2": yDois(); break;
                case "3": yTres(); break;
                // case "4": yQuatro(); break;
                // case "5": yCinco(); break;
                // case "6": ySeis(); break;
                default: Console.WriteLine("ERRO: O exercício não existe."); break;
            }
        }
    }
}