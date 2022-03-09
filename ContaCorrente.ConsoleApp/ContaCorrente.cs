using System;

namespace ContaCorrente.ConsoleApp
{
    public class ContaCorrente
    {
        public string Numero;
        public decimal Saldo;
        public bool Especial;
        public decimal LimiteSaque;
        public string[] Movimentacoes = new string[100];
        public int i;
        private static Random Rand = new Random();

        public ContaCorrente(string numero, decimal saldo, bool especial, decimal limiteSaque)
        {
            Numero = numero;
            Saldo = saldo;
            Especial = especial;
            LimiteSaque = limiteSaque;
        }

        private static string GerarNumeroConta()
        {
            int Numero = Rand.Next(1000, 2000);

            return $"{Numero}";
        }

        public static decimal GerarSaldoInicial()
        {
            decimal saldo = Rand.Next(0, 10000);

            return saldo;
        }

        public static bool GerarStatus()
        {
            int i = rand.Next(0, 1);

            if (i == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public static decimal GerarLimite()
        {
            return rand.Next(3000, 4000);
        }

        public string MostrarUltimaMovimentacao()
        {
            return Movimentacoes[i - 1];
        }
    }
}
