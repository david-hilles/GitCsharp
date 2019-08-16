using Listar_meus_carros.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listar_meus_carros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carros> listacarros = new List<Carros>();

            var opcaoMenu = MenuInicial();




        }
        public static void AdicionarVeiculo(List<Carros> listacarros)
        {
            for (int i = 0; i < 2; i++)
            {
                listacarros.Add(new Carros()
                {
                    Modelo = RetornaValores("Modelo"),
                    Ano = int.Parse(RetornaValores("Ano")),
                    Placa = RetornaValores("Placa"),
                    Cv = int.Parse(RetornaValores("Cv"))

                });
            }
            ListarCarros(listacarros);

        }

        public static void ListarCarros(List<Carros> listacarros)
        {
            foreach (Carros item in listacarros)
                Console.WriteLine($"Modelo: {item.Modelo} Ano : {item.Ano} Placa :{item.Placa} Cv : {item.Cv}");
            Console.ReadKey();
        }

        public static string RetornaValores(string modelo)
        {
            Console.WriteLine($"Informe o valor para o campo:{modelo}");
            return Console.ReadLine();
        }
        public static int MenuInicial()
        {

            Console.WriteLine("Menu - Inicial");
            Console.WriteLine("1 - Adicionar Carrros.");
            Console.WriteLine("2 - Listar Carros.");
            Console.WriteLine("3 - Sair.");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);
            return opcao;
        }


    }
}
