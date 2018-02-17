﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
namespace Procedimientos
{
    public class Procedimientos_THoteles
    {
        ConexionBD bd = new ConexionBD();
        //this method will insert the information to the database
        public void insertarTarifa(int id, int precio)
        {
            try
            {
                bd.InsertarDatos("INSERT INTO tarifa_hotel VALUES ('" + id + "', '" + precio + "')");
                MessageBox.Show("Se ha insertado la tarifa Correctamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error insertando la tarifa ! " + error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //this method will charge the information on any datagridview
        public void mostarInfo(DataGridView data)
        {
            data.DataSource = bd.cargarDatagridlugar("SELECT * FROM tarifa_hotel").Tables[0];
            data.Columns[0].HeaderCell.Value = "Identificador";
            data.Columns[1].HeaderCell.Value = "Precio de Tarifa";
        }

        //this method will delete de information from the database 
        public void eliminarInfo(DataGridView eliminartarifa)
        {
            try
            {
                if (MessageBox.Show("Desea Eliminar la tarifa código " + eliminartarifa.CurrentRow.Cells[1].Value.ToString(), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    bd.EliminarDatos("DELETE FROM tarifa_hotel WHERE id = '" + eliminartarifa.CurrentRow.Cells[0].Value.ToString() + "'");
                    MessageBox.Show("Se ha eliminado Correctamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mostarInfo(eliminartarifa);
                    eliminartarifa.ClearSelection();
                }
                else
                {
                    return;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error! "+error.Message,"Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
