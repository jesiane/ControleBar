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
namespace ControleDeBar.ConsoleApp
{
    public class TelaPrincipal
    {
        public string ApresentarMenu()
        {
            Console.Clear();
            Console.WriteLine(" === Bar da Galera");
            Console.WriteLine();
            Console.WriteLine("Digite 1 para Mesa");
            Console.WriteLine("Digite 2 para Garçon");
         //   Console.WriteLine("Digite 3 para Pedido");
            Console.WriteLine("Digite 3 para Produto");
            Console.WriteLine("Digite 4 para Conta");


            Console.WriteLine("Digite S para Sair");

            string opc = Console.ReadLine();

            return opc;
        }
    }
}