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
namespace Interfaces
{
    public partial class CRUD_THoteles : UserControl
    {
        Procedimientos_THoteles pr = new Procedimientos_THoteles();
        public CRUD_THoteles()
        {
            InitializeComponent();
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo Números!","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || precio.Text == "")
            {
                MessageBox.Show("Llene todos los campos requeridos!","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                Herencia_THoletes ht = new Herencia_THoletes();
                ht.id = Convert.ToInt32(id.Text);
                ht.Precio = Convert.ToInt32(precio.Text);
                pr.insertarTarifa(ht.id,ht.Precio);
            }
            id.Text = "";
            precio.Text = "";
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            pr.mostarInfo(mostrarinfo);
            mostrarinfo.ClearSelection();
            pr.mostarInfo(eliminartarifa);
            eliminartarifa.ClearSelection();
        }

        private void eliminartarifa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pr.eliminarInfo(eliminartarifa);
        }
    }
}
