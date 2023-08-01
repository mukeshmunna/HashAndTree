using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashAndTree.HashAndTree
{
    internal class MapNode<M,N>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<M, N>>[] items;
        public MapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<M, N>>[size];
        }
        public int GetArrayPosition(M key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public N Get(M key)
        {
            int postionnn = GetArrayPosition(key);
            LinkedList<KeyValue<M, N>> LinkedList = GetLinkedList(postionnn);
            foreach (KeyValue<M, N> item in LinkedList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(N);
        }
        public void Add(M key, N value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<M, N>> linkedList = GetLinkedList(position);
            KeyValue<M, N> item = new KeyValue<M, N>() { Key = key, Value = value };
            linkedList.AddLast(item);
        }
        public void Remove(M key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<M, N>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<M, N> foundItem = default(KeyValue<M, N>);
            foreach (KeyValue<M, N> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }
        protected LinkedList<KeyValue<M, N>> GetLinkedList(int postion)
        {
            LinkedList<KeyValue<M, N>> linkedList = items[postion];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<M, N>>();
                items[postion] = linkedList;
            }
            return linkedList;
        }
    }
    public struct KeyValue<M, N>
    {
        public M Key { get; set; }
        public N Value { get; set; }

    }
}
