using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class ConexionBD
    {
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;

        string servidor = "localhost";
        int puerto = 5432;
        string usuario = "postgres";
        string baseDatos = "proyecto_c#";
        string cadenaConexion;
        //this method is the conexion to my database
        public void Conexion()
        {
            cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + "kevin" + ";" + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);
        }
        //this method will insert datas
        public void InsertarDatos(string insertar)
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand(insertar, conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        //this method will modify datas

        public void ModificarDatos(string modificar)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(modificar, conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        //this method will delete data
        public void EliminarDatos(string eliminar)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(eliminar, conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        //this method will show datas 
        public string MostrarDatos(string consulta)
        {
            string user = null;
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(consulta, conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                conexion.Close();
            }
            return user;
        }


    }
}
