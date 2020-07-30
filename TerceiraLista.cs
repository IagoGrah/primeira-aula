using System;
using System.Linq;

namespace primeira_aula
{
    public class X3
    {
        public static void zUm()
        {
            double[] A = new double[10];
            double[] B = new double[10];
            double[] temp = new double[10];
            
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

            temp = A;
            A = B;
            B = temp;

            Console.Clear();
            Console.WriteLine("Array A:");
            Console.WriteLine(string.Join(", ", A));
            Console.WriteLine("Array B:");
            Console.WriteLine(string.Join(", ", B));
        }

        public static void zDois()
        {
            double[] arr = new double[10];
            
            Console.Clear();
            Console.WriteLine("Insira 10 números:");
            for (int i=0; i<10; i++)
            {
                arr[i] = Double.Parse(Console.ReadLine());
            }
            Console.WriteLine(arr.Length != arr.Distinct().Count() ? "CONTÉM repetição." : "NÃO contém repetição.");
        }
        
        public static void zTres()
        {
            string[] answers = new string[10];
            string[] sexos = new string[10];
            int sim = 0;
            int nao = 0;
            int homens = 0;
            int mulheres = 0;
            int homensSim = 0;
            int mulheresSim = 0;
            
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("PESSOA #"+(i+1));
                Console.WriteLine("Você gostou do produto? Responda com S ou N:");                
              prompt:
                string input = Console.ReadLine();
                if (input == "S")
                {
                    answers[i] = "S";
                    sim++;
                }
                else if (input == "N")
                {
                    answers[i] = "N";
                    nao++;
                }
                else
                {
                    Console.WriteLine("Por favor responda com 'S' ou 'N':");
                    goto prompt;
                }

                Console.WriteLine("Você é homem ou mulher? Responda com 'H' ou 'M':");
              promptSexo:
                string inputSexo = Console.ReadLine();
                if (inputSexo == "H")
                {
                    sexos[i] = "H";
                    homens++;
                }
                else if (inputSexo == "M")
                {
                    sexos[i] = "M";
                    mulheres++;
                }
                else
                {
                    Console.WriteLine("Por favor responda com 'H' para homem ou 'M' para mulher:");
                    goto promptSexo;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (sexos[i] == "H" && answers[i] == "S") {homensSim++;}
                else if (sexos[i] == "M" && answers[i] == "S") {mulheresSim++;}
            }
            
            Console.WriteLine(sim + " pessoas votaram SIM");
            Console.WriteLine(nao + " pessoas votaram NAO");
            Console.WriteLine(mulheresSim*(100/mulheres) + "% das mulheres votaram sim.");
            Console.WriteLine((homens-homensSim)*(100/homens) + "% dos homens votaram não.");
        }

        public static void zQuatro()
        {
            
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("EXERCÍCIOS DE ARRAY 2");
            Console.WriteLine("Escolha um exercício de 1 a 9:");
            switch (Console.ReadLine())
            {
                case "1": zUm(); break;
                case "2": zDois(); break;
                case "3": zTres(); break;
                // case "4": zQuatro(); break;
                // case "5": zCinco(); break;
                // case "6": zSeis(); break;
                default: Console.WriteLine("ERRO: O exercício não existe."); break;
            }
        }
    }
}