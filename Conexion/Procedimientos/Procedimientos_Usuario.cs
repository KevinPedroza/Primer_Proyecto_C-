using System;
using System.Collections;
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
        public void mostrarInfo(DataGridView data, string origen, string destino, string directo, ArrayList paises, ArrayList escalas, ArrayList preciosescalas)
        {
            if (directo == "Vuelo Directo")
            {
                bd.Conexion();
                ConexionBD.conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT ru.pais_origen, ru.pais_destino, tv.precio FROM ruta as ru JOIN tarifa_vuelo as tv on tv.ruta = ru.id " +
                    "WHERE ru.pais_origen = '" + origen + "' and pais_destino = '" + destino + "'", ConexionBD.conexion);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        data.Rows.Add(reader.GetString(0), reader.GetString(1), directo, reader.GetString(1), reader.GetString(0), directo, reader.GetInt32(2));
                    }

                }
                finally
                {
                    reader.Close();
                    cmd.Dispose();
                    ConexionBD.conexion.Close();
                }
            }
            else
            {
                for (int i = 0; i < paises.Count; i++)
                {
                    data.Rows.Add(origen, destino, escalas[i], destino, origen, escalas[i], preciosescalas[i]);
                }
            }
            data.Refresh();
            data.ClearSelection();
        }


        //this method will get the price of the route 
        public ArrayList precioEscala(string destino)
        {
            ArrayList precios = new ArrayList();
            ArrayList preciofinal = new ArrayList();

            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT tv.precio FROM tarifa_vuelo as tv join ruta as ru on ru.id = tv.ruta WHERE ru.pais_destino = '" + destino + "'", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    precios.Add(reader.GetInt32(0));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                ConexionBD.conexion.Close();
            }

            for (int i = 0; i < precios.Count; i++)
            {
                preciofinal.Add((Convert.ToInt32(precios[i]) / 2) + Convert.ToInt32(precios[i]));
            }

            return preciofinal;
        }

        //this method will get the origen 
        public string paiso(string paiso)
        {
            string pais = null;


            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT pais_origen FROM ruta WHERE pais_origen = '" + paiso + "'", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    pais = (reader.GetString(0));
                }

            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                ConexionBD.conexion.Close();
            }

            return pais;
        }
        //this method will get the origen 
        public string paisd(string paisd)
        {
            string pais = null;

            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT pais_destino FROM ruta WHERE pais_destino = '" + paisd + "'", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    pais = (reader.GetString(0));
                }

            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                ConexionBD.conexion.Close();
            }

            return pais;
        }

        //this method will get the price of the route 
        public int precioRuta(string origen, string destino, string scala)
        {
            int precioesca = 0;
            int total = 0;
            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT tv.precio FROM tarifa_vuelo as tv join ruta as ru on ru.id = tv.ruta WHERE ru.pais_destino = '" + destino + "'", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    precioesca = (reader.GetInt32(0));
                }
                total = precioesca;
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                ConexionBD.conexion.Close();
            }


            return total;
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
        public ArrayList escala(string pais_destino)
        {
            ArrayList escala = new ArrayList();

            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT pais_origen FROM ruta WHERE pais_destino = '" + pais_destino + "'", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    escala.Add(reader.GetString(0) + "," + pais_destino);
                }

            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                ConexionBD.conexion.Close();
            }

            return escala;
        }
        //this method will verify if the trip is straight 
        public ArrayList paisesEscala(string pais_origen, string pais_destino)
        {
            string final = null;
            string paiso = null;
            ArrayList paises = new ArrayList();
            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT pais_origen FROM ruta WHERE pais_destino = '" + pais_destino + "'", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    paises.Add(reader.GetString(0));
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

            return paises;
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
                    data.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6), reader.GetInt32(7));
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
