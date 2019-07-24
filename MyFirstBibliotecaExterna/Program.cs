using BibliotecaDeArquivosDoWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstBibliotecaExterna
{
    class Program
    {
        static void Main(string[] args)
        {
            //  var primeiroTeste = new BibliotecaDeArquivosDoWindows();

            GetFiles GF = new GetFiles();
            var retorno = GF.RetornaArquivosDoMeuDocumentos();               // è mesmo que STRING
            Imprimir(retorno);

            retorno = GF.RetornaArquivosImagesFiles();
            Imprimir(retorno);

            retorno = GF.RetornaArquivosGit();
            Imprimir(retorno);

            Console.ReadKey();
        }
        public static void Imprimir(string[] texto)

        {
            for (int i = 0; i < texto.Length; i++)
            {
                Console.WriteLine(texto[i]);
            }
            

        }
    }
}
