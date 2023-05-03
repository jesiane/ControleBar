using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloConta;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using ControleDeBar.ConsoleApp.ModuloMesa;
using System.Collections;
using System.Xml.Linq;

namespace ControleDeBar.ConsoleApp.ModuloGarcon
{
    public class TelaGarcom : TelaBase
    {
        public TelaGarcom(RepositorioGarcom repositorioGarcon)
        {
            this.repositorioBase = repositorioGarcon;
            nomeEntidade = "Garçom";
            
        }

  /*      public override string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Garçon \n");

            Console.WriteLine("Digite 1 para Inserir Garçon");
            Console.WriteLine("Digite 2 para Visualizar Garçon");
            Console.WriteLine("Digite 3 para Editar Garçon");
            Console.WriteLine("Digite 4 para Excluir Garçon");

            Console.WriteLine("Digite s para Sair");

            string opc = Console.ReadLine();

            return opc;
        } */

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0,-10}{1,-20}{2,-20}", "id", "Nome", "CPF");
            Console.WriteLine("---------------------------------------------------");
            foreach (Garcom garcon in registros)
            {
                Console.WriteLine("{0,-10}{1,-29}{2,-20}", garcon.id , garcon.nome, garcon.cpf);
            }
        }
        protected override EntidadeBase ObterRegistro()
        {

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o CPf: ");
            string cpf = Console.ReadLine();
        

            Console.WriteLine();

            return new Garcom(nome, cpf);

        }

    }
        
}

