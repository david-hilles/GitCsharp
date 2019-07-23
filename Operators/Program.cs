using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Passei o Nome, Senha

            var elementoX = new Teste(5,5);

            elementoX.MostrarInformacoes();

            elementoX.AlterarInformacoes(5, 5);

            elementoX.MostrarInformacoes();

            elementoX.AlterarInformacoes();

            elementoX.MostrarInformacoes();

            Console.ReadKey();

        }
    }
    public class Teste
    {
        private int A { get; set; } = 0;
        private int B { get; set; } = 0;

        public Teste(int pA,int pB)                      //Preparador
        {
            A = pA;
            B = pB;

        }

        public void AlterarInformacoes()              //Sobrecarregar 
        {
            A = B * 100;
        }
        public void AlterarInformacoes(int pA, int pB)
        {
            A = pA * 2;
            B = pB * 2;

        }
        public void MostrarInformacoes()
        {

            Console.WriteLine(A + B);

        }
    }
}
