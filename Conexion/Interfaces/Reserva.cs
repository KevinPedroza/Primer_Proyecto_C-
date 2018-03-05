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
    public partial class Reserva : Form
    {
        Procedimientos_Usuario pu = new Procedimientos_Usuario();
        ConexionBD bd = new ConexionBD();
        Usuario u = new Usuario();
        A_Hotel hh = new A_Hotel();
        int contador;
        public Reserva()
        {
            InitializeComponent();
            nuser.Text = pu.nom_user(Login.contra);
            string nomhotel = bd.MostrarDatos("SELECT nombre FROM hotel WHERE id = '" + A_Hotel.hotelid + "'");
            string nomvehiculo = bd.MostrarDatos("SELECT modelo FROM vehiculo WHERE id = '" + A_Carro.idcarro + "'");
            nhotel.Text = nomhotel;
            nvehi.Text = nomvehiculo;
            if (Usuario.escala == "Vuelo Directo")
            {
                nvuelo.Text = "Origen: " + Usuario.paiso + " , Destino: " + Usuario.paisd + ", Vuelo Directo ";
            }
            else
            {
                nvuelo.Text = "Origen: " + Usuario.paiso + " , Destino: " + Usuario.paisd + ", Escala:  " + Usuario.escala;
            }

            precio.Text = "$" + Vista_Reservas.preciore;
        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            contador = pu.obtenerReservas();
            if (contador <= 0)
            {
                string re = Convert.ToString(contador = 1);
                nreserva.Text = "Número de Reserva: " + re;
            }
            else
            {
                string re = Convert.ToString(contador += 1);
                nreserva.Text = "Número de Reserva: " + re;
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vista_Reservas vr = new Vista_Reservas();
            vr.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            int cedula = Convert.ToInt32(pu.cedula(Login.contra));
            string vehi = bd.MostrarDatos(" SELECT modelo FROM vehiculo WHERE id = '" + A_Carro.idcarro + "'");
            string hotel = bd.MostrarDatos("SELECT nombre FROM hotel WHERE id = '" + A_Hotel.hotelid + "'");

            int vehi2 = Convert.ToInt32(bd.MostrarDatos(" SELECT id FROM vehiculo WHERE id = '" + A_Carro.idcarro + "'"));
            int hotel2 = Convert.ToInt32(bd.MostrarDatos("SELECT id FROM hotel WHERE id = '" + A_Hotel.hotelid + "'"));

            if (hotel2 != 0)
            {
                pu.restarHabitaciones(hotel2, A_Hotel.habita);
            }
            else if (vehi2 != 0)
            {
                pu.restarCarro(vehi2);
            }

            pu.insertarReservacion(cedula,Vista_Reservas.fechaini, Vista_Reservas.paiso, Vista_Reservas.paisd, Vista_Reservas.fechafin, Vista_Reservas.paiss, Vista_Reservas.paisll,Usuario.escala, hotel,vehi, contador,Vista_Reservas.preciore,Usuario.adulto,Usuario.niño,A_Hotel.totalh);

            A_Carro.idcarro = 0;
            A_Hotel.hotelid = 0;

            Usuario u = new Usuario();
            this.Hide();
            u.Show();
        }
    }
}
