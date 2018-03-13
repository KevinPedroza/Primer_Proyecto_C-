using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Procedimientos;
//this method will let you see the first report
namespace Interfaces
{
    public partial class Reporte1 : Form
    {

        Procedimientos_Reportes pr = new Procedimientos_Reportes();

        public Reporte1()
        {
            InitializeComponent();
        }

        private void Reporte1_Load(object sender, EventArgs e)
        {
            ArrayList cantidad = new ArrayList();
            cantidad = pr.cantidad();
            ArrayList nombres = new ArrayList();
            nombres = pr.nombres();

            if (nombres.Count <= 0)
            {
                MessageBox.Show("No se encuentran Reservaciones en este momento!","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {

                chart1.Palette = ChartColorPalette.Pastel;
                chart1.Titles.Add("Cantidad de Hoteles Reservados");

                for (int i = 0; i < nombres.Count; i++)
                {
                    Series serie = chart1.Series.Add(nombres[i].ToString());

                    serie.Label = cantidad[i].ToString();

                    serie.Points.Add(Convert.ToDouble(cantidad[i]));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Reportes mr = new Menu_Reportes();
            mr.Show();
        }
    }
}
