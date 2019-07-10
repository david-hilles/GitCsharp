using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBibliotec
{
    class Program
    {
        static string[,] baseDelivros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();   

            MostrarSejaBemVindo();


            if (MenuInicial() == 1)
            {
                Console.Clear();

                MostrarSejaBemVindo();

                Console.WriteLine("Menu - Alocação de livros");
                Console.WriteLine("Digite o nome do livro a ser alocado :");

                var nomedolivro = Console.ReadLine();
                if (PesquisaLivroParaAlocacao(nomedolivro))
                {
                    Console.Clear();
                    Console.WriteLine("Voce deseja alocar o livro?para sim(1) para não(0)");

                    if (Console.ReadKey().KeyChar.ToString() == "1") // if se faz isso
                    {
                        AlocarLivro(nomedolivro);
                        Console.Clear();
                        Console.WriteLine("Livro Alocado com sucesso!");
                    }
                    else                                             // else se não isso
                        Console.ReadKey();

                    Console.WriteLine("Listagem de livros:");

                    for (int i = 0; i < baseDelivros.GetLength(0); i++)
                    {
                        Console.WriteLine($"Nome: {baseDelivros[i, 0]} Disponivel: {baseDelivros[i, 1]}");
                    }
                }

            }

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que mostra as informações ao menuinicial.
        /// </summary>
        public static void MostrarSejaBemVindo()

        {
            Console.WriteLine("____________________________________________");
            Console.WriteLine("      Sistema de alocação de livros");
            Console.WriteLine("____________________________________________");
            Console.WriteLine("   Desenvolvido pelas industrias EneEseAaaaa");
            Console.WriteLine("____________________________________________");
        }
        /// <summary>
        /// Metodo que mostra o conteudo do menu e as opcoes de escolha.
        /// </summary>
        /// <returns>Retorna o valor do menu escolhido em um tipo inteiro.</returns>
        public static int MenuInicial()
        {
            Console.WriteLine("\r\nMenu - Menu Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar um livro.");
            Console.WriteLine("2 - sair do sistema");
            Console.WriteLine("Digite o número desejado");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;

        }
        /// <summary>
        /// Metodo que carrega a base de dados dentro do sistema.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDelivros = new string[2, 2]
            {
               {"O pequeno","sim" },
               { "O grande","não"}
            }; 
        }
        /// <summary>
        /// Metodo que retorna se um livro pode ser alocado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser pesquisado</param>
        /// <returns>Retorna verdadeiro em caso o livro estiver livre para alocação.</returns>
        public static bool PesquisaLivroParaAlocacao(string nomeLivro)
        {
            for (int i = 0; i < baseDelivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDelivros[i, 0])
                {
                    Console.WriteLine($"O livro :{nomeLivro}" + $" pode ser alocado?:{baseDelivros[i, 1]}"); //segunda coluna

                    return baseDelivros[i, 1] == "sim"; 

                }
            }
            return false;
        }
        /// <summary>
        /// Metodo que aloca o livro de acordo com o parametro passado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser alocado.</param>
        public static void AlocarLivro(string nomeLivro)
        {
            for (int i = 0; i < baseDelivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDelivros[i, 0])
                    baseDelivros[i, 1] = "não";

            }
        }
    }
}
