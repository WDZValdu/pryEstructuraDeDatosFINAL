using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEstructuraDeDatos
{
    internal class clsNodo
    {
        //campos del nodo
        private Int32 cod;
        private string nom;
        private String tra;
        private clsNodo sig;
        private clsNodo ant;

        public Int32 Codigo
        {
            get { return cod; }
            set { cod = value; }
        }

        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public String tramite
        {
            get { return tra; }
            set { tra = value; }
        }

        public clsNodo siguiente
        {
            get { return sig; }
            set { sig = value; }
        }

        public clsNodo Anterior
        {
            get { return ant; }
            set { ant = value; }
        }

        public clsNodo Derecho
        {
            get { return sig; }
            set { sig = value; }
        }

        public clsNodo Izquierdo
        {
            get { return ant; }
            set { ant = value; }
        }
    }
}
