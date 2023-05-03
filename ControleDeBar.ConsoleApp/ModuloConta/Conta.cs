using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using ControleDeBar.ConsoleApp.ModuloMesa;
using ControleDeBar.ConsoleApp.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloConta
{
    public class Contas : EntidadeBase
    {
        public DateTime data;
        public int numero;
        public Mesa mesa;
        public Produto produto;
        public Garcom garcom;

        public Contas(int numero, Mesa mesa, Produto produto, Garcom garcom, DateTime data)
        {
            this.numero = numero;
            this.mesa = mesa;
            this.produto = produto;
            this.garcom = garcom;
            this.data = data;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Contas contasAtualiada = (Contas)registroAtualizado;
            this.numero = contasAtualiada.numero;
            this.mesa = contasAtualiada.mesa;
            this.produto = contasAtualiada.produto;
            this.garcom = contasAtualiada.garcom;
            this.data = contasAtualiada.data;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (numero < 0)
                erros.Add("O campo \"numero\" é obrigatório");



            return erros;
        }
    }
}
