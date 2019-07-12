using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoAtividade01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Seja BemVindo");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Sistema que indica se a pessoa é maior de 18 anos");
            Console.WriteLine("Digite a Idade");
            Console.WriteLine("-------------------------------------------------");

            int.TryParse(Console.ReadLine(), out int Idade);

            if (Idade < 18)
            {
                Console.WriteLine("Proibito tomar bebeidas alcoolicas");
            }
            else
            {
                Console.WriteLine("Você não pode beber");
            }


            Console.ReadKey();
        }
    }
}
