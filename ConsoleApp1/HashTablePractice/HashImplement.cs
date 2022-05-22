using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.HashTablePractice
{
    public class MyNode
    {
        public MyNode(string key, int value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }
        public int Value { get; set; }

    }


    class HashTableI
    {
        //private int size;
        private class MyNodes : List<MyNode>{};
        private readonly int length;
        private readonly MyNodes[] data;
        public HashTableI(int length)
        {
            this.length = length;
            data = new MyNodes[length];
        }

        private int Hash(string key)
        {
            int hash = 0;
            for(var i=0;i<key.Length;i++)
            {
                hash = (hash + key[i] * i) % length;
            }
            return hash;
        }

        public void Set(string key,int value)
        {
            var address = Hash(key);
            if(data[address] == null)
            {
                data[address] = new MyNodes();
            }
            data[address].Add(new MyNode(key, value));
        }

        public int Get(string key)
        {
            var address = Hash(key);
            var current = data[address];
            if(current != null && current.Any())
            {
                //大部分情況下視為O(1) => 無碰撞的情形之下
               foreach(var item in current)
                {
                    if(item.Key.Equals(key))
                    {
                        return item.Value;
                    }
                }
            }
            return 0;
        }

        public List<string> Keys()
        {
            var newList = new List<string>();
            foreach(var item in data)
            {
                if(item != null)
                {
                    newList.AddRange(item.Select(x => x.Key));
                }    
            }
            return newList;
        }

    }
    class HashImplement
    {
        //static void Main(string[] args)
        //{
        //    HashTable h = new HashTable(200000);
        //    h.Set("grapes", 10000);
        //    h.Set("apple", 54);
        //    h.Set("banana", 520);
        //    var value = h.Get("banana");
        //    Console.WriteLine(value);
        //    var list = h.Keys();
        //    Console.WriteLine(h.Keys());
        //}
    }
}
