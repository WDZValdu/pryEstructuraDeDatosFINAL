using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    class clsArbolBinario
    {
        private clsNodo PrimerNodo;

        //Creo la unica propiedad que necesito
        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }

        }

        public void Agregar(clsNodo Nuevo)
        {
            Nuevo.Izquierdo = null;
            Nuevo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo Aux = Raiz;
                clsNodo NodoPadre = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (Nuevo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }
                if (Nuevo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nuevo;
                }
                else
                {
                    NodoPadre.Derecho = Nuevo;
                }
            }
        }

        //Recorrido Grilla
        public void RecorrerAsc(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            inOrderAsc(Grilla,Raiz);
        }
        public void RecorrerDes(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            inOrderDes(Grilla, Raiz);
        }
        //Recorrido Lista
        public void RecorrerAsc(ComboBox cmb)
        {
            cmb.Items.Clear();
            inOrderAsc(cmb, Raiz);
        }

        public void RecorrerDes(ComboBox cmb)
        {
            cmb.Items.Clear();
            inOrderDes(cmb, Raiz);
        }

        //Recorrer TreeView
        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();
        }
        //Ascendente Grilla
        private void inOrderAsc(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) inOrderAsc(dgv, R.Izquierdo);
            dgv.Rows.Add(R.Codigo, R.Nombre, R.tramite);
            if (R.Derecho != null) inOrderAsc(dgv, R.Derecho);
        }

        //Descendente Grilla
        private void inOrderDes(DataGridView dgv, clsNodo R)
        {
            if (R.Derecho != null) inOrderDes(dgv, R.Derecho);
            dgv.Rows.Add(R.Codigo, R.Nombre, R.tramite);
            if (R.Izquierdo != null) inOrderDes(dgv, R.Izquierdo);
        }

        //Ascendente ComboBox
        private void inOrderAsc(ComboBox cmb, clsNodo R)
        {
            if(R.Izquierdo != null)
            {
                inOrderAsc(cmb, R.Izquierdo);
            }
            cmb.Items.Add(R.Codigo);
            if (R.Derecho !=null)
            {
                inOrderAsc(cmb, R.Derecho);
            }
        }

        //Descendente ComboBox
        private void inOrderDes(ComboBox cmb, clsNodo R)
        {
            if (R.Derecho != null)
            {
                inOrderDes(cmb, R.Derecho);
            }
            cmb.Items.Add(R.Codigo);
            if (R.Izquierdo !=null)
            {
                inOrderDes(cmb, R.Izquierdo);
            }
        }

        private void PreOrden(clsNodo R, TreeNode NodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            NodoTreeView.Nodes.Add(NodoPadre);
            if(R.Izquierdo != null)
            {
                PreOrden(R.Izquierdo, NodoPadre);
            }
            if (R.Derecho != null)
            {
                PreOrden(R.Derecho, NodoPadre);
            }
        }
        //PreOrden ComboBox
        public void rPreOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            PreOrden(Combo, Raiz);
        }
        private void PreOrden(ComboBox Lst, clsNodo R)
        {
            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo!= null)
            {
                PreOrden(Lst, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PreOrden(Lst, R.Derecho);
            }
        }
        //Preorden Grilla
        public void rPreOrden(DataGridView grilla)
        {
           grilla.Rows.Clear();
           PreOrden(grilla, Raiz);
        }

        private void PreOrden(DataGridView grilla,clsNodo R)
        {
            grilla.Rows.Add(R.Codigo,R.Nombre,R.tramite);
            if (R.Izquierdo!= null)
            {
                PreOrden(grilla, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PreOrden(grilla, R.Derecho);
            }
        }

        //PostOrden ComboBox
        public void rPostOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            PostOrden(Combo, Raiz);
        }
        
        private void PostOrden(ComboBox Lst, clsNodo R)
        {
            
            if (R.Izquierdo != null)
            {
                PostOrden(Lst, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PostOrden(Lst, R.Derecho);
            }
            Lst.Items.Add(R.Codigo);
        }
        
        //PostOrden grilla

        public void rPostOrden(DataGridView grilla)
        {
            grilla.Rows.Clear ();
            PostOrden(grilla, Raiz);
        }

        public void PostOrden(DataGridView grilla, clsNodo R)
        {
            
            if (R.Izquierdo!= null)
            {
                PostOrden(grilla, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PostOrden(grilla, R.Derecho);
            }
            grilla.Rows.Add(R.Codigo, R.Nombre, R.tramite);
        }

        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;
       
        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }

        private void GrabarVectorInOrden(clsNodo NodoPadre, Int32 Codigo)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo, Codigo);
            }
            if (NodoPadre.Codigo != Codigo)
            {
                Vector[i] = NodoPadre;
                i = i + 1;
            }
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho, Codigo);
            }
        }

        private void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo);
            }

            Vector[i] = NodoPadre;
            i = i + 1;

            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);
            }
        }

        public void Eliminar(Int32 codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz,codigo);
            Raiz = null;
            EquilibrarArbol(0, i-1);
        }

    }
}
