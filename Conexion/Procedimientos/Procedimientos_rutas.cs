using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
using System.Data;
//this method will have all methods that the roads part needs for it to work
namespace Procedimientos
{
    public class Procedimientos_rutas
    {
        ConexionBD bd = new ConexionBD();
        //this method will charge the information on the combobox
        public void cargarCombo(ComboBox combo)
        {
            bd.Conexion();
            ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT nombre FROM pais", ConexionBD.conexion);
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
        //this method will charge the information on the database
        public void registrarRuta(int id, string origen, string destino, string duracion)
        {
            try
            {
                bd.InsertarDatos("INSERT INTO ruta VALUES('" + id + "','" + origen + "','" + destino + "','" + duracion + "')");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error! " + error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //this method will charge the information on the datagrid view
        public void mostrarInfoDataGrid(DataGridView data )
        {
            data.DataSource = bd.cargarDatagridlugar("SELECT * FROM ruta").Tables[0];
            data.Columns[0].HeaderCell.Value = "Identificador";
            data.Columns[1].HeaderCell.Value = "País Origen";
            data.Columns[2].HeaderCell.Value = "País Destino";
            data.Columns[3].HeaderCell.Value = "Duración";
        }
        //this method will delete the information from the database
        public void eliminarInfo(DataGridView eliminar_ruta)
        {
            try
            {

                if (MessageBox.Show("Desea Eliminar la ruta de Origen " + eliminar_ruta.CurrentRow.Cells[1].Value.ToString() + " Con destino a " + eliminar_ruta.CurrentRow.Cells[2].Value.ToString(), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    bd.EliminarDatos("DELETE FROM tarifa_vuelo WHERE ruta = '" + eliminar_ruta.CurrentRow.Cells[0].Value.ToString() + "'");
                    bd.EliminarDatos("DELETE FROM ruta WHERE id = '" + eliminar_ruta.CurrentRow.Cells[0].Value.ToString() + "'");
                    MessageBox.Show("Se ha eliminado Correctamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mostrarInfoDataGrid(eliminar_ruta);
                    eliminar_ruta.ClearSelection();
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

        //this method will modify the information from the database
        public void modificarRuta(int id,string origen,string destino,string duracion)
        {
            try
            {
                bd.ModificarDatos("UPDATE ruta SET pais_origen = '" + origen + "', pais_destino = '" + destino + "', duracion = '" + duracion + "' WHERE id = '" + id + "'");
                MessageBox.Show("Se ha modificado Correctamente!","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error en la modificación! "+error.Message,"Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}

