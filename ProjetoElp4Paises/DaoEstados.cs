using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class DaoEstados:DAO<Estados>
    {
        public DaoEstados()
        {

        }

        public override string Excluir(object obj)
        {
            return null;
        }
        public override List<Estados> Listar()
        {
            return null;
        }
        public override Object CarregaObj(int chave)
        {
            return null;
        }
        public override List<Estados> Pesquisar(string chave)
        {
            return null;
        }
        public override string Salvar(object obj)
        {
            Estados oEstado = (Estados)obj;
            string mSql = "", mOk = "";
            if (oEstado.Codigo == 0)
            {
                mSql = "insert into estados(Estados,Uf,CodigoPais,datCad,UltAlt) Values(@estado,@uf,@codigopais,@datcad,@ultalt)";

            }
            else
            {
                mSql = "update estados set estado = @estado, uf = @uf, codigopais = @codigopais, datcat = @datcat , ultalt = @ultalt,codigo = @codigo where  codigo = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@Estado", oEstado.Estado);
                cmd.Parameters.AddWithValue("@Uf", oEstado.Uf);
                cmd.Parameters.AddWithValue("@CodigoPais", oEstado.OPais.Codigo);
                cmd.Parameters.AddWithValue("@Datcad", oEstado.DatCad);
                cmd.Parameters.AddWithValue("@Ultalt", oEstado.UltAlt);
                cmd.Parameters.AddWithValue("@Codigo", oEstado.Codigo);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT @@IDENTITY";
                mOk = cmd.ExecuteScalar().ToString();

            }
            return mOk;

        }

    }
}
