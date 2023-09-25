using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimpleCS
{
    class Nodo
    {
        /// <summary>
        /// Id es unico y no es nullo
        /// </summary>
        public int Id
		{
            get;
            set;
		}

        /// <summary>
        /// Nombre dentro del nodo
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Puntero del nodo
        /// </summary>
        public Nodo? Next
        {
            get;
            set;
        }

        public Nodo()
		{
			Id = 0;
            Name = "";
            Next = null;
		}

        public Nodo(int d)
        {
            Id = d;
            Name = "";
            Next = null;
        }

        public Nodo(int d,string n, Nodo? s)
		{
			Id = d;
            Name = n;
			Next = s;
		}

        public override string ToString()
        {
            return Id.ToString() + " " + Name;
        }
    }
}