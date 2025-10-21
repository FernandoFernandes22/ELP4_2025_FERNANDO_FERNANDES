using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class DaoPaises:DAO<Paises>
    {
        
        public DaoPaises() 
        {
        
        }

        public override string Excluir(object obj)
        {
            string mSql = "";
            string mOk = "";
            Paises oPais = (Paises)obj;

            mSql = "delete from paises where codigo = @codigo";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", oPais.Codigo);
                cmd.ExecuteNonQuery();
                mOk = "Registro excluído com sucesso!";
            }
            return mOk;
        }
        public override List<Paises> Listar()
        {
            List<Paises> lista = new List<Paises>();
            string mSql = "select * from paises order by codigo";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Paises oPais = new Paises();
                        oPais.Codigo = Convert.ToInt32(dr["codigo"]); 
                        oPais.Pais = dr["pais"].ToString();
                        oPais.Sigla = dr["sigla"].ToString();
                        oPais.Ddi = dr["ddi"].ToString();
                        oPais.Moeda = dr["moeda"].ToString();
                        oPais.DatCad = Convert.ToDateTime(dr["datCad"]);
                        oPais.UltAlt = Convert.ToDateTime(dr["ultAlt"]);

                        lista.Add(oPais);
                    }
                }
            }
            return lista;
        }
        public override Object CarregaObj(int chave)
        {
            Paises oPais = null;
            string mSql = "select * from paises where codigo = @codigo";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@id", chave);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        oPais = new Paises();
                        oPais.Codigo = Convert.ToInt32(dr["codigo"]);
                        oPais.Pais = dr["pais"].ToString();
                        oPais.Sigla = dr["sigla"].ToString();
                        oPais.Ddi = dr["ddi"].ToString();
                        oPais.Moeda = dr["moeda"].ToString();
                        oPais.DatCad = Convert.ToDateTime(dr["datCad"]);
                        oPais.UltAlt = Convert.ToDateTime(dr["ultAlt"]);
                    }
                }
            }
            return oPais;
        }
        public override List<Paises> Pesquisar(string chave)
        {
            return null;
        }
        public override string Salvar(object obj)
        {
            Paises oPais = (Paises)obj;
            string mSql = "", mOk = "";
            if (oPais.Codigo == 0)
            {
                mSql = "insert into paises(Pais,Sigla,DDI,Moeda,datCad,UltAlt) Values(@pais,@sigla,@ddi,@moeda,@datcad,@ultalt)";

            }
            else
            {
                mSql = "update paises set pais = @pais, sigla = @sigla, ddi = @ddi , moeda = @moeda,datcat = @datcat,ultalt = @ultalt where  codigo = @codigo";
            }    
                using (SqlCommand cmd = new SqlCommand(mSql, cnn))
                {
                    cmd.Parameters.AddWithValue("@Pais", oPais.Pais);
                    cmd.Parameters.AddWithValue("@Sigla", oPais.Sigla);
                    cmd.Parameters.AddWithValue("@DDI", oPais.Ddi);
                    cmd.Parameters.AddWithValue("@Moeda", oPais.Moeda);
                    cmd.Parameters.AddWithValue("@Datcad", oPais.DatCad);
                    cmd.Parameters.AddWithValue("@Ultalt", oPais.UltAlt);
                    cmd.Parameters.AddWithValue("@Codigo", oPais.Codigo);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT @@IDENTITY";
                    mOk = cmd.ExecuteScalar().ToString();
                    
                }
                return mOk;
            
        }


    }
}

