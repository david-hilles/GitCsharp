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

            var opcaoMenu = MenuPrincipal();

            while (opcaoMenu != 3)
            {
                if (opcaoMenu == 1)
                   AlocarUmLivro();

                if (opcaoMenu == 2)
                    DesalocarUmLivro();

                opcaoMenu = MenuPrincipal();
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
        public static int MenuPrincipal()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("Menu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar um livro.");
            Console.WriteLine("2 - Devolver um livro.");
            Console.WriteLine("3 - sair do sistema");
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
        public static bool? PesquisaLivroParaAlocacao(ref string nomeLivro)
        {
            for (int i = 0; i < baseDelivros.GetLength(0); i++)
            {
                if (CompararNomes(nomeLivro, baseDelivros[i, 0]))
                {
                    Console.WriteLine($"O livro :{nomeLivro}" + 
                        $" pode ser alocado?:{baseDelivros[i, 1]}");                                      //segunda coluna

                    return baseDelivros[i, 1] == "sim"; 

                }
                
            }

            Console.WriteLine("Nenhum livro encontrado deseja realizar a busca novamente ? ");
            Console.WriteLine("Digite o numero da opção desejada: sim(1) não (0)");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            if(opcao == 1)
            {
                Console.WriteLine("Digite o nome do livro a ser pesquisado:");
                nomeLivro = Console.ReadLine();

                return PesquisaLivroParaAlocacao( ref nomeLivro);
            }
             
            return null;
        }
        /// <summary>
        /// Metodo que aloca o livro de acordo com o parametro passado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser alocado.</param>
        public static void AlocarLivro(string nomeLivro,bool alocar)
        {
            for (int i = 0; i < baseDelivros.GetLength(0); i++)
            {
                if (CompararNomes(nomeLivro, baseDelivros[i, 0]))
                {
                    baseDelivros[i, 1] = alocar? "não" : "sim";

                }
            }
            Console.Clear();
            MostrarListaDeLivro();
            Console.WriteLine("Livro Alocado com sucesso!");
        }
        /// <summary>
        /// Metodo que carrega o conteudo inicial da aplicação do menu 1
        /// </summary>
        public static void AlocarUmLivro()
        {
            MostrarMenuInicialLivros("alocar um livro:");

            var nomedolivro = Console.ReadLine();
            var resultadoPesquisa = PesquisaLivroParaAlocacao(ref nomedolivro);

            if (resultadoPesquisa != null && resultadoPesquisa == true)
            {
                Console.Clear();
                MostrarListaDeLivro();
                Console.WriteLine("Voce deseja alocar o livro?para sim(1) para não(0)");

                AlocarLivro(nomedolivro,Console.ReadKey().KeyChar.ToString() == "1");  // if se faz isso
                
                  
                MostrarListaDeLivro();

                Console.ReadKey();

            }
            if (resultadoPesquisa == null)
            {
                Console.WriteLine("Nenhum livro encontrado em nossa base de dados do sistema.");
            }
        }
        /// <summary>
        /// Metodo que mostra a lista de livros atualizado
        /// </summary>
        public static void MostrarListaDeLivro()
        {
            Console.WriteLine("Listagem de livros:");

            for (int i = 0; i < baseDelivros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {baseDelivros[i, 0]} Disponivel: {baseDelivros[i, 1]}");
            }
        }
        public static void DesalocarUmLivro()
        {
            MostrarMenuInicialLivros("Desalocar um livro:");

            MostrarListaDeLivro();

            var nomedolivro = Console.ReadLine();
            var resultadoPesquisa = PesquisaLivroParaAlocacao(ref nomedolivro);

            if (resultadoPesquisa != null && resultadoPesquisa == false)
            {
                Console.Clear();
                MostrarListaDeLivro();
                Console.WriteLine("Voce deseja desalocar o livro? para sim(1) para não(0)");

                AlocarLivro(nomedolivro, Console.ReadKey().KeyChar.ToString() == "0");                         // if se faz isso


                MostrarListaDeLivro();

                Console.ReadKey();

            }
            if (resultadoPesquisa == null)
            {
                Console.WriteLine("Nenhum livro encontrado em nossa base de dados do sistema.");
            }   
        }
        public static void MostrarMenuInicialLivros(string operacao)
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("Digite o nome do livro a ser alocado :");
        }
        /// <summary>
        /// Metodo que compara duas string deixando em caixa baixa e removendo espaços vazios dentro da mesma.
        /// </summary>
        /// <param name="primeiro"></param>
        /// <param name="segundo"></param>
        /// <returns></returns>
        public static bool CompararNomes (string primeiro,string segundo)
        {
            if (primeiro.ToLower().Replace(" ", "")
                    == segundo.ToLower().Replace(" ", ""))
                return true;

            return false;
        }
    }
}
