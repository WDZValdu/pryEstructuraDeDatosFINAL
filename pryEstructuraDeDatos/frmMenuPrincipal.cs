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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void estructurasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datosDeDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDeDesarrollador frmDDD = new frmDatosDeDesarrollador();
            frmDDD.Show();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola frmCola = new frmCola();
            frmCola.Show();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila frmPila = new frmPila();
            frmPila.Show();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple frmLS = new frmListaSimple();
            frmLS.Show();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble frmLD = new frmListaDoble();
            frmLD.Show();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario frmArbol = new frmArbolBinario();
            frmArbol.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void operacionesConTablasDeBasesDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmBaseDeDatos frmbd = new frmBaseDeDatos();
            frmbd.Show();
        }

        private void consultasEnLasBasesDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmBDConsulta frmBDConsulta = new frmBDConsulta();
            frmBDConsulta.Show();
        }

        private void repasoDeOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmRepasoDeOperaciones frmRep = new frmRepasoDeOperaciones();
            frmRep.Show();
        }
    }
}
