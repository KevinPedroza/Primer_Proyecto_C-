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
//this method will let you see the second report
namespace Interfaces
{
    public partial class Reporte2 : Form
    {
        Procedimientos_Reportes pr = new Procedimientos_Reportes();
        public Reporte2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Reportes mr = new Menu_Reportes();
            mr.Show();
        }

        private void Reporte2_Load(object sender, EventArgs e)
        {
            ArrayList persona = new ArrayList();
            persona = pr.personas();
            ArrayList nombres = new ArrayList();
            nombres = pr.hoteles();


            if (nombres.Count <= 0)
            {
                MessageBox.Show("No se encuentran Reservaciones en este momento!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                chart1.Palette = ChartColorPalette.Pastel;
                chart1.Titles.Add("Cantidad de Personas Hospedadas por Hotel");

                for (int i = 0; i < nombres.Count; i++)
                {
                    Series serie = chart1.Series.Add(nombres[i].ToString());

                    serie.Label = persona[i].ToString();

                    serie.Points.Add(Convert.ToDouble(persona[i]));
                }
            }
        }
    }
}
