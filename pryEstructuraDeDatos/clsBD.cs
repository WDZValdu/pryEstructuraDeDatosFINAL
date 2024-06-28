using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    public class clsBD
    {
        OleDbConnection conn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private string varCadenaConexion1 = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=Libreria.mdb";
        private string varCadenaConexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";

        public void Listar (DataGridView dgvConsulta)
        {
            try
            {
                conn.ConnectionString = varCadenaConexion1;
                conn.Open();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.TableDirect;
                cmd.CommandText = "Libro";

                adaptador = new OleDbDataAdapter(cmd);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, "Libro");

                dgvConsulta.DataSource = null;
                dgvConsulta.DataSource = DS.Tables["Libro"];

                
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Listar(DataGridView dgvConsulta,String consultaSQL)
        {
            try
            {
                conn.ConnectionString = varCadenaConexion1;
                conn.Open();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consultaSQL;

                adaptador = new OleDbDataAdapter(cmd);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, "Libro");

                dgvConsulta.DataSource = null;
                dgvConsulta.DataSource = DS.Tables["Libro"];


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
