using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using ControleDeBar.ConsoleApp.ModuloGarcon;
using ControleDeBar.ConsoleApp.ModuloMesa;
using ControleDeBar.ConsoleApp.ModuloProduto;
using System.Collections;


namespace ControleDeBar.ConsoleApp.ModuloConta
{
    public class TelaConta : TelaBase
    {
        private RepositorioConta repositorioContas;
        private RepositorioGarcom repositorioGarcom;
        private RepositorioMesa repositorioMesa;
        private RepositorioProduto repositorioProduto;

        private TelaGarcom telaGarcom;
        private TelaMesa telaMesa;
        private TelaProduto telaProduto;

        public TelaConta(RepositorioConta repositorioContas, RepositorioProduto repositorioProduto, RepositorioMesa repositorioMesa,
            RepositorioGarcom repositorioGarcom, TelaGarcom telaGarcom, TelaMesa telaMesa, TelaProduto telaProduto)
        {
            this.repositorioContas = repositorioContas;
            this.repositorioProduto = repositorioProduto;
            this.repositorioMesa = repositorioMesa;
            this.repositorioGarcom = repositorioGarcom;
            this.telaGarcom = telaGarcom;
            this.telaMesa = telaMesa;
            this.telaProduto = telaProduto;
        } 
        public TelaConta(RepositorioConta repositorioConta)
        {
            this.repositorioBase = repositorioConta;
            nomeEntidade = "Conta";
            sufixo = "s";
        }

        /*     public override string ApresentarMenu()
             {
                 Console.Clear();

                 Console.WriteLine("Cadastro de Contas \n");

                 Console.WriteLine("Digite 1 para Inserir Contas");
                 Console.WriteLine("Digite 2 para Visualizar Contas");
                 Console.WriteLine("Digite 3 para Editar Contas");
                 Console.WriteLine("Digite 4 para Excluir Contas");

                 Console.WriteLine("Digite s para Sair");

                 string opc = Console.ReadLine();

                 return opc;
             } */

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Número", "Mesa", "Garçom", "Produto", "Quantidade", "Valor");

            Console.WriteLine("------------------------------------------------------------------------------------------------");

            foreach (Contas contas in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", contas.id, contas.numero, contas.mesa.numMesa, contas.garcom.nome, contas.produto.nome, contas.produto.quantidade, contas.produto.preco);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o numero da Conta: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Produto produto = ObterProduto();

            Mesa mesa = ObterMesa();

            Garcom garcom = ObterGarcom();

            Console.Write("Digite a data: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());



            return new Contas(numero, mesa, produto, garcom, data);
        }
        private Produto ObterProduto()
        {
            telaProduto.VisualizarRegistros(false);

            Produto produto = (Produto)telaProduto.EncontrarRegistro("Digite o id do funcionário: ");

            Console.WriteLine();

            return produto;
        }

        private Mesa ObterMesa()
        {
            telaMesa.VisualizarRegistros(false);

            Mesa mesa = (Mesa)telaMesa.EncontrarRegistro("Digite o id do medicamento: ");

            Console.WriteLine();

            return mesa;
        }
        private Garcom ObterGarcom()
        {
            telaGarcom.VisualizarRegistros(false);

            Garcom garcom = (Garcom)telaGarcom.EncontrarRegistro("Digite o id do Garçom: ");

            Console.WriteLine();

            return garcom;
        }
    }
}
/*    protected override EntidadeBase ObterRegistro()
    {
        Console.Write("Digite o numero da Conta: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Mesa mesa = ObterMesa();
        Garcom garcom = ObterGarcom();
        Produto produto = ObterProduto();


        Console.Write("Digite a data: ");
        DateTime data = Convert.ToDateTime(Console.ReadLine());



        return new Contas(numero, mesa, produto, garcom, data);


        Console.WriteLine();


    }

    private Produto ObterProduto()
    {
        telaProduto.VisualizarRegistros(false);

        Produto produto = (Produto)telaProduto.EncontrarRegistro("Digite o id do funcionário: ");

        Console.WriteLine();

        return produto;
    }

    private Mesa ObterMesa()
    {
        telaMesa.VisualizarRegistros(false);

        Mesa mesa = (Mesa)telaMesa.EncontrarRegistro("Digite o id da mesa: ");

        Console.WriteLine();

        return mesa;
    }

    private Garcom ObterGarcom()
    {
        telaGarcom.VisualizarRegistros(false);

        Garcom garcom = (Garcom)telaGarcom.EncontrarRegistro("Digite o id do Garçom: ");

        Console.WriteLine();

        return garcom;
*/
