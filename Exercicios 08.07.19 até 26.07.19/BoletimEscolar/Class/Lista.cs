using BoletimEscolar.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolar.Classes
{
    public class Listagens
    {
        string[,] arrayAluno = new string[2, 5];
        Class1 boletim = new Class1();
       // int pId;
        public void Inserir()

        {
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {

                Console.WriteLine("Informe o nome do aluno");
                var nome = Console.ReadLine();
                arrayAluno[i, 0] = i.ToString();
                arrayAluno[i, 1] = nome;



                //calculando a media

                var media = DigitaNotas();
                arrayAluno[i, 2] = media.ToString();

                Console.WriteLine("Informe o número de aulas:");
                int.TryParse(Console.ReadLine(), out int totalAulas);

                Console.WriteLine("Informe o número de faltas:");
                int.TryParse(Console.ReadLine(), out int numeroFaltas);
                var frequencia = boletim.Frequencia(totalAulas, numeroFaltas);

                arrayAluno[i, 3] = frequencia.ToString();
                //informa situaçao
                arrayAluno[i, 4] = boletim.retornaSituacaoAluno(media, frequencia);


            }

        }
        public int DigitaNotas()
        {
            Console.WriteLine("Informe a nota 1:");
            int.TryParse(Console.ReadLine(), out int nota1);


            Console.WriteLine("Informe a nota 2:");
            int.TryParse(Console.ReadLine(), out int nota2);


            Console.WriteLine("Informe a nota 3:");
            int.TryParse(Console.ReadLine(), out int nota3);

            return boletim.CalculaNota(nota1, nota2, nota3);
        }

        public void ListarInformacao()
        {
            
            
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                Console.WriteLine($"Id..........: {arrayAluno[i, 0]}");
                Console.WriteLine($"Nome........: {arrayAluno[i, 1]}");
                Console.WriteLine($"Média.......: {arrayAluno[i, 2]}");
                Console.WriteLine($"Frequência..: {arrayAluno[i, 3]}%");
                Console.WriteLine($"Situação....: {arrayAluno[i, 4]}\n");
            }
        }
        public void ApagaRegistro()
        {
            Console.WriteLine("Informe o Registro para remover : ");
            var CapturaNome = Console.ReadLine();

            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {


                if (CapturaNome == arrayAluno[i, 0])
                {
                    arrayAluno[i, 1] = "";
                    arrayAluno[i, 2] = "";
                    arrayAluno[i, 3] = "";
                    arrayAluno[i, 4] = "";

                    Console.WriteLine("Deseja remover o registro? Sim(s) ou não (n)");

                    var continuar = Console.ReadLine().ToString().ToLower();
                    if (continuar == "s")
                        break;
                }

            }
            ListarInformacao();

        }

        public void AlteraRegistro(int pId)
        {
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                if (arrayAluno[i, 0] == pId.ToString())
                {

                    var media = DigitaNotas();
                    arrayAluno[i, 2] = media.ToString(); //media
                    var frequencia = Convert.ToInt32(arrayAluno[i, 3]);
                    arrayAluno[i, 4] = boletim.retornaSituacaoAluno(media, frequencia);//situação
                    break;
                }
            }
        }


    }
}