using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Queues
{
    public class NumberOfIslands
    {
        //https://www.youtube.com/watch?v=HS7t2i9ldmE
        //REDO - above link is with bfs approach
        //["1","1","1","1","0"],
        //["1","1","0","1","0"],
        //["1","1","0","0","0"],
        //["0","0","0","0","0"]
        public int NumIslandsdata(char[][] grid)
        {
            if(grid==null || grid.Length == 0)
            {
                return 0;
            }
            int islandsCount = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if(grid[i][j] == '1')
                    {
                        ++islandsCount;
                        dfs(grid, i, j);
                    }

                }
            }
            return islandsCount;
        }

        public void dfs(char[][] grid,int row,int col)
        {
            if(row<0 || col< 0 || row >= grid.Length || col>= grid[0].Length || grid[row][col] == '0')
            {
                return;
            }

            grid[row][col] = '0'; //visited 1's
            dfs(grid, row + 1, col);
            dfs(grid, row - 1, col);
            dfs(grid, row, col + 1);
            dfs(grid, row, col - 1);

        }

        //Time : O(m*n)
        //Space : O(m*n)
    }
}
