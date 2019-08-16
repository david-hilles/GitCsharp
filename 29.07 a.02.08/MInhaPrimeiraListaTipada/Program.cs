using MInhaPrimeiraListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MInhaPrimeiraListaTipada
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lanche> minhaLista = new List<Lanche>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Insira os Dados : ");
                minhaLista.Add(new Lanche()
                {
                    Nome = RetornaValores("Nome"),
                    Quantidade = int.Parse(RetornaValores("Quantidade")), //out int Quantidade,
                    Valor = double.Parse(RetornaValores("Valor")) 
                });


            }

         //  minhaLista.Add(new Lanche()
         //  {
         //      Nome = "Pao de queijo",
         //      Quantidade = 9,
         //      Valor = 1.85
         //  });
         //
         //  minhaLista.Add(new Lanche()
         //  {
         //      Nome = "Bolinho de Carne + Refri Bonus : Gastrite",
         //      Quantidade = 2,
         //      Valor = 7.85
         //  });
         //  minhaLista.Add(new Lanche()
         //  {
         //      Nome = "Pastel de frango",
         //      Quantidade = 2,
         //      Valor = 7.85
         //  });
         //  minhaLista.Add(new Lanche()
         //  {
         //      Nome = "X salada",
         //      Quantidade = 4,
         //      Valor = 7.85
         //  });
            foreach (Lanche item in minhaLista)
                Console.WriteLine($"Lanches disponiveis: {item.Nome}");

         //   Console.WriteLine("Removendo Item");
            // minhaLista.Remove(minhaLista.FirstOrDefault(x => x.Quantidade == 2));
        //  
        //   foreach (Lanche item in minhaLista) 
        //   {
        //       if (item.Quantidade == 2)
        //          
        //       {
        //           minhaLista.Remove(item);
        //           break;
        //       }
        //
        //   }
        //
        //   foreach (Lanche item in minhaLista)
        //       Console.WriteLine($"Lanches disponiveis: {item.Nome}");

            Console.ReadKey();

        }
        public static string RetornaValores (string nome)
        {
            Console.WriteLine($"Informe o valor para o campo:{nome}");
            return Console.ReadLine();//
        }
    }
}
