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
    public partial class Login : Form
    {
        int contador = 0;
        Procedimientos.Procedimientos p = new Procedimientos.Procedimientos(); 
        public Login()
        {
            contador = contador+1;
            InitializeComponent();
        }
        //this method will close the frame

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void password_Enter(object sender, EventArgs e)
        {
            if (contador == 1)
            {
                password.Text = null;
                contador++;
            }
            if (contador > 1)
            {
                password.Text = password.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro lo = new Registro();
            lo.Show();
        }
        //this method will let you get to the program
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                p.login(Usuario.Text, password.Text);
                
            }
            catch (Exception error)
            {
                MessageBox.Show("Contraseña o Usuario Incorrectos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Usuario.Text = "";
        }
    }
}
