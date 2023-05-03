using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloConta;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using ControleDeBar.ConsoleApp.ModuloGarcon;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloMesa
{
    public class TelaMesa : TelaBase
    {
        private TelaGarcom telaGarcon;
        private RepositorioGarcom repositorioGarcom;
        
       private TelaConta telaConta;
       private RepositorioConta repositorioConta;


        public TelaMesa(RepositorioMesa repositorioMesa)
        {
            this.repositorioBase = repositorioMesa;
            nomeEntidade = "Mesa";
            sufixo = "s";
        }

    /*    public override string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Mesas \n");

            Console.WriteLine("Digite 1 para Inserir Mesa");
            Console.WriteLine("Digite 2 para Visualizar Mesa");
            Console.WriteLine("Digite 3 para Editar Mesa");
            Console.WriteLine("Digite 4 para Excluir Mesa");

            Console.WriteLine("Digite s para Sair");

            string opc = Console.ReadLine();

            return opc;
        } */

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("|{0,-10}|{1,-20}|", "id", "Numero Mesa");
            Console.WriteLine("--------------------------------------");
            foreach (Mesa mesa in registros)
            {
                Console.WriteLine("|{0, -10}|{1, -20}|", mesa.id, mesa.numMesa);
            }

        }


        protected override EntidadeBase ObterRegistro()
        {
          
            Console.Write("Digite o numero da mesa: ");
            int numMesa = Convert.ToInt32(Console.ReadLine());


            return new Mesa(numMesa );
        }
    }
}