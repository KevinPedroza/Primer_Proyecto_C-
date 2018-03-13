using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Procedimientos;
using Conexion;
//this form will let the user to administrate de CRUD of roads
namespace Interfaces
{
    public partial class CRUD_Rutas : UserControl
    {
        Procedimientos_rutas pr = new Procedimientos_rutas();
        ConexionBD bd = new ConexionBD();
        public CRUD_Rutas()
        {
            InitializeComponent();
        }

        private void id_inruta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo Números!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                return;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_inruta.Text == "")
                {
                    MessageBox.Show("Ingrese un Identificador!", "Aviso!");
                }
                else if (bd.MostrarDatos("SELECT id FROM ruta WHERE id = '" + id_inruta.Text + "'") == id_inruta.Text)
                {
                    MessageBox.Show("Ese Identificador de Ruta ya Existe!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Herencia_Rutas hr = new Herencia_Rutas();
                    hr.Id = Convert.ToInt32(id_inruta.Text);
                    hr.Origen = pais_origenin.SelectedItem.ToString();
                    hr.Destino = pais_destinoin.SelectedItem.ToString();
                    hr.Duracion = duracionin.Text;
                    pr.registrarRuta(hr.Id, hr.Origen,hr.Destino,hr.Duracion);
                    MessageBox.Show("Se ha registrado Correctamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error! " + error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            id_inruta.Text = "";
            pais_origenin.SelectedIndex = -1;
            pais_destinoin.SelectedIndex = -1;
            duracionin.SelectedIndex = 0;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            pr.mostrarInfoDataGrid(mostrar_rutas);
            pr.mostrarInfoDataGrid(eliminar_ruta);
            modify_info.ClearSelection();
            pr.mostrarInfoDataGrid(modify_info);
            neworigen.Items.Clear();
            pr.cargarCombo(neworigen);
            newdestiny.Items.Clear();
            pr.cargarCombo(newdestiny);
        }

        private void eliminar_ruta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pr.eliminarInfo(eliminar_ruta);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Herencia_Rutas hr = new Herencia_Rutas();
            hr.Id = Convert.ToInt32(id_modi.Text);
            hr.Origen = neworigen.SelectedItem.ToString();
            hr.Destino = newdestiny.SelectedItem.ToString();
            hr.Duracion = newduration.Text;
            pr.modificarRuta(hr.Id, hr.Origen, hr.Destino, hr.Duracion);
            pr.mostrarInfoDataGrid(modify_info);
            id_modi.Text = "";
            neworigen.Text = "";
            newdestiny.Text = "";
            newduration.Text = "0:00";
        }

        private void modify_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea Modificar la ruta de Origen " + modify_info.CurrentRow.Cells[1].Value.ToString() + " Con destino a " + modify_info.CurrentRow.Cells[2].Value.ToString(), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    id_modi.Text = modify_info.CurrentRow.Cells[0].Value.ToString();
                    neworigen.Text = modify_info.CurrentRow.Cells[1].Value.ToString();
                    newdestiny.Text = modify_info.CurrentRow.Cells[2].Value.ToString();
                    newduration.Text = modify_info.CurrentRow.Cells[3].Value.ToString();
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
    }
}
