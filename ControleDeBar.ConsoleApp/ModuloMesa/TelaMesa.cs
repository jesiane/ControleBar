using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloConta;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloMesa
{
    public class TelaMesa : TelaBase
    {
        public TelaMesa(RepositorioMesa repositorioMesa)
        {
            this.repositorioBase = repositorioMesa;
            nomeEntidade = "Mesa";
            sufixo = "s";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0,-10}{1,-29}{2,-20}{3,-20}", "id", "Conta", "Garçon", "Pedido");
            Console.WriteLine("---------------------------------------------------");
            foreach (Mesa mesa in registros)
            {
                Console.WriteLine("{0,-10}{1,-29}{2,-20}{3,-20}", mesa.id, mesa.conta, mesa.garcon, mesa.pedido);
            }
        }
      

        protected override EntidadeBase ObterRegistro()
        {
           
            Console.Write("Digite o nome: ");
            string conta = Console.ReadLine();
            Console.WriteLine("Digite o login: ");
            string garcon = Console.ReadLine();
            Console.WriteLine("Digite a senha: ");
            string pedido = Console.ReadLine();

            return new Mesa(conta, garcon, pedido);    
          }
    }
}