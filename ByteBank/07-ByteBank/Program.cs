using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new(867, 86712540);
                        
            Console.WriteLine("Total de contas criadas até o momento: "+ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine("Sua agencia: "+conta.Agencia);
            Console.WriteLine("Sua numero: "+conta.Numero);

            ContaCorrente contaDaGabriela = new(867, 86712544);

            Console.WriteLine("Total de contas criadas até o momento: " + ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine("Sua agencia: " + conta.Agencia);
            Console.WriteLine("Sua numero: " + conta.Numero);
        }
    }
}
