using System.Collections;
using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloConta;
using ControleDeBar.ConsoleApp.ModuloMesa;

namespace ControleDeBar.ConsoleApp.ModuloGarcom
{
    public class Garcom : EntidadeBase
    {

        public string nome;
        public string cpf;

        public Garcom(string name, string cpf)
        {

            nome = name;
            this.cpf = cpf;

        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Garcom Garcon = (Garcom)registroAtualizado;

            nome = Garcon.nome;
            cpf = Garcon.cpf;
        }



        public override ArrayList Validar()
        {

            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (string.IsNullOrEmpty(cpf.Trim()))
                erros.Add("O campo \"CPF\" é obrigatório");

            return erros;
        }
    }
}
