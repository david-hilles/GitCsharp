using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MostrarJoinhaClass
{
    public class AquiMostraJoinha
    {
        public void MetodoInicialDoJoinha()
        {
            Console.WriteLine("Aqui está iniciamos o nosso joinha");

            Console.ReadKey();
        }

        public void MetodoDoisPontoZero(bool eQuinta)
        {
            if (eQuinta)
                Console.WriteLine("Cariai mermão!!");
            else
                Console.WriteLine("Aiai!!");

            Console.ReadKey();
        }
        /// <summary>
        /// MEtodo qeu vamos identificar o tipo
        /// </summary>
        /// <returns>Retorna alto????????</returns>
       public string[] TesteUmOperadorLegal()
        {
            return new string[2] { "Teste 1", "Teste 2" };
        }
    }
}
