using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    internal class clsListaSimple
    {
        private clsNodo pri;

        //propiedades de la clase
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        //Metodos de la clase
        public void Agregar (clsNodo Nuevo)
        {
            if(Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo <= Primero.Codigo)
                {
                    Nuevo.siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    clsNodo aux = pri;
                    clsNodo ant = pri;
                    
                    while (aux != null && Nuevo.Codigo > aux.Codigo) { ant = aux; aux = aux.siguiente; }

                    ant.siguiente = Nuevo;
                    Nuevo.siguiente = aux;
                }
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.siguiente;
            }
            else
            {
                clsNodo ant = Primero;
                clsNodo aux = Primero;
                while (aux.Codigo != Codigo) { ant = aux; aux = aux.siguiente; }
                ant.siguiente = aux.siguiente;
            }
        }

        public void Recorrer(ComboBox combo)
        {
            clsNodo aux = Primero;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add(aux.Codigo);
                aux = aux.siguiente;
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.tramite);

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
            StreamWriter Ad = new StreamWriter("ListaSimple.csv", false, Encoding.UTF8);
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
    }
}
