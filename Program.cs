using System;

namespace primeira_aula
{
    class Program
    {
        static void qUm()
        {
            Console.WriteLine("Crescente:");

            for (int i=1; i<=10; i++)
            {
                Console.Write(i+" ");
            }

            Console.WriteLine("\nDecrescente:");

             for (int i=10; i>=1; i--)
            {
                Console.Write(i+" ");
            }

            Console.WriteLine("\nCrescente sem pares:");
            
            for (int i=1; i<=10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i+" ");
                }
            }
        }
        
        static void qDois()
        {
            int count = 0;
            for (int i=1; i<=100; i++)
            {
                count += i;
            }
            Console.WriteLine(count);
        }

        static void qTres()
        {
            for (int i=1; i<200; i++)
            {
                if (i%2!=0) {Console.Write(i+" ");}
            }
        }

        static void qQuatro()
        {
            string userInput = "";
            double counter = 0;
            double sum = 0;
            double ageInput = 0;
            
            Console.WriteLine("Insira as idades dos alunos, quando terminar insira 0");
            
            while (userInput != "0")
            {
              waiting:
                userInput = Console.ReadLine();
                bool isIt = Double.TryParse(userInput, out ageInput);
                if (!isIt)
                {
                    Console.WriteLine("ERRO, insira um número inteiro.");
                    goto waiting;    
                }
                sum += ageInput;
                counter++;
            }
            counter--;
            Console.WriteLine($"A média de idade dos {counter} alunos é {(sum/counter).ToString("F")}.");
        }

        static void qCinco()
        {
            int[] idades = new int[5];

            for (int i=0; i<5; i++)
            {
                System.Console.WriteLine($"Nome da Mulher {i+1}:");
                Console.ReadLine();
                System.Console.WriteLine($"Idade da Mulher {i+1}:");
                idades[i] = Int32.Parse(Console.ReadLine());
            }
            int naFaixa = 0;
            for (int i=0; i<5; i++)
            {
                if (idades[i] < 36 && idades[i] > 17)
                {
                    naFaixa++;
                }
            }
            Console.WriteLine($"{naFaixa*20}% das mulheres estão na faixa entre 18 e 35 anos.");
        }

        static void qSeis()
        {
            string candidato1 = "";
            string candidato2 = "";
            double votos1 = 0.0;
            double votos2 = 0.0;
          
          menu:
            Console.WriteLine("Digite C para CADASTRAR, V para VOTAR, ou A para apurar:");
            var menuInput = Console.ReadLine();
            if (menuInput == "C") {
                goto modoCadastro;
            } else if (menuInput == "V") {
                goto modoVoto;
            } else if (menuInput == "A") {
                goto modoApura;
            } else {
                Console.WriteLine("ERRO");
                goto menu;
            };
          
          modoCadastro:
            if (candidato1 != "")
            {
                Console.WriteLine("CANDIDATOS JÁ REGISTRADOS");
                goto menu;
            }
            
            Console.WriteLine("Insira a Senha:");
            if (Console.ReadLine() != "Pa$$w0rd")
            {
                Console.WriteLine("SENHA INCORRETA");
                goto modoCadastro;
            }
            Console.WriteLine("Insira o nome do candidato 1:");
            candidato1 = Console.ReadLine();
            Console.WriteLine("Insira o nome do candidato 2:");
            candidato2 = Console.ReadLine();
            Console.WriteLine("CADASTRO COMPLETO");
            goto menu;

          modoVoto:
            if (candidato1 == "" || candidato2 == "")
            {
                Console.WriteLine("CANDIDATOS NÃO CADASTRADOS");
                goto menu;
            }
            Console.WriteLine($"Digite 1 para votar em {candidato1}, ou digite 2 para votar em {candidato2}:");
            var userVote = Console.ReadLine();
            if (userVote == "1") { votos1++; }
            else if(userVote == "2") { votos2++; }
            else {
                Console.WriteLine("ERRO");
                goto modoVoto;
            }
            Console.WriteLine("VOTO CONTABILIZADO");
            Console.Beep();
            goto menu;

          modoApura:
            Console.WriteLine("Insira a Senha:");
            if (Console.ReadLine() != "Pa$$w0rd")
            {
                Console.WriteLine("SENHA INCORRETA");
                goto modoApura;
            }
            
            if (candidato1 == "" || candidato2 == "")
            {
                Console.WriteLine("CANDIDATOS NÃO CADASTRADOS");
                goto menu;
            }
            
            if (votos1>votos2) 
            { 
                Console.WriteLine($"{candidato1} venceu de {votos1} a {votos2} com {(votos1*(100/(votos1+votos2))).ToString("F")}% dos votos!");
            }
            else if (votos2>votos1)
            {
                Console.WriteLine($"{candidato2} venceu de {votos2} a {votos1} com {(votos2*(100/(votos1+votos2))).ToString("F")}% dos votos!");
            }
            else if (votos1 == 0 && votos2 == 0)
            {
                Console.WriteLine("NENHUM VOTO REGISTRADO");
                goto menu;
            }
            else
            {
                Console.WriteLine("SEGUNDO TURNO!");
            }
        }

        static void qSete()
        {
            int cigDia = 0;
            int anos = 0;
            double preco = 0.00;
            
            Console.WriteLine("Quantos cigarros são fumados por dia?");
            cigDia = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Quantos anos fumando?");
            anos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Qual o preço da carteira?");
            preco = double.Parse(Console.ReadLine());
            
            double dinheiroGasto = ((cigDia*preco/20)*365)*anos;
            Console.WriteLine($"Foram gastos R${dinheiroGasto.ToString("F")}.");
        }

        static void qOito()
        {
            Console.WriteLine("X:");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Y:");
            double y = Double.Parse(Console.ReadLine());

            if (x % y != 0)
            {
                Console.WriteLine("X NÃO é múltiplo de Y");
            }
            else
            {
                Console.WriteLine("X é múltiplo de Y");
            }
        }

        static void qNove()
        {
            Console.WriteLine("X:");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Y:");
            double y = Double.Parse(Console.ReadLine());
            Console.WriteLine("Z:");
            double z = Double.Parse(Console.ReadLine());

            Console.WriteLine(x > (y+z) ? "X é maior que a soma de Y e Z" : "X não é maior que a soma de Y e Z");
        }

        static void Main(string[] args)
        {
            qNove();
        }
    }
}