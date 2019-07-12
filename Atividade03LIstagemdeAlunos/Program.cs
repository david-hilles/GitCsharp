using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03LIstagemdeAlunos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("__________________________________");
            Console.WriteLine("      Listagem de Alunos: ");
            Console.WriteLine("__________________________________");

            Console.ReadKey();

            string[,] ListadeAluno = new string[20, 3] {
                { "David","24","masculino"},
                { "Miguel","18","masculino"},
                {"Lucas","19","masculino"},
                { "Joao","20","masculino"},
                {"Aline","21","feminino"},
                { "Arthur","22","masculino"},
                { "Gabriel","25","masculino"},
                {"Matheus","27","masculino"},
                { "Heitor","28","masculino"},
                { "Enzo	","22","masculino"},
                { "Giovanna","12","feminino"},
                { "Nicolas","15","masculino"},
                { "Luiza","20","feminino"},
                { "Roger","25","masculino"},
                { "Beatriz","20","feminino"},
                { "Helena","19","feminino"},
                { "Rogerio","22","masculino"},
                { "Caua","42","masculino"},
                { "Murilo","35","masculino"},
                { "Emanuel","22","masculino"}               
            };

            for (int i = 0; i < ListadeAluno.GetLength(0); i++)
            {
                var nomeAluno = ListadeAluno[i, 0];
                var nomeIdade = ListadeAluno[i, 1];
                var nomesexo = ListadeAluno[i, 2];

                Console.WriteLine($"Aluno: {nomeAluno} | Idade {nomeIdade} | sexo: {nomesexo}");

                
            }
            Console.ReadKey();

        }
    }
}
