using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Procedimientos;
using Conexion;

namespace Interfaces
{
    public partial class A_Hotel : Form
    {
        Procedimientos_Usuario pu = new Procedimientos_Usuario();
        ConexionBD bd = new ConexionBD();
        public static int hotelid;
        public static int totalh;
        public static int habita;
        public A_Hotel()
        {
            InitializeComponent();
            continuar.Visible = false;
            verificar.Visible = false;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;

            string miVariable = hoy.ToString("dd/MM/yyyy");

            double totalh = Convert.ToInt32(adultos.Value) + Convert.ToInt32(niños.Value);
            double resultado = totalh / 4;
            if (Math.Ceiling(resultado) > 1)
            {
                MessageBox.Show("Necesita " + Math.Ceiling(resultado) + " Habitaciones para el total de Personas!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                habi.Value = Convert.ToInt32(Math.Ceiling(resultado));
                verificar.Visible = true;
                continuar.Visible = true;
            }
            else if (fini.Value.ToString() == ffin.Value.ToString())
            {
                MessageBox.Show("Seleccione una Fecha!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (habi.Value == 1 & adultos.Value == 0 & niños.Value == 0)
            {
                MessageBox.Show("Ingrese Huéspedes!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (habi.Value == 0 & adultos.Value == 0 & niños.Value == 0)
            {
                MessageBox.Show("Ingrese Huéspedes y Habitaciones!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else if (Convert.ToDateTime(fini.Value.ToShortDateString()) < Convert.ToDateTime(miVariable) || Convert.ToDateTime(ffin.Value.ToShortDateString()) < Convert.ToDateTime(miVariable))
            {
                MessageBox.Show("Ingrese una Fecha actual o posterior!","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                continuar.Visible = true;
                verificar.Visible = true;
                habita = Convert.ToInt32(habi.Value);
            }

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (hoteles.SelectedRows.Count == 0)
            {
                if (MessageBox.Show("No desea un Hotel ?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    Close();
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (hoteles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Hotel!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                totalh = Convert.ToInt32(adultos.Value + niños.Value);
                hotelid = Convert.ToInt32(hoteles.CurrentRow.Cells[0].Value);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void A_Hotel_Load(object sender, EventArgs e)
        {

        }

        private void hoteles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void hoteles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string foto = bd.MostrarDatos("SELECT foto FROM hotel WHERE id = '" + hoteles.CurrentRow.Cells[0].Value + "'");
                Bitmap foto2 = new Bitmap(foto);
                pictureBox2.Image = (Image)foto2;

                if (Convert.ToInt32(hoteles.CurrentRow.Cells[2].Value) < habi.Value)
                {
                    MessageBox.Show("Este Hotel no cuenta con las habitaciones necesarias!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    return;
                }
            }
            catch (Exception error)
            {
                string err = error.Message;
            }

        }

        private void buscardestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            hoteles.Rows.Clear();
            pu.cargarHoteles(hoteles, buscardestino.Text);
            hoteles.ClearSelection();
        }


    }
}
