using System;

namespace ContaCorrente.ConsoleApp
{
    public class ContaCorrente
    {
        public string Numero;
        public decimal Saldo;
        public bool Especial;
        public decimal LimiteSaque;
        public string[] Movimentacoes;
        public int i;
        public Random rand;

        public ContaCorrente(string numero, decimal saldo, bool especial, decimal limiteSaque)
        {
            Numero = numero;
            Saldo = saldo;
            Especial = especial;
            LimiteSaque = limiteSaque;
        }

        public string GerarNumeroConta()
        {
            rand = new Random();
            int Numero = rand.Next(1000, 2000);

            return $"{Numero}";
        }

        public decimal GerarSaldo()
        {
            Saldo = rand.Next(0, 10000);

            return Saldo;
        }

        public bool GerarStatus()
        {
            int i = rand.Next(0, 1);

            if (i == 0)
            {
                Especial = true;
            }

            else Especial = false;

            return Especial;
        }

        public decimal GerarLimite()
        {
            LimiteSaque = rand.Next(3000, 4000);
            
            return LimiteSaque;
        }

        public string MostrarMovimentacoes()
        {
            
            
            return Movimentacoes[i];
        }
    }
}