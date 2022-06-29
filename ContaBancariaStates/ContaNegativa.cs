using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaComPatternState.ContaBancariaStates
{
    internal class ContaNegativa : EstadoDaConta
    {
        public void Depositar(ContaBancaria conta,double valor)
        {
            conta._saldo += valor*0.95;
        }

        public void Sacar(ContaBancaria conta,double valor)
        {

            throw new Exception("Conta com saldo negativo, saque indisponivel.");
         
        }
    }
}
