using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class ColEstados:Colecoes<Estados>
    {
        public Estados BuscarPorUf(string uf)
        {
            foreach (var oEstado in aLista)
            {
                if (oEstado.Uf.Equals(uf, StringComparison.OrdinalIgnoreCase))
                {
                    return oEstado;
                }
            }
            return null;
        }
    }
}
