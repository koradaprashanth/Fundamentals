using System;
using System.Collections.Generic;
using System.Text;

namespace MySampleCodeProject.Questions
{
    public class MinNumber
    {
        public int minNum(int threshold, List<int> points)
        {
            int count = 1;
            bool thresholdreached = false;
            for (int i = 0; i < points.Count; i++)
            {
                count++;
                if (i + 2 < points.Count)
                {
                    if (threshold <= points[i + 2] - points[0])
                    {
                        thresholdreached = true;
                        break;
                    }
                    i++;
                }
                else if (i + 1 < points.Count)
                {
                    if (threshold <= points[i + 1] - points[0])
                    {
                        thresholdreached = true;
                        break;
                    }
                }
            }
            return thresholdreached ? count : points.Count;
        }
    }
}
