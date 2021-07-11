using System;
using System.Collections.Generic;
using System.Collections;
using Concepts;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;

namespace MySampleCodeProject
{
    public class Program
    {


        private static string result;
        public static void Main(string[] args)
        {

            #region Arrays

            //Intersection of Two Arrays II
            //int[] nums1 = new int[] { 1, 2, 2, 1 }; int[] nums2 = new int[] { 2, 2 };
            //var interesectedElements = Intersect(nums1, nums2);
            //for (int i = 0; i < interesectedElements.Length; i++)
            //{
            //    Console.WriteLine(interesectedElements[i]);
            //}

            //Diagonal Traverse
            //int[,] intArray = new int[3,3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //int[] res = new int[9];
            //res=FindDiagonalOrder(intArray);

            //Longest Common Prefix; 
            //string[] strs = new string[] { "flower", "flow", "flight" };
            //string res = LongestCommonPrefix(strs);
            //Console.WriteLine(res);

            //Reverse String
            //char[] ch = new char[] { 'h', 'e', 'l', 'l', 'o' };
            //ReverseString(ch);
            //for (int i = 0; i < ch.Length; i++)
            //{
            //    Console.WriteLine(ch[i]);
            //}          

            //Two Sum II - Input array is sorted
            //var result = TwoSum(new int[] { 2, 7, 11, 15 }, 18);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}

            //Remove Element
            //var result = RemoveElement(new int[] { 3, 2, 2, 3 }, 3);
            //Console.WriteLine(result);

            //Max Consecutive Ones
            //var result = FindMaxConsecutiveOnes(new int[] { 1, 0, 1, 1, 0, 1});
            //Console.WriteLine(result);

            //Minimum Size Subarray Sum
            //var result = MinSubArrayLen(7, new int[] { 2, 3, 1, 2, 4, 3 });
            //Console.WriteLine(result);

            //Rotate Array
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            //Rotate(arr, 3);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //Reverse words in string
            //var result = ReverseWordsII("the sky is blue");
            //Console.WriteLine(result);

            //Pascal's Triangle II
            //var result = GetRow(3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //Remove Duplicates from Sorted Array
            //var res = RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
            //Console.WriteLine(res);

            //Move Zeroes
            //int[] nums = new int[] { 0, 1, 0, 3, 12 };
            //MoveZeroes(nums);
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}
            //var data = solution(7, 42, new int[] { 6, 42, 11, 7, 1, 42 });

            //var data = Codility(new string[] { "co", "dil", "ity" });


            //var data= findDiagonalOrder(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 },new int[] { 7, 8, 9 } });

            //foreach (var item in data)
            //{
            //    Console.WriteLine(item);
            //}

            //var data = findReverseDiagonalOrder(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } });
            ////var data = findReverseDiagonalOrder(new int[][] { new int[] { 2, 3 } });
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item);
            //}

            //var data = TwoSumDirect(new int[]{2, 7, 11, 15},9);
            //var data = findReverseDiagonalOrder(new int[][] { new int[] { 2, 3 } });
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Queues 

            //MyQueue q = new MyQueue();
            //q.enQueue(5);
            //q.enQueue(3);

            //if (q.isEmpty() == false)
            //{
            //    Console.WriteLine(q.Front());
            //}
            //q.deQueue();
            //if (q.isEmpty() == false)
            //{
            //    Console.WriteLine(q.Front());
            //}
            //q.deQueue();
            //if (q.isEmpty() == false)
            //{
            //    Console.WriteLine(q.Front());
            //}

            //MyCircularQueue circularQueue = new MyCircularQueue(3); // set the size to be 3
            //Console.WriteLine(circularQueue.EnQueue(1));  // return true
            //Console.WriteLine(circularQueue.EnQueue(2));  // return true
            //Console.WriteLine(circularQueue.EnQueue(3));  // return true
            //Console.WriteLine(circularQueue.EnQueue(4));  // return false, the queue is full
            //Console.WriteLine(circularQueue.Rear());  // return 3
            //Console.WriteLine(circularQueue.IsFull());  // return true
            //Console.WriteLine(circularQueue.DeQueue());  // return true
            //Console.WriteLine(circularQueue.EnQueue(4));  // return true
            //Console.WriteLine(circularQueue.Rear());  // return 4
            #endregion

            #region Stacks

            //Console.WriteLine(IsValid("(])"));
            //Console.WriteLine(IsValid("{[[]{}]}"));

            #endregion

            #region Binary Tree


            #endregion

            #region MyCalender

            //var result = gameWinner("wwwbbbbwww");
            //Console.ReadLine();

            //WriteSomething();
            //Console.WriteLine(result);
            //Console.ReadLine();
            //static async Task<string> WriteSomething()
            //{
            //    await Task.Delay(5);
            //    result = "Print Hello world!";
            //    return "Something";
            //}


            //Dictionary<int, String> Names = new Dictionary<int, string>();
            //Names.Add(10, "sushma");
            //Names.Add(15, "prashanth");
            //Names.Add(20, "sushma");
            //Console.WriteLine("the value at key 15 =" + Names[15]);
            //var output = new List<int[]>();
            //var i = new int[] { 1, 2 };
            //output.Add(i);
            //i[0] = 10;
            //Console.WriteLine(output[0][0]);

            //Program a = new Program();
            //var data= a.Solution(2014, "April", "May", "Wednesday");
            //Console.WriteLine(data);

            #endregion



            //Calculate();
            //Console.Read();



        }

        #region AsyncAwait

        async static void Calculate()
        {
            //Task.Run(() => { Calculate1(); });
            //Task.Run(() => { Calculate2(); });
            //Task.Run(() => { Calculate3(); });

            await Calculate1_2();
            Calculate3();
        }

        async static Task Calculate1_2()
        {
            var result1 = await Task.Run(() => {

                return Calculate1();
            });

            Calculate2(result1);
        }

        static int Calculate1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Calculating result1");
            return 100;
        }

        static int Calculate2(int result1)
        {
            Console.WriteLine("Calculating result2");
            return result1 * 2;
        }

        static int Calculate3()
        {
            Console.WriteLine("Calculating result3");
            return 300;
        }

        #endregion



        public int Solution(int Y, string A, string B, string W)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
             string[] Months ={"January","February","March","April",
                "May","June","July","August","September","October","November","December"};

            string[] Days ={"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"};

            MyCalendar dt = new MyCalendar(Months.ToList().IndexOf(W), Y);

            int startMonthIndex = Months.ToList().IndexOf(A);
            int endMonthIndex = Months.ToList().IndexOf(B);
            while((dt.getMonthIndex() != startMonthIndex)||(!string.Equals(Days[dt.getDayOfMonthIndex()], "Monday", StringComparison.OrdinalIgnoreCase)))
            {
                dt.advance();
            }
            int daysSpent = 0;

            while (dt.getMonthIndex() <= endMonthIndex)
            {
                daysSpent++;
                dt.advance();
            }
            return daysSpent/7;
        }

        class MyCalendar
        { // To store numeric values
           private int day, month, year;
           private int dayOfYear;
            // it will be in range from 0 to 6 ( Signifying Sunday to Saturday 
            private static int[] numDays = {
                31,
                28,
                31,
                30,
                31,
                30,
                31,
                31,
                30,
                31,
                30,
                31
            };
            public MyCalendar(int dayOfYear, int year)
            {
                day = 1;
                month = 1; // January 
                this.year = year;
                this.dayOfYear = dayOfYear;
            } // check if a year is leap year or not 
            private static bool isLeapYear(int year)
            {
                return ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
            }
            private static int getDays(int month, int year)
            {
                if (isLeapYear(year) && month == 1)
                {
                    // Feb
                    return numDays[month] + 1;
                }
                else
                {
                    return numDays[month];
                }
            }
            public void advance()
            {
                dayOfYear = (dayOfYear + 1) % 7;
                day++;
                int maxDaysInMonth = getDays(month, year);
                // if it was last day of month, then increment the month 
                if (day > maxDaysInMonth)
                {
                    day = 1;
                    month++;
                    // if it was 31st december, we need to change year also 
                    if (month > 12)
                    {
                        month = 0;
                        year++;
                    }
                }
            }
            public int getMonthIndex()
            {
                return month;
            }
            public int getDayOfMonthIndex()
            {
                return dayOfYear;
            }
           
        }





        #region Arrays Implementation

        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            var hashSet = new HashSet<int>(nums1);


            List<int> data = new List<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                if (hashSet.Contains(nums2[i]))
                {
                    data.Add(nums2[i]);
                }

            }

            return data.ToArray();

        }

        public static int[] TwoSumDirect(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dict.ContainsKey(complement))
                {
                    return new int[] { dict[complement], i };
                }

                dict.Add(nums[i], i);

            }
            return new int[] { };
        }
        public int[] PlusOne(int[] digits)
        {

            return new int[] { 1 };

        }
               
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0)
            {
                return 0;
            }

            int k = 0;
            int i = 0;
            int j = 0;

            while (true)
            {
                if (i >= haystack.Length)
                {
                    break;
                }

                if (haystack[i] == needle[j])
                {
                    k++;

                    if (k == needle.Length)
                    {
                        return i - k + 1;
                    }

                    i++;
                    j++;

                    continue;
                }

                j = 0;
                i = i - k + 1;
                k = 0;

            }

            return -1;

            ////This represents my pointer that will traverse the needle.
            //int needleInHayStackIndex = 0;
            //for (int i = 0; i < haystack.Length; i++)
            //{
            //    if (haystack[i] == needle[needleInHayStackIndex])
            //    {
            //        if (needleInHayStackIndex == (needle.Length - 1))
            //        {
            //            //Return the index in haystack                        
            //            return i - needleInHayStackIndex;
            //        }

            //        needleInHayStackIndex++;
            //    }
            //    else if (needleInHayStackIndex != 0)
            //    {
            //        //We need to move the i back in the haystack
            //        //To check for a match starting from the next character.
            //        //Eg: [helllo][llo]
            //        i = i - needleInHayStackIndex;
            //        needleInHayStackIndex = 0;
            //    }
            //}

        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            String prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == "") return "";
                }
            return prefix;

        }


        public static int[] findDiagonalOrder(int[][] matrix)
        {
            if(matrix ==null || matrix.Length == 0)
            {
                return new int[] { };
            }

            int N = matrix.Length;
            int M = matrix[0].Length;
            int i;
            int j;
            List<int> result = new List<int>();            

            for(int k=0; k<= M - 1; k++)
            {
                i = k;
                j = 0;
                while (i >= 0)
                {
                    result.Add(matrix[i][j]);
                    i = i - 1;
                    j = j + 1; 
                }
            }

            for (int k = 1; k <= N-1; k++)
            {
                i = N -1;
                j = k;
                while(j<= N - 1)
                {
                    result.Add(matrix[i][j]);
                    i = i - 1;
                    j = j + 1;
                }
            }

            return result.ToArray();
        }

        public static int[] findReverseDiagonalOrder(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                return new int[0];
            }

            var n = matrix.Length;
            var m = matrix[0].Length;
            var res = new int[n * m];
            var row = 0;
            var col = 0;
            var dir = 1;
            for (int i = 0; i < n * m; i++)
            {
                res[i] = matrix[row][col];
                row -= dir;
                col += dir;

                if (row >= n)
                {
                    row = n - 1;
                    col += 2;
                    dir = -dir;
                }
                if (col >= m)
                {
                    col = m - 1;
                    row += 2;
                    dir = -dir;
                }
                if (row < 0)
                {
                    row = 0;
                    dir = -dir;
                }
                if (col < 0)
                {
                    col = 0;
                    dir = -dir;
                }

            }

            return res;
        }

        #endregion

        #region two pointer technique

        public static void ReverseString(char[] s)
        {
            int start = 0;
            int end = s.Length - 1;
            while (start <= end)
            {
                char x = s[start];
                s[start] = s[end];
                s[end] = x;
                start++;
                end--;

            }
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            int start = 0;
            int end = numbers.Length - 1;
            while (start < end)
            {
                if (numbers[start] + numbers[end] == target)
                    return new int[] { start,end };
                else if (numbers[start] + numbers[end] > target)
                    end--;
                else
                    start++;
            }
            return new int[] { };

        }

        public static int RemoveElement(int[] nums, int val)
        {
            int start = 0;
            int end = nums.Length ;
            while (start < end)
            {
                if (nums[start] == val)
                {
                    nums[start] = nums[end-1];
                    end--;
                }
                else
                {
                    start++;
                }
            }
            return end;
        }

        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int counter = 0;
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                counter = nums[i] == 0 ? 0 : counter+1;
                k = counter > k ? counter : k;

            }
            return k;

        }

        public static int MinSubArrayLen(int s, int[] nums)
        {
            List<int> lst = new List<int>(); 
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (k + nums[i] == s)
                        break;
                    else
                    {

                        continue;
                    }
                    

                }
                k = 0;
                i++;

            }
            return k;
        }

        public static void Rotate(int[] nums, int k)
        {
            int x = 0;int y = nums.Length-1;
            for (int i = 0; i < k; i++)
            {
                x = nums[nums.Length - 1];
                while (y >=0)
                {
                    if (y == 0)
                    {
                        nums[y] = x;
                        y = nums.Length - 1;
                        break;
                    }
                    nums[y] = nums[y - 1];                   
                    y--;
                }
            }
        }

        #endregion

        #region Conclusion
        public static string ReverseWordsI(string s)
        {            
            string str = "";
            List<string> strLst = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString() == " ")
                {
                    strLst.Add(s.Substring(0, i));
                    s = s.Substring(i, s.Length-i).Trim();
                    i = -1;
                }              
            }
            foreach (var item in strLst)
            {
                str = str + item + " ";
            }
            
            return str;
        }

        public static IList<int> GetRow(int rowIndex)
        {
            if (rowIndex == 0)
                return new List<int> { 1 };

            IList<int> line = GetRow(rowIndex - 1);
            IList<int> res = new List<int>();
            for (int i = 0; i <= rowIndex; i++)
            {
                if (i == 0 || i == rowIndex)
                    res.Add(1);
                else
                    res.Add(line[i - 1] + line[i]);
            }
            return res;
            //List<List<int>> lst = new List<List<int>>();
            //lst.Add(new List<int>() { 1 });
            //for (int i = 1; i <= rowIndex ; i++)
            //{
            //    List<int> currRow = new List<int>();
            //    List<int> prevRow = lst[i-1];

            //    currRow.Add(1);
            //    for (int j = 1; j < i; j++)
            //    {
            //        currRow.Add(prevRow[j - 1] + prevRow[j]);

            //    }
            //    currRow.Add(1);
            //    lst.Add(currRow);
            //    if(i == rowIndex)
            //    {
            //        return currRow;
            //    }

            //}
            //return new List<int>() { };
        }


        public static string ReverseWordsII(string s)
        {
            string str = ""; string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    str = s[i] + str;
                }
                else
                {
                    str = str + s[i];
                    result = result + str;
                    str = "";
                }
                if (i == s.Length - 1)
                    result = result + str;
            }
            return result;
        }


        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int count = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[count])
                {
                    count++;
                    nums[count] = nums[i];
                }
            }
            return count + 1;
        }

        public static void MoveZeroes(int[] nums)
        {
            //int[] arr = new int[nums.Length];
            //int zero = 0; int nonzero = nums.Length-1;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] == 0)
            //    {
            //        arr[nonzero] = nums[i];
            //        nonzero--;
            //    }
            //    else
            //    {
            //        arr[zero] = nums[i];
            //        zero++;
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    nums[i] = arr[i];

            //}
            //Two pointer concept
            int k = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if(nums[k]==0 && nums[i] != 0)
                {
                    int temp = nums[i];
                    nums[i]= nums[k];
                    nums[k] = temp;
                    k++;
                    i = k;
                }
                else if (nums[k] != 0)
                    k = i;

            }
           

        }




        #endregion

        #region Queue Implementations




        #endregion

        #region Stack Implementations

        public static bool IsValid(string s)
        {
            if (s.Length == 0)
                return true;

            //bool isvalid = false;
            Dictionary<char,char> dict = new Dictionary<char, char>();
            Stack<char> st = new Stack<char>();

            dict.Add('(', ')');
            dict.Add('{', '}');
            dict.Add('[', ']');

            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    st.Push(s[i]);
                }
                else
                {
                    if (st.Count == 0)
                        continue;

                    if(s[i]== dict[st.Peek()])
                    {
                        st.Pop();
                    }
                }

            }





            return st.Count==0;
        }

        #endregion

        #region HashTables



        #endregion

    }

    #region Queue Classes

    public class MyQueue
    {
        // store elements
        private ArrayList data;
        // a pointer to indicate the start position
        private int p_start;
        public MyQueue()
        {
            data = new ArrayList();
            p_start = 0;
        }
        /** Insert an element into the queue. Return true if the operation is successful. */
        public bool enQueue(int x)
        {
            data.Add(x);
            return true;
        }
        /** Delete an element from the queue. Return true if the operation is successful. */
        public bool deQueue()
        {
            if (isEmpty() == true)
            {
                return false;
            }
            p_start++;
            return true;
        }
        /** Get the front item from the queue. */
        public int Front()
        {
            return Convert.ToInt32(data[p_start]);
        }
        /** Checks whether the queue is empty or not. */
        public bool isEmpty()
        {
            return p_start >= data.Count;
        }
    };


    public class MyCircularQueue
    {

        int capacity;
        List<int> list;

        public MyCircularQueue(int k)
        {
            capacity = k;
            list = new List<int>();
        }

        public bool EnQueue(int value)
        {
            if (list.Count == capacity) return false;
            list.Add(value);
            return true;
        }


        public bool DeQueue()
        {
            if (list.Count == 0) return false;
            list.RemoveAt(0);
            return true;
        }

        public int Front()
        {
            return list.Count == 0 ? -1 : list[0];
        }

        public int Rear()
        {
            return list.Count == 0 ? -1 : list[list.Count - 1];
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }

        public bool IsFull()
        {
            return list.Count == capacity;
        }
    }

    /**
     * Your MyCircularQueue object will be instantiated and called as such:
     * MyCircularQueue obj = new MyCircularQueue(k);
     * bool param_1 = obj.EnQueue(value);
     * bool param_2 = obj.DeQueue();
     * int param_3 = obj.Front();
     * int param_4 = obj.Rear();
     * bool param_5 = obj.IsEmpty();
     * bool param_6 = obj.IsFull();
     */
    #endregion


}
