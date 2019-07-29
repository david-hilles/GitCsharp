using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCantina.Classes
{
    public class Lanche
    {

        double saldo = 0;
        public double Saldo { get { return saldo; } }
        public Lanche()
        {
            saldo = 20;
        }

        public double LanchesParaComprar()
        {
            Console.Clear();

            Console.WriteLine($"______ Menu Lanches ______ " +
                             $"\r\n Escolha sua opcao " +
                             //  $"" +
                             $"\r\n 1 - Dogao ______ R$3,00 " +
                             $"\r\n 2 - Pastel______R$4,00 ");

            var opcaoescolhida = Console.ReadLine();
            switch (opcaoescolhida)
            {

                case "1": { return 3.00; }
                case "2": { return 4.00; }

            }
            return 0.00;
        }
        public double MostrarSaldo()
        {
            return saldo;
        }

        public bool Compra()
        {
            var lacheescolhido = LanchesParaComprar();
            if (lacheescolhido <= saldo)
            {
                saldo -= lacheescolhido;
                return true;
            }

            return false;
        }

    }
}
