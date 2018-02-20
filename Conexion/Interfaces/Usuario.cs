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
    public partial class Usuario : Form
    {
        Procedimientos_Usuario pu = new Procedimientos_Usuario();
        
        public Usuario()
        {
            InitializeComponent();
            nombreuser.Text = pu.nom_user(Login.contra);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Cerrar Sesion?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Hide();
                Login lo = new Login();
                lo.Show();
            }
            else
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir del Programa?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            origen.Items.Clear();
            pu.llenarCombo(origen,"SELECT pais_origen FROM ruta;");
            destino.Items.Clear();
            pu.llenarCombo(destino, "SELECT pais_destino FROM ruta;");
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            string paiso = origen.SelectedItem.ToString();
            string paisd = destino.SelectedItem.ToString();
            string direcoesca = pu.escala_Directo(paiso, paisd);
            string escalasalida = pu.escala_salida(paiso, paisd);
            vuelos.Rows.Clear();
            pu.mostrarInfo(vuelos,paiso,paisd,direcoesca,paisd,paiso,escalasalida);
        }
    }
}
