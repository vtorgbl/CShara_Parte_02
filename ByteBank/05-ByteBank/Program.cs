using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();

            //gabriela.nome ="gabriela";
            //gabriela.profissão ="dev c#";
            //gabriela.cpf ="958.759.153-35";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = gabriela;
            //conta.titular = new Cliente();

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            if (conta.titular == null) 
            {
                Console.WriteLine("Ops, a referência em conta.titular é NULL");
            }
                        
            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular);
            //Console.WriteLine(conta.titular.nome);
            //Console.WriteLine(conta.titular.cpf);
            //Console.WriteLine(conta.titular.profissão);

            Console.ReadLine();
        }
    }
}
