using CriacaoDeLista.Organizando.Lista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoBiliotecaDeLista1
{
    class Program
    {
        static void Main(string[] args)
        {

            Listas l = new Listas();
            l.Carregalista();
            l.listar();

            l.LimparLista();
            l.listar();

        }
    }
}
