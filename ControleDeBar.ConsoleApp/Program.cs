/*O Sr. João do Nascimento, proprietário do Bar da Galera, precisacontrolar melhor o que cada cliente consumiu em seu
estabelecimento, para consequentemente aumentar a produtividade e alavancar o sucesso do seu bar. A equipe do Bar da Galera precisa
de mais agilidade na realização das atividades e processos, e desta forma precisam de um sistema que ajude a controlar as questões
financeiras do estabelecimento.O programa proposto deve registrar o que os clientes consumiram,
registrar o garçom que atende as mesas e ao final do dia ser capaz de fornecer o valor faturado pelo restaurante.
Geralmente os clientes ficam localizados em suas mesas. Eles realizam seus pedidos/produtos e um garçom registra o pedido na
conta da mesa. Os pedidos podem ser adicionados e removidos de uma determinada conta. O total da conta é emitida para uma mesa
específica.O sistema deve permitir a possibilidade de o Sr. João visualizar as contas que estão abertas e o total faturado no dia.

Requisitos Funcionais:
● Permitir que o garçom registre os pedidos dos clientes
em suas respectivas mesas.
● Permitir a adição e remoção de pedidos/produtos em
uma determinada conta.
● Gerar relatório diário de faturamento do restaurante.
● Permitir que os funcionários cadastrem produtos
● Permitir que os funcionários cadastrem mesas
● Permitir que os funcionários cadastrem garçons.*/
using ControleDeBar.ConsoleApp.ModuloConta;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using ControleDeBar.ConsoleApp.ModuloGarcon;
using ControleDeBar.ConsoleApp.ModuloMesa;
using ControleDeBar.ConsoleApp.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ConsoleApp
{
    internal partial class Program
    {

        static void Main(string[] args)
        {

            RepositorioGarcom repositorioGarcon = new RepositorioGarcom(new ArrayList());
            RepositorioConta repositorioConta = new RepositorioConta(new ArrayList());
            RepositorioMesa repositorioMesa = new RepositorioMesa(new ArrayList());
            RepositorioProduto repositorioProduto = new RepositorioProduto(new ArrayList());

            CadastrarRegistros(repositorioProduto, repositorioMesa, repositorioGarcon, repositorioConta);

            TelaGarcom telaGarcom = new TelaGarcom(repositorioGarcon);
            TelaConta telaConta = new TelaConta(repositorioConta);
            TelaMesa telaMesa = new TelaMesa(repositorioMesa);
            TelaProduto telaProduto = new TelaProduto(repositorioProduto);

            TelaPrincipal principal = new TelaPrincipal();
            while (true)
            {
                string opc = principal.ApresentarMenu();
                if (opc == "s")
                    break;

                if (opc == "1")
                {
                    string submenu = telaMesa.ApresentarMenu();
                    if (submenu == "1")
                    {
                        telaMesa.InserirNovoRegistro();
                    }
                    else if (submenu == "2")
                    {
                        telaMesa.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (submenu == "3")
                    {
                        telaMesa.EditarRegistro();
                    }
                    else if (submenu == "4")
                    {
                        telaMesa.ExcluirRegistro();
                    }
                }


                else if (opc == "2")
                {
                    string submenu = telaGarcom.ApresentarMenu();
                    if (submenu == "1")
                    {
                        telaGarcom.InserirNovoRegistro();
                    }
                    else if (submenu == "2")
                    {
                        telaGarcom.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (submenu == "3")
                    {
                        telaGarcom.EditarRegistro();
                    }
                    else if (submenu == "4")
                    {
                        telaGarcom.ExcluirRegistro();
                    }
                }

                else if (opc == "3")
                {
                    string submenu = telaProduto.ApresentarMenu();
                    if (submenu == "1")
                    {
                        telaProduto.InserirNovoRegistro();
                    }
                    else if (submenu == "2")
                    {
                        telaProduto.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (submenu == "3")
                    {
                        telaProduto.EditarRegistro();
                    }
                    else if (submenu == "4")
                    {
                        telaProduto.ExcluirRegistro();
                    }
                }

                else if (opc == "4")
                {
                    string submenu = telaConta.ApresentarMenu();
                    if (submenu == "1")
                    {
                        telaConta.InserirNovoRegistro();
                    }
                    else if (submenu == "2")
                    {
                        telaConta.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (submenu == "3")
                    {
                        telaConta.EditarRegistro();
                    }
                    else if (submenu == "4")
                    {
                        telaConta.ExcluirRegistro();
                    }
                }
            }
        }

        private static void CadastrarRegistros(RepositorioProduto repositorioProduto, RepositorioMesa repositorioMesa, RepositorioGarcom repositorioGarcom,RepositorioConta repositorioConta)
        {
            Produto produto1 = new Produto("Cerveja", 18.00, 50);
            Produto produto2 = new Produto("Pastel", 10.00, 10);
            Produto produto3 = new Produto("Risoles", 7.00, 10);
            Produto produto4 = new Produto("Refrigerante", 10.00, 25);

            repositorioProduto.Inserir(produto1);
            repositorioProduto.Inserir(produto2);
            repositorioProduto.Inserir(produto3);
            repositorioProduto.Inserir(produto4);

            Mesa mesa1 = new Mesa(001);
            Mesa mesa2 = new Mesa(002);
            Mesa mesa3 = new Mesa(003);
            Mesa mesa4 = new Mesa(004);

            repositorioMesa.Inserir(mesa1);
            repositorioMesa.Inserir(mesa2);
            repositorioMesa.Inserir(mesa3);
            repositorioMesa.Inserir(mesa4);

            Garcom garcon1 = new Garcom("João", "123");
            Garcom garcon2 = new Garcom("Felipe", "456");
            Garcom garcon3 = new Garcom("Marcos", "789");
            Garcom garcon4 = new Garcom("Antonia", "321");

            repositorioGarcom.Inserir(garcon1);
            repositorioGarcom.Inserir(garcon2);
            repositorioGarcom.Inserir(garcon3);
            repositorioGarcom.Inserir(garcon4);

        //    Contas conta1 = new Contas(1,1,1);
        //    repositorioConta.Inserir(conta1);
        }
    }
}