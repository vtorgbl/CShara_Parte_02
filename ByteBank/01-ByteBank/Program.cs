﻿using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 363;
            contaDaGabriela.numero = 363452;
            contaDaGabriela.saldo = 100;

            Console.WriteLine("Titular: "+contaDaGabriela.titular);
            Console.WriteLine("Agencia: "+contaDaGabriela.agencia);
            Console.WriteLine("Numero: "+contaDaGabriela.numero);
            Console.WriteLine("Saldo: "+contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;

            Console.ReadLine();
        }
    }
}
