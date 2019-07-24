

using ProjetoDaCalculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoBibliotecaDeOutroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora bbCalc = new Calculadora();
            Console.WriteLine($" Soma = {bbCalc.CalculaAdicao(10, 35)}");

            Console.WriteLine(" Sutração =  " + bbCalc.CalculaSubtração(10, 35));

            Console.ReadKey();


        }
    }
}
