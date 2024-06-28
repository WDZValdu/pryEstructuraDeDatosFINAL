using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEstructuraDeDatos
{
    internal class clsPila
    {
        public clsNodo pri;
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            if(Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                Nuevo.siguiente = Primero;
                Primero = Nuevo;
            }
        }

        public void Eliminar()
        {
            if (Primero != null)
            {
                Primero = Primero.siguiente;
            }
        }

        public void Recorrer()
        {
            clsNodo aux = Primero;
            StreamWriter Ad = new StreamWriter("Pila.csv", false, Encoding.UTF8);
            Ad.WriteLine("Lista de espera \n");
            Ad.WriteLine("Codigo;Nombre;Tramite");

            while (aux != null)
            {

                Ad.WriteLine(aux.Codigo + ";" + aux.Nombre + ";" + aux.tramite);
                
                aux = aux.siguiente; //Rompe la estructura
            }
            Ad.Close();
            Ad.Dispose();
        }
        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.tramite);
                aux = aux.siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo Aux = Primero;
            Combo.Items.Clear();
            while (Aux != null)
            {
                Combo.Items.Add(Aux.Nombre);
                Aux = Aux.siguiente;
            }
        }
        public void Recorrer(ListBox Lista)
        {
            clsNodo Aux = Primero;
            Lista.Items.Clear();
            while (Aux != null)
            {
                Lista.Items.Add(Aux.Codigo);
                Aux = Aux.siguiente;
            }
        }
    }
}
