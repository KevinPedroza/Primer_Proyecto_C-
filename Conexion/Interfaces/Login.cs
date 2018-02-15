using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
namespace Interfaces
{
    public partial class Login : Form
    {
        ConexionBD bd = new ConexionBD();
        int contador = 0;
        Procedimientos.Procedimientos p = new Procedimientos.Procedimientos(); 
        public Login()
        {
            contador = contador+1;
            InitializeComponent();
        }

        //this method will let me check if i can sing up to the program

        public void login(string user, string contra)
        {
            string consulta = "SELECT nombre FROM user_admin WHERE nombre = '" + user + "' AND  contra = MD5('" + contra + "')";
            string consulta3 = "SELECT admi FROM user_admin WHERE contra = MD5('" + contra + "') AND nombre = '" + user + "'";
            string bduser = bd.MostrarDatos(consulta);
            string bdtipo = bd.MostrarDatos(consulta3);

            if (user.Equals(bduser) & bdtipo.Equals("T"))
            {
                MessageBox.Show("Bienvenido Administrador!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Administrados_Cruds ad = new Administrados_Cruds();
                ad.Show();

            }
            else if (bduser.Equals(user) & bdtipo.Equals("F"))
            {
                MessageBox.Show("Bienvenido Usuario!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Contraseña o Usuario Incorrectos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
                login(Usuario.Text, password.Text);
                
            }
            catch (Exception error)
            {
                string erro = error.Message;
               MessageBox.Show("Contraseña o Usuario Incorrectos! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Usuario.Text = "";
        }
    }
}
