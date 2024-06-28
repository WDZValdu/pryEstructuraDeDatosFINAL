using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEstructuraDeDatos
{
    internal class clsCola
    {
        // AGUANTE BOCA

        //Campos de la clase
        private clsNodo pri;
        private clsNodo ult;

        //Propiedades
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        //Metodos

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.siguiente = Nuevo;
                Ultimo = Nuevo;
            }
        }

        public void Eliminar()
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.siguiente;               
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo,aux.Nombre,aux.tramite);
         
                aux = aux.siguiente; //Rompe la estructura
            }
        }

        public void Recorrer(ComboBox combo)
        {
            clsNodo aux = Primero;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add(aux.Nombre);

                aux = aux.siguiente; //Rompe la estructura
            }
        }

        public void Recorrer(ListBox list)
        {
            clsNodo aux = Primero;
            list.Items.Clear();
            while (aux != null)
            {
                list.Items.Add(aux.Codigo);

                aux = aux.siguiente; //Rompe la estructura
            }
        }

        public void Recorrer()
        {
            clsNodo aux = Primero;
            StreamWriter Ad = new StreamWriter("Cola.csv", false, Encoding.UTF8);
            Ad.WriteLine("Lista de espera \n");
            Ad.WriteLine("Codigo;Nombre;Tramite");

            while (aux != null)
            {
                Ad.Write(aux.Codigo);
                Ad.Write(";");
                Ad.Write(aux.Nombre);
                Ad.Write(";");
                Ad.WriteLine(aux.tramite);
                

                aux = aux.siguiente; //Rompe la estructura
            }
            Ad.Close();
            Ad.Dispose();
        }
    }
}
