using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;

namespace Procedimientos
{
    public class Procedimientos_Aeropertos
    {

        ConexionBD bd = new ConexionBD();
        //this method will charge the information on the table 
        public void MostrarDatosconcombo(DataGridView data)
        {
            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM aeropuerto", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    data.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(3), reader.GetString(2));
                }

            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                ConexionBD.conexion.Close();
            }
            data.Refresh();
            data.ClearSelection();
        }

        //this method will charge the combobox on the datagridview
        public void MostrarDatosCombo(DataGridViewComboBoxColumn combo)
        {
            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT nombre FROM lugar", Conexion.ConexionBD.conexion);
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
    }
}
