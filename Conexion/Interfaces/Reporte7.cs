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
namespace Interfaces
{
    public partial class Reporte7 : Form
    {
        Procedimientos_Reportes pr = new Procedimientos_Reportes();
        public Reporte7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Reportes mr = new Menu_Reportes();
            mr.Show();
        }

        private void Reporte6_Load(object sender, EventArgs e)
        {
            try
            {
                ArrayList canti = new ArrayList();
                canti = pr.cantidadPaises();
                ArrayList nombres = new ArrayList();
                nombres = pr.nombrePaises();
                if (canti.Count == 0)
                {
                    MessageBox.Show("No se ha encontran paises con Escalas!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    chart1.Palette = ChartColorPalette.Pastel;
                    chart1.Titles.Add("Cantidad de Paises que han realizado Escalas");

                    for (int i = 0; i < canti.Count; i++)
                    {
                        Series serie = chart1.Series.Add(nombres[i].ToString());

                        serie.Label = canti[i].ToString();

                        serie.Points.Add(Convert.ToDouble(canti[i]));
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("No se ha encontran Resultados entre esas Fechas!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
