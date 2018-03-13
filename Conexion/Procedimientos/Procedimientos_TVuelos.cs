using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
using Npgsql;
//this method will have all methods that the price of flies part needs for it to work
namespace Procedimientos
{
    public class Procedimientos_TVuelos
    {
        ConexionBD bd = new ConexionBD();
        //this method will charge the information on the datagridview
        public void llenarRutas(DataGridView data)
        {
            data.DataSource = bd.cargarDatagridlugar("SELECT ru.id, ru.pais_origen, ru.pais_destino FROM ruta as ru where ru.id not in (select tv.ruta from tarifa_vuelo as tv)").Tables[0];
            data.Columns[0].HeaderCell.Value = "Identificador";
            data.Columns[1].HeaderCell.Value = "País Origen";
            data.Columns[2].HeaderCell.Value = "País Destino";
            data.ClearSelection();
        }
        //this method will charge the information on the datagridview
        public void llenarRutas2(DataGridView data)
        {
            data.DataSource = bd.cargarDatagridlugar("SELECT id,pais_origen,pais_destino FROM ruta ").Tables[0];
            data.Columns[0].HeaderCell.Value = "Identificador";
            data.Columns[1].HeaderCell.Value = "País Origen";
            data.Columns[2].HeaderCell.Value = "País Destino";
            data.ClearSelection();
        }

        //this method will insert the information into the database
        public void insertarTarifa(int id, int precio, int idruta)
        {
            try
            {
                bd.InsertarDatos("INSERT INTO tarifa_vuelo VALUES ('" + id + "', '" + precio + "','" + idruta + "')");
                MessageBox.Show("Se ha registrado la tarifa Correctamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error! " + error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //this method will charge the information on the datagridview
        public void mostrarInfo(DataGridView data)
        {
            data.DataSource = bd.cargarDatagridlugar("SELECT tarifa_vuelo.id,tarifa_vuelo.precio,r.pais_origen,r.pais_destino FROM tarifa_vuelo JOIN ruta AS r ON r.id = tarifa_vuelo.ruta").Tables[0];
            data.Columns[0].HeaderCell.Value = "Identificador";
            data.Columns[1].HeaderCell.Value = "Precio";
            data.Columns[2].HeaderCell.Value = "País Origen";
            data.Columns[3].HeaderCell.Value = "País Destino";
            data.ClearSelection();
        }

        //this method will delete the information from the database
        public void eliminarTarifa(DataGridView data)
        {
            try
            {
                if (MessageBox.Show("Desea Eliminar la tarifa código " + data.CurrentRow.Cells[0].Value.ToString(), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    bd.EliminarDatos("DELETE FROM tarifa_vuelo WHERE id = '" + data.CurrentRow.Cells[0].Value.ToString() + "'");
                    MessageBox.Show("Se ha eliminado Correctamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mostrarInfo(data);
                    data.ClearSelection();
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
        public void modificarTarifa(int id, int precio, int idruta)
        {
            try
            {
                bd.ModificarDatos("UPDATE tarifa_vuelo SET precio = '" + precio + "', ruta = '" + idruta + "' WHERE id = '" + id + "'");
                MessageBox.Show("Se ha modificado Correctamente! ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error en la modificación! " + error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //this method will charge the ids combobox 
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

    }
}
