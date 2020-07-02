using System;

namespace ExercicioCursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CadastroQuarto[] cadastro = new CadastroQuarto[10];
            
            Console.WriteLine("Digite o Numero de quartos a serem alugados");
            double n = double.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o Nome ");
                string Nome = Console.ReadLine();
                Console.WriteLine("Digite o Numero do quarto");
                int NumQuart = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o e-mail");
                string email = Console.ReadLine();
                cadastro[NumQuart] = new CadastroQuarto { Nome = Nome, NumeroQuarto = NumQuart, Email = email };

            }
            Console.WriteLine("Situação dos quartos");
            for(int i = 0; i < 10; i++)
            {
               if (cadastro[i] == null)
                {
                    Console.WriteLine((i)+":  Disponivel"); 
                }
                else
                {
                    Console.WriteLine((i)+"  "+cadastro[i]);
                }
            }
            Console.WriteLine("Juan");
        }
    }
}
