using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsertAndRemoveInList
{
    class Program
    {
        static void Main(string[] args)
        {
            //criamos a nossa base de dados inicial
            string[,] baseDeDados = new string[2, 3];

            int IndiceBaseDeDados = 0;
            //Apresentação inicial do nosso sistema
            Console.WriteLine("Iniciando sistema de lista de noem e idade.");

            var escolhaInicial = ApresentaMenuInicial();

            while (true)
            {
                switch (escolhaInicial)
                {
                    case "1": { InseriValoresNaLista(ref baseDeDados, ref IndiceBaseDeDados); } break;
                    case "2": { RemoverInformacoes(ref baseDeDados); } break;
                    case "3": { MostrarInformacoes(baseDeDados); } break;
                    case "4": { } return;


                }

            }
            //escolhaInicial = ApresentaMenuInicial();
        }
        /// <summary>
        /// Apresenta as informaçoes do menu inicial
        /// </summary>
        ///  </summary> Retorna o menu escolhido.
        public static string ApresentaMenuInicial()
        {
            //ENTROU no menu inicial inicializa a limpeza da TELA
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Inserir um novo registro");
            Console.WriteLine("2 - Remover um novo registro.");
            Console.WriteLine("3 - Listar informações.");
            Console.WriteLine("4 - Sair do sistema.");

            Console.WriteLine("Digite o número da opção desejada :");

            return Console.ReadLine();
        }
        /// <summary>
        /// Metodo que insere informações dentro da nossa base de dados
        /// </summary>
        /// <param name="baseDeDados">base de dados como ref para alterar para todos os metodos</param>
        /// <param name="indiceBase">Indice da nossa base como red para alterar para todos os metodos</param>

        public static void InseriValoresNaLista(ref string[,] baseDeDados, ref int indiceBase)
        {
            Console.WriteLine("------------INSERINDO VALORES NA LISTA--------------");

            Console.WriteLine("Informe um nome :");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe a idade");
            var idade = Console.ReadLine();

            AumentarTamanhoLista(ref baseDeDados);

            for (int i = 0; i < baseDeDados.GetLength(0); i++)

            {
                if (baseDeDados[i, 0] != null)
                    continue;

                baseDeDados[i, 0] = (indiceBase++).ToString();
                baseDeDados[i, 1] = nome;
                baseDeDados[i, 2] = idade;
                //Finalizamos aqui para apenas inserir um registro por vez...
                break;
            }
            //Informamos para o usuario que finalizou o registro e agora o meso irá voltar para o menu inicial
            Console.WriteLine("Registro cadastrado com sucesso!");
            Console.WriteLine("Para voltar ao menu ininical,basta apertar qualquer tecla.");
            Console.ReadKey();

        }
        public static void MostrarInformacoes(string[,] baseDeDados)
        {
            Console.WriteLine("Apresentação das informaçoes dentro da base de dados.");


            for (int i = 0; i < baseDeDados.GetLength(0); i++)
                Console.WriteLine($"ID{baseDeDados[i, 0]}" +
                    $"- Nome:{baseDeDados[i, 1]}" +
                    $"-Idade:{baseDeDados[i, 2]}");

            //Finalizamos a operação e indicamos que não existe mais operações a serem realizadas em
            //nosso metodo.
            Console.WriteLine("Resultados aprensentados com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial informar qualquer tecla.");
            Console.ReadKey();


        }
        /// <summary>
        /// Metodo utilizado para remover um registro pelo id denro do sistema
        /// </summary>
        /// <param name="baseDeDados">Base de dados em que ele ira remover o registro pelo id</param>
        public static void RemoverInformacoes(ref string[,] baseDeDados)
        {
            Console.WriteLine("Area de remoção de registro do sistema.");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
                Console.WriteLine($"ID:{baseDeDados[i, 0] }" +
                    $"- Nome:{baseDeDados[i, 1]} " +
                    $"-Idade:{baseDeDados[i, 2]}");

            Console.WriteLine("Informe o id registro a ser removido:");
            var id = Console.ReadLine();

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null && baseDeDados[i, 0] == id)
                {   //Nesta parte limpamos o registro de nossa base de dados
                    baseDeDados[i, 0] = null;
                    baseDeDados[i, 1] = null;
                    baseDeDados[i, 2] = null;
                }

            }
            //Finalizamos as operações desta tela
            Console.WriteLine("Operação finalizadas.");
            Console.WriteLine("Para retornar ao menu inicial apertar qualquer tecla.");
            Console.ReadKey();


        }

        public static void AumentarTamanhoLista(ref string[,] baseDeDados)
        {
            var limiteDaLista = true;

            for (int i = 0; i < baseDeDados.GetLength(0); i++)


            {

                if (baseDeDados[i, 0] == null)
                    limiteDaLista = false;

            }

            if (limiteDaLista)
            {
                var listaCopia = baseDeDados;

                baseDeDados = new string[baseDeDados.GetLength(0) + 5, 3];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    baseDeDados[i, 0] = listaCopia[i, 0];
                    baseDeDados[i, 1] = listaCopia[i, 1];
                    baseDeDados[i, 2] = listaCopia[i, 2];
                }

                Console.WriteLine("o tamanho da lista foi att");

            }


        }
    }
}

