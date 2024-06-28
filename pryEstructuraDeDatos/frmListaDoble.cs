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

namespace pryEstructuraDeDatos
{
    public partial class frmListaDoble : Form
    {
        clsListaDoble objListaDoble = new clsListaDoble();
        public frmListaDoble()
        {
            InitializeComponent();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Nodo = new clsNodo();
            Nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            Nodo.Nombre = txtNombre.Text;
            Nodo.tramite = txtTramite.Text;
            objListaDoble.agregar(Nodo);
            objListaDoble.RecorrerDes(dgtListaDoble);
            objListaDoble.RecorrerDes(lstListaDoble);
            objListaDoble.RecorrerDes(lstEliminar);
            objListaDoble.RecorrerDes();

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objListaDoble.Primero != null)
            {
                Int32 x = Convert.ToInt32(lstEliminar.Text);
                objListaDoble.Eliminar(x);
                objListaDoble.RecorrerAs(dgtListaDoble);
                objListaDoble.RecorrerAs(lstEliminar);
                objListaDoble.RecorrerAs(lstListaDoble);
                objListaDoble.RecorrerAs();
                lstEliminar.Text = "";
            }
            else
            {
                MessageBox.Show("La lista esta vacia");
                btnEliminar.Enabled = false;
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAscendente.Checked)
            {
                objListaDoble.RecorrerAs(lstEliminar);
                objListaDoble.RecorrerAs(dgtListaDoble);
                objListaDoble.RecorrerAs(lstListaDoble);
                objListaDoble.RecorrerAs();
            }
            else
            {
                objListaDoble.RecorrerDes(lstEliminar);
                objListaDoble.RecorrerDes(dgtListaDoble);
                objListaDoble.RecorrerDes(lstListaDoble);
                objListaDoble.RecorrerDes();
            }
        }
    }
}
