using ContaBancariaComPatternState.ContaBancariaStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaComPatternState
{
    public class ContaBancaria
    {
        public EstadoDaConta EstadoAtual { get; set; }
        public string Titular{ get; }
        public int Numero { get; }
        public int Agencia { get; }

        public double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public ContaBancaria(string titular ,int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }
            if (titular == null)
            {
                throw new ArgumentException("O argumento titular deve ser diferente de nulo", nameof(titular));
            }
            Titular = titular;
            Agencia = agencia;
            Numero = numero;
            EstadoAtual = new ContaPositiva();

        }

        public void Sacar(double valor)
        {
            EstadoAtual.Sacar(this,valor );
            if(_saldo < 0)
            {
                EstadoAtual = new ContaNegativa();
            }
        }

        public void Depositar(double valor)
        {
            EstadoAtual.Depositar(this,valor );
            if(_saldo > 0)
            {
                EstadoAtual = new ContaPositiva();
            }
        }

        public void Transferir(double valor, ContaBancaria contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch
            {
                throw new Exception("Operação não realizada.");
            }

            contaDestino.Depositar(valor);
        }
    }

}
