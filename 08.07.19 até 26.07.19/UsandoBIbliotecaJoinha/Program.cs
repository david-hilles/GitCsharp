using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MostrarJoinhaClass;

namespace UsandoBIbliotecaJoinha
{
    class Program
    {
        static void Main(string[] args)
        {
           new AquiMostraJoinha().MetodoInicialDoJoinha();
         
           new AquiMostraJoinha().MetodoDoisPontoZero(true);

           new AquiMostraJoinha().MetodoDoisPontoZero(false);

           Console.WriteLine(new AquiMostraJoinha().TesteUmOperadorLegal());

            
            //Operacao pesada como leitura a gravaçao na memoria
            var outroCaraParaRealizarOTeste = new AquiMostraJoinha()
            .TesteUmOperadorLegal();
            //Contagem de todos os registros da nossa lista
            var tamanhoDaLista = outroCaraParaRealizarOTeste.Length;
            //Nosso "For" agora esta mais rapido
            for (int i = 0; i < tamanhoDaLista; i++)
            {
                Console.WriteLine(outroCaraParaRealizarOTeste[i]);
            }


            Console.ReadKey();
        }
    }
}
