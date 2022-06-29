using ContaBancariaComPatternState;

namespace ContaBancariaPatternState
{
    public class Program
    {
        static void Main(string[] args)
        {
            var conta1 = new ContaBancaria("Antonio",456,456456);
            Console.WriteLine(conta1.EstadoAtual);
            Console.WriteLine(conta1.Saldo);
            conta1.Depositar(100);
            Console.WriteLine(conta1.Saldo);
            conta1.Sacar(400);
            Console.WriteLine(conta1.EstadoAtual);
            Console.WriteLine(conta1.Saldo);
            conta1.Depositar(100);
            Console.WriteLine(conta1.Saldo);
            Console.WriteLine("caso o resultado for -107 o programa foi bem sucessido usando o Design Pattern State");
        }
    }
}