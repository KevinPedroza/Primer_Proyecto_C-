﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//this class will have all the methods to connect to the database 
namespace Conexion
{
    public class ConexionBD
    {
        public static NpgsqlConnection conexion;
        public static NpgsqlCommand cmd;

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
            try
            {
                Conexion();
                conexion.Open();
                cmd = new NpgsqlCommand(insertar, conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error en la inserción de los datos! " + error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //this method will modify datas

        public void ModificarDatos(string modificar)
        {
            try
            {
                Conexion();
                conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(modificar, conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error en la modificación de los datos! " + error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        //this method will delete data
        public void traerDatosLabel(string consulta)
        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(consulta, conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        //this method will show datas 
        public string MostrarDatos(string consulta)
        {
            string user = null;
            try
            {

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
            }
            catch (Exception error)
            {

            }
            return user;
        }

        //this method will charge information on a datagridview
        public DataSet cargarDatagrid()
        {
            DataSet ds = new DataSet();
            Conexion();
            conexion.Open();
            NpgsqlDataAdapter cmd = new NpgsqlDataAdapter("SELECT id,nombre FROM pais ORDER BY nombre ASC", conexion);
            cmd.Fill(ds);
            conexion.Close();
            return ds;
        }
        //this method will charge the information on any datagrid view
        public DataSet cargarDatagridlugar(string consulta)
        {
            DataSet ds = new DataSet();
            Conexion();
            conexion.Open();
            NpgsqlDataAdapter cmd = new NpgsqlDataAdapter(consulta, conexion);
            cmd.Fill(ds);
            conexion.Close();
            return ds;
        }
    }
}
