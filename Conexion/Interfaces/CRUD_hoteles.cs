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

namespace Interfaces
{
    public partial class CRUD_hoteles : UserControl
    {
        Procedimientos_Hoteles ph = new Procedimientos_Hoteles();
        ConexionBD bd = new ConexionBD();
        string dir;
        string dir2;
        public CRUD_hoteles()
        {
            InitializeComponent();
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

        private void id_KeyPress(object sender, KeyPressEventArgs e)
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

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo Letras! ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                return;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (id.Text == "")
                {
                    errorProvider1.SetError(id, "Llene el campo ID!");
                }
                else if (nombre.Text == "")
                {
                    errorProvider1.SetError(nombre, "Llene el campo de Nombre!");
                }
                else if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Ingrese una imagen!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int idlugar = Convert.ToInt32(bd.MostrarDatos("SELECT id FROM lugar WHERE nombre = '" + lugar.SelectedItem.ToString() + "'"));
                    Herencia_Hoteles hh = new Herencia_Hoteles();
                    hh.Id = Convert.ToInt32(id.Text);
                    hh.Nombre = nombre.Text;
                    hh.Foto = dir;
                    hh.Habitaciones = Convert.ToInt32(habitaciones.Value.ToString());
                    ph.insertarHotel(hh.Id, hh.Nombre, hh.Foto, hh.Habitaciones, idlugar);
                    bd.InsertarDatos("INSERT INTO calificacion VALUES('" + hh.Id + "', '" + 0 + "')");
                    errorProvider1.Clear();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error! " + error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            id.Text = "";
            nombre.Text = "";
            pictureBox1.Image = null;
            lugar.SelectedIndex = 0;
            habitaciones.Value = 0;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            mostrarinfo.Rows.Clear();
            ph.mostrarInfo(mostrarinfo);
            eliminarinfo.Rows.Clear();
            ph.mostrarInfo(eliminarinfo);
            modificarinfo.Rows.Clear();
            ph.mostrarInfo(modificarinfo);
            newlugar.Items.Clear();
            ph.llenarCombo(newlugar, "SELECT nombre FROM lugar");
        }

        private void mostrarinfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (mostrarinfo.Columns[2].HeaderText == "Foto")
            {
                if (e.Value != null)
                {
                    try
                    {
                        e.Value = Image.FromFile(e.Value.ToString()).GetThumbnailImage(185, 120, delegate { return true; }, IntPtr.Zero);
                    }
                    catch (Exception error)
                    {}
                }
            }
        }

        private void eliminarinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ph.eliminarInfo(eliminarinfo);
        }

        private void eliminarinfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (eliminarinfo.Columns[2].HeaderText == "Foto")
            {
                if (e.Value != null)
                {
                    try
                    {
                        e.Value = Image.FromFile(e.Value.ToString()).GetThumbnailImage(185, 120, delegate { return true; }, IntPtr.Zero);
                    }
                    catch (Exception error)
                    { }
                }
            }
        }

        private void modificarinfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (eliminarinfo.Columns[2].HeaderText == "Foto")
            {
                if (e.Value != null)
                {
                    try
                    {
                        e.Value = Image.FromFile(e.Value.ToString()).GetThumbnailImage(136, 120, delegate { return true; }, IntPtr.Zero);
                    }
                    catch (Exception error)
                    { }
                }
            }
        }

        private void modificarinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea Modificar el Hotel " + modificarinfo.CurrentRow.Cells[1].Value.ToString(), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    newid.Text = modificarinfo.CurrentRow.Cells[0].Value.ToString();
                    newnombre.Text = modificarinfo.CurrentRow.Cells[1].Value.ToString();
                    newhabitaciones.Value =Convert.ToDecimal(modificarinfo.CurrentRow.Cells[3].Value.ToString());
                    string nombre = bd.MostrarDatos("SELECT nombre FROM lugar WHERE id = '" + modificarinfo.CurrentRow.Cells[4].Value.ToString() + "'");
                    newlugar.Text = nombre;
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

        private void newimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Archivos de Imagenes(*.jpg)(*,jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            op.InitialDirectory = "C://";

            if (op.ShowDialog() == DialogResult.OK)
            {
                dir2 = op.FileName;
                Bitmap foto = new Bitmap(dir2);

                newimage.Image = (Image)foto;
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                if (newimage.Image == null)
                {
                    int idlugar = Convert.ToInt32(bd.MostrarDatos("SELECT id FROM lugar WHERE nombre = '" + newlugar.SelectedItem.ToString() + "'"));
                    Herencia_Hoteles hh = new Herencia_Hoteles();
                    hh.Id = Convert.ToInt32(newid.Text);
                    hh.Nombre = newnombre.Text;
                    hh.Foto = dir2;
                    hh.Habitaciones = Convert.ToInt32(newhabitaciones.Value.ToString());
                    ph.modificarHotelSinImage(hh.Id, hh.Nombre, hh.Foto, hh.Habitaciones, idlugar);
                }
                else
                {
                    int idlugar = Convert.ToInt32(bd.MostrarDatos("SELECT id FROM lugar WHERE nombre = '" + newlugar.SelectedItem.ToString() + "'"));
                    Herencia_Hoteles hh = new Herencia_Hoteles();
                    hh.Id = Convert.ToInt32(newid.Text);
                    hh.Nombre = newnombre.Text;
                    hh.Foto = dir2;
                    hh.Habitaciones = Convert.ToInt32(newhabitaciones.Value.ToString());
                    ph.modificarHotelConImage(hh.Id, hh.Nombre, hh.Foto, hh.Habitaciones, idlugar);
                }
                modificarinfo.Rows.Clear();
                ph.mostrarInfo(modificarinfo);
            }
            catch (Exception error)
            {
                string ee = error.Message;
            }
            newid.Text = "";
            newnombre.Text = "";
            newhabitaciones.Value = 0;
            newlugar.SelectedIndex = -1;
            newimage.Image = null;
        }

        private void newnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo Letras! ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                return;
            }
        }
    }
}
