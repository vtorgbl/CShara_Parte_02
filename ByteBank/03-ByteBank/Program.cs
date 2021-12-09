using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 363;
            contaDaGabriela.numero = 363452;
            contaDaGabriela.saldo = 100;

            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 363;
            contaDaGabrielaCosta.numero = 363452;
            contaDaGabrielaCosta.saldo = 100;

            Console.WriteLine("Titular: " + contaDaGabriela.titular);
            Console.WriteLine("Agencia: " + contaDaGabriela.agencia);
            Console.WriteLine("Numero: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

            Console.WriteLine("Titular: " + contaDaGabrielaCosta.titular);
            Console.WriteLine("Agencia: " + contaDaGabrielaCosta.agencia);
            Console.WriteLine("Numero: " + contaDaGabrielaCosta.numero);
            Console.WriteLine("Saldo: " + contaDaGabrielaCosta.saldo);

            Console.WriteLine("Igualdade do tipo de referência: " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 17, idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade do tipo de valor: " + (idade == idadeMaisUmaVez));

            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine(contaDaGabriela==contaDaGabrielaCosta);

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);

            if(contaDaGabriela.saldo >= 100)
            {
                contaDaGabriela.saldo -= 100;
            }

            Console.ReadLine();
        }
    }
}
