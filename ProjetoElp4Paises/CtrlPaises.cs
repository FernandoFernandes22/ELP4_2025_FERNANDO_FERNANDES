using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class CtrlPaises:Controller<Paises>
    {
        ColPaises aColPaises;
        DaoPaises aDaoPaises;
        
        public CtrlPaises()
        {
            aColPaises = new ColPaises();
            aDaoPaises = new DaoPaises();
        }

        public override string Salvar(object obj)
        {
            // base.Salvar(obj);
            return aDaoPaises.Salvar(obj);
            
        }
        public override string Excluir(object obj)
        {
            return aDaoPaises.Excluir(obj);
        }
        public ColPaises TodosPaises()
        {
            return aColPaises;
        }
        public override List<Paises> Listar()
        {
            return aDaoPaises.Listar();
        }
        public override Object CarregaObj(int chave)
        {
            return aDaoPaises.CarregaObj(chave);
        }
        public override List<Paises> Pesquisar(string chave)
        {
            return aDaoPaises.Pesquisar(chave);
        }

    }
}
