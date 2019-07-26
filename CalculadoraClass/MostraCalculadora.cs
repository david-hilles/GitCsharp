using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraClass
{
    public class MostraCalculadora
    {
        public int CalculaAdicao(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
        public int CalculaSubtracao(int valor1, int valor2)
        {
            return valor1 - valor2;
        }
        public int CalculaMultiplicacao(int valor1, int valor2)
        {
            return valor1 * valor2;
        }
        public int CalculaDivisao(int valor1, int valor2)
        {
            return valor1 / valor2;
        }
        public int CalculoRetangulo(int valorBase, int valorAltura)
        {
            return valorBase * valorAltura;
        }
        public double CalculoDeTrianguloEquilatero(double valorlado)
        {
            return (valorlado * valorlado * Math.Sqrt(3)) / 4;
        }
        public double CalculoAreaDeCirculo (double valorArea)
        {
            return Math.Sqrt(valorArea / Math.PI);
        }
    }
}
