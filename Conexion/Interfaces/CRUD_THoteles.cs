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
//this form will let the user to administrate de CRUD of prices of hotels
namespace Interfaces
{
    public partial class CRUD_THoteles : UserControl
    {
        Procedimientos_THoteles pr = new Procedimientos_THoteles();
        ConexionBD bd = new ConexionBD();
        public CRUD_THoteles()
        {
            InitializeComponent();
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (id.SelectedItem.ToString() == "" || precio.Text == "")
            {
                MessageBox.Show("Llene todos los campos requeridos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Herencia_THoletes ht = new Herencia_THoletes();
                ht.id = Convert.ToInt32(id.SelectedItem.ToString());
                ht.Precio = Convert.ToInt32(precio.Text);
                pr.insertarTarifa(ht.id, ht.Precio);
            }
            id.Items.Clear();
            id.Text = "";
            hotel.Text = "";
            pr.llenarCombo(id, "SELECT h.id FROM hotel as h where h.id not in (select e.id from tarifa_hotel as e) ");
            id.SelectedIndex = -1;
            precio.Text = "";
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            pr.mostarInfo(mostrarinfo);
            mostrarinfo.ClearSelection();
            pr.mostarInfo(eliminartarifa);
            eliminartarifa.ClearSelection();
            pr.mostarInfo(mostrarinfodata);
            mostrarinfodata.ClearSelection();
        }

        private void eliminartarifa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pr.eliminarInfo(eliminartarifa);
        }

        private void mostrarinfodata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea Modificar la tarifa código " + mostrarinfodata.CurrentRow.Cells[0].Value.ToString() , "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    newid.Text = mostrarinfodata.CurrentRow.Cells[0].Value.ToString();
                    newprecio.Text = mostrarinfodata.CurrentRow.Cells[1].Value.ToString();
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

        private void newprecio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Herencia_THoletes ht = new Herencia_THoletes();
            ht.id = Convert.ToInt32(newid.Text);
            ht.Precio = Convert.ToInt32(newprecio.Text);
            pr.modificarTrifa(ht.id,ht.Precio);
            pr.mostarInfo(mostrarinfodata);
            mostrarinfodata.ClearSelection();
        }

        private void id_Click(object sender, EventArgs e)
        {
            if (id.Items.Count == 0)
            {
                MessageBox.Show("Todos los Hoteles cuentan con Tarifas!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void id_SelectionChangeCommitted(object sender, EventArgs e)
        {
            hotel.Text = bd.MostrarDatos("SELECT nombre FROM hotel WHERE id = '" + id.SelectedItem.ToString() + "'");
        }
    }
}
