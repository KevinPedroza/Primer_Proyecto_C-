﻿using System;
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
using Conexion;

namespace Interfaces
{
    public partial class Usuario : Form
    {
        Procedimientos_Usuario pu = new Procedimientos_Usuario();
        ConexionBD bd = new ConexionBD();
        Vista_Reservas ee = new Vista_Reservas();
        List<Color> colores = new List<Color>();
        int currentcolor = 0;
        int a = 0;
        public static int contador;
        public static string paiso;
        public static string paisd;
        public static string escala;
        public static string precio2;
        public static string fechaini;
        public static string fechafin;
        public static int adulto;
        public static int niño;
        public Usuario()
        {
            InitializeComponent();
            nombreuser.Text = pu.nom_user(Login.contra);
            int cedula = Convert.ToInt32(pu.cedula(Login.contra));
            nreservas.Text = pu.traerCantidadR(cedula);

            colores.Add(Color.FromArgb(33, 150, 243));
            colores.Add(Color.FromArgb(3, 169, 244));
            colores.Add(Color.FromArgb(0, 150, 136));
            colores.Add(Color.FromArgb(103, 58, 183));
            colores.Add(Color.FromArgb(156, 39, 176));
            colores.Add(Color.FromArgb(255, 87, 34));
            colores.Add(Color.FromArgb(255, 193, 7));
            colores.Add(Color.FromArgb(205, 220, 57));
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
            pu.llenarCombo(origen, "SELECT r.pais_origen FROM ruta as r join tarifa_vuelo as tv on tv.ruta = r.id GROUP by pais_origen;");
            destino.Items.Clear();
            pu.llenarCombo(destino, "SELECT pais_destino FROM ruta as r join tarifa_vuelo as tv on tv.ruta = r.id GROUP by pais_destino;");
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;

            string miVariable = hoy.ToString("dd/MM/yyyy");
            try
            {
                if (origen.SelectedItem.ToString() == destino.SelectedItem.ToString())
                {
                    MessageBox.Show("Seleccione Diferentes Paises!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (finicial.Value.ToString() == ffinal.Value.ToString())
                {
                    MessageBox.Show("Seleccione una Fecha!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Convert.ToDateTime(finicial.Value.ToShortDateString()) < Convert.ToDateTime(miVariable) || Convert.ToDateTime(ffinal.Value.ToShortDateString()) < Convert.ToDateTime(miVariable))
                {
                    MessageBox.Show("Ingrese una Fecha actual o posterior!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    string paiso = pu.paiso(origen.SelectedItem.ToString());
                    string paisd = pu.paisd(destino.SelectedItem.ToString());
                    string direcoesca = pu.escala_Directo(paiso, paisd);
                    adulto = Convert.ToInt32(adultos.Value);
                    niño = Convert.ToInt32(niños.Value);
                    ArrayList pais = new ArrayList();
                    pais = pu.paisesEscala(paiso, paisd);
                    ArrayList escalas = new ArrayList();
                    escalas = pu.escala(paisd);
                    ArrayList precios = new ArrayList();
                    precios = pu.precioEscala(paisd);
                    ArrayList duracion = new ArrayList();
                    duracion = pu.duracionEscala(paisd);
                    vuelos.Rows.Clear();
                    pu.mostrarInfo(vuelos, paiso, paisd, direcoesca, pais, escalas, precios, duracion, adulto + niño,A_Hotel.habita);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Seleccione Paises de Origen! " + error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(adultos.Value) == 0 & Convert.ToInt32(niños.Value) == 0)
            {
                MessageBox.Show("Ingrese Pasajeros para optimizar la busqueda de Vehiculos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                adulto = Convert.ToInt32(adultos.Value);
                niño = Convert.ToInt32(niños.Value);
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
            A_Hotel ah = new A_Hotel();

            if (vuelos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Primero Seleccione un Vuelo!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                vuelos.Focus();
            }
            else if (adultos.Value == 0 & niños.Value == 0)
            {
                MessageBox.Show("Ingrese Pasajeros! ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((finicial.Value > Convert.ToDateTime(A_Hotel.fechaini) || finicial.Value < Convert.ToDateTime(A_Hotel.fechafin)) & (ffinal.Value < Convert.ToDateTime(A_Hotel.fechafin) || ffinal.Value > Convert.ToDateTime(A_Hotel.fechafin)) & A_Hotel.hotelid != 0)
            {
                MessageBox.Show("Seleccione Fechas que Coincidan entre el Hotel y el Vuelo!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                paiso = origen.SelectedItem.ToString();
                paisd = destino.SelectedItem.ToString();
                escala = vuelos.CurrentRow.Cells[2].Value.ToString();
                precio2 = vuelos.CurrentRow.Cells[6].Value.ToString();
                fechaini = finicial.Value.ToShortDateString();
                fechafin = ffinal.Value.ToShortDateString();
                tracontinuar.HideSync(this);
                Vista_Reservas vr = new Vista_Reservas();
                vr.Show();
            }
        }

        private void finicial_onValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nreservas.Text == "0")
            {
                MessageBox.Show("No cuenta con Reservas!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.Hide();
                contador++;
                ee.Show();
            }

        }

        private void finicial_Validating(object sender, CancelEventArgs e)
        {

        }

        private void ffinal_Validating(object sender, CancelEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentcolor < colores.Count - 1)
            {
                this.BackColor = Bunifu.Framework.UI.BunifuColorTransition.getColorScale(a, colores[currentcolor], colores[currentcolor + 1]);

                if (a < 100)
                {
                    a++;
                }
                else
                {
                    a = 0;
                    currentcolor++;
                }
                timer1.Enabled = true;
            }
        }
    }
}