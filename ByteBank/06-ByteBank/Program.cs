using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new();
            Cliente cliente = new();

            cliente.Nome = "Guilherme";
            cliente.CPF = "434.616.828-97";
            cliente.Profissao = "Dev Junior #";

            conta.Saldo = -10;

            Console.WriteLine("Seu nome é: "+conta.Titular.Nome);
            Console.WriteLine("Seu CPF é: "+conta.Titular.CPF);
            Console.WriteLine("Sua profissao é: "+conta.Titular.Profissao);
            Console.WriteLine("Seu saldo é: "+conta.Saldo);

            Console.ReadLine();
        }
    }
}
