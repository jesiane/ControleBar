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
   
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} |{1, -20}| {2, -20}| {3, -20}| ", "Id", "Produto", "Preço","quantidade");

            Console.WriteLine("-----------------------------------------------------------------------------");

            foreach (Produto produto in registros)
            {
                Console.WriteLine("{0, -10} |{1, -20}| {2, -20}| {3, -20}| ", produto.id, produto.nome, produto.preco,produto.quantidade);
            }
          
        }

        protected override EntidadeBase ObterRegistro
        {
            get
            {
                Console.Write("Digite o numero Nome do produto: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o preço: ");
                double preco = Convert.ToInt32(Console.ReadLine());


                Console.Write("Digite o qunatidade: ");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                return new Produto(nome, preco, quantidade);

            }
        }
    }
}
