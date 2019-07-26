using CalculadoraClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoACalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            MostraCalculadora bbCalc = new MostraCalculadora();

            Console.WriteLine($"Soma = {bbCalc.CalculaAdicao(5, 5)}");

            Console.WriteLine($"Subtração = {bbCalc.CalculaSubtracao(12, 5)}");

            Console.WriteLine($"Multiplicação = {bbCalc.CalculaMultiplicacao(2, 4)}");

            Console.WriteLine($"Divisao = {bbCalc.CalculaDivisao(10, 5)}");

            Console.WriteLine($"CalculoRetangulo = {bbCalc.CalculoRetangulo(2, 4)}");

            Console.WriteLine($"CalculoDeTrianguloEquilatero = {bbCalc.CalculoDeTrianguloEquilatero(10)}");

            Console.WriteLine($"CalculoAreaDeCirculo = {bbCalc.CalculoAreaDeCirculo(4)}");

            Console.ReadKey();

        }
    }
}
