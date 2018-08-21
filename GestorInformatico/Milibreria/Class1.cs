using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace Milibreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string Ejec)
        {

            string cadena = "Data Source=.;Initial Catalog=Pav;User ID=sa;Password=sqladmin";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = cadena;
            con.Open();
            DataSet DS = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(Ejec, con);
            DA.Fill(DS);
            con.Close();

            return DS;

        }
    }
}
