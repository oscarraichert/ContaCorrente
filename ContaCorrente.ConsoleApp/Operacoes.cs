using System;

namespace ContaCorrente.ConsoleApp
{
    public class Operacoes
    {
        public ContaCorrente Conta;

        public Operacoes(ContaCorrente contaCorrente)
        {
            Conta = contaCorrente;
        }

        public string Saque(decimal valorSaque)
        {                        
            if (valorSaque > Conta.LimiteSaque)
            {                
                return "O valor excede o limite de saque";
            }

            if (valorSaque > Conta.Saldo)
            {                
                return "Saldo insuficiente";
            }

            Conta.Saldo -= valorSaque;

            Movimentacao mov = new Movimentacao(TipoDeMovimentacao.Saque, valorSaque);

            Conta.AdicionarMovimentacao(mov);

            return $"{mov}";
        }

        public string Deposito(decimal valor)
        {
            Conta.Saldo += valor;

            Movimentacao mov = new Movimentacao(TipoDeMovimentacao.Deposito, valor);
            Conta.AdicionarMovimentacao(mov);

            return $"{mov}";
        }

        public string EmissaoSaldo()
        {
            return $"Seu saldo é: R${Conta.Saldo}";
        }

        public string Extrato()
        {
            return $"{Conta.Movimentacoes}";
        }

        public string Transferencia(ContaCorrente contaDestino, decimal valor)
        {
            if (Conta.Saldo < valor)
            {
                return "Saldo insuficiente para transferência.";
            }
            
            Conta.Saldo -= valor;
            contaDestino.Saldo += valor;

            Movimentacao mov = new Movimentacao(TipoDeMovimentacao.Transferencia, valor);
            Conta.AdicionarMovimentacao(mov);

            return $"{mov}";
        }
    }
}