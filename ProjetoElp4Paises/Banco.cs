using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class Banco
    {
        public static SqlConnection Abrir()
        {
            string strcnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Felipops\Desktop\ELP4_FERNANDO\ELP4_2025-09-01_FERNANDO_FERNANDES\ProjetoElp4Paises\ELP42025.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(strcnn);
            cnn.Open();
            return cnn;

        }
    }
}
