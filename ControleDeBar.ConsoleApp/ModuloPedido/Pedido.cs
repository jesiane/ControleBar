using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcon;
using ControleDeBar.ConsoleApp.ModuloMesa;
using ControleDeBar.ConsoleApp.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloPedido
{
    public class Pedido : EntidadeBase
    {

        public int id;
        public Produto produto;
        public Garcom garcom;
        public Mesa mesa;

        public Pedido(int id, Produto produto, Garcom garcom, Mesa mesa)
        {
            this.id = id;
            this.produto = produto;
            this.garcom = garcom;
            this.mesa = mesa;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Pedido pedidoAtualizado = (Pedido)registroAtualizado;

            this.produto = pedidoAtualizado.produto;
            this.garcom = pedidoAtualizado.garcom;
            this.mesa = pedidoAtualizado.mesa;
        }

        public override ArrayList Validar()
        {
            throw new NotImplementedException();
        }
    }
}