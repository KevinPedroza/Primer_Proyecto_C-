using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
using Npgsql;

namespace Procedimientos
{
    public class Procedimientos_Usuario
    {
        ConexionBD bd = new ConexionBD();
        //this method will bring the name of the user
        public string nom_user(string id)
        {
            string nom = null;
            try
            {
                nom = bd.MostrarDatos("SELECT nombre FROM user_admin WHERE contra = MD5('" + id + "')");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return nom;
        }

        //this method will charge the origen combobox 
        public void llenarCombo(ComboBox combo, string consulta)
        {
            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(consulta, ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    combo.Items.Add(reader.GetString(0));
                }

            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                ConexionBD.conexion.Close();
            }
        }

        //this method will charge the informacion on the datagridview
        public void mostrarInfo(DataGridView data,string origen, string destino,string escala, string salida,string destin,string escalaregreso )
        {
            try
            {

                data.Rows.Add(origen,destino,escala,salida,destin,escalaregreso);


            }
            finally
            {
            }
            data.Refresh();
            data.ClearSelection();
        }

        //this method will verify if the trip is straight 
        public string escala_Directo(string pais_origen,string pais_destino)
        {
            string final = null;
            string paiso = null;
            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT pais_origen FROM ruta WHERE pais_destino = '" + pais_destino + "'", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    paiso = (reader.GetString(0));
                }

            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                ConexionBD.conexion.Close();
            }

            if (paiso != pais_origen)
            {
                final = paiso + ", " + pais_destino;
            }
            else
            {
                final = "Vuelo Directo";
            }

            return final;
        }
        //this method will verify if the trip is straight 
        public string escala_salida(string pais_origen, string pais_destino)
        {
            string final = null;
            string paiso = null;
            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT pais_origen FROM ruta WHERE pais_destino = '" + pais_destino + "'", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    paiso = (reader.GetString(0));
                }

            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                ConexionBD.conexion.Close();
            }

            if (paiso != pais_origen)
            {
                final = paiso;
            }
            else
            {
                final = "Vuelo Directo";
            }

            return final;
        }
    }
}
