using System;

namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        public static ContaCorrente[] Conta = new ContaCorrente[10];
        public static int numeroContas = 0;

        static void Main(string[] args)
        {
            CriarContas();
        }

        public static void CriarContas()
        {
            for (int i = 0; i < Conta.Length; i++)
            {
                ContaCorrente conta = new ContaCorrente(null, 0, false, 0);

                string numero = conta.GerarNumeroConta();
                decimal saldo = conta.GerarSaldo();
                bool especial = conta.GerarStatus();
                decimal limite = conta.GerarLimite();

                conta = new ContaCorrente(numero, saldo, especial, limite);
                Conta[numeroContas++] = conta;               
            }
        }
    }
}