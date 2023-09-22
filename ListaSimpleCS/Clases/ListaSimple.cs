namespace ListaSimpleCS.Clases
{
    class ListaSimple
    {
        /// <summary>
        /// Head controls the initial if exist else null
        /// </summary>
        /// 
        private Nodo? Head;

        /// <summary>
        /// Return the next id
        /// </summary>
        public int NextId
        {
            get { return Count() + 1; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public ListaSimple()
        {
            Clear();
        }

        /// <summary>
        /// Limpiamos la lista (todos los nodos)
        /// </summary>
        public void Clear()
        {
            Head = null;
        }
        

        /// <summary>
        /// Añade un nodo a la lista
        /// </summary>
        /// <param name="NewNode">Nuevo nodo</param>
        public void Add(Nodo NewNode)
        {
            //Cuando la lista esta "Vacia"
            if (Head == null)
            {
                Head = NewNode;
                return;
            }
            //Evitar nodos duplicados con Id suplicados

            if (Exist(NewNode.Id))
            {
                return;
            }
            //La lista no esta vacia si el dato del nodo nuevo es menor al dato de head el add es al INICIO!!!
            if (NewNode.Id < Head.Id)
            {
                NewNode.Siguiente = Head;
                Head = NewNode;
                return;
            }
            Nodo? h = Head;
            while (h.Siguiente != null)
            {
                if (NewNode.Id < h.Siguiente.Id)
                {
                    break;
                }
                h = h.Siguiente;
            }
            NewNode.Siguiente = h.Siguiente;
            h.Siguiente = NewNode;
        }

        public void Remove(int data)
        {
            if (Head == null)
            {
                return;
            }
            if (Head.Id == data)
            {
                Head = Head.Siguiente;
                return;
            }
            Nodo? h = Head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Id == data)
                {
                    break;
                }
                h = h.Siguiente;
            }
            if (h.Siguiente != null)
            {
                h.Siguiente = h.Siguiente.Siguiente;
            }
        }

        public bool Exist(int data)
        {
            if (Head == null)
            {
                return false;
            }
            if (Head.Id == data)
            {
                return true;
            }
            Nodo? h = Head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Id >= data)
                {
                    break;
                }
                h = h.Siguiente;
            }
            if (h.Siguiente != null && h.Siguiente.Id == data)
            {
                return true;
            }
            return false;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public int Count() 
        {
            int c = 0;
            Nodo? h = Head;
            while (h != null)
            {
                c++;
                h = h.Siguiente;
            }
            return c;
        }

        public string[] ToString2()
        {
            Nodo? h = Head;
            string[] r = new string[this.Count()];
            int i = 0;
            while (h != null)
            {
                r[i] += h.ToString() + " ";
                h = h.Siguiente;
                i++;
            }
            return r;
        }
    }
}