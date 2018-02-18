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
    public partial class CRUD_TVuelos : UserControl
    {
        Procedimientos_TVuelos pv = new Procedimientos_TVuelos();
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
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (id.Text == "" || precio.Text == "")
                {
                    MessageBox.Show("Llene todos los campos Requeridos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Herencia_TVuelos tv = new Herencia_TVuelos();
                    tv.Id = Convert.ToInt32(id.Text);
                    tv.Idruta = Convert.ToInt32(rutas.CurrentRow.Cells[0].Value.ToString());
                    tv.Precio = Convert.ToInt32(precio.Text);
                    pv.insertarTarifa(tv.Id,tv.Precio,tv.Idruta);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Seleccione una ruta! ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            id.Text = "";
            precio.Text = "";
            rutas.ClearSelection();
        }
    }
}
