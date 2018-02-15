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
    public partial class Registro : Form
    {
        Procedimientos.Procedimientos_Pais_Lugar p = new Procedimientos.Procedimientos_Pais_Lugar();
        int contador = 0;
        int contador2 = 0;
        public Registro()
        {
            contador++;
            contador2++;
            InitializeComponent();
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if (contador == 1)
            {
                contra.Text = null;
                contador++;
            }
            if (contador > 1)
            {
                contra.Text = contra.Text;
            }
        }

        private void bunifuMaterialTextbox3_Enter(object sender, EventArgs e)
        {
            if (contador2 == 1)
            {
                concontra.Text = null;
                contador2++;
            }
            if (contador2 > 1)
            {
                concontra.Text = concontra.Text;
            }
        }
        //this method will call another frame
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lo = new Login();
            lo.Show();
        }
        //this method will click to insert an user
        private void button2_Click(object sender, EventArgs e)
        {
            string tipoadmi = null;
            if (tipo.Checked)
            {
                tipoadmi = "T";
            }
            else
            {
                tipoadmi = "F";
            }
            p.insertarUser(cedula.Text,usuario.Text,contra.Text,concontra.Text,tipoadmi);
            cedula.Text = "";
            usuario.Text = "";
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            if (p.cargarChech() == true)
            {
                tipo.Enabled = false;
            }
            else
            {
                return;
            }
        }
    }
}
