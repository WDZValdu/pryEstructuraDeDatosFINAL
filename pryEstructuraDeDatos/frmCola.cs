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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
        clsCola cola = new clsCola();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Nodo = new clsNodo();
            Nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            Nodo.Nombre = txtNombre.Text;
            Nodo.tramite = txtTramite.Text;
            cola.Agregar(Nodo);
            cola.Recorrer(dgtCola);
            cola.Recorrer(lstCola);
            cola.Recorrer();

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cola.Primero !=null)
            {
                lblCodigoEliminado.Text = cola.Primero.Codigo.ToString();
                lblNombreEliminado.Text = cola.Primero.Nombre;
                lblTramiteEliminado.Text = cola.Primero.tramite;
                cola.Eliminar();
                cola.Recorrer(dgtCola);
                cola.Recorrer(lstCola);
                cola.Recorrer();
                
                
            }
        }
    }
}
