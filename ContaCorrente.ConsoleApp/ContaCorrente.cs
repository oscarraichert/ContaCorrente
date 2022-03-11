namespace ContaCorrente.ConsoleApp
{
    public class ContaCorrente
    {
        public string Numero;
        public decimal Saldo;
        public bool Especial;
        public decimal LimiteSaque;
        public Movimentacao[] Movimentacoes;
        public int i;
        public Operacoes Operacoes;

        public ContaCorrente(string numero, decimal saldo, bool especial, decimal limiteSaque)
        {
            Numero = numero;
            Saldo = saldo;
            Especial = especial;
            LimiteSaque = limiteSaque;
            Operacoes = new Operacoes(this);
            Movimentacoes = new Movimentacao[100];
        }

        public override string ToString()
        {
            string status = Especial == true? "Especial" : "Básica";

            return $"Número da conta: {Numero}" +
                $"\nSaldo: R${Saldo}" +
                $"\nStatus da conta: {status}" +
                $"\nLimite de saque: R${LimiteSaque}";
        }

        public void AdicionarMovimentacao(Movimentacao movimentacao)
        {
            Movimentacoes[i++] = movimentacao;
        }
    }
}