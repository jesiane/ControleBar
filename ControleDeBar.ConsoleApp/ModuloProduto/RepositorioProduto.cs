﻿using ControleDeBar.ConsoleApp.Compartilhado;
using System.Collections;


namespace ControleDeBar.ConsoleApp.ModuloProduto
{
    public class RepositorioProduto : RepositorioBase
    {
        public RepositorioProduto(ArrayList listaProduto)
        {
            this.listaRegistros = listaProduto;
        }
        public override EntidadeBase SelecionarPorId(int id)
        {
            return base.SelecionarPorId(id);
        }
       
    }
}
