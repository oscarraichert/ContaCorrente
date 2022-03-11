namespace ContaCorrente.ConsoleApp
{
    public enum TipoDeMovimentacao
    {
        Saque, Deposito, Transferencia
    }

    public class Movimentacao
    {
        public TipoDeMovimentacao Tipo;
        public decimal Valor;
        public string Resumo;

        public Movimentacao(TipoDeMovimentacao tipo, decimal valor)
        {
            Tipo = tipo;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"{Tipo} no valor de R${Valor} efetuado com sucesso."; ;
        }
    }
}