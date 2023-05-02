using ControleDeBar.ConsoleApp.Compartilhado;

using System.Collections;


namespace ControleDeBar.ConsoleApp.ModuloConta
{
    public class TelaConta : TelaBase
    {
        public TelaConta(RepositorioConta repositorioConta)
        {
            this.repositorioBase = repositorioConta;
            nomeEntidade = "Conta";
            sufixo = "s";
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0,-10}{1,-29}{2,-20}", "Mesa", "Produto", "Garçon");
            Console.WriteLine("---------------------------------------------------");
            foreach (Conta conta in registros)
            {
                Console.WriteLine("{0,-10}{1,-29}{2,-20}", conta.mesa, conta.produto, conta.garcom);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {

            Console.Write("Digite o numero da mesa: ");
            string numero = Console.ReadLine();
            Console.WriteLine("Digite o produto: ");
            string produto = Console.ReadLine();
            Console.WriteLine("Digite o garçon: ");
            string garson = Console.ReadLine();
          
            Console.WriteLine();


            return new Conta(numero,produto,garson);
        }
    }
}
