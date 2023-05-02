using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloMesa;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloProduto
{
    public class TelaProduto : TelaBase
    {
        public TelaProduto(RepositorioProduto repositorioProduto)
        {
            this.repositorioBase = repositorioProduto;
            nomeEntidade = "Produto";
            sufixo = "s";
        }
        public override string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Medicamentos \n");

            Console.WriteLine("Digite 1 para Inserir Medicamento");
            Console.WriteLine("Digite 2 para Visualizar Medicamentos");
            Console.WriteLine("Digite 3 para Editar Medicamentos");
            Console.WriteLine("Digite 4 para Excluir Medicamentos");
            Console.WriteLine("Digite 5 para Visualizar Medicamentos Mais Retirados");
            Console.WriteLine("Digite 6 para Visualizar Medicamentos em Falta\n");

            Console.WriteLine("Digite s para Sair");

            string opc = Console.ReadLine();

            return opc;
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20}", "Id", "Nome", "Fornecedor", "Quantidade");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Produto produto in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20}", produto.id, produto.descricao, produto.valor);
            }
          
        }

        protected override EntidadeBase ObterRegistro()
        {
            throw new NotImplementedException();
        }
    }
}
