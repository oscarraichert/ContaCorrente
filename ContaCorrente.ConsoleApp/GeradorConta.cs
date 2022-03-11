using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    public class GeradorAleatorio
    {
        public ContaCorrente[] Contas;

        public static Random Random = new Random();

        public GeradorAleatorio(ContaCorrente[] contas)
        {
            Contas = contas;
        }

        public static string GerarNumeroConta()
        {
            int Numero = Random.Next(1000, 5000);

            return $"{Numero}";
        }

        public static decimal GerarValor()
        {
            decimal Saldo = Random.Next(0, 10000);

            return Saldo;
        }

        public static bool GerarStatus()
        {
            int i = Random.Next(0, 2);

            if (i == 0)
            {
                return true;
            }

            else return false;
        }

        public static decimal GerarLimite()
        {
            decimal LimiteSaque = Random.Next(3000, 4000);

            return LimiteSaque;
        }

        public static ContaCorrente GerarConta()
        {
            string numero = GerarNumeroConta();
            decimal saldo = GerarValor();
            bool especial = GerarStatus();
            decimal limite = GerarLimite();

            ContaCorrente conta = new ContaCorrente(numero, saldo, especial, limite);
            return conta;
        }

        public void GerarMovimentacoes(int quantidade, ContaCorrente conta)
        {
            for (int i = 0; i < quantidade; i++)
            {
                int opcao = Random.Next(1, 5);
                var valor = GerarValor();

                switch (opcao)
                {
                    case 1: conta.Operacoes.Deposito(valor); break;
                    case 2: conta.Operacoes.Saque(valor); break;
                    case 3: conta.Operacoes.EmissaoSaldo(); break;
                    case 4:
                        int indice = Random.Next(Contas.Length);
                        conta.Operacoes.Transferencia(Contas[indice], valor);
                        break;
                }
            }
        }
    }
}