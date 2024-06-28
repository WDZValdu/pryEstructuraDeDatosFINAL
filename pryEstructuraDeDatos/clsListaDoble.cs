using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    internal class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult;

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

        public void agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo < Primero.Codigo)
                {
                    Nuevo.siguiente = Primero;
                    Primero.Anterior = Nuevo;
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.siguiente = Nuevo;
                        Nuevo.Anterior = Ultimo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        clsNodo sig = Primero;
                        clsNodo ant = Primero;
                        while (sig.Codigo < Nuevo.Codigo)
                        {
                            ant = sig;
                            sig = sig.siguiente;
                        }
                        ant.siguiente = Nuevo;
                        Nuevo.siguiente = sig;
                        sig.Anterior = Nuevo;
                        Nuevo.Anterior = ant;
                    }
                }
            }
        }

        public void RecorrerDes (DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();
            while (aux !=null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.tramite);
                aux = aux.Anterior;
            }
        }

        public void RecorrerAs(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.tramite);
                aux = aux.siguiente;
            }
        }

        public void RecorrerAs(ListBox lstListaDoble)
        {
            clsNodo aux = Primero;
            lstListaDoble.Items.Clear();
            while (aux != null)
            {
                lstListaDoble.Items.Add(aux.Codigo);

                aux = aux.siguiente; //Rompe la estructura
            }
        }
        public void RecorrerDes(ListBox lstListaDoble)
        {
            clsNodo aux = Ultimo;
            lstListaDoble.Items.Clear();
            while (aux != null)
            {
                lstListaDoble.Items.Add(aux.Codigo);

                aux = aux.Anterior; //Rompe la estructura
            }
        }

        public void RecorrerAs(ComboBox combo)
        {
            clsNodo aux = Primero;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add(aux.Codigo);
                aux = aux.siguiente;
            }
        }
        public void RecorrerDes(ComboBox combo)
        {
            clsNodo aux = Ultimo;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }
        }
        public void RecorrerAs()
        {
            clsNodo aux = Primero;
            StreamWriter Ad = new StreamWriter("ListaDoble.csv", false, Encoding.UTF8);
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

        public void RecorrerDes()
        {
            clsNodo aux = Ultimo;
            StreamWriter Ad = new StreamWriter("ListaDoble.csv", false, Encoding.UTF8);
            Ad.WriteLine("Lista de espera \n");
            Ad.WriteLine("Codigo;Nombre;Tramite");

            while (aux != null)
            {

                Ad.WriteLine(aux.Codigo + ";" + aux.Nombre + ";" + aux.tramite);

                aux = aux.Anterior; //Rompe la estructura
            }
            Ad.Close();
            Ad.Dispose();
        }



        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                    if (Ultimo.Codigo == Codigo)
                    {                        
                        Ultimo = Ultimo.Anterior;
                        Ultimo.siguiente = null;
                    }
                    else
                    {
                        clsNodo aux = Primero;
                        clsNodo ant = Primero;
                        while (aux.Codigo < Codigo)
                        {
                            ant = aux;
                            aux = aux.siguiente;
                        }
                        ant.siguiente = aux.siguiente;
                        aux = aux.siguiente;
                        aux.Anterior = ant;
                    }
                }
            }
        }


    }

    
}
