using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloConta;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
 
        public int numMesa;

        public Mesa( int numMesa)
        {
          
            this.numMesa = numMesa;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Mesa Mesa = (Mesa)registroAtualizado;

            this.numMesa = Mesa.numMesa;
           
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (numMesa < 0)
                erros.Add("O campo \"numero\" é obrigatório");

            return erros;
        }
    }
}