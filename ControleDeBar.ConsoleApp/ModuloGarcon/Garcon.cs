using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloConta;
using ControleDeBar.ConsoleApp.ModuloMesa;

namespace ControleDeBar.ConsoleApp.ModuloGarcon
{
    public class Garcom : EntidadeBase
    {
        public int id;
        public string name;
        public string cpf;


        public Conta conta;
        public Mesa mesa;

        public Garcom(string name, string cpf, Conta conta, Mesa mesa)
        {
        
            this.name = name;
            this.cpf = cpf;
            this.conta = conta;
            this.mesa = mesa;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Garcom Garcon = (Garcom)registroAtualizado;

            this.name = Garcon.name;
            this.cpf = Garcon.cpf;
        }

     

        public override ArrayList Validar()
        {

            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(name.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (string.IsNullOrEmpty(cpf.Trim()))
                erros.Add("O campo \"CPF\" é obrigatório");

          
            return erros;
        }
    }
}
