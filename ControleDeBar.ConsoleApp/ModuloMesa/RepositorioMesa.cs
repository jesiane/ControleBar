using ControleDeBar.ConsoleApp.Compartilhado;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloMesa
{
    public class RepositorioMesa : RepositorioBase
    {
        public RepositorioMesa(ArrayList listaMesa)
        {
            this.listaRegistros = listaMesa ;
        }
        public override EntidadeBase SelecionarPorId(int id)
        {
            return base.SelecionarPorId(id);
        }
    }

    
}