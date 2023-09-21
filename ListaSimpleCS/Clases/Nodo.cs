using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimpleCS
{
    class Nodo
    {
		//private int dato;
        //private string name;
		//private Nodo? siguiente;
        //Id es unico y no es nullo
		public int Id
		{
            get; //{ return dato; }
            set; //{ dato = value; }
		}

        public string Name
        {
            get; //{ return name; }
            set; //{ name = value; }
        }

        public Nodo? Siguiente
        {
            get; //{ return siguiente; }
            set; //{ siguiente = value; }
        }

        public Nodo()
		{
			Id = 0;
            Name = "";
            Siguiente = null;
		}

        public Nodo(int d)
        {
            Id = d;
            Name = "";
            Siguiente = null;
        }

        public Nodo(int d,string n, Nodo? s)
		{
			Id = d;
            Name = n;
			Siguiente = s;
		}

        public override string ToString()
        {
            return Id.ToString() + " " + Name;
        }
    }
}