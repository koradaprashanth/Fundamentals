using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.HashTable
{
    public class MyHashSet
    {
        /** Initialize your data structure here. */
        List<int> ls;
        public MyHashSet()
        {
            ls = new List<int>();
        }

        public void Add(int key)
        {
            if (!ls.Contains(key))
            {
                ls.Add(key);
            }
        }

        public void Remove(int key)
        {
            if (ls.Contains(key))
            {
                ls.Remove(key);
            }
        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            return false;
        }
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
