using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimpleCS
{
    internal class Nodo
    {
		private int data;
		private Nodo? next;

		public int Dato
		{
			get { return data; }
			set { data = value; }

		}

        public Nodo? Siguiente
        {
            get { return next; }
            set { next = value; }
        }

        public Nodo()
		{
			data = 0;
			next = null;
		}

        public Nodo(int d)
        {
            this.data = d;
            next = null;
        }

        public Nodo(int d, Nodo? s)
		{
			this.data = d;
			this.next = s;
		}

        public override string ToString()
        {
            return data.ToString();
        }
    }
}