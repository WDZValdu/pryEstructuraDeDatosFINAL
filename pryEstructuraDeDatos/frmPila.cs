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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        private void frmPila_Load(object sender, EventArgs e)
        {

        }
        clsPila objPila = new clsPila();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nodo = new clsNodo();
            nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nodo.Nombre = txtNombre.Text;
            nodo.tramite = txtTramite.Text;
            objPila.Agregar(nodo);
            objPila.Recorrer(dgtPila);
            objPila.Recorrer(lstPila);
            objPila.Recorrer();

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objPila.Primero != null) 
            {
                lblCodigoEliminado.Text = objPila.Primero.Codigo.ToString();
                lblNombreEliminado.Text = objPila.Primero.Nombre;
                lblTramiteEliminado.Text = objPila.Primero.tramite;
                objPila.Eliminar();
                objPila.Recorrer(dgtPila);
                objPila.Recorrer(lstPila);
                objPila.Recorrer();
            }
            else 
            {
                lblCodigoEliminado.Text = "";
                lblNombreEliminado.Text = "";
                lblTramiteEliminado.Text = "";
            }
        }
    }
}
