using FuncoesCalculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaLibray
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc4 = new FuncoesCalc();

            Console.WriteLine($"Soma = {calc4.Adicao(5, 5)}");

            Console.WriteLine($"Subtração = {calc4.Subtracao(12, 5)}");

            Console.WriteLine($"Divisao = {calc4.Divisao(10, 5)}");

            Console.WriteLine($"Multiplicacao ={calc4.Multiplicacao(2, 5)}");

            Console.WriteLine($"Area Retangulo = {calc4.AreaRetangulo(10, 5)}");

            Console.WriteLine($"Area Triangulo = {calc4.AreaTrianguloEqui(10, 10)}");

            Console.WriteLine($"Raio = {calc4.RaioCirculo(20)}");

            //Console.WriteLine($"Funcoes = {calc4.}")

            Console.ReadKey();
        }
    }
}
