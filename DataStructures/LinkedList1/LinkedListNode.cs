 namespace LinkedList
{
    /// <summary>
    /// A node in the LinkedList
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkedListNode<T>
    {
        /// <summary>
        /// Constructs a new node with the specifid value.
        /// </summary>
        /// <param name="value"></param>
        public LinkedListNode(T value)
        {
            Value = value;
        }

        /// <summary>
        /// The node value
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// the next node in the linked list ( null if last node)
        /// </summary>
        public LinkedListNode<T> Next { get; set; }
        public LinkedListNode<T> Head { get; private set; }
        public int Count { get; private set; }
        public LinkedListNode<T> Tail { get; private set; }

        
        public void AddFirst(LinkedListNode<T> node)
        {
            // Save off the head node so we don't loose it
            LinkedListNode<T> temp = Head;

            //point head to the new node
            Head = node;

            // Insert the rest of the list behind the head
            Head.Next = temp;

            Count++;

            if(Count == 1)
            {
                //if the list was empty then Head and Tail should
                // both point to the new node.
                Tail = Head;
            }
        }
        public void AddLast(LinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }

            Tail = node;
            Count++;
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if(Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    LinkedListNode<T> current = Head;
                    while(current.Next != Tail)
                    {
                        current = current.Next;
                    }

                    current.Next = null;
                    Tail = current;
                }

                Count--;
            }
        }
    }

    
}
  