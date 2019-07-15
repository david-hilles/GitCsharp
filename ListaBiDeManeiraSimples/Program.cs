using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiDeManeiraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando nossa lista com mais de uma dimensão
            string[,] listaDeNomes = new string[5, 2];

            //Usando um laço simples para colocar valores mas no mesmo agora utilizando o
            //Getlenght com o parametro "0" pra indicar que queremos o tamanho da primeira coluna
            for (int i = 0; i < listaDeNomes.GetLength(0); i++)
            {
                listaDeNomes[i, 0] = i.ToString();
                //Aqui apenas adicionarmos ua informacao extra pra dexar legal
                listaDeNomes[i, 1] = $"Felipe_{i}";

            }

            //Lembrando que Getlenght é um metodo e usamos"(parametro)" com parametro ou as vezes sem
            //pra realizar a chamada do mesmo

            for (int i = 0; i < listaDeNomes.GetLength(0); i++)
            {
                //formatamos uma string de maneira que os dados sejam apresentados
                Console.WriteLine($"ID:{listaDeNomes[i, 0]} - Nome:{listaDeNomes[i, 1]}");
            }
            Console.ReadKey();
        }
    }
}
