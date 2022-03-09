using System;

namespace ContaCorrente.ConsoleApp
{
    public class Operacoes
    {
        public ContaCorrente Conta;
        
        public decimal Saque()
        {
            decimal valorSaque = Conta.Saldo - Conta.rand.Next(50, 5000);

            if (valorSaque > Conta.LimiteSaque)
            {
                Console.WriteLine("O valor excede o limite de saque");
                return Conta.Saldo;
            }

            else if (valorSaque > Conta.Saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return Conta.Saldo;
            }
            
            else return valorSaque;
        }
    }
}