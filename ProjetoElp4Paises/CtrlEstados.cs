﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class CtrlEstados:Controller<Estados>
    {
        ColEstados aColEstados;
        DaoEstados aDaoEstados;
        

        public CtrlEstados()
        {
            aColEstados = new ColEstados();
            aDaoEstados = new DaoEstados();
        }

       
        public override string Salvar(object obj)
        {
            // base.Salvar(obj);
            return aDaoEstados.Salvar(obj);

        }
        public override string Excluir(object obj)
        {
            return aDaoEstados.Excluir(obj);
        }
       
        public override List<Estados> Listar()
        {
            return aDaoEstados.Listar();
        }
        public override Object CarregaObj(int chave)
        {
            return aDaoEstados.CarregaObj(chave);
        }
        public override List<Estados> Pesquisar(string chave)
        {
            return aDaoEstados.Pesquisar(chave);
        }
    }
}
