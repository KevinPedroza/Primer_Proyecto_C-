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
namespace Interfaces
{
    public partial class CRUD_TVuelos : UserControl
    {
        Procedimientos_TVuelos pv = new Procedimientos_TVuelos();
        ConexionBD bd = new ConexionBD();
        public CRUD_TVuelos()
        {
            InitializeComponent();
            pv.llenarRutas(rutas);
            rutas.ClearSelection();
        }

        private void bunifuCustomTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo números! ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                return;
            }
        }

        private void bunifuCustomTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo números! ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                return;
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            pv.llenarRutas(rutas);
            pv.mostrarInfo(mostrarinfo);
            pv.mostrarInfo(eliminarinfo);
            pv.mostrarInfo(modificarinfo);
            pv.llenarRutas2(newruta);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (id.SelectedItem.ToString() == "" || precio.Text == "")
                {
                    MessageBox.Show("Llene todos los campos Requeridos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Herencia_TVuelos tv = new Herencia_TVuelos();
                    tv.Id = Convert.ToInt32(id.SelectedItem.ToString());
                    tv.Idruta = Convert.ToInt32(rutas.CurrentRow.Cells[0].Value.ToString());
                    tv.Precio = Convert.ToInt32(precio.Text);
                    pv.insertarTarifa(tv.Id, tv.Precio, tv.Idruta);

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Seleccione una ruta! " + error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            id.Items.Clear();
            id.Text = "";
            pv.llenarCombo(id, "SELECT ru.id FROM ruta as ru where ru.id not in (select tv.ruta from tarifa_vuelo as tv)");
            id.SelectedIndex = -1;
            precio.Text = "";
            pv.llenarRutas(rutas);
            rutas.ClearSelection();
        }

        private void eliminarinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pv.eliminarTarifa(eliminarinfo);
        }

        private void newprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo números! ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                return;
            }
        }

        private void modificarinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea Modificar la tarifa código " + modificarinfo.CurrentRow.Cells[0].Value.ToString(), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    newid.Text = modificarinfo.CurrentRow.Cells[0].Value.ToString();
                    newprecio.Text = modificarinfo.CurrentRow.Cells[1].Value.ToString();
                    int index = 0;
                    foreach (DataGridViewRow fila in newruta.Rows)
                    {
                        if (modificarinfo.CurrentRow.Cells[2].Value.ToString() == fila.Cells[1].Value.ToString() & modificarinfo.CurrentRow.Cells[3].Value.ToString() == fila.Cells[2].Value.ToString())
                        {
                            index = fila.Index;
                        }
                        newruta.ClearSelection();
                        newruta.Rows[index].Selected = true;
                        newruta.CurrentCell = newruta.Rows[index].Cells[0];
                    }

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
            try
            {
                if (newprecio.Text == "")
                {
                    errorProvider1.SetError(newprecio, "Ingrese un Precio!");
                }
                else
                {
                    errorProvider1.Clear();
                    Herencia_TVuelos tv = new Herencia_TVuelos();
                    tv.Id = Convert.ToInt32(newid.Text);
                    tv.Idruta = Convert.ToInt32(newruta.CurrentRow.Cells[0].Value.ToString());
                    tv.Precio = Convert.ToInt32(newprecio.Text);
                    pv.modificarTarifa(Convert.ToInt32(tv.Id),Convert.ToInt32(tv.Precio),Convert.ToInt32(tv.Idruta));
                    pv.mostrarInfo(modificarinfo);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error! "+error.Message,"Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            newid.Text = "";
            newprecio.Text = "";
            newruta.ClearSelection();

        }

        private void id_Click(object sender, EventArgs e)
        {
            if (id.Items.Count == 0)
            {
                MessageBox.Show("Todos las Rutas cuentan con Tarifas!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
