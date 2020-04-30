using System;

namespace ClassExample
{
    public class Stack<T> : IStack<T>
    {
        public T First 
        {
            get
            {
                return FirstNode.Value;
            }
        }

        public T Last 
        {
            get 
            {
                return LastNode.Value;                 
            } 
        }

     
        private Node<T> FirstNode { get; set; }
        private Node<T> LastNode 
        { 
            get 
            {
                var node = FirstNode;
                if (node == null) return null;
                while (node.Next != null) 
                {
                    node = node.Next;                     
                }
                return node;
            } 
            
        }
        public void Push(T item)
        {
            var node = new Node<T>(item);
            if (FirstNode == null)
            {
                FirstNode = node;
                return;
            }
            LastNode.Next = node;
        }
        public T Pop()
        {
            var lastNode = LastNode;
            var node = FirstNode;
            if (node == null) return default;
            while (node.Next != lastNode)
            {
                node = node.Next;
            }
            var value = lastNode.Value;
            node.Next = null;
            return value;
           
        }
    }
}
