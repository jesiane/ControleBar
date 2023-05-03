namespace ControleDeBar.ConsoleApp
{
    public class TelaPrincipal
    {
        public string ApresentarMenu()
        {
            Console.Clear();
            Console.WriteLine(" === Bar da Galera ===");
            Console.WriteLine();
            Console.WriteLine(" Digite 1 para Mesa");
            Console.WriteLine(" Digite 2 para Garçon");
         //   Console.WriteLine("Digite 3 para Pedido");
            Console.WriteLine(" Digite 3 para Produto");
            Console.WriteLine(" Digite 4 para Conta");


            Console.WriteLine("Digite S para Sair");

            string opc = Console.ReadLine();

            return opc;
        }
    }
}