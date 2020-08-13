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
            
            // Console.WriteLine(arr.Length != arr.Distinct().Count() ? "CONTÉM repetição." : "NÃO contém repetição.");

            bool hasRepeat = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i] && i != j)
                    {
                        hasRepeat = true;
                        break;
                    }
                }
                if (hasRepeat) {break;}
            }
            Console.WriteLine(hasRepeat ? "CONTÉM repetição." : "NÃO contém repetição.");
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
            double[] A = new double[5];
            double sum = 0;
            
            Console.Clear();
            Console.WriteLine("Insira 5 números:");
            for (int i=0; i<5; i++)
            {
                double input = Double.Parse(Console.ReadLine());
                A[i] = input;
                if (input%2 != 0) {sum+=input;}
            }
            Console.WriteLine("Soma dos números ímpares: "+sum);
        }

        public static void zCinco()
        {
            double[] arr = new double[10];
            double positive = 0;
            
            Console.Clear();
            Console.WriteLine("Insira 10 números:");
            for (int i=0; i<10; i++)
            {
                double input = Double.Parse(Console.ReadLine());
                arr[i] = input;
                if (input > 0) {positive++;}
            }
            Console.WriteLine(positive+" números positivos.");
        }

        public static void zSeis()
        {
            double[] Q = new double[10];
            double biggest = 0;
            int position = 0;
            double input;

            Console.WriteLine("Insira 10 números positivos:");
            for (int i=0; i<10; i++)
            {
                do
                {
                    input = Double.Parse(Console.ReadLine());
                    if (input < 0)
                    {
                        Console.WriteLine("Apenas números POSITIVOS!");
                    }
                }
                while (input < 0);
                Q[i] = input;
                if (Q[i] >= biggest)
                {
                    biggest = Q[i];
                    position = i;
                }
            }
            Console.WriteLine("O maior número é "+biggest+", por último na posição "+position+".");
        }

        public static void zSete()
        {
            double[] A = new double[10];
            int same = 0;
            double input;

            Console.WriteLine("Insira 10 números:");
            for (int i=0; i<10; i++)
            {
                input = Double.Parse(Console.ReadLine());
                A[i] = input;
                if (input == i) {same++;}
            }
            Console.WriteLine("O valor de um item é igual à sua posição "+same+" vezes neste array.");
        }

        public static void zOito()
        {
            char[] arr = new char[10];
            int vowels = 0;
            
            Console.WriteLine("Insira 10 letras do alfabeto:");
            for (int i=0; i<10; i++)
            {
                bool isChar = Char.TryParse(Console.ReadLine(), out char input);
                
                if (!isChar || !Char.IsLetter(input))
                {
                    Console.WriteLine("ERRO! Inválido.");
                    return;
                }
                
                arr[i] = input;
                switch (char.ToUpper(input))
                {
                    case 'A':
                    case 'E': 
                    case 'I':
                    case 'O':
                    case 'U':
                        vowels++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("O array contém "+vowels+" vogais.");
        }

        public static void zNove()
        {
            char[] arr = new char[10];
            
            Console.WriteLine("Insira 10 letras do alfabeto:");
            for (int i=0; i<10; i++)
            {
                bool isChar = Char.TryParse(Console.ReadLine(), out char input);
                
                if (!isChar || !Char.IsLetter(input))
                {
                    Console.WriteLine("ERRO! Inválido.");
                    return;
                }

                arr[i] = input;
            }
            string frase = new string(arr);
            Console.WriteLine(frase);
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
                case "4": zQuatro(); break;
                case "5": zCinco(); break;
                case "6": zSeis(); break;
                case "7": zSete(); break;
                case "8": zOito(); break;
                case "9": zNove(); break;
                default: Console.WriteLine("ERRO: O exercício não existe."); break;
            }
        }
    }
}