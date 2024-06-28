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
    public partial class frmRepasoDeOperaciones : Form
    {
        public frmRepasoDeOperaciones()
        {
            InitializeComponent();
        }
        clsBD objBD = new clsBD();
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * FROM LIBRO";

            switch (cmbOperacion.SelectedIndex)
            {
                case 0://Diferencia
                    lblEjemplo.Text = cmbOperacion.Text + ": Paises que no tienen libros";
                    varSQL = "SELECT * from pais where idpais not in (Select idpais from libro)";
                break;
                case 1://DIFERENCIA 2
                    lblEjemplo.Text = cmbOperacion.Text + ": " + "Elimina los libros mayores a 7";

                    varSQL =
                        "select * from libro where idlibro " +
                        "not in " +
                        "(select distinct idlibro from libro where idlibro > 7) ";
                    break;
                case 2://ORDEN 1 
                    lblEjemplo.Text = cmbOperacion.Text + ": " + "Ordena los libros de mayor a menor segun el precio";

                    varSQL = "select idlibro, titulo, idautor, precio from libro order by precio desc";
                break;
                case 3://ORDEN 2
                    lblEjemplo.Text = cmbOperacion.Text + ": "+ "Ordena los libros de menor a mayor segun su cantidad";

                    varSQL = "select idlibro, titulo, idautor, precio, cantidad from libro order by cantidad asc";
                break;
                case 4://SEL. MULTIATRIBUTO X CONVOLUCION 1
                    lblEjemplo.Text = cmbOperacion.Text + ": " + "Selecciona los libros de dos tablas virtuales(no existentes) con la condicion de que el libro sea menor a 30 y su precio sea menor a 500 ";

                    varSQL =
                        "select * from (select * from libro as T1 where T1.idlibro <30) as T2 where T2.precio < 500";
                    break;
                case 5://SEL. MULTIATRIBUTO X CONVOLUCION 2
                    lblEjemplo.Text = cmbOperacion.Text + ": " + "Selecciona los libros de dos tablas virtuales(no existentes) con la condicion de que el autor sea menor a 20 y el idioma del libro sea menor a 6 ";

                    varSQL =
                        "select * from (select * from libro as T1 where T1.idautor < 20) as T2 where T2.ididioma < 6";
                    break;
                case 6://SEL. MULTIATRIBUTO X INTERSECCION 1
                    lblEjemplo.Text = cmbOperacion.Text + ": " + "Selecciona los los libros que el precio es mayor a 500 y el pais son menores a 5 ";

                    varSQL =
                        "select idlibro, titulo, idpais, precio from libro where precio > 500 and idpais < 5";
                    break;
                case 7://SEL. MULTIATRIBUTO X INTERSECCION 2
                    lblEjemplo.Text = cmbOperacion.Text + ": " + "Selecciona los los libros que el precio es mayor a 600, el pais menor a 3 y cantidad mayor a 6 ";

                    varSQL =
                        "select * from libro where precio > 600 and idpais < 3 and cantidad > 6";
                    break;
                case 8://SELECCION SIMPLE 1
                    lblEjemplo.Text = cmbOperacion.Text + ": " + "Selecciona los libros que cuya cantidad es igual a 4";

                    varSQL =
                        "select idlibro, titulo, idautor, cantidad from libro where cantidad = 4 ";
                    break;
                case 9://SELECCION SIMPLE 2
                    lblEjemplo.Text = cmbOperacion.Text + ": " + "Selecciona los los libros que cuyo precio es igual a 700 ";

                    varSQL =
                        "select idlibro, titulo, precio from libro where precio = 700 ";
                    break;
                case 10://PROYECCION X UN ATRIBUTO 1
                    lblEjemplo.Text = cmbOperacion.Text + ": " + "Muestra los nombres de los libros";

                    varSQL =
                        "select titulo from libro";
                    break;
                case 11://PROYECCION X UN ATRIBUTO 2
                    lblEjemplo.Text = cmbOperacion.Text + ": " + "Muestra los libros registrados";

                    varSQL =
                        "select idlibro from libro";
                    break;
                case 12://PROYECCION MULTIATRIBUTO 1
                    lblEjemplo.Text = cmbOperacion.Text + ": " + "Muestra el nombre, el precio y la cantidad del libro";

                    varSQL =
                        "select titulo,precio,cantidad from libro";
                    break;
                case 13://PROYECCION MULTIATRIBUTO 2
                    lblEjemplo.Text = cmbOperacion.Text + ": " + "Muestra el cod. de indentificacion del libro, ademas de el nombre y el año en el que salió";

                    varSQL =
                        "select idlibro,titulo,año from libro";
                    break;
                case 14://JUNTAR 1                   
                    lblEjemplo.Text = cmbOperacion.Text + ": " + "Muestra el ID de cada autor de cada libro";

                    varSQL =
                        "select * from libro, autor where libro.idautor = autor.idautor";
                    break;
                case 15://JUNTAR 2
                    lblEjemplo.Text = cmbOperacion.Text + ": " + "Muestra el idioma de cada libro segun sus ID";

                    varSQL =
                        "select * from libro, idioma where libro.ididioma = idioma.ididioma";
                    break;
                case 16://INTERSECCIÓN 1
                    lblEjemplo.Text = cmbOperacion.Text + ": " + "Libros donde el idioma sea igual a 5";
                    // corregir
                    varSQL =
                        "select * from libro where ididioma " +
                        "in " +
                        "(select distinct ididioma from libro where ididioma = 5)";
                    break;
                case 17://INTERSECCION 2
                    lblEjemplo.Text = cmbOperacion.Text + ": " + "Libros donde la cantidad es mayor a 7";
                    //corregir
                    varSQL =
                        "select * from libro where cantidad " +
                        "in " +
                        "(select distinct cantidad from libro where cantidad > 7)";
                    break;
                case 18://UNION 1
                    lblEjemplo.Text = cmbOperacion.Text + ": " + "Union entre libros del pais 7 y 2";

                    varSQL =
                        "select * from Libro where idpais = 7 " +
                        "union " +
                        "select * from Libro where idpais = 2";

                    break;
                case 19://UNION 2
                    lblEjemplo.Text = cmbOperacion.Text + ": " + "Union entre libros de los los idiomas 8 y 2";

                    varSQL =
                        "select titulo, ididioma, año from Libro where ididioma = 8 " +
                        "union " +
                        "select titulo, ididioma, año from Libro where ididioma = 2";
                    break;
            }
            objBD.Listar(dgvGrilla,varSQL);
        }
    }
}
