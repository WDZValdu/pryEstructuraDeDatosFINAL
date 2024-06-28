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
    public partial class frmArbolBinario : Form
    {
        
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario objArbol = new clsArbolBinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nodo = new clsNodo();
            nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nodo.Nombre = txtNombre.Text;
            nodo.tramite = txtTramite.Text;
            objArbol.Agregar(nodo);
            objArbol.RecorrerAsc(dgtArbolBinario);
            objArbol.Recorrer(tvArbol);
            objArbol.RecorrerAsc(lstEliminar);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text= "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objArbol.Eliminar(Convert.ToInt32(lstEliminar.SelectedItem));
            objArbol.RecorrerAsc(dgtArbolBinario);
            objArbol.Recorrer(tvArbol);
            objArbol.RecorrerAsc(lstEliminar);
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            objArbol.Equilibrar();
            objArbol.RecorrerAsc(dgtArbolBinario);
            objArbol.Recorrer(tvArbol);
            objArbol.RecorrerAsc(lstEliminar);
        }

        private void optInOrAsc_CheckedChanged(object sender, EventArgs e)
        {
            if (optInOrAsc.Checked) 
            {
                objArbol.RecorrerAsc(dgtArbolBinario);
                objArbol.RecorrerAsc(lstEliminar);
            }
        }

        private void optInOrDesc_CheckedChanged(object sender, EventArgs e)
        {
                objArbol.RecorrerDes(dgtArbolBinario);
                objArbol.RecorrerDes(lstEliminar);
        }

        private void optPreOrd_CheckedChanged(object sender, EventArgs e)
        {
            objArbol.rPreOrden(lstEliminar);
            objArbol.rPreOrden(dgtArbolBinario);
        }

        private void optPostOrd_CheckedChanged(object sender, EventArgs e)
        {
            objArbol.rPostOrden(lstEliminar);
            objArbol.rPostOrden(dgtArbolBinario);
        }
    }
}
