using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolar.Class
{
    public class Class1
    {
       
        public int CalculaNota(int Nota1, int Nota2, int Nota3)
        {
            return  (Nota1 + Nota2 + Nota3 )/ 3;
        }

        public int Frequencia(int TotalAulas, int TotalFaltas)
        {
            return ((TotalAulas - TotalFaltas) * 100) / TotalAulas;
        }

        public void situacao(int media,int frequencia)
        {
            if ((media >=7) && (frequencia >=75))
            
                Console.WriteLine($"Aluno com media {media}e Frequecia {frequencia}%");
            else
                Console.WriteLine($"Aluno reprovado com media {media}e Frequecia {frequencia}%");
        }

        public string retornaSituacaoAluno(int media, int frequencia)
        {
            if ((media >= 7) && (frequencia >= 75))
                return "Aprovado";
            else
                return "Reprovado";
        }
    }

}
