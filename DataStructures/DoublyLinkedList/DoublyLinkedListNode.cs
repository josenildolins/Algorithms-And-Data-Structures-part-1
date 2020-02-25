using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    public class DoublyLinkedListNode<T>
    {
        /// <summary>
        /// A node in the LinkedList
        /// </summary>
        /// <param name="value"></param>
        public DoublyLinkedListNode(T value)
        {
            value = Value;
        }

        /// <summary>
        /// The node Value
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// The Next node in the linked list (null if last node)
        /// </summary>
        public DoublyLinkedListNode<T> Next { get; set; }

        /// <summary>
        /// The previous node in the linked list (null if first node)
        /// </summary>
        public DoublyLinkedListNode<T> Previous { get; set; }
    }
}
