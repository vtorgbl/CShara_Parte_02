using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";


            Console.WriteLine(contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(50);

            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);

            contaDoBruno.Depositar(500);

            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDoBruno.titular = "Gabriela";

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo da conta do Bruno: "+contaDoBruno.saldo);
            Console.WriteLine("Saldo da conta da Gabriela: "+contaDaGabriela.saldo);

            Console.WriteLine("Resulltado Transeferencia: "+ resultadoTransferencia);

            Console.WriteLine("Saldo da conta do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da conta da Gabriela: " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
