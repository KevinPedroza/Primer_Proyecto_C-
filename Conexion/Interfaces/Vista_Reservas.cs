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
    public partial class Vista_Reservas : Form
    {
        Procedimientos_Usuario pu = new Procedimientos_Usuario();
        bool hidden;
        bool hidden2;
        int panelcarwith;
        public Vista_Reservas()
        {
            InitializeComponent();
            panelcar.Visible = false;
            panelhotel.Visible = false;
            nombreuser.Text = pu.nom_user(Login.contra);
            hidden = true;
            hidden2 = true;
            panelcarwith = info.Width + 37;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuario u = new Usuario();
            u.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            panelcar.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
            panelhotel.Visible = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (hidden)
            {
                panelcar.Width = panelcar.Width + 10;
                if (panelcar.Width >= panelcarwith)
                {
                    timer1.Stop();
                    hidden = false;
                    this.Refresh();
                }

            }
            else
            {
                panelcar.Width = panelcar.Width - 10;
                if (panelcar.Width <= 0)
                {
                    timer1.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (hidden2)
            {
                panelhotel.Width = panelhotel.Width + 10;
                if (panelhotel.Width >= panelcarwith)
                {
                    timer2.Stop();
                    hidden2 = false;
                    this.Refresh();
                }

            }
            else
            {
                panelhotel.Width = panelhotel.Width - 10;
                if (panelhotel.Width <= 0)
                {
                    timer2.Stop();
                    hidden2 = true;
                    this.Refresh();
                }
            }
        }
    }
}

