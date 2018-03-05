using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
using Npgsql;

namespace Procedimientos
{
    public class Procedimientos_Reportes 
    {

        ConexionBD bd = new ConexionBD();

        //this method will show the first report
        public ArrayList cantidad()
        {
            ArrayList canti = new ArrayList();

            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(r.hotel), h.nombre FROM reserva AS r JOIN hotel AS h on h.nombre = r.hotel WHERE r.hotel = h.nombre GROUP BY h.nombre;", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    canti.Add(reader.GetString(0));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                ConexionBD.conexion.Close();
            }


            return canti;
        }
        //this method will show the name of the hotels, first report
        public ArrayList nombres()
        {
            ArrayList nombres = new ArrayList();

            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(r.hotel), h.nombre FROM reserva AS r JOIN hotel AS h on h.nombre = r.hotel WHERE r.hotel = h.nombre GROUP BY h.nombre;", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    nombres.Add(reader.GetString(1));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                ConexionBD.conexion.Close();
            }


            return nombres;
        }

        //this method will show the second report
        public ArrayList personas()
        {
            ArrayList canti = new ArrayList();

            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT SUM(c.hospedado), h.nombre FROM compra as c JOIN hotel as h on h.id = c.id_hotel WHERE c.id_hotel <> 0 GROUP BY h.nombre;", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    canti.Add(reader.GetString(0));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                ConexionBD.conexion.Close();
            }


            return canti;
        }
        //this method will show the name of the hotels, second report
        public ArrayList hoteles()
        {
            ArrayList nombres = new ArrayList();

            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT SUM(c.hospedado), h.nombre FROM compra as c JOIN hotel as h on h.id = c.id_hotel WHERE c.id_hotel <> 0 GROUP BY h.nombre; ", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    nombres.Add(reader.GetString(1));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                ConexionBD.conexion.Close();
            }


            return nombres;
        }
        //this method will show the third report
        public ArrayList cantidadVisitas()
        {
            ArrayList canti = new ArrayList();

            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(r.paisd), r.paisd FROM reserva as r GROUP BY r.paisd", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    canti.Add(reader.GetString(0));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                ConexionBD.conexion.Close();
            }


            return canti;
        }
        //this method will show the name of the hotels, second report
        public ArrayList paisVisitas()
        {
            ArrayList nombres = new ArrayList();

            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(r.paisd), r.paisd FROM reserva as r GROUP BY r.paisd ", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    nombres.Add(reader.GetString(1));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                ConexionBD.conexion.Close();
            }


            return nombres;
        }

        //this method will show the total of adults, fourth report
        public ArrayList adultos(string fechaini, string fechafin)
        {
            ArrayList nombres = new ArrayList();

            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT SUM(c.adulto) FROM compra as c WHERE to_date(c.fechaini,'DD/MM/YY')  >= '" + fechaini + "' AND to_date(c.fechafin,'DD/MM/YY')  <= '" + fechafin + "'", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    nombres.Add(reader.GetString(0));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                ConexionBD.conexion.Close();
            }


            return nombres;
        }


        //this method will show the total of children, fifth report
        public ArrayList niños(string fechaini, string fechafin)
        {
            ArrayList nombres = new ArrayList();

            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT SUM(c.nino) FROM compra as c WHERE to_date(c.fechaini,'DD/MM/YY')  >= '" + fechaini + "' AND to_date(c.fechafin,'DD/MM/YY')  <= '" + fechafin + "'", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    nombres.Add(reader.GetString(0));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                ConexionBD.conexion.Close();
            }


            return nombres;
        }
    }
}
