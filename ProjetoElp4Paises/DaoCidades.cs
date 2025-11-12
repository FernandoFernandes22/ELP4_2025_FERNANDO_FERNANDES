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
            string mSql = "";
            string mOk = "";
            Cidades aCidade = (Cidades)obj;

            mSql = "delete from cidades where codigo = @codigo";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", aCidade.Codigo);
                cmd.ExecuteNonQuery();
                mOk = "Registro excluído com sucesso!";
            }
            return mOk;
        }
        public override List<Cidades> Listar()
        {
            List<Cidades> lista = new List<Cidades>();
            string mSql = "select * from cidades order by codigo";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Cidades aCidade = new Cidades();
                        aCidade.Codigo = Convert.ToInt32(dr["codigo"]);
                        aCidade.Cidade = dr["cidade"].ToString();
                        aCidade.Ddd = dr["ddd"].ToString();
                        aCidade.OEstado.Codigo = Convert.ToInt32(dr["codigoestado"]);
                        aCidade.DatCad = Convert.ToDateTime(dr["datCad"]);
                        aCidade.UltAlt = Convert.ToDateTime(dr["ultAlt"]);

                        lista.Add(aCidade);
                    }
                }
            }
            return lista;
        }
        public override Object CarregaObj(int chave)
        {
            Cidades aCidade = null;
            string mSql = "select * from cidades where codigo = @codigo";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", chave);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        aCidade = new Cidades();
                        aCidade.Codigo = Convert.ToInt32(dr["codigo"]);
                        aCidade.Cidade = dr["cidade"].ToString();
                        aCidade.Ddd = dr["ddd"].ToString();
                        aCidade.OEstado.Codigo = Convert.ToInt32(dr["codigoestado"]);
                        aCidade.DatCad = Convert.ToDateTime(dr["datCad"]);
                        aCidade.UltAlt = Convert.ToDateTime(dr["ultAlt"]);
                    }
                }
            }
            return aCidade;
        }
        public override List<Cidades> Pesquisar(string chave)
        {
            List<Cidades> lista = new List<Cidades>();
            string mSql = $"select * from cidades where cidade like '%{chave}%'";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Cidades aCidade = new Cidades();
                        aCidade.Codigo = Convert.ToInt32(dr["codigo"]);
                        aCidade.Cidade = dr["cidade"].ToString();
                        aCidade.Ddd = dr["ddd"].ToString();
                        aCidade.OEstado.Codigo = Convert.ToInt32(dr["codigoestado"]);
                        aCidade.DatCad = Convert.ToDateTime(dr["datCad"]);
                        aCidade.UltAlt = Convert.ToDateTime(dr["ultAlt"]);

                        lista.Add(aCidade);
                    }
                }
            }
            return lista;
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
                mSql = "update cidades set cidade = @cidade,ddd = @ddd, codigoestado = @codigoestado, datcad = @datcad, ultalt = @ultalt,codigo = @codigo where  codigo = @codigo";
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
