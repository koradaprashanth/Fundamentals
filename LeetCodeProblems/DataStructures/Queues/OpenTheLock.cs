using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.DataStructures.Queues
{
    public class OpenTheLock
    {
        //REDO
        public int OpenLock(string[] deadends, string target)
        {
            var deadEnds = new HashSet<string>(deadends);
            if (deadEnds.Contains("0000") || deadEnds.Contains(target))
                return -1;


            var visited = new HashSet<string>();
            var queue = new Queue<string>();
            queue.Enqueue("0000");
            visited.Add("0000");

            int level = 0;
            while (queue.Any())
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var current = queue.Dequeue();
                    if (current.Equals(target))
                        return level;
                    foreach (var neighbor in GetNeighbors(current))
                    {
                        if (!visited.Contains(neighbor) && !deadEnds.Contains(neighbor))
                        {
                            queue.Enqueue(neighbor);
                            visited.Add(neighbor);
                        }
                    }
                }
                level++;
            }

            return -1;
        }

        private List<string> GetNeighbors(string s)
        {
            var result = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                var charArray1 = s.ToCharArray();
                charArray1[i] = charArray1[i] == '9' ? '0' : (char)((int)charArray1[i] + 1);
                result.Add(new string(charArray1));
                var charArray2 = s.ToCharArray();
                charArray2[i] = charArray2[i] == '0' ? '9' : (char)((int)charArray2[i] - 1);
                result.Add(new string(charArray2));
            }

            return result;
        }
    }
}
