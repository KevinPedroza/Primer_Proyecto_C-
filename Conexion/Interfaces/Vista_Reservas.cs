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
using Conexion;
namespace Interfaces
{
    public partial class Vista_Reservas : Form
    {
        Procedimientos_Usuario pu = new Procedimientos_Usuario();
        ConexionBD bd = new ConexionBD();
        A_Hotel hh = new A_Hotel();
        bool hidden;
        bool hidden2;
        int panelcarwith;

        public static string fechaini;
        public static string paiso;
        public static string paisd;
        public static string fechafin;
        public static string paiss;
        public static string paisll;
        public static string hotel;
        public static int hotel3;
        public static int preciore;
        public Vista_Reservas()
        {
            InitializeComponent();
            panelcar.Visible = false;
            panelhotel.Visible = false;
            eliminar.Visible = false;
            nombreuser.Text = pu.nom_user(Login.contra);
            hidden = true;
            hidden2 = true;
            panelcarwith = info.Width + 36;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Usuario.contador = 0;
            this.Hide();
            Usuario u = new Usuario();
            u.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            panelcar.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
            panelhotel.Visible = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (hidden)
            {
                panelcar.Width = panelcar.Width + 9;
                if (panelcar.Width >= panelcarwith)
                {
                    timer1.Stop();
                    hidden = false;
                    this.Refresh();
                }

            }
            else
            {
                panelcar.Width = panelcar.Width - 9;
                if (panelcar.Width <= 0)
                {
                    timer1.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (hidden2)
            {
                panelhotel.Width = panelhotel.Width + 9;
                if (panelhotel.Width >= panelcarwith)
                {
                    timer2.Stop();
                    hidden2 = false;
                    this.Refresh();
                }

            }
            else
            {
                panelhotel.Width = panelhotel.Width - 9;
                if (panelhotel.Width <= 0)
                {
                    timer2.Stop();
                    hidden2 = true;
                    this.Refresh();
                }
            }
        }

        private void Vista_Reservas_Load(object sender, EventArgs e)
        {
            try
            {
                string nomhotel = bd.MostrarDatos("SELECT nombre FROM hotel WHERE id = '" + A_Hotel.hotelid + "'");
                string nomvehiculo = bd.MostrarDatos("SELECT modelo FROM vehiculo WHERE id = '" + A_Carro.idcarro + "'");

                string preciohotel = bd.MostrarDatos("SELECT precio FROM tarifa_hotel as ho join hotel as tv on tv.id = ho.id WHERE tv.id = '" + A_Hotel.hotelid + "'");
                string preciovehi = bd.MostrarDatos(" SELECT precio FROM vehiculo WHERE id = '" + A_Carro.idcarro + "'");

                TimeSpan fechahotel2 = hh.ffin.Value - hh.fini.Value;
                int diasvuelo2 = fechahotel2.Days;

                int precioh2 = Convert.ToInt32(preciohotel + A_Hotel.totalh) * diasvuelo2;
                int preciovu2 = Convert.ToInt32(Usuario.precio2);
                int preciove2 = Convert.ToInt32(preciovehi);

                if (preciohotel == null)
                {
                    precioh2 = 0;
                }
                else if (preciovehi == null)
                {
                    preciove2 = 0;
                }
                else if (preciovu2 == 0)
                {
                    preciovu2 = 0;
                }

                int porcentaje2 = ((precioh2 + preciovu2 + preciove2) * 13) / 100;

                string consulta = bd.MostrarDatos("SELECT foto FROM hotel WHERE id = '" + A_Hotel.hotelid + "'");
                if (consulta == null)
                {
                    pictureBox2.Image = null;
                }
                else
                {
                    Bitmap foto = new Bitmap(consulta);
                    pictureBox2.Image = (Image)foto;
                }

                if (Usuario.contador >= 1)
                {
                    int cedula = Convert.ToInt32(pu.cedula(Login.contra));
                    info.Rows.Clear();
                    info.Columns.Clear();
                    pu.cargaGridReserva(info, "SELECT id_cedula,fechaini,paiso,paisd,fechafini,paiss,paislle,escadi,hotel,vehi,reserva,precio FROM reserva");
                    info.ClearSelection();
                    eliminar.Visible = true;
                }
                else if (nomhotel == null)
                {
                    info.Rows.Clear();
                    pu.mostrarInfoGeneral(info, Usuario.fechaini, Usuario.fechafin, Usuario.paiso, Usuario.paisd, Usuario.escala
                    , null, nomvehiculo, (precioh2 + preciovu2 + preciove2 + porcentaje2));
                }
                else if (nomvehiculo == null)
                {
                    info.Rows.Clear();
                    pu.mostrarInfoGeneral(info, Usuario.fechaini, Usuario.fechafin, Usuario.paiso, Usuario.paisd, Usuario.escala
                    , nomhotel, null, (precioh2 + preciovu2 + preciove2 + porcentaje2));
                }
                else
                {
                    info.Rows.Clear();
                    pu.mostrarInfoGeneral(info, Usuario.fechaini, Usuario.fechafin, Usuario.paiso, Usuario.paisd, Usuario.escala
                    , nomhotel, nomvehiculo, (precioh2 + preciovu2 + preciove2 + porcentaje2));
                }

                pu.mostrarCarro(carinfo, A_Carro.idcarro.ToString());
                pu.mostrarHotel(hotelinfo, A_Hotel.hotelid);
                hotelinfo.ClearSelection();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (info.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una Reservación!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (Usuario.contador >= 1)
            {
                MessageBox.Show("Ya esta Reservado!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fechaini = info.CurrentRow.Cells[0].Value.ToString();
                paiso = info.CurrentRow.Cells[1].Value.ToString();
                paisd = info.CurrentRow.Cells[2].Value.ToString();
                fechafin = info.CurrentRow.Cells[3].Value.ToString();
                paiss = info.CurrentRow.Cells[4].Value.ToString();
                paisll = info.CurrentRow.Cells[5].Value.ToString();
                preciore = Convert.ToInt32(info.CurrentRow.Cells[9].Value.ToString());
                this.Hide();
                Reserva r = new Reserva();
                r.Show();
            }
        }

        private void info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Usuario.contador >= 1)
                {

                    int precio2 = Convert.ToInt32(bd.MostrarDatos("SELECT precio FROM reserva WHERE id_cedula = '" + info.CurrentRow.Cells[0].Value.ToString() + "' AND precio = '" + info.CurrentRow.Cells[11].Value.ToString() + "'"));
                    precio.Text = "Precio Total: $" + precio2;
                }
                else
                {
                    precio.Text = "Precio Total: $" + info.CurrentRow.Cells[9].Value.ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            if (info.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una Reservación!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (MessageBox.Show("Desea Comprar este Vuelo?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                if (Usuario.contador < 1)
                {
                    int cedula = Convert.ToInt32(pu.cedula(Login.contra));
                    int vehi = Convert.ToInt32(bd.MostrarDatos(" SELECT id FROM vehiculo WHERE id = '" + A_Carro.idcarro + "'"));
                    int hotel2 = Convert.ToInt32(bd.MostrarDatos("SELECT id FROM hotel WHERE id = '" + A_Hotel.hotelid + "'"));
                    int paisv = Convert.ToInt32(bd.MostrarDatos("SELECT id FROM pais WHERE nombre = '" + Usuario.paisd + "'"));

                    pu.realizarCompra(cedula, vehi, hotel2, paisv, Usuario.escala, Usuario.adulto,Usuario.niño,A_Hotel.totalh, info.CurrentRow.Cells[0].Value.ToString(), info.CurrentRow.Cells[3].Value.ToString());


                    if (hotel2 != 0)
                    {
                        pu.restarHabitaciones(hotel2, A_Hotel.habita);
                    }

                    if (vehi != 0)
                    {
                        pu.restarCarro(vehi);
                    }
                    hotel = bd.MostrarDatos("SElECT nombre FROM hotel WHERE id = '" + A_Hotel.hotelid + "'");
                    this.Hide();
                    Compra c = new Compra();
                    c.Show();
                }
                else
                {
                    int cedula = Convert.ToInt32(info.CurrentRow.Cells[0].Value.ToString());
                    int vehi;
                    int hotel2;
                    if (info.CurrentRow.Cells[9].Value.ToString() == null)
                    {
                        vehi = 0;
                    }
                    else
                    {
                        vehi = Convert.ToInt32(bd.MostrarDatos("SELECT v.id FROM vehiculo as v join reserva as r on r.vehi = v.modelo WHERE v.modelo = '" + info.CurrentRow.Cells[9].Value.ToString() + "'"));
                    }

                    if (info.CurrentRow.Cells[8].Value.ToString() == null)
                    {
                        hotel2 = 0;
                        hotel3 = 0;
                    }
                    else
                    {
                        hotel2 = Convert.ToInt32(bd.MostrarDatos("SELECT h.id FROM hotel as h join reserva as r on r.hotel = h.nombre WHERE h.nombre = '" + info.CurrentRow.Cells[8].Value.ToString() + "'"));
                        hotel3 = Convert.ToInt32(bd.MostrarDatos("SElECT id FROM hotel WHERE nombre = '" + info.CurrentRow.Cells[8].Value.ToString() + "'"));
                    }

                    int paisv = Convert.ToInt32(bd.MostrarDatos("SELECT p.id FROM pais as p join reserva as r on r.paisd = p.nombre WHERE p.nombre = '" + info.CurrentRow.Cells[3].Value.ToString() + "'"));
                    string escala = info.CurrentRow.Cells[7].Value.ToString();
                    int adulto = Convert.ToInt32(bd.MostrarDatos("SELECT adulto FROM reserva WHERE reserva = '" + info.CurrentRow.Cells[10].Value.ToString() + "'"));
                    int nino = Convert.ToInt32(bd.MostrarDatos("SELECT nino FROM reserva WHERE reserva = '" + info.CurrentRow.Cells[10].Value.ToString() + "'"));
                    int habi = Convert.ToInt32(bd.MostrarDatos("SELECT hospedado FROM reserva WHERE reserva = '" + info.CurrentRow.Cells[10].Value.ToString() + "'"));

                    pu.realizarCompra(cedula, vehi, hotel2, paisv, escala,adulto,nino,habi, info.CurrentRow.Cells[1].Value.ToString(), info.CurrentRow.Cells[4].Value.ToString());

                    bd.EliminarDatos("DELETE FROM reserva WHERE reserva = '" + info.CurrentRow.Cells[10].Value.ToString() + "'");
                    info.Columns.Clear();
                    pu.cargaGridReserva(info, "SELECT * FROM reserva");
                    info.ClearSelection();

                    this.Hide();
                    Compra c = new Compra();
                    c.Show();
                }


            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (info.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una Reserva Para Eliminar!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Desea Eliminar la Reservación Número: " + info.CurrentRow.Cells[10].Value.ToString() + " ?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int vehi = Convert.ToInt32(bd.MostrarDatos("SELECT v.id FROM vehiculo as v join reserva as r on r.vehi = v.modelo WHERE v.modelo = '" + info.CurrentRow.Cells[9].Value.ToString() + "'"));
                    int hotel = Convert.ToInt32(bd.MostrarDatos("SELECT h.id FROM hotel as h join reserva as r on r.hotel = h.nombre WHERE h.nombre = '" + info.CurrentRow.Cells[8].Value.ToString() + "'"));
                    int habitaciones = Convert.ToInt32(bd.MostrarDatos("SELECT r.habitacion FROM reserva as r join hotel as h on h.nombre = r.hotel WHERE r.hotel = '" + info.CurrentRow.Cells[8].Value.ToString() + "'"));

                    if (hotel != 0)
                    {
                        pu.sumarHabitaciones(hotel, habitaciones);
                    }

                    if (vehi != 0)
                    {
                        pu.sumarCarro(vehi);
                    }

                    bd.EliminarDatos("DELETE FROM reserva WHERE reserva = '" + info.CurrentRow.Cells[10].Value.ToString() + "'");
                    info.Columns.Clear();
                    pu.cargaGridReserva(info, "SELECT * FROM reserva");
                    info.ClearSelection();
                }
                else
                {
                    return;
                }
            }

        }
    }
}

