using System;
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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple objListaSimple = new clsListaSimple();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Nodo = new clsNodo();
            Nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            Nodo.Nombre = txtNombre.Text;
            Nodo.tramite = txtTramite.Text;
            objListaSimple.Agregar(Nodo);
            objListaSimple.Recorrer(dgtListaSimple);
            objListaSimple.Recorrer(lstListaSimple);
            objListaSimple.Recorrer(lstEliminar);
            objListaSimple.Recorrer();

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objListaSimple.Primero != null)
            {
                Int32 x = Convert.ToInt32(lstEliminar.Text);
                objListaSimple.Eliminar(x);
                objListaSimple.Recorrer(dgtListaSimple);
                objListaSimple.Recorrer(lstEliminar);
                objListaSimple.Recorrer(lstListaSimple);
                objListaSimple.Recorrer();
                lstEliminar.Text= "";
            }
            else
            {
                MessageBox.Show("La lista esta vacia"); 
                
            }
           
        }
    }
}
