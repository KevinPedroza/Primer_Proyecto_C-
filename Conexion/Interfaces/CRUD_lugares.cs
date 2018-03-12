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

namespace Interfaces
{
    public partial class CRUD_lugares : UserControl
    {
        string consulta = "SELECT id,nombre FROM lugar ORDER BY nombre ASC;";
        Procedimientos.Procedimientos_Pais_Lugar p = new Procedimientos.Procedimientos_Pais_Lugar();
        ConexionBD bd = new ConexionBD();
        public CRUD_lugares()
        {
            InitializeComponent();
            p.cargaGridIlugar(dataGridView1, consulta);
            p.cargaGridIlugar(dataGridView2, consulta);
            p.cargaGridIlugar(dataGridView3, consulta);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (id_lugar.SelectedItem.ToString() == "" || nombre_lugar.Text == "")
            {
                MessageBox.Show("Llene todos los campos requeridos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (bd.MostrarDatos("SELECT nombre FROM lugar WHERE nombre = '" + nombre_lugar.Text + "'") == nombre_lugar.Text)
            {
                MessageBox.Show("Ese lugar ya Existe!","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                p.insertarLugar(Convert.ToInt32(id_lugar.SelectedItem.ToString()), nombre_lugar.Text);
                id_lugar.Items.Clear();
                id_lugar.Text = "";
                p.llenarCombo(id_lugar, "SELECT h.id FROM pais as h where h.id not in (select e.id from lugar as e)");
                id_lugar.SelectedIndex = -1;
                nombre_lugar.Text = "";
                pais.Clear();
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            p.cargaGridIlugar(dataGridView1, consulta);
            p.cargaGridIlugar(dataGridView2, consulta);
            p.cargaGridIlugar(dataGridView3, consulta);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea Modificar la Información de " + dataGridView1.CurrentRow.Cells[0].Value.ToString(), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    newid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    newnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                }
                else
                {
                    return;
                }
            }
            catch (Exception error)
            {
                string erro = error.Message;

            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            p.modificarLugar(Convert.ToInt32(newid.Text), newnombre.Text);
            p.cargaGridIlugar(dataGridView1, consulta);
            newid.Text = "";
            newnombre.Text = "";

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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea Eliminar la Información de " + dataGridView2.CurrentRow.Cells[1].Value.ToString(), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    bd.EliminarDatos("DELETE FROM lugar WHERE id = '" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'");
                    MessageBox.Show("Se ha eliminado Correctamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    p.cargaGridIlugar(dataGridView2, consulta);
                }
                else
                {
                    return;
                }
            }
            catch (Exception error)
            {
                string erro = error.Message;

            }

        }

        private void id_lugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo Números!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                return;
            }
        }

        private void nombre_lugar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void id_lugar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pais.Text = bd.MostrarDatos("SELECT nombre FROM pais WHERE id = '" + id_lugar.SelectedItem.ToString() + "'");
        }
    }
}
