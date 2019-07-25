using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoletimEscolar.Class;
using BoletimEscolar.Classes;

namespace VisualizaBoletim
{
    class Resultado
    {
        static void Main(string[] args)
        {

            //  Class1 CalculaNota = new Class1();
            //
            //  Console.WriteLine(" Informe a Nota ");
            //  var Nota1 = Convert.ToInt32(Console.ReadLine());
            //
            //  Console.WriteLine(" Informe uma nota ");
            //  var Nota2 = Convert.ToInt32(Console.ReadLine());
            //
            //  Console.WriteLine(" Informe uma nota");
            //  var Nota3 = Convert.ToInt32(Console.ReadLine());
            //
            //  var media = CalculaNota.CalculaNota(Nota1, Nota2, Nota3);
            //  var frequencia = CalculaNota.Frequencia(100, 10);
            //
            //  CalculaNota.situacao(media, frequencia);
            //  Console.ReadKey();

            //Console.WriteLine($" Frequencia = {Frequencia}");

            //Listagens cadastro = new Listagens();
            //cadastro.Cabeçalho();
            //cadastro.MostrarMenu();
            //cadastro.Inserir();
            //cadastro.ListarInformacao();
            //cadastro.ApagaRegistro();

            //Console.ReadKey();

            Listagens cadastro = new Listagens();

            Cabeçalho();

            var opcao = apresentaMenuInicial();

            while (true)
            {

                switch (opcao)
                {
                    case "1": cadastro.Inserir(); break;
                    case "2": cadastro.ListarInformacao(); break;
                    case "3": cadastro.ApagaRegistro(); break;
                    case "4":
                        Console.WriteLine("Digite o Id");
                        int.TryParse(Console.ReadLine(),out int id);
                        cadastro.AlteraRegistro(id); break;
                    case "5": return;

                        
                }

                Console.ReadKey();

                opcao = apresentaMenuInicial();
            }


        }

        public static string apresentaMenuInicial()
        {
            Console.Clear();
            Cabeçalho();

            Console.WriteLine("1 - Inserir um novo registro");
            Console.WriteLine("2 - listar um novo registro.");
            Console.WriteLine("3 - Excluir um registro.");
            Console.WriteLine("4 - Alterar um registro.");
            Console.WriteLine("5 - Sair do sistema.");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);
            Console.WriteLine();

            return opcao.ToString();

        }

        public static void Cabeçalho()
        {
            Console.Clear();

            Console.WriteLine("__________________________________");
            Console.WriteLine("        BOLETIM ESCOLAR           ");
            Console.WriteLine("__________________________________");

        }

        
    }
}