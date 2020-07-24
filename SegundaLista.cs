using System;

namespace primeira_aula
{
    class X2
    {
        public static void yUm()
        {
            double[] A = new double[15];
            double[] B = new double[15];
            double[] C = new double[15];

            Console.Clear();
            Console.WriteLine("Insira os 15 números de A:");
            for (int i=0; i<15; i++)
            {
                A[i] = Double.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("Insira os 15 números de B:");
            for (int i=0; i<15; i++)
            {
                B[i] = Double.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < 15; i++)
            {
                C[i] = A[i]-B[i];
            }
            
            Console.Clear();
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

        public static void yQuatro()
        {
            double[] A = new double[10];
            double[] B = new double[10];

            Console.Clear();
            Console.WriteLine("Insira os 10 números de A:");
            for (int i=0; i<10; i++)
            {
                A[i] = Double.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("Insira os 10 números de B:");
            for (int i=0; i<10; i++)
            {
                B[i] = Double.Parse(Console.ReadLine());
            }

            Console.Clear();
            for (int i=0; i<10; i++)
            {
                if (A[i] != B[i])
                {
                    Console.WriteLine("A e B NÃO são arrays idênticos.");
                    return;
                }
            }

            Console.WriteLine("A e B são arrays idênticos.");
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
                case "4": yQuatro(); break;
                // case "5": yCinco(); break;
                // case "6": ySeis(); break;
                default: Console.WriteLine("ERRO: O exercício não existe."); break;
            }
        }
    }
}