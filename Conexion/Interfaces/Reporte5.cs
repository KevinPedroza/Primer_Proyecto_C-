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
    public partial class Reporte5 : Form
    {
        Procedimientos_Reportes pr = new Procedimientos_Reportes();
        public Reporte5()
        {
            InitializeComponent();
        }

        private void Reporte5_Load(object sender, EventArgs e)
        {
            finicio.Format = DateTimePickerFormat.Custom;
            finicio.CustomFormat = "dd/MM/yyyy";

            ffin.Format = DateTimePickerFormat.Custom;
            ffin.CustomFormat = "dd/MM/yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Reportes mr = new Menu_Reportes();
            mr.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(finicio.Value.ToShortDateString() + "" + ffin.Value.ToShortDateString());
                ArrayList canti = new ArrayList();
                canti = pr.niños(finicio.Value.ToShortDateString(), ffin.Value.ToShortDateString());
                if (canti.Count == 0)
                {
                    MessageBox.Show("No se ha encontran Resultados entre esas Fechas!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    chart1.Palette = ChartColorPalette.Pastel;
                    chart1.Titles.Add("Cantidad de Niños que han viajado entre " + finicio.Value.ToShortDateString() + " Y " + ffin.Value.ToShortDateString());

                    for (int i = 0; i < canti.Count; i++)
                    {
                        Series serie = chart1.Series.Add("Niños");

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
