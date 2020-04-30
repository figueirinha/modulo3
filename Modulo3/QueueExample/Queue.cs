using System;

namespace QueueExample
{
    public class Queue<T> : IQueue<T>
    {
        public T First => FirstNode.Value;

        public T Last => LastNode.Value;
        private Node<T> FirstNode { get; set; }
        private Node<T> LastNode 
        { 
            get 
            {
                var node = FirstNode;
                if (node == null) return null; 
                while (node.Next != null) node = node.Next;               
                return node;
            } 
        }
        public T Dequeue()
        {
            if (FirstNode == null) return default;
            var res = First;
            FirstNode = FirstNode.Next;
            return res;
        }

        public void Enqueue(T item)
        {
            var node = new Node<T>(item);
            if (FirstNode == null)
            {
                FirstNode.Next = node;
                return;
            }
            LastNode.Next = node;

        }
    }
}
