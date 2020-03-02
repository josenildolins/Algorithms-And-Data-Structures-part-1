using System;
using System.Collections;
using System.Collections.Generic;

namespace Queue.Priority
{
    /// <summary>
    /// A collection that returns the highest priority item first and lowest priority item last.
    /// </summary>
    /// <typeparam name="T">The type of data stored in the collection</typeparam>
    public class PriorityQueue<T> : IEnumerable<T> where T: IComparable<T>
    {
        LinkedList<T> _items = new LinkedList<T>();

        /// <summary>
        /// Adds an item to the queue in priority order
        /// </summary>
        public void Enqueue(T item)
        {
            // if the list is empty, just add the items
            if (_items.Count == 0)
            {
                _items.AddLast(item);
            }
            else
            {
                //find the proper insert point
                var current = _items.First;

                //While we're not at the end of the list and the current value
                // is larger than the value being inserted...
                while (current != null && current.Value.CompareTo(item) > 0)
                {
                    current = current.Next;
                }

                if (current == null)
                {
                    // We made it to the end of the list
                    _items.AddLast(item);
                }
                else
                {
                    // The current item is <= the one being added
                    // So add the item before it.
                    _items.AddBefore(current, item);
                }
            }
        }

        //The rest of the class is exactly the same as the Linked List Example

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
