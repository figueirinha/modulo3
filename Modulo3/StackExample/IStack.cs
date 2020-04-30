using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExample
{
    public interface IStack<T>
    {
        void Push(T item);
        T Pop();

        T First { get; }
        T Last { get; }
    }
}
