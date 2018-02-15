using System;
using System.Collections.Generic;
using System.Drawing;
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
        

        //this method will chek if i have already an administrator on the database
        public string obtenerTipo()
        {
            string tipo = null;
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

        //this method will let me insert data to my database
        public void insertarPais(int id, string nombre, string dire)
        {
            try
            {
                string consulta = "INSERT INTO pais VALUES('" + id + "','" + nombre + "', '" + dire + "')";
                bd.InsertarDatos(consulta);
                MessageBox.Show("Se ha registrado Exitosamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        //this method will modify the tables that the custimer wants
        public void modificarPais(int id, string nombre, string dire)
        {
            try
            {
                string consulta = "UPDATE pais SET nombre ='" + nombre + "', bandera ='" + dire + "' WHERE id = '" + id + "'";
                bd.ModificarDatos(consulta);
                MessageBox.Show("Se ha modificado Exitosamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        //this method will charge the datagrid and clear everything there.
        public void cargaGridI(DataGridView data)
        {
            try
            {
                data.DataSource = bd.cargarDatagrid().Tables[0];
                data.Columns[0].HeaderCell.Value = "Identificador";
                data.Columns[1].HeaderCell.Value = "Nombre País";
                data.Refresh();
                data.ClearSelection();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        //this method will charge the datagrid and clear everything of a place.
        public void cargaGridIlugar(DataGridView data,string consulta)
        {
            
            try
            {
                data.DataSource = bd.cargarDatagridlugar(consulta).Tables[0];
                data.Columns[0].HeaderCell.Value = "Identificador";
                data.Columns[1].HeaderCell.Value = "Nombre Lugar";
                data.Refresh();
                data.ClearSelection();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //this method will insert a place to the database
        public void insertarLugar(int id, string nombre)
        {
            try
            {
                string consulta = "INSERT INTO lugar VALUES('" + id + "','" + nombre + "')";
                bd.InsertarDatos(consulta);
                MessageBox.Show("Se ha registrado Exitosamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //this method will modify the tables that the custimer wants on determinated table
        public void modificarLugar(int id, string nombre)
        {
            try
            {
                string consulta = "UPDATE lugar SET nombre ='" + nombre + "' WHERE id = '" + id + "'";
                bd.ModificarDatos(consulta);
                MessageBox.Show("Se ha modificado Exitosamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
