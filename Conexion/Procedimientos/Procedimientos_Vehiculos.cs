using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
namespace Procedimientos
{
    public class Procedimientos_Vehiculos
    {
        ConexionBD bd = new ConexionBD();
        //this method will charge information on a combobox
        public void llenarMarcaCombo(ComboBox combo)
        {
            combo.Items.Add("Hyundai");
            combo.Items.Add("Toyota");
            combo.Items.Add("Nissan");
            combo.Items.Add("Suzuki");
            combo.Items.Add("Mitsubichi");
            combo.Items.Add("Mazda");
        }

        //this method will charge the models to the combobox
        public void llenarModeloCombo(ComboBox combo, ComboBox marca)
        {
            try
            {
                if (marca.SelectedItem.ToString() == "Hyundai")
                {
                    combo.Items.Clear();
                    combo.Items.Add("Accent");
                    combo.Items.Add("H1");
                    combo.Items.Add("Tucson");
                }
                else if (marca.SelectedItem.ToString() == "Toyota")
                {
                    combo.Items.Clear();
                    combo.Items.Add("4Runner");
                    combo.Items.Add("Hilux");
                    combo.Items.Add("Rav4");
                }
                else if (marca.SelectedItem.ToString() == "Nissan")
                {
                    combo.Items.Clear();
                    combo.Items.Add("X-Trail");
                    combo.Items.Add("Frontier");
                    combo.Items.Add("Urvan");
                }
                else if (marca.SelectedItem.ToString() == "Suzuki")
                {
                    combo.Items.Clear();
                    combo.Items.Add("Ertiga");
                    combo.Items.Add("Switch");
                    combo.Items.Add("Gran Vitara");
                }
                else if (marca.SelectedItem.ToString() == "Mitsubichi")
                {
                    combo.Items.Clear();
                    combo.Items.Add("Montero Sport");
                    combo.Items.Add("L200");
                    combo.Items.Add("Outlander");
                }
                else if (marca.SelectedItem.ToString() == "Mazda")
                {
                    combo.Items.Clear();
                    combo.Items.Add("Mazda 3");
                    combo.Items.Add("RX-8");
                    combo.Items.Add("BT-50");
                }
            }
            catch (Exception error)
            {

            }
        }

        //this method will charge the types on the combobox
        public void llenarTiposCombo(ComboBox combo)
        {
            combo.Items.Add("HashBack");
            combo.Items.Add("Pick-Up");
            combo.Items.Add("Coupe");
            combo.Items.Add("Van");
            combo.Items.Add("Suvs");
        }

        //this method will charge the information on the database
        public void registrarVehiculo(int id, string marca, string modelo, string tipo, int precio, int canti)
        {
            try
            {
                bd.InsertarDatos("INSERT INTO vehiculo VALUES ('" + id + "', '" + marca + "', '" + modelo + "', '" + tipo + "', '" + precio + "', '" + canti + "');");
                MessageBox.Show("Se ha registrado Correctamente!","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //this method will show the information on the datagridview
        public void mostrarInfo(DataGridView data)
        {
            data.DataSource = bd.cargarDatagridlugar("SELECT * FROM vehiculo").Tables[0];
            data.Columns[0].HeaderCell.Value = "Identificador";
            data.Columns[1].HeaderCell.Value = "Marca";
            data.Columns[2].HeaderCell.Value = "Modelo";
            data.Columns[3].HeaderCell.Value = "Tipo";
            data.Columns[4].HeaderCell.Value = "Precio";
            data.Columns[5].HeaderCell.Value = "Cantidad";
            data.ClearSelection();
        }

        //this method will delete the information from the database
        public void eliminarInfo(DataGridView eliminar_ruta)
        {
            try
            {

                if (MessageBox.Show("Desea Eliminar el Vehiculo Código " + eliminar_ruta.CurrentRow.Cells[0].Value.ToString() + " Marca " + eliminar_ruta.CurrentRow.Cells[1].Value.ToString(), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    bd.EliminarDatos("DELETE FROM vehiculo WHERE id = '" + eliminar_ruta.CurrentRow.Cells[0].Value.ToString() + "'");
                    MessageBox.Show("Se ha eliminado Correctamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mostrarInfo(eliminar_ruta);
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

        //this method will modify the information from the cars
        public void modificarInfo(int id, string marca,string modelo,string tipo, int precio,int canti)
        {
            try
            {
                bd.ModificarDatos("UPDATE vehiculo SET marca = '" + marca + "', modelo = '" + modelo + "', tipo = '" + tipo + "', precio = '" + precio + "', cantidad = '" + canti + "' WHERE id = '" + id + "'");
                MessageBox.Show("Se ha modificado Correctamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error en la modificación! " + error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
