using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02.Lista_de_umbolo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReceitaDeBolo
            Console.WriteLine("__________________________________");
            Console.WriteLine("      Receita completa Bolo ");
            Console.WriteLine("__________________________________");

            Console.ReadKey();

            string[] receitadebolo = new string[6] { "2 copos de açúcar",
                                                     "3 ovos",
                                                     "1 copo de leite",
                                                     "2 colheres de margarina",
                                                     "1 colher (chá) de fermento em pó",
                                                     "2 copos de farinha de trigo",};

             for (int i = 0; i < receitadebolo.Length; i++)
                Console.WriteLine(receitadebolo[i]);

                Console.ReadKey();

            string[] mododepreparo = new string[4] { "Junte todos os ingredientes no copo do liquidificador.",
                                                    "Bata até perceber que a mistura ficou homogênea",
                                                 "Despeje o conteúdo numa fôrma untada e leve para assar em forno aquecido por 35 minutos",
                                                "Espere esfriar e sirva com calda de chocolate"};

            for(int i = 0; i < mododepreparo.Length; i++)
            {
                Console.WriteLine(mododepreparo[i]);
                Console.ReadKey();
            }
             
  


            //{ "3 ovos" },
            //{ "1 copo de leite."},
            //{ "2 colheres de margarina."},
            //{ " 1 colher (chá) de fermento em pó"},
            //{ "2 copos de farinha de trigo."}



        }
    }
}
