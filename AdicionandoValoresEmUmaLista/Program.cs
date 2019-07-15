using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Manualmente pessoal
namespace AdicionandoValoresEmUmaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criacao da nossa lista
            string[,] listaDeNome = new string[10, 2];
            //aqui vamos criar a forma externa de indentificar nossos registros
            int IdParaLista = 0; ;

            InsereRegistro(ref listaDeNome, ref IdParaLista);

            Console.ReadKey();

            InsereRegistro(ref listaDeNome, ref IdParaLista);

            Console.ReadKey();

        }
        public static void InsereRegistro(ref string[,] listaDeNome,ref int IdParaLista)
        {

            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                if (listaDeNome[i, 0] != null)
                    continue;
                //indicamos que ele deve apenas informar o nome do nosso registro
                Console.WriteLine("\r\n Informa um nome para adicionar um registro");
                var nome = Console.ReadLine();
                //Criamos o nosso identificador unico com um objeto externo que
                //mesmo apos sairmos do nosso laço ainda poderar ser incrementado
                listaDeNome[i, 0] = (IdParaLista++).ToString();
                //aqui colocamos nosso nome na lista
                listaDeNome[i, 1] = nome;

                //indentificamos se o mesmo ainda deseja inserir registros dentro da nossa lista
                Console.WriteLine("Deseja inserir um novo registro?  sim(1) ou não(0) ");
                //o redkey so espera uma unica tecla a nos retorna a tecla que foi acionada e nao o valor dela
                var continuar = Console.ReadKey().KeyChar.ToString();
                //aqui validamos a condição se o mesmo deve ou não continuar a adicionar registro até que a nossa
                //lista esteja completa de informações
                if (continuar == "0")
                    break;//Break e uma plavra reservada do c# que para,por isso break, todo laço de repetição
                //ou sequenciador logico

                AumentaTamanhoLista(ref listaDeNome);

            }

            Console.WriteLine("Registro adicionados com sucesso, segue lista de informações adicionadas:");
            //Mas agora a coisa muda,
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
                //Utilizamos o string format, basicamente ele fez da mesma forma que o sifrão
                //a diferença entre eles é que este e um cara em grande quantidades
                //acaba sendo mas rápido
                Console.WriteLine(string.Format("Registro ID {0} - Nome:{1}", listaDeNome[i, 0], listaDeNome[i, 1]));

        }
        public static void AumentaTamanhoLista(ref string[,] listaDeNome)
        {
            var limiteDaLista = true;
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                if (listaDeNome[i, 0] == null)
                    limiteDaLista = false;

            }
            //caso não tenha mais registro nossa variavel ficou com true então indica que precisamos aumentar nossa lista
            if(limiteDaLista)
            {
                var listaCopia = listaDeNome;

                listaDeNome = new string[listaDeNome.GetLength(0) + 5, 2];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    //Copiamos a informação do indentificador unico
                    listaDeNome[i, 0] = listaCopia[i, 0];
                    listaDeNome[i, 1] = listaCopia[i, 1];

                }
                //indicamos qeu neste ponto a lista foi atulizada em seu tamanho
                Console.WriteLine("O tamanho da lista for atualizado.");
            }
        }
    }
}
