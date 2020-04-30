using System;
using System.Collections.Generic;
using System.Text;

namespace QueueExample
{
    public interface IQueue<T>
    {
        public void Enqueue(T item);
        public T Dequeue();

        T First { get; }
        T Last { get; }
    }
}
