using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloConta;
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
            nomeEntidade = "Garcon";
            sufixo = "s";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0,-10}{1,-29}{2,-20}", "id", "Nome", "CPF");
            Console.WriteLine("---------------------------------------------------");
            foreach (Garcom garcon in registros)
            {
                Console.WriteLine("{0,-10}{1,-29}{2,-20}", garcon.id , garcon.name, garcon.cpf);
            }
        }
        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o CPf: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("conta: ");
            string conta = Console.ReadLine();
            Console.WriteLine("Mesa");
            string mesa = Console.ReadLine();
            Console.WriteLine();


            return new Garcom( nome, cpf);

        }
    }
        
}

