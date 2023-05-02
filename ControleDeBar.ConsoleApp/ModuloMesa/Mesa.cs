using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloConta;
using ControleDeBar.ConsoleApp.ModuloGarcon;
using ControleDeBar.ConsoleApp.ModuloPedido;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public int id;
        public Conta conta;
        public Garcom garcon;
        public Pedido pedido;
        private string? conta1;
        private string? garcon1;
        private string? pedido1;

        public Mesa(string? conta1, string? garcon1, string? pedido1)
        {
            this.conta1 = conta1;
            this.garcon1 = garcon1;
            this.pedido1 = pedido1;
        }

        public Mesa(int id, Conta conta, Garcom garcon, Pedido pedido)
        {
            this.id = id;
            this.conta = conta;
            this.garcon = garcon;
            this.pedido = pedido;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Mesa Mesa = (Mesa)registroAtualizado;

            this.conta = Mesa.conta;
            this.garcon = Mesa.garcon;
            this.pedido = Mesa.pedido;
        }

        public override ArrayList Validar()
        {
            throw new NotImplementedException();
        }
    }
}