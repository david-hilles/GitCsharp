using SistemaCantina.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCantina
{
    class Program
    {
        static void Main(string[] args)
        {
            Lanche accountUser = new Lanche();

            //  accountUser.LanchesParaComprar();
            //
            //  Console.WriteLine("Informe o preço do lanche");
            //  double.TryParse(Console.ReadLine(), out double valorparacompra);

            while (accountUser.Saldo > 0)
            {
                if (accountUser.Compra())
                    Console.WriteLine("Compra Realizada");

                else
                    Console.WriteLine("Operação não realizada");


                Console.WriteLine($"Saldo disponivel para comprar outro Lanche:{accountUser.Saldo.ToString("N2")}");
                Console.ReadKey();

            }
        }
    }
}
