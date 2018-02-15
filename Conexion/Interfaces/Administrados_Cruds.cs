﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class Administrados_Cruds : Form
    {
        public Administrados_Cruds()
        {
            InitializeComponent();
            cruD_paise1.Hide();
            cruD_lugares1.Hide();
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button2.Height;
            slide_panel.Top = button2.Top;
            cruD_lugares1.Show();
            cruD_paise1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button3.Height;
            slide_panel.Top = button3.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button4.Height;
            slide_panel.Top = button4.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button5.Height;
            slide_panel.Top = button5.Top;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button6.Height;
            slide_panel.Top = button6.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button7.Height;
            slide_panel.Top = button7.Top;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            slide_panel.Visible = true;
            slide_panel.Height = button8.Height;
            slide_panel.Top = button8.Top;
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
