using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
