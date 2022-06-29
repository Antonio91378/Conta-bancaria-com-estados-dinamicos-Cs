using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaComPatternState.ContaBancariaStates
{
    internal class ContaPositiva : EstadoDaConta
    {
        public void Depositar(ContaBancaria conta,double valor)
        {
            conta._saldo += valor*0.98;
        }


        public void Sacar(ContaBancaria conta, double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            conta._saldo -= valor;
        }
    }
}
