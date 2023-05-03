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
        public ArrayList listaPedidos = new ArrayList();
        public Garcom garcom;

        public string status;
        public double total;

        public Contas(int numero, Mesa mesa, Garcom garcom)
        {
            this.numero = numero;
            this.mesa = mesa;
            this.garcom = garcom;
            this.data = DateTime.Now.Date;

            status = "aberta";
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Contas contasAtualiada = (Contas)registroAtualizado;
            this.numero = contasAtualiada.numero;
            this.mesa = contasAtualiada.mesa;
            this.garcom = contasAtualiada.garcom;
            this.data = contasAtualiada.data;
        }

        public double SomarTotalPedidos()
        {
            total = 0;
            foreach (Pedido pedido in listaPedidos)
            {
                total += pedido.Calculo();
            }

            return total;
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
