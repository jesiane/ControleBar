using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloConta;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using ControleDeBar.ConsoleApp.ModuloGarcon;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloMesa
{
    public class TelaMesa : TelaBase
    {
       

        public TelaMesa(RepositorioMesa repositorioMesa)
        {
            this.repositorioBase = repositorioMesa;
            nomeEntidade = "Mesa";
            sufixo = "s";
        }

 
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("|{0,-10}| {1,-20}|", "id", "Numero Mesa");
            Console.WriteLine("--------------------------------------");
            foreach (Mesa mesa in registros)
            {
                Console.WriteLine("|{0,-10}| {1, -20}|", mesa.id, mesa.numMesa);
            }

        }


        protected override EntidadeBase ObterRegistro
        {
            get
            {

                Console.Write("Digite o numero da mesa: ");
                int numMesa = Convert.ToInt32(Console.ReadLine());


                return new Mesa(numMesa);
            }
        }
    }
}