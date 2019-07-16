using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] baseDeLivros = new string[2, 5];

            int IndicebaseDeLivros = 0;

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Iniciando sistema de lista de nome do livro.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            var escolhaInicial = ApresentaMenuInicial();

            while(true)
            {
                switch (escolhaInicial)
                {
                    case "1": { InseriValoresNaLista(ref baseDeLivros, ref IndicebaseDeLivros); } break;
                    case "2": { RemoverInformacoes(ref baseDeLivros); } break;
                    case "3": { MostrarInformacoes(baseDeLivros); } break;
                    case "4": { MostrarInformacoes(baseDeLivros, "true"); } break;
                    case "5":
                        {
                            return;
                        }
                }
                escolhaInicial = ApresentaMenuInicial();
            }
        }
        public static string ApresentaMenuInicial()
        {
            Console.Clear();
            Console.WriteLine("_________________________________________________________");
            Console.WriteLine("_________________ * MENU INICIAL BIBLIOTECA *____________");
            Console.WriteLine("_________________________________________________________");
            Console.WriteLine("1 - Inserir um novo registro");
            Console.WriteLine("2 - Remover um novo registro.");
            Console.WriteLine("3 - Listar informações.");
            Console.WriteLine("4 - Listar as informações desativadas.");
            Console.WriteLine("5 - Sair do sistema.");

            Console.WriteLine("Digite o número da opção que você deseja :");
            return Console.ReadLine();
        }
        public static void InseriValoresNaLista(ref string[,] baseDeLivros, ref int indiceBase)
        {
            Console.WriteLine("_________________ * INSERINDO VALORES NA LISTA * __________");

            Console.WriteLine("\r\nInforme um nome do livro :");
            var nome = Console.ReadLine();

            Console.WriteLine("\r\nInforme o Autor do livro");
            var autordolivro = Console.ReadLine();

            //Console.WriteLine("Data de alteração");
            //var Datadealteração = Console.ReadLine();

            AumentarTamanhoLista(ref baseDeLivros);

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)

            {
                if (baseDeLivros[i, 0] != null)
                    continue;
                baseDeLivros[i, 0] = (indiceBase++).ToString();
                baseDeLivros[i, 1] = nome;
                baseDeLivros[i, 2] = autordolivro;
                baseDeLivros[i, 3] = "true";
                baseDeLivros[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                break;
            }
            Console.WriteLine("Registrado com sucesso!");
            Console.WriteLine("___________________________________________________");
            Console.WriteLine("Para voltar ao menu inicial digitar qualquer tecla");
            Console.ReadKey();
        }
        public static void MostrarInformacoes(string[,] baseDeLivros, string mostrarRegistrosNAtivos = "false")
        {
            Console.WriteLine("Apresentação das informaçoes dentro da base de livros.");

            if (mostrarRegistrosNAtivos == "true")
                Console.WriteLine("Registros desativados dentro do sistema.");
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if(baseDeLivros[i, 3] != mostrarRegistrosNAtivos)
                    Console.WriteLine($"ID{baseDeLivros[i, 0]}" +
                                      $"-  Nome do livro:{baseDeLivros[i, 1]}" +
                                      $"-  Autordolivro:{baseDeLivros[i, 2]}" +
                                      $"-  Data alteração:{baseDeLivros[i, 4]}");

            }
            Console.WriteLine("Resultados aprensentados com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial informar qualquer tecla.");
            Console.ReadKey();
        }
        public static void RemoverInformacoes(ref string[,] baseDeLivros)
        {
            Console.WriteLine("Area de remoção de registro do sistema.");
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (baseDeLivros[i, 3] != "false")
                    Console.WriteLine($"ID{ baseDeLivros[i, 0] }" +
                                    $"- Nome do livro:{baseDeLivros[i, 1]}" +
                                   $"- Autordolivro:{baseDeLivros[i, 2]}");

            }
            Console.WriteLine("Informe o id registro a ser removido:");
            var id = Console.ReadLine();

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if(baseDeLivros[i, 0] != null && baseDeLivros[i, 0] == id)
                {
                    baseDeLivros[i, 3] = "false";

                    baseDeLivros[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }

            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Operação finalizada com sucesso!");
            Console.WriteLine("Para retornar ao menu inicial apertar qualquer tecla.");
            Console.ReadKey();
        }

        public static void AumentarTamanhoLista(ref string[,] baseDeLivros)
        {
            var limiteDaLista = true;

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)

            {
                if (baseDeLivros[i, 0] == null)
                    limiteDaLista = false;

            }

            if(limiteDaLista)
            {
                var listaCopia = baseDeLivros;

                baseDeLivros = new string[baseDeLivros.GetLength(0) + 5, 5];

                for (int i = 0; i < baseDeLivros.GetLength(0); i++)
                {
                    baseDeLivros[i, 0] = listaCopia[i, 0];

                    baseDeLivros[i, 1] = listaCopia[i, 1];

                    baseDeLivros[i, 2] = listaCopia[i, 2];

                    baseDeLivros[i, 3] = listaCopia[i, 3];

                    baseDeLivros[i, 4] = listaCopia[i, 4];

                }
                Console.WriteLine("O tamanho da lista foi Atualizado!.");
            }
        }

    }
}
