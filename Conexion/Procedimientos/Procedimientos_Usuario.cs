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
        double divi = 5;
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

        //this method will bring the name of the user
        public string cedula(string id)
        {
            string nom = null;
            try
            {
                nom = bd.MostrarDatos("SELECT cedula FROM user_admin WHERE contra = MD5('" + id + "')");
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
        public void mostrarInfo(DataGridView data, string origen, string destino, string directo, ArrayList paises, ArrayList escalas, ArrayList preciosescalas, ArrayList dura, int pasajeros, int habi)
        {
            if (directo == "Vuelo Directo")
            {
                bd.Conexion();
                ConexionBD.conexion.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT ru.pais_origen, ru.pais_destino, tv.precio,ru.duracion FROM ruta as ru JOIN tarifa_vuelo as tv on tv.ruta = ru.id " +
                    "WHERE ru.pais_origen = '" + origen + "' and pais_destino = '" + destino + "'", ConexionBD.conexion);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        data.Rows.Add(reader.GetString(0), reader.GetString(1), directo, reader.GetString(1), reader.GetString(0), directo, reader.GetInt32(2), 0, reader.GetString(3), pasajeros, habi);
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
                    data.Rows.Add(origen, destino, escalas[i], destino, origen, escalas[i], preciosescalas[i], dura[i], 0, pasajeros, habi);
                }
            }
            data.Refresh();
            data.ClearSelection();
        }

        //this method will get the duration of the route 
        public ArrayList duracionEscala(string destino)
        {
            ArrayList duracion = new ArrayList();

            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT ru.duracion FROM ruta as ru WHERE ru.pais_destino = '" + destino + "'", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    duracion.Add(reader.GetString(0));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                ConexionBD.conexion.Close();
            }


            return duracion;
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
            //tgg
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
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT ho.id,ho.nombre,ho.habitaciones,p.nombre,l.nombre, ca.calificacion, ta.precio " +
                "FROM hotel as ho JOIN calificacion as ca ON ca.idhotel = ho.id JOIN tarifa_hotel as ta on ta.id = ho.id JOIN pais as p on p.id = ho.lugar JOIN lugar as l on l.id = ho.lugar WHERE lower(ho.nombre) like lower('%" + destino + "%') OR " +
                "lower(l.nombre) like lower('%" + destino + "%') or lower(p.nombre) like lower('%" + destino + "%') ORDER BY ca.calificacion DESC; ", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    data.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetDouble(5) / divi, reader.GetInt32(6));
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

        //this method will charge the informacion on the datagridview 
        public void mostrarSelection(DataGridView data, string origen, string destino, string directo, ArrayList paises, ArrayList escalas, ArrayList preciosescalas, ArrayList dura)
        {
            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT ru.pais_origen, ru.pais_destino, tv.precio,ru.duracion FROM ruta as ru JOIN tarifa_vuelo as tv on tv.ruta = ru.id " +
                "WHERE ru.pais_origen = '" + origen + "' and pais_destino = '" + destino + "'", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    data.Rows.Add(reader.GetString(0), reader.GetString(1), directo, reader.GetString(1), reader.GetString(0), directo, reader.GetInt32(2), 0, reader.GetString(3));
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

        //this method will charge the informacion of the caron the datagridview 
        public void mostrarCarro(DataGridView data, string id)
        {
            data.DataSource = bd.cargarDatagridlugar("SELECT * FROM vehiculo WHERE id = '" + id + "'").Tables[0];
            data.Columns[0].HeaderCell.Value = "Placa";
            data.Columns[1].HeaderCell.Value = "Marca";
            data.Columns[2].HeaderCell.Value = "Modelo";
            data.Columns[3].HeaderCell.Value = "Tipo";
            data.Columns[4].HeaderCell.Value = "Precio";
            data.Columns[5].HeaderCell.Value = "Cantidad";
            data.Refresh();
            data.ClearSelection();
        }
        //this method will charge the informacion of the hotels on the datagridview 
        public void mostrarHotel(DataGridView data, int id)
        {
            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT h.id,h.nombre,h.habitaciones,p.nombre,l.nombre FROM hotel as h JOIN pais as p on p.id = h.lugar JOIN lugar as l on l.id = h.lugar WHERE h.id = '" + id + "'", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    data.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4));
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

        //this method will charge the general informacion the datagridview 
        public void mostrarInfoGeneral(DataGridView data, string fechaini, string fechafinal, string paiso, string paisd, string escala, string hotel, string vehiculo, int precio)
        {
            data.Rows.Add(fechaini, paiso, paisd, fechafinal, paisd, paiso, escala, hotel, vehiculo, precio);
            data.Columns[0].HeaderCell.Value = "Fecha Inicial";
            data.Columns[1].HeaderCell.Value = "País Origen";
            data.Columns[2].HeaderCell.Value = "País Destino";
            data.Columns[3].HeaderCell.Value = "Fecha Final";
            data.Columns[4].HeaderCell.Value = "País Salida";
            data.Columns[5].HeaderCell.Value = "País Llegada";
            data.Columns[6].HeaderCell.Value = "Escala O Directo";
            data.Columns[7].HeaderCell.Value = "Hotel";
            data.Columns[8].HeaderCell.Value = "Vehiculo";
            data.Columns[9].HeaderCell.Value = "Precio";
            data.Refresh();
            data.ClearSelection();
        }

        //this method will get the nombers of the reserves
        public int obtenerReservas()
        {
            int reservas = 0;

            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT reserva FROM reserva", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    reservas = reader.GetInt32(0);
                }

            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                ConexionBD.conexion.Close();
            }

            return reservas;
        }

        //this method will insert the reservation on the database
        public void insertarReservacion(int cedula, string fechaini, string paiso, string paisd, string fechafini, string paiss, string paisll, string escadi, string hotel, string vehi, int re, int precio, int adulto, int nino, int totalh)
        {
            try
            {
                bd.InsertarDatos("INSERT INTO reserva VALUES( '" + cedula + "', '" + fechaini + "', '" + paiso + "', '" + paisd + "', '" + fechafini + "', '" + paiss + "', '" + paisll + "', '" + escadi + "', '" + hotel + "', '" + vehi + "', '" + re + "', '" + precio + "', '" + adulto + "', '" + nino + "','" + totalh + "' )");
                MessageBox.Show("Se ha registrado la reserva Exitosamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //this method will bring the quantity of reservations of a client
        public string traerCantidadR(int cedula)
        {
            string cantidad = null;

            try
            {
                cantidad = bd.MostrarDatos("SELECT COUNT(id_cedula) FROM reserva WHERE id_cedula = '" + cedula + "'");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error!)", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cantidad;
        }

        //this method will charge the datagrid and clear everything of a place.
        public void cargaGridReserva(DataGridView data, string consulta)
        {

            try
            {
                data.DataSource = bd.cargarDatagridlugar(consulta).Tables[0];
                data.Columns[0].HeaderCell.Value = "Cedúla";
                data.Columns[1].HeaderCell.Value = "Fecha Inicial";
                data.Columns[2].HeaderCell.Value = "País Origen";
                data.Columns[3].HeaderCell.Value = "País Destino";
                data.Columns[4].HeaderCell.Value = "Fecha Final";
                data.Columns[5].HeaderCell.Value = "País Salida";
                data.Columns[6].HeaderCell.Value = "País Llegada";
                data.Columns[7].HeaderCell.Value = "Escala O Directo";
                data.Columns[8].HeaderCell.Value = "Hotel";
                data.Columns[9].HeaderCell.Value = "Vehiculo";
                data.Columns[10].HeaderCell.Value = "Reserva #";
                data.Columns[11].HeaderCell.Value = "Precio";
                data.Refresh();
                data.ClearSelection();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //this method will insert the informatio about the sale that it did 
        public void realizarCompra(int cedula, int vehi, int hotel, int pais, string escala, int adulto, int nino, int totalh, string fechaini, string fechafin)
        {
            try
            {
                bd.InsertarDatos("INSERT INTO compra VALUES('" + cedula + "', '" + vehi + "', '" + hotel + "', '" + pais + "', '" + escala + "', '" + adulto + "', '" + nino + "', '" + totalh + "','" + fechaini + "', '" + fechafin + "')");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido un error!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //this method will rest a car when it is bought 
        public void restarCarro(int carro)
        {
            try
            {
                int resta = Convert.ToInt32(bd.MostrarDatos("SELECT cantidad FROM vehiculo WHERE id = '" + carro + "'")) - 1;
                bd.MostrarDatos("UPDATE vehiculo SET cantidad = '" + resta + "' WHERE id = '" + carro + "'");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //this method will add a car when it is bought 
        public void sumarCarro(int carro)
        {
            try
            {
                int resta = Convert.ToInt32(bd.MostrarDatos("SELECT cantidad FROM vehiculo WHERE id = '" + carro + "'")) + 1;
                bd.MostrarDatos("UPDATE vehiculo SET cantidad = '" + resta + "' WHERE id = '" + carro + "'");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //this method will rest rooms from the hotel
        public void restarHabitaciones(int idhabitaciones, int habi)
        {
            try
            {
                int resta = Convert.ToInt32(bd.MostrarDatos("SELECT habitaciones FROM hotel WHERE id = '" + idhabitaciones + "'")) - habi;
                bd.MostrarDatos("UPDATE hotel SET habitaciones = '" + resta + "' WHERE id = '" + idhabitaciones + "'");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //this method will add rooms from the hotel
        public void sumarHabitaciones(int idhabitaciones, int habi)
        {
            try
            {
                int resta = Convert.ToInt32(bd.MostrarDatos("SELECT habitaciones FROM hotel WHERE id = '" + idhabitaciones + "'")) + habi;
                bd.MostrarDatos("UPDATE hotel SET habitaciones = '" + resta + "' WHERE id = '" + idhabitaciones + "'");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //this method will qualify the hotels that have been bought 
        public void calificarHotelWithID(int id, string calificacion)
        {
            int hotel2 = Convert.ToInt32(bd.MostrarDatos("SElECT h.id FROM hotel as h WHERE h.id = '" + id + "'"));

            try
            {
                int hotel = Convert.ToInt32(bd.MostrarDatos("SElECT h.id FROM hotel as h join calificacion as ca on ca.idhotel = h.id WHERE h.id = '" + id + "'"));
                double cali = Convert.ToInt32(bd.MostrarDatos("SElECT calificacion FROM calificacion WHERE idhotel = '" + hotel + "'"));
                if (hotel == 0)
                {
                    bd.InsertarDatos("INSERT INTO calificacion VALUES('" + hotel2 + "','" + Convert.ToDouble(calificacion) + "')");
                }
                else if (cali > 25)
                {
                    divi += 5;
                    bd.ModificarDatos("UPDATE calificacion SET calificacion = '" + Convert.ToDouble(calificacion) + cali + "' WHERE idhotel = '" + hotel + "'");
                }
                else
                {
                    bd.ModificarDatos("UPDATE calificacion SET calificacion = '" + Convert.ToDouble(calificacion) + cali + "' WHERE idhotel = '" + hotel + "'");
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //this method will qualify the hotels that have been bought with the name of the hotel
        public void calificarHotelWithNAME(string nombre, string calificacion)
        {
            int hotel2 = Convert.ToInt32(bd.MostrarDatos("SElECT h.id FROM hotel as h WHERE nombre = '" + nombre + "'"));

            try
            {
                int hotel = Convert.ToInt32(bd.MostrarDatos("SElECT h.id FROM hotel as h join calificacion as ca on ca.idhotel = h.id WHERE h.nombre = '" + nombre + "'"));
                double cali = Convert.ToInt32(bd.MostrarDatos("SElECT calificacion FROM calificacion WHERE idhotel = '" + hotel + "'"));
                if (hotel == 0)
                {
                    bd.InsertarDatos("INSERT INTO calificacion VALUES('" + hotel2 + "','" + Convert.ToDouble(calificacion) + "')");
                }
                else if (cali > 25)
                {
                    divi += 5;
                    bd.ModificarDatos("UPDATE calificacion SET calificacion = '" + Convert.ToDouble(calificacion) + cali + "' WHERE idhotel = '" + hotel + "'");
                }
                else
                {
                    bd.ModificarDatos("UPDATE calificacion SET calificacion = '" + Convert.ToDouble(calificacion) + cali + "' WHERE idhotel = '" + hotel + "'");
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

    }
}
