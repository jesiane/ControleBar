using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using ControleDeBar.ConsoleApp.ModuloMesa;
using ControleDeBar.ConsoleApp.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ConsoleApp
{
    public class Pedido
    {
        public int quantidade;
        public Produto produto;

        public Pedido(int quantidade, Produto produto)
        {
            this.quantidade = quantidade;
            this.produto = produto;
        }

        public double Calculo()
        {
            return quantidade * produto.preco;
        }

    }
}