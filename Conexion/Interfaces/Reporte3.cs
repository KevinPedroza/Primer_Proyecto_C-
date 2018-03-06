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
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;

namespace Interfaces
{
    public partial class Reporte3 : Form
    {
        Procedimientos_Reportes pr = new Procedimientos_Reportes();
        public Reporte3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Reportes mr = new Menu_Reportes();
            mr.Show();
        }

        private void Reporte3_Load(object sender, EventArgs e)
        {
            ArrayList cantidad = new ArrayList();
            cantidad = pr.cantidadVisitas();
            ArrayList paises = new ArrayList();
            paises = pr.paisVisitas();


            if (paises.Count <= 0)
            {
                MessageBox.Show("No se encuentran paises en este momento!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                chart1.Palette = ChartColorPalette.Pastel;
                chart1.Titles.Add("Porcentaje de Visitas por País");

                for (int i = 0; i < paises.Count; i++)
                {
                    Series serie = chart1.Series.Add(paises[i].ToString());

                    serie.Label = cantidad[i].ToString();

                    serie.Points.Add(Convert.ToDouble(cantidad[i]));
                }
            }
        }
    }
}
