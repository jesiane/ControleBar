using ControleDeBar.ConsoleApp.Compartilhado;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloGarcon
{
    public class RepositorioGarcom : RepositorioBase
    {

        public RepositorioGarcom(ArrayList listaGarcon)
        {
            this.listaRegistros = listaGarcon; 
        }
        public override EntidadeBase SelecionarPorId(int id)
        {
            return base.SelecionarPorId(id);
        }
    }
}
