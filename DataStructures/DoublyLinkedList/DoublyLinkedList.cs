using System;
using System.Collections;
using System.Collections.Generic;

namespace DoublyLinkedList
{
    public class DoublyLinkedList<T>: IEnumerable<LinkedListNode<T>>,ICollection<T>
    {
        private int count;

        public DoublyLinkedListNode<T> Head { get; private set; }
        public DoublyLinkedListNode<T> Tail { get; private set; }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public bool Empty { get; private set; }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void AddFirst(DoublyLinkedListNode<T> node)
        {
           //Save off the head node so we don't lose it
            DoublyLinkedListNode<T> temp = Head;

            //point to the new node
            Head = node;

            //Insert the rest of the list behind the head
            Head.Next = temp;

            if (Empty)
            {
                // if the list was empty than Head and Tail should
                // both point to the new node.
                Tail = Head;
            }
            else
            {
                // Before Head ------------> 5 <--> 7 -> null
                // After Head ->3 <-->5<-->7->null

                // temp Previous was null, now Head
                temp.Previous = Head;
            }

            count++;

        }

        public void AddLast(DoublyLinkedListNode<T> node)
        {
            if (Empty)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;

                // Before Head -> 3 <->5 -> null
                // After Head ->3 <->5 <-> 7 -> null
                // 7.Previous = 5
                node.Previous = Tail;
            }

            Tail = node;
            count++;
        }

        public void RemoveFirst()
        {
            if (!Empty)
            {
                // Before Head -> 3 <->5
                //After Head --------->5

                //Head ->3 -> null
                //Head------->null
                Head = Head.Next;
                count--;

                if (Empty)
                {
                    Tail = null;
                }
                else{
                    //5.Previous was 3, now null
                    Head.Previous = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (!Empty)
            {
                if(count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    //Before: Head -->3 --->5 --->7
                    // Tail = 7
                    // After: Head --->3 -->5--> null
                    //        Tail = 5
                    // null out s's Next pointer

                    Tail.Previous.Next = null;
                    Tail = Tail.Previous;
                }
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<LinkedListNode<T>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            DoublyLinkedListNode<T> previous = null;
            DoublyLinkedListNode<T> current = Head;

            //1: Empty list - do nothing
            //2: SSingle node: (previous is null)
            //3: Many nodes
            // a: node to remove is the first node
            // b: node to remove is the middle or last

            while(current != null)
            {
                // Head -> 3 - >5 ->7 ->null
                // Head -> 3 ------>7 -> null
                if (current.Value.Equals(item))
                {
                    //It's a node in the middle or end
                    if(previous!= null)
                    {
                        //Case 3b
                        previous.Next = current.Next;

                        //it was the end - so update Tail
                        if(current.Next == null)
                        {
                            Tail = previous;
                        }
                        else
                        {
                            // Before Head ->3 <->5 <-> 7 - > null
                            // After Head -> 3 <------->7 - > null


                            // previous = 3
                            // current = 5
                            // current.Next = 7
                            // so ... 7.Previous = 3
                            current.Next.Previous = previous;
                        }
                        count--;
                    }
                    else
                    {
                        // Case 2 or 3a
                        RemoveFirst();
                    }
                }
            }
            return true;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
