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

                string cadena = "Data Source=DESKTOP-KRHUM84\\SQLEXPRESS;Initial Catalog=Pancho;Integrated Security=True";
                //string cadena = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BD;User ID=sa;Password=Ataquero88";
               

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


                string cadena = "Data Source=DESKTOP-KRHUM84\\SQLEXPRESS;Initial Catalog=Pancho;Integrated Security=True";

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
        public static void Update(string Ejec)
        {
            try
            {


                string cadena = "Data Source=DESKTOP-KRHUM84\\SQLEXPRESS;Initial Catalog=Pancho;Integrated Security=True";

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
                string cadena = "Data Source=DESKTOP-KRHUM84\\SQLEXPRESS;Initial Catalog=Pancho;Integrated Security=True";
             
                
                SqlConnection con = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                DataTable table;
                con.ConnectionString = cadena;
                con.Open();

                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select b.Descripcion as Barrio,l.Descripcion as Localidad ,d.Descripcion as Depto,p.Descripcion as Prov,td.Descripcion as TipoDoc,* from Cliente c"
                                    +" join Barrio b on b.IdBarrio = c.IdBarrio join Localidad l on l.IdLocalidad = c.IdLocalidad"
                                    +" join Departamento d on d.IdDepartamento = c.IdDepartamento "+ 
                                    " join Provincia p on p.IdProvincia = d.IdProvincia "+ 
                                    " left outer join TipoDoc td on td.IdTipoDoc =c.IdTipoDoc "+ 
                                    "where (c.NroDoc ="+dni+ ") OR (c.Cuit ="+dni +" )";
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
