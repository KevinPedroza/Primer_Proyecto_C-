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
    public partial class A_Carro : Form
    {
        Procedimientos_Usuario pu = new Procedimientos_Usuario();
        Usuario u = new Usuario();
        public static int idcarro;
        public A_Carro()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (carros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Vehiculo!","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                idcarro = Convert.ToInt32(carros.CurrentRow.Cells[0].Value);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (carros.SelectedRows.Count == 0)
            {
                if (MessageBox.Show("No desea un Vehiculo ?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    Close();
                }
            }
        }

        private void A_Carro_Load(object sender, EventArgs e)
        {
            carros.Rows.Clear();
            pu.cargarCarros(carros, Convert.ToInt32(u.adultos.Value) + Convert.ToInt32(u.adultos.Value));
            carros.ClearSelection();
        }
    }
}
