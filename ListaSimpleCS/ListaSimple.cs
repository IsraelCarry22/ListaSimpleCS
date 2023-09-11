using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimpleCS
{
	internal class ListaSimple
	{
		private Nodo? head;

		public Nodo? Head
		{
			get { return head; }
			set { head = value; }
		}

		public ListaSimple()
		{
			head = null;
		}

		public void Add(Nodo NewNode)
		{
			head = NewNode;
		}
	}
}