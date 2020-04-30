﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QueueExample
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value)
        {
            Value = value;
        }
        public Node(T value, Node<T> next)
        {
            Value = value;
            Next = next;
        }
    }
}
