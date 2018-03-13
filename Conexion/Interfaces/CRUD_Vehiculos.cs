using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Procedimientos;
using Conexion;
//this form will let the user to administrate de CRUD of cars
namespace Interfaces
{
    public partial class CRUD_Vehiculos : UserControl
    {
        Procedimientos_Vehiculos pv = new Procedimientos_Vehiculos();
        ConexionBD bd = new ConexionBD();
        int contador = 0;
        public CRUD_Vehiculos()
        {
            InitializeComponent();
        }

        private void marca_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            contador++;
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo Números!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (contador >= 6)
            {
                id.Enabled = false;
            }
            else
            {
                return;
            }

        }

        private void precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo Números!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                return;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                errorProvider1.SetError(id, "Llene el campo ID! ");
            }
            else if (precio.Text == "")
            {
                errorProvider1.SetError(precio, "Llene el campo de Precio! ");
            }
            else if (bd.MostrarDatos("SELECT marca FROM vehiculo WHERE id = '" + marca.SelectedItem.ToString() + "'") == marca.SelectedItem.ToString())
            {
                MessageBox.Show("Esa marca de Vehiculo ya Existe!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (bd.MostrarDatos("SELECT id FROM vehiculo WHERE id = '" + id.Text + "'") == id.Text)
            {
                MessageBox.Show("Ese identificador de Vehiculo ya Existe!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (bd.MostrarDatos("SELECT modelo FROM vehiculo WHERE id = '" + modelo.Text + "'") == modelo.Text)
            {
                MessageBox.Show("Ese modelo de Vehiculo ya Existe!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Herencia_Vehiculos hv = new Herencia_Vehiculos();
                hv.Id = Convert.ToInt32(id.Text);
                hv.Precio = Convert.ToInt32(precio.Text);
                hv.Marca = marca.SelectedItem.ToString();
                hv.Modelo = modelo.Text;
                hv.Tipo = tipo.SelectedItem.ToString();
                hv.Canidad = Convert.ToInt32(canti.Value);
                errorProvider1.Clear();
                pv.registrarVehiculo(hv.Id, hv.Marca, hv.Modelo, hv.Tipo, hv.Precio, hv.Canidad);
            }
            id.Text = "";
            precio.Text = "";
            marca.SelectedIndex = 0;
            tipo.SelectedIndex = 0;
            canti.Value = 0;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            pv.mostrarInfo(mostrarinfo);
            pv.mostrarInfo(eliminarinfo);
            pv.mostrarInfo(modificarinfo);
            newmarca.Items.Clear();
            pv.llenarMarcaCombo(newmarca);
            newtipo.Items.Clear();
            pv.llenarTiposCombo(newtipo);
        }

        private void eliminarinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pv.eliminarInfo(eliminarinfo);
        }

        private void modificarinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea Modificar el Vehiculo Código " + modificarinfo.CurrentRow.Cells[0].Value.ToString() + " Marca " + modificarinfo.CurrentRow.Cells[1].Value.ToString(), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    newid.Text = modificarinfo.CurrentRow.Cells[0].Value.ToString();
                    newmarca.Text = modificarinfo.CurrentRow.Cells[1].Value.ToString();
                    newmodelo.Text = modificarinfo.CurrentRow.Cells[2].Value.ToString();
                    newtipo.Text = modificarinfo.CurrentRow.Cells[3].Value.ToString();
                    newprecio.Text = modificarinfo.CurrentRow.Cells[4].Value.ToString();
                    newcanti.Value = Convert.ToDecimal(modificarinfo.CurrentRow.Cells[5].Value.ToString());
                }
                else
                {
                    return;
                }
            }
            catch (Exception error)
            {
                string erro = error.Message;
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (newprecio.Text == "")
            {
                errorProvider1.SetError(newprecio, "Llene el campo Precio!");
            }
            else if (newmodelo.Text == "")
            {
                errorProvider1.SetError(newmodelo, "Llene el campo Modelo!");
            }
            else
            {
                Herencia_Vehiculos hv = new Herencia_Vehiculos();
                hv.Id = Convert.ToInt32(newid.Text);
                hv.Precio = Convert.ToInt32(newprecio.Text);
                hv.Marca = newmarca.SelectedItem.ToString();
                hv.Modelo = newmodelo.Text;
                hv.Tipo = newtipo.SelectedItem.ToString();
                hv.Canidad = Convert.ToInt32(newcanti.Value);
                errorProvider1.Clear();

                pv.modificarInfo(hv.Id, hv.Marca, hv.Modelo, hv.Tipo, hv.Precio, hv.Canidad);
                pv.mostrarInfo(modificarinfo);
            }
            newid.Text = "";
            newprecio.Text = "";
            newcanti.Value = 0;
            newmarca.SelectedIndex = -1;
            newtipo.SelectedIndex = -1;
        }

        private void newmarca_TextChanged(object sender, EventArgs e)
        {
        }

        private void newmodelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo LetraS!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                return;
            }

        }

        private void modelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo LetraS!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                return;
            }
        }
    }
}
