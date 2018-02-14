using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;

namespace Procedimientos
{
    public class Procedimientos
    {
        ConexionBD bd = new ConexionBD();
        //this method will let me check if i can sing up to the program

        public void login(string user, string contra)
        {
            string consulta = "SELECT nombre FROM user_admin WHERE nombre = '" + user + "' AND  contra = MD5('" + contra + "')";
            string consulta3 = "SELECT admi FROM user_admin WHERE contra = MD5('" + contra + "') AND nombre = '" + user + "'";
            string bduser = bd.MostrarDatos(consulta);
            string bdtipo = bd.MostrarDatos(consulta3);

            if (user.Equals(bduser) &  bdtipo.Equals("T"))
            {
                MessageBox.Show("Bienvenido Administrador!","Welcome",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
        //this method will chek if i have already an administrator on the database
        public string obtenerTipo()
        {
            string tipo = null;
            string consulta = "";
            tipo = bd.MostrarDatos("SELECT admi FROM user_admin WHERE admi = 'T'");
            return tipo;
        }
        //this method will charge the combobox
        public bool cargarChech()
        {
            bool verificar = false;
            if (obtenerTipo() != "T" || obtenerTipo() == null)
            {
                verificar = false;
            }
            else
            {
                verificar = true;
            }
            return verificar;
        }
        //this method will insert an user to the database
        public void insertarUser(string cedula,string nombre,string contra,string concontra,string tipo)
        {
            bool coinciden = false;          
            try
            {
                if (contra.Equals(concontra))
                {
                    coinciden = true;
                }
                if (coinciden == true)
                {
                    string consulta = "INSERT INTO user_admin VALUES('" + cedula + "','" + nombre + "', MD5('" + contra + "'), '" + tipo + "')";
                    bd.InsertarDatos(consulta);
                    MessageBox.Show("Se ha registrado Exitosamente!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden!","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido un Error! "+error.Message );
            }
        }
    }
}
