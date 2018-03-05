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
    public class Procedimientos_Hoteles
    {
        ConexionBD bd = new ConexionBD();
        //this method will charge the information on the combobox
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

        //this method wil insert the information on the dabatase
        public void insertarHotel(int id, string nombre, string foto, int habi, string pais, string lugar)
        {
            try
            {
                bd.InsertarDatos("INSERT INTO hotel VALUES ('" + id + "', '" + nombre + "', '" + foto + "', '" + habi + "','" + pais + "', '" + lugar + "')");
                MessageBox.Show("Se ha registrado Correctamente!","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error! " + error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //this method will charge the informacion on the datagridview
        public void mostrarInfo(DataGridView data)
        {
            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM hotel", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    data.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3),reader.GetString(4),reader.GetString(5));
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

        //this method will delete de information from the database 
        public void eliminarInfo(DataGridView eliminartarifa)
        {
            try
            {
                if (MessageBox.Show("Desea Eliminar el Hotel " + eliminartarifa.CurrentRow.Cells[1].Value.ToString(), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    bd.EliminarDatos("DELETE FROM hotel WHERE id = '" + eliminartarifa.CurrentRow.Cells[0].Value.ToString() + "'");
                    bd.EliminarDatos("DELETE FROM calificacion WHERE idhotel = '" + eliminartarifa.CurrentRow.Cells[0].Value.ToString() + "'");
                    MessageBox.Show("Se ha eliminado Correctamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    eliminartarifa.Rows.Clear();
                    mostrarInfo(eliminartarifa);
                    eliminartarifa.ClearSelection();
                }
                else
                {
                    return;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error! " + error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //this method will modify the information on the database
        public void modificarHotelConImage(int id, string nombre, string foto,int habi,string pais,string lugar)
        {
            try
            {
                bd.ModificarDatos("UPDATE hotel SET nombre = '" + nombre + "', foto = '" + foto + "', habitaciones = '" + habi + "', pais = '" + pais + "', lugar = '" + lugar + "' WHERE id = '" + id + "'");
                MessageBox.Show("Se ha modificado Correctamente! ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error en la modificación! " + error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //this method will modify the information on the database without image
        public void modificarHotelSinImage(int id, string nombre, string foto, int habi, string pais, string lugar)
        {
            try
            {
                bd.ModificarDatos("UPDATE hotel SET nombre = '" + nombre + "', habitaciones = '" + habi + "', pais = '" + pais + "', lugar = '" + lugar + "' WHERE id = '" + id + "'");
                MessageBox.Show("Se ha modificado Correctamente! ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error en la modificación! " + error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
