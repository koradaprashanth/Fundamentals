using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Recursion
{
    public class Pascal_sTriangle
    {
        public IList<IList<int>> GenerateMethod(int numRows)
        {
            //input = 5;

            List<IList<int>> data = new List<IList<int>>();


            // First base case; if user requests zero rows, they get zero rows.
            if (numRows == 0)
            {
                return data;
            }


            // Second base case; first row is always [1].
            data.Add(new List<int>());
            data[0].Add(1);

            for (int i = 1; i < numRows; i++)
            {
                

                IList<int> curr = new List<int>();
                IList<int> prevRow = data[i - 1];

                // The first row element is always 1.
                curr.Add(1);

                // Each triangle element (other than the first and last of each row)
                // is equal to the sum of the elements above-and-to-the-left and
                // above-and-to-the-right.
                for (int j = 1; j < prevRow.Count; j++)
                {
                    curr.Add(prevRow[j-1] + prevRow[j]);
                }

                // The last row element is always 1.
                curr.Add(1);

                data.Add(curr);
            }

            return data;
        }
    }
}
