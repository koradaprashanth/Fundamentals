using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.HashTable
{
    public class ValidSudoku
    {
        public bool IsValidSudoku(char[,] board)
        {
            //for (var i = 0; i < 9; i++)
            //{
            //    var hsr = new HashSet<char>();

            //    var hsc = new HashSet<char>();

            //    var hsx = new HashSet<char>();

            //    for (var j = 0; j < 9; j++)
            //    {
            //        if (board[i, j] != '.' && !hsr.Add(board[i, j])) return false;

            //        if (board[j, i] != '.' && !hsc.Add(board[j, i])) return false;

            //        var x = (i % 3) * 3 + j % 3;

            //        var y = (i / 3) * 3 + j / 3;

            //        if (board[x, y] != '.' && !hsx.Add(board[x, y])) return false;
            //    }
            //}

            //return true;

            HashSet<string> seen = new HashSet<string>();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    char current_val = board[i, j];
                    if (current_val != '.')
                    {
                        if ((!seen.Add(current_val + " found in row " + i) ||
                            !seen.Add(current_val + " found in column " + j) ||
                            !seen.Add(current_val + " found in sub box " + i / 3 + "-" + j/3)))
                            return false;
                    }
                }
            }
            return true;
        }
    }
}
