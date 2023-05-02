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
        public int id;
        public string nome;
        public string descricao;    
        public Double valor;

        public Produto(int id, string nome, string descricao, double valor)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.valor = valor;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Produto produtoAtualizado = (Produto)registroAtualizado;

            this.nome = produtoAtualizado.nome;
            this.descricao = produtoAtualizado.descricao;
            this.valor = produtoAtualizado.valor;
        }

        public override ArrayList Validar()
        {
            throw new NotImplementedException();
        }
    }
}
