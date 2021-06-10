using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Queues
{
    //REDO
    public class WallsAndGates
    {
        
        public void WallsAndGatesdata(int[][] rooms)
        {


            //for (int i = 0; i < rooms.Length; i++)
            //{
            //    for (int j = 0; j < rooms[i].Length; j++)
            //    {
            //        if(rooms[i][j] ==0)
            //            dfs(i, j, 0, rooms);
            //    }

            //}
            if (rooms == null || rooms.Length == 0)
                return;
            //2^31-1 = 2147483647 (INF) infinity
            int INF = Int32.MaxValue, gate = 0, wall = -1; 
            int m = rooms.Length, n = rooms[0].Length;

            Queue<(int, int)> queue = new Queue<(int, int)>();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (rooms[i][j] == gate)
                        queue.Enqueue((i, j));
                }
            }

            int[,] dir = new int[,] { { -1, 0 }, { 1, 0 }, { 0, -1 }, { 0, 1 } };
            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    int r = curr.Item1 + dir[i, 0];
                    int c = curr.Item2 + dir[i, 1];

                    if (r >= 0 && r < m && c >= 0 && c < n && rooms[r][c] == INF)
                    {
                        rooms[r][c] = rooms[curr.Item1][curr.Item2] + 1;
                        queue.Enqueue((r, c));
                    }
                }
            }
        }


        public void dfs(int i,int j,int count, int[][] rooms)
        {
            if(i<0 || i>=rooms.Length || j<0 || j>=rooms[i].Length || rooms[i][j] < count)
            {
                return;
            }

            rooms[i][j] = count;
            dfs(i + 1, j, count + 1, rooms);
            dfs(i - 1, j, count + 1, rooms);
            dfs(i, j + 1, count + 1, rooms);
            dfs(i, j - 1, count + 1, rooms);
        }
    }
}
