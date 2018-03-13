using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
//this form will let the user to administrate de CRUD of countries
namespace Interfaces
{
    public partial class CRUD_paise : UserControl
    {
        string dir;
        string dir2;
        string dir3;
        Procedimientos.Procedimientos_Pais_Lugar p = new Procedimientos.Procedimientos_Pais_Lugar();
        ConexionBD bd = new ConexionBD();

        public CRUD_paise()
        {
            InitializeComponent();
            p.cargaGridI(dataGridView1);
            p.cargaGridI(dataGridView2);
            p.cargaGridI(dataGridView3);
            p.cargaGridI(dataGridView4);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Archivos de Imagenes(*.jpg)(*,jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            op.InitialDirectory = "C://";

            if (op.ShowDialog() == DialogResult.OK)
            {
                dir = op.FileName;
                Bitmap foto = new Bitmap(dir);

                pictureBox1.Image = (Image)foto;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo Números! ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo Números! ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                return;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (dir == null)
            {
                MessageBox.Show("Ingrese una Imagen!","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (id_pais.Text == "")
            {
                MessageBox.Show("Ingrese un Nombre!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nombre_pais.Text == "")
            {
                MessageBox.Show("Ingrese una Identificador!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (bd.MostrarDatos("SELECT nombre FROM pais WHERE id = '" + id_pais.Text + "'") == nombre_pais.Text)
            {
                MessageBox.Show("Ese nombre de País ya Existe!","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else if (bd.MostrarDatos("SELECT id FROM pais WHERE id = '" + id_pais.Text + "'") == id_pais.Text)
            {
                MessageBox.Show("Ese identificador de País ya Existe!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                p.insertarPais(Convert.ToInt32(id_pais.Text),nombre_pais.Text,dir);
                p.cargaGridI(dataGridView1);
            }
            id_pais.Text = "";
            nombre_pais.Text = "";
            pictureBox1.Image = null;
            
        }

        private void bunifuCustomTextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dir2 = bd.MostrarDatos("SELECT bandera FROM pais WHERE id = '" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'");
                Bitmap foto = new Bitmap(dir2);
                photo.Image = (Image)foto;

                if (MessageBox.Show("Desea Modificar la Información de " + dataGridView2.CurrentRow.Cells[0].Value.ToString(), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                { 
                    newide.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    newnombre.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                }
                else
                {
                    return;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (dir3 == null)
            {
                p.modificarPais(Convert.ToInt32(newide.Text),newnombre.Text,dir2);
                p.cargaGridI(dataGridView2);
            }
            else
            {
                p.modificarPais(Convert.ToInt32(newide.Text), newnombre.Text, dir3);
                p.cargaGridI(dataGridView2);
            }
            newide.Text = "";
            newimagen.Image = null;
            newnombre.Text = "";
        }

        private void newimagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Archivos de Imagenes(*.jpg)(*,jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            op.InitialDirectory = "C://";

            if (op.ShowDialog() == DialogResult.OK)
            {
                dir3 = op.FileName;
                Bitmap foto = new Bitmap(dir3);

                newimagen.Image = (Image)foto;
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            p.cargaGridI(dataGridView2);
            p.cargaGridI(dataGridView3);
            p.cargaGridI(dataGridView4);
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string consulta = "DELETE FROM pais WHERE id = '" + dataGridView3.CurrentRow.Cells[0].Value.ToString()+ "' ";
                if (MessageBox.Show("Desea Eliminar la Información de " + dataGridView3.CurrentRow.Cells[1].Value.ToString(), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int idruta = Convert.ToInt32(bd.MostrarDatos("SELECT id from ruta WHERE pais_origen = '" + dataGridView3.CurrentRow.Cells[1].Value.ToString() + "' OR pais_destino = '" + dataGridView3.CurrentRow.Cells[1].Value.ToString() + "'"));
                    bd.EliminarDatos("DELETE FROM tarifa_vuelo WHERE ruta = '" + idruta + "'");
                    bd.EliminarDatos("DELETE FROM ruta WHERE pais_origen = '" + dataGridView3.CurrentRow.Cells[1].Value.ToString() + "' OR pais_destino = '" + dataGridView3.CurrentRow.Cells[1].Value.ToString() + "' ");
                    bd.EliminarDatos(consulta);
                    p.cargaGridI(dataGridView3);
                }
                else
                {
                    return;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string consulta = bd.MostrarDatos("SELECT bandera FROM pais WHERE id = '" + dataGridView4.CurrentRow.Cells[0].Value.ToString() + "'");
            Bitmap foto = new Bitmap(consulta);
            pictureBox2.Image = (Image)foto;
        }

        private void newnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo letras!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                return;
            }
        }
    }
}
