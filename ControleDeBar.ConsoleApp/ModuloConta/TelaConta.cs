using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloConta;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using ControleDeBar.ConsoleApp.ModuloGarcon;
using ControleDeBar.ConsoleApp.ModuloMesa;
using ControleDeBar.ConsoleApp.ModuloProduto;
using ControleDeBar.ConsoleApp;
using System.Collections;

namespace Restaurante.ConsoleApp.ModuloConta
{
    public class TelaConta : TelaBase
    {
        public RepositorioConta repositorioConta = null;
        public RepositorioGarcom repositorioGarcom = null;
        public RepositorioProduto repositorioProduto = null;
        public RepositorioMesa repositorioMesa = null;

        protected override EntidadeBase ObterRegistro => throw new NotImplementedException();

        public TelaConta(RepositorioConta repositorioConta, RepositorioGarcom repositorioGarcom, RepositorioProduto repositorioProduto, RepositorioMesa repositorioMesa)
        {
            repositorioBase = repositorioConta;

            this.repositorioConta = repositorioConta;
            this.repositorioGarcom = repositorioGarcom;
            this.repositorioProduto = repositorioProduto;
            this.repositorioMesa = repositorioMesa;
            nomeEntidade = "Conta";
            sufixo = "s";
        }

        public override string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine($"Cadastro de {nomeEntidade}{sufixo} \n");

            Console.WriteLine($"(1) Inserir {nomeEntidade}");
            Console.WriteLine($"(2) Editar {nomeEntidade}{sufixo}");
            Console.WriteLine($"(3) Excluir {nomeEntidade}{sufixo}");
            Console.WriteLine($"(4) Visualizar {nomeEntidade}{sufixo}");
            Console.WriteLine($"(5) Visualizar {nomeEntidade}{sufixo}abertas");
            Console.WriteLine($"(6) Adicionar Pedido na {nomeEntidade}");
            Console.WriteLine($"(7) Listar Pedidos da {nomeEntidade}");
            Console.WriteLine($"(8) Fechar {nomeEntidade}");
            Console.WriteLine($"(9) Vizualizar total do dia");
            Console.WriteLine("(S) para voltar");

            string opcao = Console.ReadLine().ToUpper();

            return opcao;
        }
     
        public override void InserirNovoRegistro()
        {
            EntidadeBase registro = ObterRegistro();

            if (TemErrosDeValidacao(registro))
            {
                InserirNovoRegistro();

                return;
            }

            repositorioBase.Inserir(registro);

            MostrarMensagem("Registro inserido com sucesso!", ConsoleColor.Green);
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine();
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}|", "Id", "Garçom", "Status");
            Console.WriteLine("-----------------------------------------------------------------------");

            foreach (Contas conta in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -10} |", conta.id, conta.numero, conta.status);
            }
            Console.ReadLine();
        }
        protected void MostrarContasEmAberto(ArrayList registros)
        {
            Console.WriteLine();
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}| {3, -10}|", "Id", "Garçom", "Mesa", "Status");
            Console.WriteLine("-------------------------------------------------------------------------");

            foreach (Contas conta in registros)
            {
                if (conta.status == "Aberta")
                {
                    Console.WriteLine("{0, -10} | {1, -20} | {2, -10}| {3, -10}|", conta.id, conta.numero, conta.mesa.numMesa, conta.status);
                }
            }
            Console.ReadLine();
        }
        protected void MostrarTabelaDeProdutosDeUmPedido()
        {
            Console.WriteLine("Digite o id da conta que quer listar os produtos pedidos: ");
            int id = int.Parse(Console.ReadLine());

            Contas conta = (Contas)repositorioConta.SelecionarPorId(id);

            Console.WriteLine();
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20} |", "Produtos", "Quantidade", "Total");
            Console.WriteLine("---------------------------------------------------------------");

            foreach (Pedido pedido in conta.listaPedidos)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20} |", pedido.produto.nome, pedido.quantidade, pedido.Calculo);
            }
            Console.ReadLine();
        }
        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o id da Mesa: ");
            int numMesa = int.Parse(Console.ReadLine());

            Console.Write("Digite o id da Garçom: ");
            int idGarcom = int.Parse(Console.ReadLine());

            Mesa mesa = repositorioMesa.SelecionarPorId(numMesa);
            Garcom garcom = (Garcom)repositorioGarcom.SelecionarPorId(numMesa);

            Contas conta = new Contas(numero, mesa, garcom);

            return conta;
        }
        protected void AdicionarPedidoNaConta()
        {
            Console.WriteLine("Digite o id da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Contas conta = (Contas)repositorioConta.SelecionarPorId(numConta);

            Console.WriteLine("Digite o Produto a ser pedido: ");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Digite a quantidade: ");
            int quantidadeProduto = int.Parse(Console.ReadLine());

            Produto produtoSelecionado = null;

            foreach (Produto produto in repositorioProduto.SelecionarTodos())
            {
                if (produto.nome == nomeProduto)
                {
                    produtoSelecionado = produto;
                    break;
                }
            }

            Pedido pedido = new Pedido(quantidadeProduto, produtoSelecionado);
            conta.listaPedidos.Add(pedido);
        }
        protected void TotalValorPedidos()
        {
            Console.WriteLine($"Total Valor Pedidos: {repositorioConta.ValorTotal()}");
            Console.ReadLine();
        }
        protected void FecharConta()
        {
            Console.WriteLine("Digite o ID da Conta a fechar: ");
            int id = int.Parse(Console.ReadLine());

            Contas conta = (Contas)repositorioConta.SelecionarPorId(id);

            conta.status = "Fechada";

            MostrarMensagem("Conta fechada com sucesso!", ConsoleColor.Green);
        }
    }
}
