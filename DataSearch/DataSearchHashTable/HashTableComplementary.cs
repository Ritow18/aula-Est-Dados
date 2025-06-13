using System;
using System.Collections.Generic;

namespace dataSearchHashTable
{
    public class HashTable<T>
    {
        private List<LinkedList<T>> tableList;
        private int capacity;
        public HashTable( int capacity = 10)
        {
            this.capacity = capacity;
            tableList = new List<LinkedList<T>>(capacity);
            for (int i = 0; i < capacity; i++)
            {
                tableList.Add(new LinkedList<T>());
            }
        }
        private int Hash(T value)
        {
            return Math.Abs(value.GetHashCode()) % capacity;
        }
        public void insert(T value) 
        {
            int indice = Hash(value);
            if (!tableList[indice].Contains(value))
            {
                tableList[indice].AddLast(value);
                Console.WriteLine($"{value} inserido na posição: {indice}");
            }
            else
            {
                Console.WriteLine($"{value} é um valor que já existe na posição: {indice}");
            }
        }
        public bool Search(T value) 
        {
            int indice = Hash(value);
            return tableList[indice].Contains(value);
        }
        public bool Remove(T value)
        {
            int indice = Hash(value);
            return tableList[indice].Remove(value);
        }
        public void Display()
        {
            for (int i = 0; i < capacity; i++)
            {
                Console.Write($"[{i}]: ");
                foreach (var item in tableList[i])
                {
                    Console.Write(item + " -> ");
                }
                Console.Write("null");
            }
        }
    }
}
