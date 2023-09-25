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
        /// Clear to list all nodes
        /// </summary>
        public void Clear()
        {
            Head = null;
        }

        /// <summary>
        /// Add new node to list
        /// </summary>
        /// <param name="NewNode">Nuevo nodo</param>
        public void Add(Nodo NewNode)
        {
            if (IsEmpty())
            {
                Head = NewNode;
                return;
            }
            if (Exist(NewNode.Id))
            {
                return;
            }
            if (NewNode.Id < Head.Id)
            {
                NewNode.Next = Head;
                Head = NewNode;
                return;
            }
            Nodo? h = Head;
            while (h.Next != null)
            {
                if (NewNode.Id < h.Next.Id)
                {
                    break;
                }
                h = h.Next;
            }
            NewNode.Next = h.Next;
            h.Next = NewNode;
        }

        /// <summary>
        /// Remove node from to list
        /// </summary>
        /// <param name="data">date in node removed</param>
        public void Remove(int data)
        {
            if (IsEmpty())
            {
                return;
            }
            if (Head != null && Head.Id == data)
            {
                Head = Head.Next;
                return;
            }
            Nodo? h = Head;
            while (h.Next != null)
            {
                if (h.Next.Id == data)
                {
                    break;
                }
                h = h.Next;
            }
            if (h.Next != null)
            {
                h.Next = h.Next.Next;
            }
        }

        /// <summary>
        /// Check if there is a node with the data entered
        /// </summary>
        /// <param name="data">date ingresed</param>
        /// <returns></returns>
        public bool Exist(int data)
        {
            if (IsEmpty())
            {
                return false;
            }
            if (Head != null && Head.Id == data)
            {
                return true;
            }
            Nodo? h = Head;
            while (h.Next != null)
            {
                if (h.Next.Id >= data)
                {
                    break;
                }
                h = h.Next;
            }
            if (h.Next != null && h.Next.Id == data)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// We check if the list is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Head == null;
        }

        /// <summary>
        /// counts how many items exist in the enlist
        /// </summary>
        /// <returns></returns>
        public int Count() 
        {
            int c = 0;
            Nodo? h = Head;
            while (h != null)
            {
                c++;
                h = h.Next;
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
                h = h.Next;
                i++;
            }
            return r;
        }
    }
}