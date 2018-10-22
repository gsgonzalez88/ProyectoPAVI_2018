using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DBHelper
{
    public class Utilidades
    {

        public static string cadena = "	workstation id=pavGestor.mssql.somee.com;packet size=4096;user id=franfavaro9_SQLLogin_2;pwd=rsur3b2auh;data source=pavGestor.mssql.somee.com;persist security info=False;initial catalog=pavGestor";

        public static SqlConnection Conexion = new SqlConnection();

        public static SqlCommand Comando = new SqlCommand();

        public static SqlTransaction t = null;

        public static DataTable Ejecutar(string Ejec)
        {
            DataTable table;
            try
            {
                Conexion.ConnectionString = cadena;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = Ejec;
                table = new DataTable();
                table.Load(Comando.ExecuteReader());
                Conexion.Close();
                return table;
            }
            catch (Exception e)
            {

                throw new Exception("" + e.Message);
            }

        }

        public static void Insert(string Ejec)
        {
            int rtdo;
            try
            {
                Conexion.ConnectionString = cadena;
                Conexion.Open();
                t = Conexion.BeginTransaction();
                Comando.Connection = Conexion;
                Comando.Transaction = t;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = Ejec;
                rtdo = Comando.ExecuteNonQuery();

                t.Commit();
                Conexion.Close();
            }
            catch (Exception e)
            {
                if (t != null)
                    t.Rollback();
            }

        }

        public static void Update(string Ejec)
        {
            int rtdo;
            try
            {
                Conexion.ConnectionString = cadena;
                Conexion.Open();
                t = Conexion.BeginTransaction();
                Comando.Connection = Conexion;
                Comando.Transaction = t;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = Ejec;
                rtdo = Comando.ExecuteNonQuery();
                t.Commit();
                Conexion.Close();
            }
            catch (Exception e)
            {
                if (t != null)
                    t.Rollback();
            }

        }

        public static DataTable ConsultarCliente(int dni)
        {
            DataTable table;
            try
            {
                Conexion.ConnectionString = cadena;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = "select b.Descripcion as Barrio,l.Descripcion as Localidad ,d.Descripcion as Depto,p.Descripcion as Prov,td.Descripcion as TipoDoc,* from Cliente c"
                                    + " join Barrio b on b.IdBarrio = c.IdBarrio join Localidad l on l.IdLocalidad = c.IdLocalidad"
                                    + " join Departamento d on d.IdDepartamento = c.IdDepartamento " +
                                    " join Provincia p on p.IdProvincia = d.IdProvincia " +
                                    " left outer join TipoDoc td on td.IdTipoDoc =c.IdTipoDoc " +
                                    "where (c.NroDoc =" + dni + ") OR (c.Cuit =" + dni + " )";
                table = new DataTable();
                table.Load(Comando.ExecuteReader());
                Conexion.Close();
                return table;
            }
            catch (Exception e)
            {
                throw new Exception("" + e.Message);
            }
        }
    }
}
