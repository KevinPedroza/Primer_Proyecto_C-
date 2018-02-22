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
        public void mostrarInfo(DataGridView data, string origen, string destino, string escala, string salida, string destin, string escalaregreso)
        {
            try
            {
                data.Rows.Add(origen, destino, escala, salida, destin, escalaregreso);
            }
            finally
            {
            }
            data.Refresh();
            data.ClearSelection();
        }

        //this method will verify if the trip is straight 
        public string escala_Directo(string pais_origen, string pais_destino)
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

        //this method will charge the information about the cars on the datagridview
        public void cargarCarros(DataGridView data, int cantidad)
        {
            if (cantidad > 5)
            {
                data.DataSource = bd.cargarDatagridlugar("SELECT id,marca,modelo,tipo,precio FROM vehiculo WHERE tipo = 'Van' AND cantidad > 0").Tables[0];
                data.Columns[0].HeaderCell.Value = "Placa";
                data.Columns[1].HeaderCell.Value = "Marca";
                data.Columns[2].HeaderCell.Value = "Modelo";
                data.Columns[3].HeaderCell.Value = "Tipo";
                data.Columns[4].HeaderCell.Value = "Precio";
            }
            else
            {
                data.DataSource = bd.cargarDatagridlugar("SELECT id,marca,modelo,tipo,precio FROM vehiculo WHERE tipo != 'Van' AND cantidad > 0").Tables[0];
                data.Columns[0].HeaderCell.Value = "Placa";
                data.Columns[1].HeaderCell.Value = "Marca";
                data.Columns[2].HeaderCell.Value = "Modelo";
                data.Columns[3].HeaderCell.Value = "Tipo";
                data.Columns[4].HeaderCell.Value = "Precio";
            }
            data.ClearSelection();
            data.Refresh();
        }

        //this method will charge the information about the hotels on the datagridview
        public void cargarHoteles(DataGridView data, string destino)
        {
            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT ho.id,ho.nombre,ho.foto,ho.habitaciones,ho.pais,ho.lugar, ca.calificacion, ta.precio " +
                "FROM hotel as ho JOIN calificacion as ca ON ca.idhotel = ho.id JOIN tarifa_hotel as ta on ta.id = ho.id WHERE lower(ho.nombre) like lower('%" + destino + "%') OR " +
                "lower(ho.lugar) like lower('%" + destino + "%') or lower(ho.pais) like lower('%" + destino + "%') ORDER BY ca.calificacion DESC; ", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    data.Rows.Add(reader.GetInt32(0),reader.GetString(1),reader.GetString(2),reader.GetInt32(3),reader.GetString(4),reader.GetString(5),reader.GetInt32(6),reader.GetInt32(7));
                }

            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                ConexionBD.conexion.Close();
            }
            data.Refresh();
        }
    }
}
