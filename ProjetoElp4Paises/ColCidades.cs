using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class ColCidades:Colecoes<Cidades>
    {

        public Cidades BuscarPorDDD(string uf)
        {
            foreach (var aCidade in aLista)
            {
                if (aCidade.Ddd.Equals(uf, StringComparison.OrdinalIgnoreCase))
                {
                    return aCidade;
                }
            }
            return null;
        }
    }
}
