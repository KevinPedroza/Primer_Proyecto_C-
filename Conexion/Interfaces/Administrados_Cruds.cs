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
    public partial class Administrados_Cruds : Form
    {
        Procedimientos_TVuelos tv = new Procedimientos_TVuelos();
        Procedimientos_Aeropertos pr2 = new Procedimientos_Aeropertos();
        Procedimientos_Hoteles ph = new Procedimientos_Hoteles();
        Procedimientos_rutas pr = new Procedimientos_rutas();
        public Administrados_Cruds()
        {
            InitializeComponent();
            cruD_paise1.Hide();
            cruD_lugares1.Hide();
            cruD_Aeropuertos1.Hide();
            cruD_Rutas1.Hide();
            cruD_THoteles1.Hide();
            cruD_TVuelos1.Hide();
            cruD_hoteles1.Hide();
        }

        private void Administrados_Cruds_Load(object sender, EventArgs e)
        {
            slide_panel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button1.Height;
            slide_panel.Top = button1.Top;
            cruD_paise1.Show();
            cruD_lugares1.Hide();
            cruD_Aeropuertos1.Hide();
            cruD_Rutas1.Hide();
            cruD_THoteles1.Hide();
            cruD_TVuelos1.Hide();
            cruD_hoteles1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button2.Height;
            slide_panel.Top = button2.Top;
            cruD_lugares1.Show();
            cruD_paise1.Hide();
            cruD_Aeropuertos1.Hide();
            cruD_Rutas1.Hide();
            cruD_THoteles1.Hide();
            cruD_TVuelos1.Hide();
            cruD_hoteles1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button3.Height;
            slide_panel.Top = button3.Top;
            cruD_Aeropuertos1.Show();
            cruD_paise1.Hide();
            cruD_lugares1.Hide();
            cruD_Rutas1.Hide();
            cruD_THoteles1.Hide();
            cruD_TVuelos1.Hide();
            cruD_hoteles1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button4.Height;
            slide_panel.Top = button4.Top;
            MessageBox.Show("No esta disponible está herramienta. Estamos trabajando en ella! Gracias","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            cruD_paise1.Hide();
            cruD_lugares1.Hide();
            cruD_Aeropuertos1.Hide();
            cruD_Rutas1.Hide();
            cruD_THoteles1.Hide();
            cruD_TVuelos1.Hide();
            cruD_hoteles1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button5.Height;
            slide_panel.Top = button5.Top;
            cruD_Rutas1.Show();
            pr.cargarCombo(cruD_Rutas1.pais_origenin);
            pr.cargarCombo(cruD_Rutas1.pais_destinoin);
            cruD_paise1.Hide();
            cruD_lugares1.Hide();
            cruD_Aeropuertos1.Hide();
            cruD_THoteles1.Hide();
            cruD_TVuelos1.Hide();
            cruD_hoteles1.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button6.Height;
            slide_panel.Top = button6.Top;
            cruD_hoteles1.Show();
            cruD_hoteles1.pais.SelectedIndex = 0;
            cruD_hoteles1.lugar.SelectedIndex = 0;
            ph.llenarCombo(cruD_hoteles1.pais, "SELECT nombre FROM pais");
            ph.llenarCombo(cruD_hoteles1.lugar, "SELECT nombre FROM lugar");
            cruD_Rutas1.Hide();
            cruD_paise1.Hide();
            cruD_lugares1.Hide();
            cruD_Aeropuertos1.Hide();
            cruD_THoteles1.Hide();
            cruD_TVuelos1.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button7.Height;
            slide_panel.Top = button7.Top;
            cruD_THoteles1.Show();
            cruD_Rutas1.Hide();
            cruD_paise1.Hide();
            cruD_lugares1.Hide();
            cruD_Aeropuertos1.Hide();
            cruD_TVuelos1.Hide();
            cruD_hoteles1.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button8.Height;
            slide_panel.Top = button8.Top;
            cruD_TVuelos1.Show();
            tv.llenarRutas(cruD_TVuelos1.rutas);
            cruD_THoteles1.Hide();
            cruD_Rutas1.Hide();
            cruD_paise1.Hide();
            cruD_lugares1.Hide();
            cruD_Aeropuertos1.Hide();
            cruD_hoteles1.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button9.Height;
            slide_panel.Top = button9.Top;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir del Programa?","Aviso!",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void button10_Click(object sender, EventArgs e)
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
    }
}
