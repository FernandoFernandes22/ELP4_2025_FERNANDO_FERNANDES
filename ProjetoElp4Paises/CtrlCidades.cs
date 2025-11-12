using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class CtrlCidades:Controller<Cidades>
    {
            ColCidades aColCidades;
            DaoCidades aDaoCidades;
            CtrlEstados aCtrlEstados;


        public CtrlCidades()
        {
            aColCidades = new ColCidades();
            aDaoCidades = new DaoCidades();
            aCtrlEstados = new CtrlEstados();
        }

        public CtrlCidades(CtrlEstados aCtrlEstados)
        {
            this.aCtrlEstados = aCtrlEstados;
        }
        public override string Salvar(object obj)
        {
            // base.Salvar(obj);
            return aDaoCidades.Salvar(obj);

        }
        public override string Excluir(object obj)
        {
            return aDaoCidades.Excluir(obj);
        }

        public override List<Cidades> Listar()
        {
            return aDaoCidades.Listar();
        }
        public override Object CarregaObj(int chave)
        {
            return aDaoCidades.CarregaObj(chave);
        }
        public override List<Cidades> Pesquisar(string chave)
        {
            return aDaoCidades.Pesquisar(chave);
        }
        public CtrlEstados ACtrlEstados
        {
            get => aCtrlEstados;
            set => aCtrlEstados = value;
        }
    }
    
}
