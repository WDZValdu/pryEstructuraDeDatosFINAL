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
    public partial class frmBaseDeDatos : Form
    {
        public frmBaseDeDatos()
        {
            InitializeComponent();
        }
        clsBD objBD = new clsBD();

        private void btnPSimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO FROM LIBRO ORDER BY 1 DESC";

            objBD.Listar(dgvGrilla, varSQL);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * FROM Libro WHERE IdAutor = 2 UNION SELECT * FROM Libro WHERE IdAutor = 5 UNION SELECT * FROM Libro WHERE IdAutor = 3";

            objBD.Listar(dgvGrilla, varSQL);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * FROM Libro WHERE IdIdioma IN (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";

            objBD.Listar(dgvGrilla, varSQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * FROM Libro WHERE IdIdioma NOT IN (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";

            objBD.Listar(dgvGrilla, varSQL);
        }

        private void btnSelecSimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * FROM Libro WHERE IdAutor = 2";

            objBD.Listar(dgvGrilla, varSQL);
        }

        private void btnSelecPorConv_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * FROM (SELECT * FROM Libro as T1 WHERE T1.IdIdioma > 5) as T2 WHERE T2.IdAutor > 10";

            objBD.Listar(dgvGrilla, varSQL);
        }

        private void btnPMulti_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT IdLibro, Titulo, Año FROM Libro ";

            objBD.Listar(dgvGrilla, varSQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * FROM Libro, Idioma WHERE Libro.IdIdioma = Idioma.IdIdioma";

            objBD.Listar(dgvGrilla, varSQL);
        }

        private void btnSelecMulti_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT IdLibro, Titulo, Año FROM Libro WHERE Año > '1000'";

            objBD.Listar(dgvGrilla, varSQL);
        }
    }
}
