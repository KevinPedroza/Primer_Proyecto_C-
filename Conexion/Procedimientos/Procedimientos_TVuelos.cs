using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion; 

namespace Procedimientos
{
    public class Procedimientos_TVuelos
    {
        ConexionBD bd = new ConexionBD();
        //this method will charge the information on the datagridview
        public void llenarRutas(DataGridView data)
        {
            data.DataSource = bd.cargarDatagridlugar("SELECT id,pais_origen,pais_destino FROM ruta").Tables[0];
            data.Columns[0].HeaderCell.Value = "Identificador";
            data.Columns[1].HeaderCell.Value = "País Origen";
            data.Columns[2].HeaderCell.Value = "País Destino";
            data.ClearSelection();
        }

        //this method will insert the information into the database
        public void insertarTarifa(int id,int precio,int idruta)
        {
            try
            {
                bd.InsertarDatos("INSERT INTO tarifa_vuelo VALUES ('" + id + "', '" + precio + "','" + idruta + "')");
                MessageBox.Show("Se ha registrado la tarifa Correctamente!","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error! "+error.Message,"Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
