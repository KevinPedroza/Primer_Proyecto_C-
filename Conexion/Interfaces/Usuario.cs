using System;
using System.Collections;
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
            pu.llenarCombo(origen, "SELECT pais_origen FROM ruta GROUP by pais_origen;");
            destino.Items.Clear();
            pu.llenarCombo(destino, "SELECT pais_destino FROM ruta GROUP by pais_destino;");
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (origen.SelectedItem.ToString() == destino.SelectedItem.ToString())
            {
                MessageBox.Show("Seleccione Diferentes Paises!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string paiso = pu.paiso(origen.SelectedItem.ToString());
                string paisd = pu.paisd(destino.SelectedItem.ToString());
                string direcoesca = pu.escala_Directo(paiso, paisd);
                ArrayList pais = new ArrayList();
                pais = pu.paisesEscala(paiso, paisd);
                ArrayList escalas = new ArrayList();
                escalas = pu.escala(paisd);
                ArrayList precios = new ArrayList();
                precios = pu.precioEscala(paisd);
                vuelos.Rows.Clear();
                pu.mostrarInfo(vuelos, paiso, paisd, direcoesca, pais, escalas, precios);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(adultos.Value) == 0 & Convert.ToInt32(niños.Value) == 0)
            {
                MessageBox.Show("Ingrese Pasajeros para optimizar la busqueda de Vehiculos!","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                A_Carro c = new A_Carro();
                c.ShowDialog();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            A_Hotel ah = new A_Hotel();
            ah.ShowDialog();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (vuelos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Primero Seleccione un Vuelo!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                vuelos.Focus();
            }
            else if (adultos.Value == 0 & niños.Value == 0)
            {
                MessageBox.Show("Ingrese Pasajeros! ","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                this.Hide();
                Vista_Reservas vr = new Vista_Reservas();
                vr.Show();
            }
        }
    }
}
