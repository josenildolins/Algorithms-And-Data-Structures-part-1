using System;
using System.Collections;
using System.Collections.Generic;

namespace Queue.list
{
    /// <summary>
    /// A first In First out Collection
    /// </summary>
    /// <typeparam name="T">The type of data stored in the collection</typeparam>
    public class Queue<T> : IEnumerable<T>
    {

        // The Queue items - the last item is the
        // newest queue item, the first is the oldest.
        // this is so LinkedList<T>.GetEnumerator "just works"
        LinkedList<T> _items = new LinkedList<T>();

        /// <summary>
        /// Adds an item to the back of the quee
        /// </summary>
        /// <param name="item">The item to place in the queue</param>
        public void Enqueue(T item)
        {
            _items.AddLast(item);
        }

        /// <summary>
        /// removes and returns the front item from the queue
        /// </summary>
        /// <returns>The front item from the queue</returns>
        public T Dequeue()
        {
            if(_items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            // store the last value in a temporary variable
            T value = _items.First.Value;

            //remove the last item
            _items.RemoveFirst();

            // return the stored last value
            return value;
        }

        /// <summary>
        /// Returns the front item from the queue without removing it from the queue
        /// </summary>
        /// <returns>The front item from the queue</returns>
        public T Peek()
        {
            if(_items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }

            // return the last value in the queue
            return _items.First.Value;
        }

        /// <summary>
        /// The number of items in the queue
        /// </summary>
        public int Count
        {
            get
            {
                return _items.Count;
            }
        }

        /// <summary>
        /// Remove all items from the queue
        /// </summary>
        public void Clear()
        {
            _items.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }

    }
}
