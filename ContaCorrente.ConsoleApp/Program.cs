using System;

namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        public static ContaCorrente[] Contas = new ContaCorrente[10];
        public static int numeroContas = 0;

        static void Main(string[] args)
        {
            CriarContas();
            GerarMovimentacoes();
            VisualizarMovimentacoes();
        }

        private static void VisualizarMovimentacoes()
        {
            foreach (ContaCorrente conta in Contas)
            {
                Console.WriteLine($"\n{conta}\n");
                foreach (Movimentacao mov in conta.Movimentacoes)
                {
                    if (mov != null)
                    {
                        Console.WriteLine(mov);
                    }
                }

                Console.WriteLine("----------------------------------------------------------------------------------------------");
            }
        }

        private static void GerarMovimentacoes()
        {
            GeradorAleatorio gerador = new GeradorAleatorio(Contas);

            foreach (ContaCorrente conta in Contas)
            {
                gerador.GerarMovimentacoes(GeradorAleatorio.Random.Next(3, 10), conta);
            }
        }

        public static void CriarContas()
        {
            for (int i = 0; i < Contas.Length; i++)
            {
                Contas[numeroContas++] = GeradorAleatorio.GerarConta();
            }
        }
    }
}