using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCSharp.Classes
{
    public class Conta
    {
        double saldo = 0;
        //Propriedade que contem o valor do SALDO!
        public double Saldo { get{ return saldo; } }
        public Conta()
        {
            //Bonus de mil reais pra iniciar operar daytrade
            saldo = 1000;
        }
        /// <summary>
        /// Metodo para sacar dinheiro de acordo com o saldo disponivel
        /// </summary>
        /// <param name="valor">valor a ser sacado</param>
        /// return retorna se o saque foi feito ou não


        public bool Sacar(double valor)
        {
            if (valor <=saldo)
            {//Desconta do valor em saldo na conta
                saldo -= valor;
                return true;
            }
            // retorna FALSE em caso de nao conter saldo disponivel
            return false;

        }

        public double MostrarSaldo()
        {
            return saldo;
        }

    }
}
