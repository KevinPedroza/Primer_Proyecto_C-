using System;
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
    public partial class Menu_Reportes : Form
    {
        bool hidden;
        bool hidden2;
        bool hidden3;
        bool hidden4;
        bool hidden5;
        bool hidden6;
        bool hidden7;

        int panel1;
        int panel2;
        int panel3;
        int panel4;
        int panel5;
        int panel6;
        int panel7;
        public Menu_Reportes()
        {
            InitializeComponent();
            hidden = true;
            hidden2 = true;
            hidden3 = true;

            hidden4 = true;
            hidden5 = true;
            hidden6 = true;

            hidden7 = true;

            panel1 = 110;
            panel2 = 110;
            panel3 = 110;

            panel4 = 117;
            panel5 = 117;
            panel6 = 117;

            panel7 = 80;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrados_Cruds ad = new Administrados_Cruds();
            ad.Show();
        }

        private void uno_MouseEnter(object sender, EventArgs e)
        {
            timer1.Start();
            r1.Visible = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (hidden)
            {
                r1.Width = r1.Width + 10;
                if (r1.Width >= panel1)
                {
                    timer1.Stop();
                    hidden = false;
                    this.Refresh();
                }

            }
            else
            {
                r1.Width = r1.Width - 10;
                if (r1.Width <= 4)
                {
                    timer1.Stop();
                    r1.Visible = false;
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (hidden2)
            {
                r2.Width = r2.Width + 10;
                if (r2.Width >= panel2)
                {
                    timer2.Stop();
                    hidden2 = false;
                    this.Refresh();
                }

            }
            else
            {
                r2.Width = r2.Width - 10;
                if (r2.Width <= 4)
                {
                    timer2.Stop();
                    r2.Visible = false;
                    hidden2 = true;
                    this.Refresh();
                }
            }
        }

        private void dos_MouseEnter(object sender, EventArgs e)
        {
            timer2.Start();
            r2.Visible = true;
        }

        private void tres_MouseEnter(object sender, EventArgs e)
        {
            timer3.Start();
            r3.Visible = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (hidden3)
            {
                r3.Width = r3.Width + 10;
                if (r3.Width >= panel3)
                {
                    timer3.Stop();
                    hidden3 = false;
                    this.Refresh();
                }

            }
            else
            {
                r3.Width = r3.Width - 10;
                if (r3.Width <= 4)
                {
                    timer3.Stop();
                    r3.Visible = false;
                    hidden3 = true;
                    this.Refresh();
                }
            }
        }

        private void cuatro_MouseEnter(object sender, EventArgs e)
        {
            timer4.Start();
            r4.Visible = true;
        }

        private void cinco_MouseEnter(object sender, EventArgs e)
        {
            timer5.Start();
            r5.Visible = true;
        }

        private void seis_MouseEnter(object sender, EventArgs e)
        {
            timer6.Start();
            r6.Visible = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (hidden4)
            {
                r4.Width = r4.Width + 9;
                if (r4.Width >= panel4)
                {
                    timer4.Stop();
                    hidden4 = false;
                    this.Refresh();
                }

            }
            else
            {
                r4.Width = r4.Width - 9;
                if (r4.Width <= 10)
                {
                    timer4.Stop();
                    r4.Visible = false;
                    hidden4 = true;
                    this.Refresh();
                }
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (hidden5)
            {
                r5.Width = r5.Width + 9;
                if (r5.Width >= panel5)
                {
                    timer5.Stop();
                    hidden5 = false;
                    this.Refresh();
                }

            }
            else
            {
                r5.Width = r5.Width - 9;
                if (r5.Width <= 10)
                {
                    timer5.Stop();
                    r5.Visible = false;
                    hidden5 = true;
                    this.Refresh();
                }
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (hidden6)
            {
                r6.Width = r6.Width + 9;
                if (r6.Width >= panel6)
                {
                    timer6.Stop();
                    hidden6 = false;
                    this.Refresh();
                }

            }
            else
            {
                r6.Width = r6.Width - 9;
                if (r6.Width <= 10)
                {
                    timer6.Stop();
                    r6.Visible = false;
                    hidden6 = true;
                    this.Refresh();
                }
            }
        }

        private void siete_MouseEnter(object sender, EventArgs e)
        {
            timer7.Start();
            r7.Visible = true;
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (hidden7)
            {
                r7.Width = r7.Width + 10;
                if (r7.Width >= 110)
                {
                    timer7.Stop();
                    hidden7 = false;
                    this.Refresh();
                }

            }
            else
            {
                r7.Width = r7.Width - 9;
                if (r7.Width <= 10)
                {
                    timer7.Stop();
                    r7.Visible = false;
                    hidden7 = true;
                    this.Refresh();
                }
            }
        }

        private void r1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reporte1 r = new Reporte1();
            r.Show();
        }

        private void r2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reporte2 r = new Reporte2();
            r.Show();
        }

        private void r3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reporte3 r = new Reporte3();
            r.Show();
        }

        private void r4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reporte4 mr = new Reporte4();
            mr.Show();
        }
    }
}

