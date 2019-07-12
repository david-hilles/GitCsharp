using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaTestecarro
{
    class Program
    {
        static string[,] AluguelDeCarro;
        static void Main(string[] args)
        {
            Carregabase();
           
                   
            var opcaoMenu = MenuPrincipal();

            while (opcaoMenu != 4)
            {
                if (opcaoMenu == 1)
                    AlocarUmCarro();

                if (opcaoMenu == 2)
                    DesalocarUmCarro();

                if (opcaoMenu == 3)
                {
                    MostrarAlocarCarro();
                    Console.Read();
                }

                opcaoMenu = MenuPrincipal();
            }

            Console.ReadKey();

        }
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("___________________________");
            Console.WriteLine("Menu - Alocação de Carro");
            Console.WriteLine("___________________________");
            Console.WriteLine("Seja Bem Vindo :");
            Console.WriteLine("___________________________");


        }
        public static int MenuPrincipal()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("Menu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar um Carro.");
            Console.WriteLine("2 - Devolver um Carro.");
            Console.WriteLine("3 - Ver lista de Carros");        
            Console.WriteLine("4 - Sair do sistema.");
            Console.WriteLine("Digite o número desejado");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }

        public static void Carregabase()
        {
            AluguelDeCarro = new string[2, 3]

            {
                { "Polo", "2011" , "sim" },
                { "Gol", "2010" , "não" }
            };
        }
        public static bool? PesquisaAlocaocarro(string nomedocarro)
        {
            for (int i = 0; i < AluguelDeCarro.GetLength(0); i++)
            {
                if (nomedocarro == AluguelDeCarro[i, 0])
                {
                    Console.WriteLine($"O Carro :{nomedocarro}" +
                        $" - Ano {AluguelDeCarro[i, 1]} pode ser alocado?:{AluguelDeCarro[i, 2]}");         //segunda coluna

                    return AluguelDeCarro[i, 2] == "sim";

                }
                return false;
            }

            Console.WriteLine("Nenhum Carro encontrado deseja realizar a busca novamente ? ");
            Console.WriteLine("Digite o numero da opção desejada: sim(1) não (0)");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);
            if (opcao == 1)
            {
                Console.WriteLine("Digite o nome do Carro a ser pesquisado:");
                nomedocarro = Console.ReadLine();

                return PesquisaAlocaocarro(nomedocarro);
            }

            return null;
        }
        public static void AlocarCarro(string nomecarro, bool alocar)
        {
            for (int i = 0; i < AluguelDeCarro.GetLength(0); i++)
            {
                if (CompararNomes(nomecarro, AluguelDeCarro[i, 0]))
                {
                    AluguelDeCarro[i, 2] = alocar ? "não" : "sim";
                }
            }

            Console.Clear();
            MostrarAlocarCarro();
            Console.WriteLine("Carro Alocado com sucesso!");
        }
        public static void AlocarUmCarro()
        {
            MostrarMenuInicialCarros("alocar um Carro:\n");
            // MostrarAlocarCarro();

            var nomedocarro = Console.ReadLine();
            var resultadoPesquisa = PesquisaAlocaocarro(nomedocarro);

            if (resultadoPesquisa != null && resultadoPesquisa == true)
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Voce deseja alocar o Carro ? para sim(1) para não(0)");

                AlocarCarro(nomedocarro, Console.ReadKey().KeyChar.ToString() == "1");               // if se faz isso


                //MostrarAlocarCarro();

                Console.ReadKey();
            }
            if (resultadoPesquisa == null)
            {
                Console.WriteLine("Nenhum Carro encontrado em nossa base de dados do sistema.");
            }

        }
        public static void MostrarAlocarCarro()
        {
            Console.WriteLine("Listagem de Carros:\n");

            for (int i = 0; i < AluguelDeCarro.GetLength(0); i++)
            {
                Console.WriteLine($"Modelo: {AluguelDeCarro[i, 0]} Ano: {AluguelDeCarro[i, 1]} Disponivel: {AluguelDeCarro[i, 2]}");
            }
        }
        public static void DesalocarUmCarro()
        {
            
            MostrarMenuInicialCarros("Desalocar o Carro:\r\n");

            MostrarAlocarCarro();

            var nomedocarro = Console.ReadLine();
            var resultadoPesquisa = PesquisaAlocaocarro(nomedocarro);

            if(resultadoPesquisa != null && resultadoPesquisa == false)
            {

                Console.Clear();
                MostrarAlocarCarro();
                Console.WriteLine("Voce deseja desalocar o Carro? para sim(1) para não(0)");

                AlocarCarro(nomedocarro, Console.ReadKey().KeyChar.ToString() == "0");                         // if se faz isso

                MostrarAlocarCarro();

                Console.ReadKey();

            }
            if (resultadoPesquisa == null)
            {
                Console.WriteLine("Nenhum Carro encontrado em nossa base de dados do sistema.");
            }

        }
        public static void MostrarMenuInicialCarros(string operacao)
        { 
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            //Console.WriteLine("Digite o modelo do carro a ser alocado:");

        }
        public static bool CompararNomes (string primeiro,string segundo)
        {
            if (primeiro.ToLower().Replace(" ", "")
                   == segundo.ToLower().Replace(" ", ""))
                return true;

            return false;
        }
    }
}
  
