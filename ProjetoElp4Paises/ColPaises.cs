using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class ColPaises:Colecoes<Paises>
    {
        public Paises BuscarPorSigla(string sigla)
        {
            foreach (var oPais in aLista)
            {
                if (oPais.Sigla.Equals(sigla, StringComparison.OrdinalIgnoreCase))
                {
                    return oPais;
                }
            }
            return null;
        }
    }
}
