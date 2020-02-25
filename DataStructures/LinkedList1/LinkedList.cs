using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    /// <summary>
    /// A linked list collection capable of basic operation such as
    /// Add,Remove, Find and Enumerate
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T>: ICollection<T>
    {
        /// <summary>
        /// The first node in the list or null if empty
        /// </summary>
        public LinkedListNode<T> Head { get; private set; }
        
        /// <summary>
        /// The las node in the list or null if empty
        /// </summary>
        public LinkedListNode<T> Tail { get; private set; }
        public int Count { get; private set; }

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void AddFirst(LinkedListNode<T> node)
        {
            // Save off the head node so we don't loose it
            LinkedListNode<T> temp = Head;

            //point head to the new node
            Head = node;

            // Insert the rest of the list behind the head
            Head.Next = temp;

            Count++;

            if (Count == 1)
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

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

       
        public void RemoveFirst()
        {
            if(Count != 0)
            {
                Head = Head.Next;
                Count--;

                if(Count == 0)
                {
                    Tail = null;
                }
            }
        }
        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    LinkedListNode<T> current = Head;

                    while (current.Next != Tail)
                    {
                        current = current.Next;
                    }

                    current.Next = null;
                    Tail = current;
                }

                Count--;
            }

        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            LinkedListNode<T> current = Head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

    }
}


