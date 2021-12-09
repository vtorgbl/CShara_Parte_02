using System;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = " Bruno";
            conta.agencia = 852;
            conta.numero = 852369;
            conta.saldo = 200;

            Console.WriteLine("Titular: " + conta.titular);
            Console.WriteLine("Agencia: " + conta.agencia);
            Console.WriteLine("Numero: " + conta.numero);
            Console.WriteLine("Saldo: " + conta.saldo);
        }
    }
}
