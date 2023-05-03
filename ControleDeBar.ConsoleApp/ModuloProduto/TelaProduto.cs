using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloMesa;
using System;
using System.Collections;


namespace ControleDeBar.ConsoleApp.ModuloProduto
{
    public class TelaProduto : TelaBase
    {
        public TelaProduto(RepositorioProduto repositorioProduto)
        {
            this.repositorioBase = repositorioProduto;
            nomeEntidade = "Produto";
            sufixo = "s";
        }
   /*     public override string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Produtos \n");

            Console.WriteLine("Digite 1 para Inserir Produtos");
            Console.WriteLine("Digite 2 para Visualizar Produtos");
            Console.WriteLine("Digite 3 para Editar Produtos");
            Console.WriteLine("Digite 4 para Excluir Produtos");

            Console.WriteLine("Digite s para Sair");

            string opc = Console.ReadLine();

            return opc;
        } */

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | ", "Id", "Produto", "Preço");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Produto produto in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | ", produto.id, produto.nome, produto.preco);
            }
          
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o numero Nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o preço: ");
            string preco = Console.ReadLine();


            return new Produto(nome, preco);

        }
    }
}
