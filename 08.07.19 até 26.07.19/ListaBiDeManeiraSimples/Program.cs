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

            //Aqui como estamos usando apenas uam referencia da nossa lista colocamos ref ao passar ela no metodo
            CarregaInformacoesEListaElasEmTela(ref listaDeNomes);

            //Aqui carregar as infomações e mostrar em tela ele espera um comando
            Console.ReadKey();
            
            //Indicamos que o usuario precisa informar um numero de identificação para pesquisar um registro.
            Console.WriteLine("informe o ID do registro a ser pesquisado.");
            //Aqui como realizamos a pesquisa

            PesquisandoInformacoesNaNossaLista(listaDeNomes, Console.ReadLine());

            Console.ReadKey();
        }
        //Metodo usado apra carregar as informacoes iniciais da nossa coleção
        public static void CarregaInformacoesEListaElasEmTela(ref string[,] arrayBi)
        {
            //Usando um laço simples para colocar valores mas no mesmo agora utilizando o
            //Getlenght com o parametro "0" pra indicar que queremos o tamanho da primeira coluna
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                arrayBi[i, 0] = i.ToString();
                //Aqui apenas adicionarmos ua informacao extra pra dexar legal
                arrayBi[i, 1] = $"Felipe_{i}";

            }

            //Lembrando que Getlenght é um metodo e usamos"(parametro)" com parametro ou as vezes sem
            //pra realizar a chamada do mesmo

            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //formatamos uma string de maneira que os dados sejam apresentados
                Console.WriteLine($"ID:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");
            }

        }
        public static void PesquisandoInformacoesNaNossaLista(string[,] arrayBi, string pId)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Realizamos nossa comparacao dos mesmo tipos
                if (arrayBi[i, 0] == pId)
                {//Mostramos as informações formatadas da nossa pesquisa
                    Console.WriteLine($"Informação escolhida : Id:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");
                    //Aqui saimos da nossa lista mas retornamos vazio "return;" pois estamos em um metodo
                    //vazio "void" que não espera retornar algo.
                    return;
                }
            }

            //Caso ele passe por esta linha identificamos que ele não encontrou resultados compativeis.
            Console.WriteLine("Infelizmente a busca pelo id não resultou em nenhuma informação.");

        }
    }
}