using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Procedimientos;

namespace Interfaces
{
    public partial class CRUD_Aeropuertos : UserControl
    {
        Procedimientos_Aeropertos pr = new Procedimientos_Aeropertos();
        int contfila = 0;
        Conexion.ConexionBD bd = new Conexion.ConexionBD();

        //this method will charge the information on the table
        public void MostrarDatossincombo()
        {
            bd.Conexion();
            Conexion.ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM aeropuerto", Conexion.ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    dataGridView2.Rows.Add(reader.GetInt32(0), reader.GetString(1), null, reader.GetString(2));
                }

            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                Conexion.ConexionBD.conexion.Close();
            }
            dataGridView2.Refresh();
            dataGridView2.ClearSelection();
        }
        public CRUD_Aeropuertos()
        {
            InitializeComponent();
            pr.MostrarDatosCombo(localidad_aero);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            contfila = dataGridView1.Rows.Count - 1;
            string va = null;
            DataGridViewComboBoxCell combo = null;
            try
            {

                combo = dataGridView1.CurrentRow.Cells[2] as DataGridViewComboBoxCell;
                va = Convert.ToString(combo.Value);
                if (dataGridView1.CurrentRow.Cells[0].Value == null || dataGridView1.CurrentRow.Cells[1].Value == null || dataGridView1.CurrentRow.Cells[3].Value == null || va == null)
                {
                    return;
                }
                else
                {
                    string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    string iata = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    bd.InsertarDatos("INSERT INTO aeropuerto VALUES('" + id + "','" + nombre + "','" + iata + "','" + va + "')");
                    contfila++;
                    MessageBox.Show("Se ha registrado correctamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                string err = error.Message;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            localidad_aero.Items.Clear();
            pr.MostrarDatosCombo(localidad_aero);
            try
            {

                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    if (dataGridView1.CurrentRow.Cells[i].Value == null)
                    {

                        dataGridView1.CurrentRow.Cells[i].ReadOnly = false;
                    }
                    else
                    {
                        dataGridView1.CurrentRow.Cells[i].ReadOnly = true;

                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            pr.MostrarDatosconcombo(dataGridView3);
            dataGridView4.Rows.Clear();
            pr.MostrarDatosconcombo(dataGridView4);
            dataGridView5.Rows.Clear();
            pr.MostrarDatosconcombo(dataGridView5);
            dataGridView2.Rows.Clear();
            MostrarDatossincombo();
            localidad_modi.Items.Clear();
            pr.MostrarDatosCombo(localidad_modi);
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea Eliminar la Información de " + dataGridView3.CurrentRow.Cells[1].Value.ToString(), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    bd.EliminarDatos("DELETE FROM aeropuerto WHERE id = '" + dataGridView3.CurrentRow.Cells[0].Value.ToString() + "'");
                    MessageBox.Show("Se ha eliminado Correctamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView3.Rows.Clear();
                    pr.MostrarDatosconcombo(dataGridView3);
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

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string va = null;
            DataGridViewComboBoxCell combo = null;
            try
            {

                combo = dataGridView2.CurrentRow.Cells[2] as DataGridViewComboBoxCell;
                va = Convert.ToString(combo.Value);
                string id = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                string nombre = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                string iata = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                bd.ModificarDatos("UPDATE aeropuerto SET nombre = '" + nombre + "', iata = '" + iata + "', localidad = '" + va + "' WHERE id = '" + id + "'");
                MessageBox.Show("Se ha Modificado correctamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView5.Rows.Clear();
                pr.MostrarDatosconcombo(dataGridView5);
                dataGridView2.Rows.Clear();
                MostrarDatossincombo();
            }
            catch (Exception error)
            {
                string err = error.Message;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.CurrentRow.Cells[0].ReadOnly = true;
        }
    }
}
