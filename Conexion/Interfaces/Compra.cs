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
//this form will let the user to know that already bought a fly or a car o a hotel
namespace Interfaces
{
    public partial class Compra : Form
    {
        bool hidden;
        int panelcarwith;
        Procedimientos_Usuario pu = new Procedimientos_Usuario();
        public Compra()
        {
            InitializeComponent();

            hidden = true;
            panelcarwith = 32;
            califica.Visible = false;
            cali.Visible = false;

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Vista_Reservas.hotel != null)
            {
                if (califica.Value == 0)
                {
                    MessageBox.Show("Ingrese una Calificación del Hotel", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    pu.calificarHotelWithNAME(Vista_Reservas.hotel, califica.Value.ToString());
                    MessageBox.Show("Se ha calificado Exitosamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    A_Hotel.hotelid = 0;
                    A_Carro.idcarro = 0;
                    this.Hide();
                    Usuario u = new Usuario();
                    u.Show();
                }
            }
            else if (Vista_Reservas.hotel3 != 0)
            {
                if (califica.Value == 0)
                {
                    MessageBox.Show("Ingrese una Calificación del Hotel", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    pu.calificarHotelWithID(Vista_Reservas.hotel3, califica.Value.ToString());
                    MessageBox.Show("Se ha calificado Exitosamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    A_Hotel.hotelid = 0;
                    A_Carro.idcarro = 0;
                    this.Hide();
                    Usuario u = new Usuario();
                    u.Show();
                }
            }
            else
            {
                A_Hotel.hotelid = 0;
                A_Carro.idcarro = 0;
                this.Hide();
                Usuario u = new Usuario();
                u.Show();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                verify.Height = verify.Height + 11;
                if (verify.Height >= panelcarwith + 9)
                {
                    timer1.Stop();
                    hidden = false;
                    this.Refresh();
                }

            }

        }

        private void Compra_Load(object sender, EventArgs e)
        {
            verify.Visible = true;
            timer1.Start();
            if (Vista_Reservas.hotel != null || Vista_Reservas.hotel3 != 0)
            {
                califica.Visible = true;
                cali.Visible = true;
            }
        }
    }
}
