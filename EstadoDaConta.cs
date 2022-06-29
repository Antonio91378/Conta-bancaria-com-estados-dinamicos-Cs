using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaComPatternState
{
    public interface EstadoDaConta
    {
        void Sacar(ContaBancaria contaBancaria, double valor);
        void Depositar(ContaBancaria contaBancaria, double valor);
    }
}
