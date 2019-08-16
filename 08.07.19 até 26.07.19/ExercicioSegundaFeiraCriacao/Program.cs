using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSegundaFeiraCriacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeCarros = new string[5, 4];

            int IdParaLista = 0;

            InsereRegistro(ref listaDeCarros, ref IdParaLista);

            Console.ReadKey();

            InsereRegistro(ref listaDeCarros, ref IdParaLista);

            Console.ReadKey();
        }

        public static void InsereRegistro(ref string[,] listaDeCarros, ref int IdParaLista)

        {
            int IDLista = 0;
            for (int i = 0; i < listaDeCarros.GetLength(0); i++)
            {

                if (listaDeCarros[i, 0] != null)
                    continue;

                Console.WriteLine("\r\nInforme um carro para adicionar na lista");
                var nomeCarro = Console.ReadLine();
                

                listaDeCarros[i, 0] = (IDLista++).ToString();
                listaDeCarros[i, 1] = nomeCarro;

                Console.WriteLine("\r\n Informe a placa do carro para adicionar na lista");
                var placa = Console.ReadLine();

                listaDeCarros[i, 2] = placa;

                Console.WriteLine("\r\n Informe a cor do carro para adicionar na lista");
                var cor = Console.ReadLine();

                listaDeCarros[i, 3] = cor;

                Console.WriteLine("Deseja inserir um novo registro? sim(1) Não(0)");
                var continuar = Console.ReadKey().KeyChar.ToString();

                if (continuar == "0")
                    break;

                AumentaTamanhoLista(ref listaDeCarros);

            }

            Console.WriteLine("Registro adicionado com sucesso, lista das informações adicionadas: ");

            for (int i = 0; i < listaDeCarros.GetLength(0); i++)
                //Utilizamos o string format, basicamente ele faz da mesma forma que o $
                //a diferença entre ele é que este e um cara em grande quantidades
                //acaba sendo mais rápido

                Console.WriteLine(string.Format("Registro ID {0} - Carro: {1} - Placa: {2} - Cor: {3} ", listaDeCarros[i, 0], listaDeCarros[i, 1], listaDeCarros[i, 2], listaDeCarros[i, 3]));


            Console.ReadKey();

        }
        public static void AumentaTamanhoLista(ref string[,] listaDeCarros)
        {
            var limiteDaLista = true;

            for (int i = 0; i < listaDeCarros.GetLength(0); i++)
            {
                if (listaDeCarros[i, 0] == null)
                    limiteDaLista = false;

            }
            if (limiteDaLista)
            {
                var listaCopia = listaDeCarros;

                listaDeCarros = new string[listaDeCarros.GetLength(0) + 5, 2];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    listaDeCarros[i, 0] = listaCopia[i, 0];
                    listaDeCarros[i, 1] = listaCopia[i, 1];
                    listaDeCarros[i, 2] = listaCopia[i, 2];
                }

                Console.WriteLine("O tamanho da lista foi atualizado");
            }
        }
    }
}