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

namespace Interfaces
{
    public partial class CRUD_Aeropuertos : UserControl
    {

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

        //this method will charge the information on the table 
        public void MostrarDatosconcombo(DataGridView data)
        {
            bd.Conexion();
            Conexion.ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM aeropuerto", Conexion.ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    data.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(3), reader.GetString(2));
                }

            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                Conexion.ConexionBD.conexion.Close();
            }
            data.Refresh();
            data.ClearSelection();
        }

        //this method will charge the combobox on the datagridview
        public void MostrarDatosCombo(DataGridViewComboBoxColumn combo)
        {
            bd.Conexion();
            Conexion.ConexionBD.conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT nombre FROM lugar", Conexion.ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    combo.Items.Add(reader.GetString(0));
                }

            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                Conexion.ConexionBD.conexion.Close();
            }
        }
        public CRUD_Aeropuertos()
        {
            InitializeComponent();
            MostrarDatosCombo(localidad_aero);
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
            try
            {

                if (dataGridView1.CurrentRow.Cells[0].Value == null)
                {

                    dataGridView1.CurrentRow.Cells[0].ReadOnly = false;
                }
                else
                {
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
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
            MostrarDatosconcombo(dataGridView3);
            dataGridView4.Rows.Clear();
            MostrarDatosconcombo(dataGridView4);
            dataGridView5.Rows.Clear();
            MostrarDatosconcombo(dataGridView5);
            dataGridView2.Rows.Clear();
            MostrarDatossincombo();
            MostrarDatosCombo(localidad_modi);
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
                    MostrarDatosconcombo(dataGridView3);
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
                MostrarDatosconcombo(dataGridView5);
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
