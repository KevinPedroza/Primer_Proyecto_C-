﻿using System;
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
//this form will let the user to rent a hotel
namespace Interfaces
{
    public partial class A_Hotel : Form
    {
        Procedimientos_Usuario pu = new Procedimientos_Usuario();
        ConexionBD bd = new ConexionBD();
        public static int hotelid;
        public static int totalh;
        public static int habita;
        public static string fechaini;
        public static string fechafin;
        public static string lugarpais;
        public static int con = 0;
        public A_Hotel()
        {
            InitializeComponent();
            continuar.Visible = false;
            verificar.Visible = false;
            con++;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;

            string miVariable = hoy.ToString("dd/MM/yyyy");
            try
            {
                if (fini.Value.ToString() == ffin.Value.ToString())
                {
                    MessageBox.Show("Seleccione una Fecha!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (habinew.Text == "" & adultos.Value == 0 & niños.Value == 0)
                {
                    MessageBox.Show("Ingrese Huéspedes y Habitaciones!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Convert.ToDateTime(fini.Value.ToShortDateString()) < Convert.ToDateTime(miVariable) || Convert.ToDateTime(ffin.Value.ToShortDateString()) < Convert.ToDateTime(miVariable))
                {
                    MessageBox.Show("Ingrese una Fecha actual o posterior!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    continuar.Visible = true;
                    verificar.Visible = true;
                    habita = Convert.ToInt32(habinew.Text);
                }
            }
            catch (Exception error)
            {

            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("No desea un Hotel ?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return;
            }
            else
            {
                Close();
                if (con > 0)
                {
                    MessageBox.Show("Presione el botón Buscar o Actualizar para actualizar la información!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            if (hoteles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Hotel!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                totalh = Convert.ToInt32(adultos.Value + niños.Value);
                hotelid = Convert.ToInt32(hoteles.CurrentRow.Cells[0].Value);
                fechaini = fini.Value.ToShortDateString();
                fechafin = ffin.Value.ToShortDateString();
                lugarpais = hoteles.CurrentRow.Cells[3].Value.ToString();
                u.actualizarData();
                DialogResult = DialogResult.OK;
                Close();
                if (con > 0)
                {
                    MessageBox.Show("Presione el botón Buscar o Actualizar para actualizar la información!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void hoteles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string foto = bd.MostrarDatos("SELECT foto FROM hotel WHERE id = '" + hoteles.CurrentRow.Cells[0].Value + "'");
                Bitmap foto2 = new Bitmap(foto);
                pictureBox2.Image = (Image)foto2;

                if (Convert.ToInt32(hoteles.CurrentRow.Cells[2].Value) < Convert.ToInt32(habinew.Text))
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

        private void adultos_ValueChanged(object sender, EventArgs e)
        {
            double adul = Convert.ToDouble(adultos.Value);
            double nin = Convert.ToDouble(niños.Value);

            double total = adul + nin;

            double resultado = total / 4;
            if (Math.Ceiling(resultado) >= 0)
            {
                habinew.Text = Math.Ceiling(resultado).ToString();
            }
        }

        private void niños_ValueChanged(object sender, EventArgs e)
        {
            double adul = Convert.ToDouble(adultos.Value);
            double nin = Convert.ToDouble(niños.Value);

            double total = adul + nin;

            double resultado = total / 4;
            if (Math.Ceiling(resultado) >= 0)
            {
                habinew.Text = Math.Ceiling(resultado).ToString();
            }
        }

        private void A_Hotel_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            time2.Text = DateTime.Now.ToShortDateString();
        }
    }
}
