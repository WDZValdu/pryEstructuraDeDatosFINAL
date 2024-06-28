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
    public partial class frmBDConsulta : Form
    {
        public frmBDConsulta()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            clsBD objBD = new clsBD();
            //objBD.Listar(dgvMostrar);
            objBD.Listar(dgvMostrar, txtConsulta.Text);
        }
    }
}
