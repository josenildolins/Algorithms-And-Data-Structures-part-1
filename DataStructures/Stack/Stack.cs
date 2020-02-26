using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack.Array
{
    /// <summary>
    /// A last In First Out (LIFO) Collection Implemented as an array.
    /// </summary>
    /// <typeparam name="T"> The type of item contained in the stack</typeparam>
    public class Stack<T> : IEnumerable<T>
    {

        /// <summary>
        /// Enumerates each items in the stack in LIFO order. the stack remain unaltered.
        /// </summary>
        /// <returns>The LIFO enumerator</returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = _size; i >= 0; i--)
            {
                yield return _items[i];
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {

            return GetEnumerator();

        }

        // The array of items contained in the stack. Initiated to 0 length,
        // will grow as needed during push
        T[] _items = new T[0];

        // The current number of items in the stack
        int _size;

        /// <summary>
        /// Adds the specifidenitems to the stack
        /// </summary>
        /// <param name="items"></param>
        public void Push(T items)
        {
            //_size  = 0 ... first push
            // _size == length .... growth boundary
            if (_size == _items.Length)
            {
                // initial size of 4, otherwise double the current length
                int newLength = _size == 0 ? 4 : _size * 2;

                // allocate, copy and assign the new array
                T[] newArray = new T[newLength];
                _items.CopyTo(newArray, 0);
                _items = newArray;
            }

            // add the item to the stack array and increase the size
            _items[_size] = items;
            _size++;
        }

        /// <summary>
        /// Removes and returns the top item from the stack
        /// </summary>
        /// <returns>The top-most items in the stack</returns>
        public T Pop()
        {

            if (_size == 0)
            {
                throw new InvalidOperationException("the stack is empty");
            }
            _size--;

            return _items[_size];
        }

        public T peek()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("The stack is empty");

            }

            return _items[_size - 1];

        }

        /// <summary>
        /// The current number of items in the stack
        /// </summary>
        public int Count
        {

            get
            {
                return _size;
            }
        }

        /// <summary>
        /// Remove all items from the stack
        /// </summary>
        public void clear()
        {
            _size = 0;
        }




    }
}

