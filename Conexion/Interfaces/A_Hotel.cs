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
namespace Interfaces
{
    public partial class A_Hotel : Form
    {
        Procedimientos_Usuario pu = new Procedimientos_Usuario();
        public static int hotelid;
        public A_Hotel()
        {
            InitializeComponent();
            continuar.Visible = false;
            verificar.Visible = false;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            double totalh = Convert.ToInt32(adultos.Value) + Convert.ToInt32(niños.Value);
            double resultado = totalh / 4;
            if (Math.Ceiling(resultado) > 1)
            {
                MessageBox.Show("Necesita " + Math.Ceiling(resultado) + " Habitaciones para el total de Personas!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                habi.Value = Convert.ToInt32(Math.Ceiling(resultado));
                continuar.Visible = true;
                verificar.Visible = true;

            }
            else
            {
                continuar.Visible = true;
                verificar.Visible = true;
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
            if (hoteles.Columns[2].HeaderText == "Foto")
            {
                if (e.Value != null)
                {
                    try
                    {
                        e.Value = Image.FromFile(e.Value.ToString()).GetThumbnailImage(101, 120, delegate { return true; }, IntPtr.Zero);
                    }
                    catch (Exception error)
                    { }
                }
            }
        }

        private void hoteles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(hoteles.CurrentRow.Cells[3].Value) < habi.Value)
            {
                MessageBox.Show("Este Hotel no cuenta con las habitaciones necesarias!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                return;
            }
        }

        private void buscardestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            hoteles.Rows.Clear();
            pu.cargarHoteles(hoteles,buscardestino.Text);
            hoteles.ClearSelection();
        }
    }
}
