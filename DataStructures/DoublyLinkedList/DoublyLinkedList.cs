﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace DoublyLinkedList
{
    public class DoublyLinkedList<T>: IEnumerable<LinkedListNode<T>>,ICollection<T>
    {
        public T Head { get; private set; }
        public T Tail { get; private set; }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void AddFirst(DoublyLinkedListNode<T> node)
        {
           T temp = Head;
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
            throw new NotImplementedException();
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
