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
            string mSql = "";
            string mOk = "";
            Estados oEstado = (Estados)obj;

            mSql = "delete from estados where codigo = @codigo";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", oEstado.Codigo);
                cmd.ExecuteNonQuery();
                mOk = "Registro excluído com sucesso!";
            }
            return mOk;
        }
        public override List<Estados> Listar()
        {
            List<Estados> lista = new List<Estados>();
            string mSql = "select * from estados order by codigo";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Estados oEstado = new Estados();
                        oEstado.Codigo = Convert.ToInt32(dr["codigo"]);
                        oEstado.Estado = dr["estado"].ToString();
                        oEstado.Uf = dr["uf"].ToString();
                        oEstado.OPais.Codigo =Convert.ToInt32(dr["codigopais"]);
                        oEstado.DatCad = Convert.ToDateTime(dr["datCad"]);
                        oEstado.UltAlt = Convert.ToDateTime(dr["ultAlt"]);

                        lista.Add(oEstado);
                    }
                }
            }
            return lista;
        }
        public override Object CarregaObj(int chave)
        {
            Estados oEstado = null;
            string mSql = "select * from estados where codigo = @codigo";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", chave);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        oEstado = new Estados();
                        oEstado.Codigo = Convert.ToInt32(dr["codigo"]);
                        oEstado.Estado = dr["estado"].ToString();
                        oEstado.Uf = dr["uf"].ToString();
                        oEstado.OPais.Codigo = Convert.ToInt32(dr["codigopais"]);
                        oEstado.DatCad = Convert.ToDateTime(dr["datCad"]);
                        oEstado.UltAlt = Convert.ToDateTime(dr["ultAlt"]);
                    }
                }
            }
            return oEstado;
        }
        public override List<Estados> Pesquisar(string chave)
        {
            List<Estados> lista = new List<Estados>();
            string mSql = $"select * from estados where estado like '%{chave}%'";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Estados oEstado = new Estados();
                        oEstado.Codigo = Convert.ToInt32(dr["codigo"]);
                        oEstado.Estado = dr["estado"].ToString();
                        oEstado.Uf = dr["uf"].ToString();
                        oEstado.OPais.Codigo = Convert.ToInt32(dr["codigopais"]);
                        oEstado.DatCad = Convert.ToDateTime(dr["datCad"]);
                        oEstado.UltAlt = Convert.ToDateTime(dr["ultAlt"]);

                        lista.Add(oEstado);
                    }
                }
            }
            return lista;
        }
        public override string Salvar(object obj)
        {
            Estados oEstado = (Estados)obj;
            string mSql = "", mOk = "";
            if (oEstado.Codigo == 0)
            {
                mSql = "insert into estados(Estado,Uf,CodigoPais,DatCad,UltAlt) Values(@estado,@uf,@codigopais,@datcad,@ultalt)";

            }
            else
            {
                mSql = "update estados set estado = @estado, uf = @uf, codigopais = @codigopais, datcat = @datcad , ultalt = @ultalt,codigo = @codigo where  codigo = @codigo";
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
