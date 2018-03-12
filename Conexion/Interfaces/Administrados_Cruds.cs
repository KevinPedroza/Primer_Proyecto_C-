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
        Procedimientos_Vehiculos pv = new Procedimientos_Vehiculos();
        Procedimientos_THoteles pth = new Procedimientos_THoteles();
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
            cruD_Vehiculos1.Hide();
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
            cruD_Vehiculos1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button2.Height;
            slide_panel.Top = button2.Top;
            cruD_lugares1.id_lugar.Items.Clear();
            pth.llenarCombo(cruD_lugares1.id_lugar, "SELECT h.id FROM pais as h where h.id not in (select e.id from lugar as e)");
            if (cruD_lugares1.id_lugar.Items.Count == 0)
            {
                MessageBox.Show("Todos los lugares cuentan con Paises!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cruD_lugares1.Show();
            }
            cruD_paise1.Hide();
            cruD_Aeropuertos1.Hide();
            cruD_Rutas1.Hide();
            cruD_THoteles1.Hide();
            cruD_TVuelos1.Hide();
            cruD_hoteles1.Hide();
            cruD_Vehiculos1.Hide();
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
            cruD_Vehiculos1.Hide();
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
            cruD_Vehiculos1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button5.Height;
            slide_panel.Top = button5.Top;
            cruD_Rutas1.Show();
            cruD_Rutas1.pais_origenin.Items.Clear();
            cruD_Rutas1.pais_destinoin.Items.Clear();
            pr.cargarCombo(cruD_Rutas1.pais_origenin);
            pr.cargarCombo(cruD_Rutas1.pais_destinoin);
            cruD_Rutas1.pais_destinoin.SelectedIndex = 0;
            cruD_Rutas1.pais_origenin.SelectedIndex = 0;
            cruD_paise1.Hide();
            cruD_lugares1.Hide();
            cruD_Aeropuertos1.Hide();
            cruD_THoteles1.Hide();
            cruD_TVuelos1.Hide();
            cruD_hoteles1.Hide();
            cruD_Vehiculos1.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button6.Height;
            slide_panel.Top = button6.Top;
            cruD_hoteles1.Show();
            cruD_hoteles1.lugar.Items.Clear();
            ph.llenarCombo(cruD_hoteles1.lugar, "SELECT nombre FROM lugar");
            cruD_hoteles1.lugar.SelectedIndex = 0;
            cruD_Rutas1.Hide();
            cruD_paise1.Hide();
            cruD_lugares1.Hide();
            cruD_Aeropuertos1.Hide();
            cruD_THoteles1.Hide();
            cruD_TVuelos1.Hide();
            cruD_Vehiculos1.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button7.Height;
            slide_panel.Top = button7.Top;
            cruD_THoteles1.id.Items.Clear();
            pth.llenarCombo(cruD_THoteles1.id, "SELECT h.id FROM hotel as h where h.id not in (select e.id from tarifa_hotel as e) ");

            if (cruD_THoteles1.id.Items.Count == 0)
            {
                MessageBox.Show("Todos los Hoteles cuentan con Tarifas!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cruD_THoteles1.Show();
            }
            cruD_Rutas1.Hide();
            cruD_paise1.Hide();
            cruD_lugares1.Hide();
            cruD_Aeropuertos1.Hide();
            cruD_TVuelos1.Hide();
            cruD_hoteles1.Hide();
            cruD_Vehiculos1.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button8.Height;
            slide_panel.Top = button8.Top;
            cruD_TVuelos1.id.Items.Clear();
            tv.llenarCombo(cruD_TVuelos1.id,"SELECT ru.id FROM ruta as ru where ru.id not in (select tv.ruta from tarifa_vuelo as tv)");
            tv.llenarRutas(cruD_TVuelos1.rutas);
            if (cruD_TVuelos1.id.Items.Count == 0)
            {
                MessageBox.Show("Todos las Rutas cuentan con Tarifas!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cruD_TVuelos1.Show();
            }
            cruD_THoteles1.Hide();
            cruD_Rutas1.Hide();
            cruD_paise1.Hide();
            cruD_lugares1.Hide();
            cruD_Aeropuertos1.Hide();
            cruD_hoteles1.Hide();
            cruD_Vehiculos1.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button9.Height;
            slide_panel.Top = button9.Top;
            cruD_Vehiculos1.Show();
            cruD_Vehiculos1.marca.Items.Clear();
            cruD_Vehiculos1.tipo.Items.Clear();
            pv.llenarMarcaCombo(cruD_Vehiculos1.marca);
            pv.llenarTiposCombo(cruD_Vehiculos1.tipo);
            cruD_Vehiculos1.marca.SelectedIndex = 0;
            cruD_Vehiculos1.tipo.SelectedIndex = 0;
            cruD_THoteles1.Hide();
            cruD_Rutas1.Hide();
            cruD_paise1.Hide();
            cruD_lugares1.Hide();
            cruD_Aeropuertos1.Hide();
            cruD_hoteles1.Hide();
            cruD_TVuelos1.Hide();
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

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Reportes mr = new Menu_Reportes();
            mr.Show();
        }
    }
}
