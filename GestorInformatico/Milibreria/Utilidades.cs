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
        public static DataTable Ejecutar(string Ejec)
        {
            try
            {


                string cadena = "Data Source=DESKTOP-GLE5LO1\\SQLEXPRESS;Initial Catalog=Prueba;Integrated Security=True";

                SqlConnection con = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                DataTable table;
                con.ConnectionString = cadena;
                con.Open();

                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = Ejec;
                table = new DataTable();
                table.Load(cmd.ExecuteReader());
                con.Close();

                return table;
            }
            catch (Exception e)
            {

                throw new Exception("" + e.Message);
            }

        }
        public static void Insert(string Ejec)
        {
            try
            {


                string cadena = "Data Source=DESKTOP-GLE5LO1\\SQLEXPRESS;Initial Catalog=Prueba;Integrated Security=True";

                SqlConnection con = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                con.ConnectionString = cadena;
                con.Open();

                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = Ejec;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception e)
            {

                throw new Exception("" + e.Message);
            }

        }
        public static DataTable ConsultarCliente(int dni)
        {
            try
            {

                string cadena = "Data Source=DESKTOP-GLE5LO1\\SQLEXPRESS;Initial Catalog=Prueba;Integrated Security=True";

                SqlConnection con = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                DataTable table;
                con.ConnectionString = cadena;
                con.Open();

                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select *  from cliente where NroDoc ="+dni;
                table = new DataTable();
                table.Load(cmd.ExecuteReader());
                con.Close();

                return table;

            }
            catch (Exception e)
            {

                throw new Exception("" + e.Message);
            }

        }

        
    }
}
