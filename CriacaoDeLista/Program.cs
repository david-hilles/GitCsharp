using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iniciando uma lista de string com array linear
            string[] lista = new string[10];           // aqui definimos as posiçoes da lista iniciando ela com 10
            //espaços na memoria para alocar informaçoes de texto

            //laço que usamos geralmente para andar sobre as posições da nossa lista
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");

            }
            foreach (var item in lista) //"var item" indica uma unicade da nossa lista "in lista"
                //indica a lista que desejamos varrer
                Console.WriteLine(item);//Aqui apresentamos essa informacao na tela

            Console.ReadKey();

            for (int i = 0; i < lista.Length; i++)
                lista[i] = string.Empty;//Aqui limpamos o nosso valor dentro da coleção

            //Laço de repetição que usamos para varrer nossa lista de maneira mais simples
            foreach (var item in lista)
                Console.WriteLine(item);

            Console.ReadKey();


        }
    }
}
