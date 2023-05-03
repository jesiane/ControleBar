using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloProduto
{ 
    public class Produto : EntidadeBase
    {
        
        public string nome;
        public string preco;
        public int quantidade;

        public Produto(string nome, string preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Produto produtoAtualizado = (Produto)registroAtualizado;

            this.nome = produtoAtualizado.nome;
            this.preco = produtoAtualizado.preco;
            this.quantidade = produtoAtualizado.quantidade;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();
            if (string.IsNullOrEmpty(nome.Trim()))
                erros.Add("O campo \"Nome do produto\" é obrigatório");

            if (string.IsNullOrEmpty(preco.Trim()))
                erros.Add("O campo \"Preço\" é obrigatório");
          
            if (quantidade < 0)
                erros.Add("O campo \"numero\" é obrigatório");

            return erros;
        }
    }
}
