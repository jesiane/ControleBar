﻿using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloConta
{
    public class RepositorioConta : RepositorioBase
    {
        public RepositorioConta(ArrayList listaConta)
        {
            this.listaRegistros = listaConta; ;
        }
        public override EntidadeBase SelecionarPorId(int id)
        {
            return (Contas)base.SelecionarPorId(id);
        }

        public double ValorTotal()
        {
            double totalTodasAsContas = 0;
            foreach (Contas conta in listaRegistros)
            {
                if (conta.data == DateTime.Now.Date)
                {
                    conta.SomarTotalPedidos();
                    totalTodasAsContas += conta.SomarTotalPedidos();
                }
            }
            return totalTodasAsContas;
        }
    }
}
