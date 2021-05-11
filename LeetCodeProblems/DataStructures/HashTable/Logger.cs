using System.Collections.Generic;

namespace LeetCodeProblems.DataStructures.HashTable
{
    public class Logger
    {
        /** Initialize your data structure here. */
        Dictionary<string, int> diction;
        public Logger()
        {
            diction = new Dictionary<string, int>();
        }

        /** Returns true if the message should be printed in the given timestamp, otherwise returns false.
            If this method returns false, the message will not be printed.
            The timestamp is in seconds granularity. */
        public bool ShouldPrintMessage(int timestamp, string message)
        {
            if (!diction.ContainsKey(message))
            {
                diction[message] = timestamp;
                return true;
            }

            int oldTimeStamp = diction[message];
            if((timestamp- oldTimeStamp) >= 10)
            {
                diction[message] = timestamp;
                return true;
            }else
            {
                return false;
            }
        }
    }

     /**
     * Your Logger object will be instantiated and called as such:
     * Logger obj = new Logger();
     * bool param_1 = obj.ShouldPrintMessage(timestamp,message);
     */
}
