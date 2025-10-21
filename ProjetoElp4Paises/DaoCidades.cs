using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class DaoCidades:DAO<Cidades>
    {
        public DaoCidades()
        {

        }

        public override string Excluir(object obj)
        {
            return null;
        }
        public override List<Cidades> Listar()
        {
            return null;
        }
        public override Object CarregaObj(int chave)
        {
            return null;
        }
        public override List<Cidades> Pesquisar(string chave)
        {
            return null;
        }
        public override string Salvar(object obj)
        {
            Cidades aCidade = (Cidades)obj;
            string mSql = "", mOk = "";
            if (aCidade.Codigo == 0)
            {
                mSql = "insert into cidades(Cidade,Ddd,CodigoEstado,DatCad,UltAlt) Values(@cidade,@ddd,@codigoestado,@datcad,@ultalt)";

            }
            else
            {
                mSql = "update cidades set cidade = @cidade,ddd = @ddd, codigoestado = @codigoestado, datcat = @datcat , ultalt = @ultalt,codigo = @codigo where  codigo = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@Cidade", aCidade.Cidade);
                cmd.Parameters.AddWithValue("@Ddd", aCidade.Ddd);
                cmd.Parameters.AddWithValue("@Codigo", aCidade.Codigo);
                cmd.Parameters.AddWithValue("@CodigoEstado", aCidade.OEstado.Codigo);
                cmd.Parameters.AddWithValue("@Datcad", aCidade.DatCad);
                cmd.Parameters.AddWithValue("@Ultalt", aCidade.UltAlt);
                
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT @@IDENTITY";
                mOk = cmd.ExecuteScalar().ToString();

            }
            return mOk;

        }
    }
}
