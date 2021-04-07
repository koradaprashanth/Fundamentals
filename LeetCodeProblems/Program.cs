using System;
using LeetCodeProblems.DataStructures.Arrays;
using LeetCodeProblems.Company.FB;
using LeetCodeProblems.DataStructures.LinkedLists;
using LeetCodeProblems.DataStructures.Recursion;
using LeetCodeProblems.DataStructures.HashTable;
using System.Collections.Generic;

namespace LeetCodeProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region DataStructures

            #region Arrays
            //NextSquareNumbers nextSquare = new NextSquareNumbers();
            //nextSquare.NextSquareNumbersMethod();

            //Max Consecutive Ones
            //int[] arr = new int[6] { 555,901,482,1771 };
            //MaxConsecutiveOnes maxnumbers = new MaxConsecutiveOnes();
            //maxnumbers.MaxConsecutiveOnesMethod(arr);

            //FindNumbers
            //int[] arr = new int[4] { 555, 901, 482, 1771 };
            //FindNumbersWithEvenNumbers findNumbers = new FindNumbersWithEvenNumbers();
            //findNumbers.FindNumbersMethod(arr);

            //SquaresOfSortedArray
            //int[] arr = new int[5] { -4, -1, 0, 3, 10 };
            //SquaresOfSortedArray sqArray = new SquaresOfSortedArray();
            //sqArray.SortedSquares(arr);


            //DuplicateZeros
            //int[] arr = new int[8] { 1, 0, 2, 3, 0, 4, 5, 0 };
            //DuplicateZeros dzArray = new DuplicateZeros();
            //dzArray.DuplicateZerosMethod(arr);

            //MergeSortedArray
            //int[] nums1 = new int[6] { 1, 2, 3, 0, 0, 0 };
            //int m = 3;
            //int[] nums2 = new int[3] { 2, 5, 6 };
            //int n = 3;
            //MergeSortedArray msArray = new MergeSortedArray();
            //msArray.Merge(nums1, m, nums2, n);

            //RemoveElement
            //int[] rArray = new int[4] { 3, 2, 2, 3 };
            //int val = 3;
            //RemoveElement rEle = new RemoveElement();
            //rEle.RemoveElementMethod(rArray, val);

            //RemoveDuplicates
            //int[] dupArray = new int[10] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            //RemoveDuplicatesFromSortedArray rmDupl = new RemoveDuplicatesFromSortedArray();
            //rmDupl.RemoveDuplicates(dupArray);

            //CheckIfNAndItsDoubleExists
            //int[] doubleArray = new int[4] {3, 1, 7, 11};
            //CheckIfNAndItsDoubleExists chck = new CheckIfNAndItsDoubleExists();
            //chck.CheckIfNAndItsDoubleExistsMethod(doubleArray);

            //Valid Mountain Array
            //int[] validArray = new int[4] { 0, 3, 2, 1 };
            //ValidMountainArray validA = new ValidMountainArray();
            //Console.WriteLine(validA.ValidMountainArrayMethod(validArray));

            //Replace Elements with Greatest Element on Right Side
            //int[] repArray = new int[6] { 17, 18, 5, 4, 6, 1 };
            //ReplaceElementsWithGreatestElement repObj = new ReplaceElementsWithGreatestElement();
            //repObj.ReplaceElements(repArray);

            //Repeated Deletion Algorithm
            //int[] repDelArray = new int[10] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            //RepeatedDeletionAlgorithm rep = new RepeatedDeletionAlgorithm();
            //int[] result = rep.RepeatedDeletionAlgorithmMethod(repDelArray);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}
            //int result = rep.RepeatedDeletionAlgorithmMethod(repDelArray);
            //Console.WriteLine(result);
            //Console.ReadLine();


            //Move Zeros
            //int[] moveZeros = new int[5] { 0, 1, 0, 3, 12 };
            //MoveZeros mZArray = new MoveZeros();
            //mZArray.MoveZeroes(moveZeros);

            //Sort Array By Parity
            //int[] parityArray = new int[4] { 3, 1, 2, 4 };
            //SortArrayByParity sortArray = new SortArrayByParity();
            //sortArray.SortArrayByParityMethod(parityArray);

            //Height Checker
            //int[] heightC = new int[6] { 1, 1, 4, 2, 1, 3 };
            //HeightChecker hR = new HeightChecker();
            //hR.HeightCheckerMethod(heightC);

            //Max Consecutive Ones II
            //int[] maxAr = new int[5] { 1, 0, 1, 1, 0 };
            //MaxConsecutiveOnesII maxAree = new MaxConsecutiveOnesII();
            //maxAree.FindMaxConsecutiveOnes(maxAr);

            //Third Max Number
            //int[] maxNumber = new int[4] { 2, 2, 3, 1 };
            //ThirdMaxNumber trdm = new ThirdMaxNumber();
            //Console.WriteLine(trdm.ThirdMaxMethod(maxNumber));
            //Console.ReadLine();
            #endregion

            #region LinkedList

            LinkedListCycle lnk = new LinkedListCycle();


            #endregion

            #endregion


            #region Company

            #region FB

            // Find All Numbers Disappeared in an Array
            //int[] missArray = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            //FindMissingNumbersInArray aar = new FindMissingNumbersInArray();
            //aar.FindDisappearedNumbers(missArray);

            //A Big Number
            //1000000001 1000000002 1000000003 1000000004 1000000005
            //long[] longArr = new long[5] { 1000000001, 1000000002 ,1000000003 ,1000000004 ,1000000005 };
            //ABigSum b = new ABigSum();
            //b.aVeryBigSum(longArr);

            //DesignerPDFViewer
            //int[] ar = new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            //int[] ar = new int[26] { 6, 5, 7, 3, 6, 7, 3, 4, 4, 2, 3, 7, 1, 3, 7, 4, 6, 1, 2, 4, 3, 3, 1, 1, 3, 5 };
            //DesignerPDFViewer ds = new DesignerPDFViewer();
            //ds.designerPdfViewer(ar, "zbkkfhwplj");

            //Left Rotation
            //int[] ar = new int[] { 1, 2, 3, 4, 5 };
            //LeftRotation lr = new LeftRotation();
            //lr.rotLeft(ar,3);




            #endregion

            #endregion

            #region Recursion

            //char[] str = new char[] { 'a', 'b', 'c', 'x' };
            //ReverseAString rs = new ReverseAString();
            ////rs.printReverse(str);
            //rs.reverseString(str);

            #endregion

            #region HashTables

            //ContainsDuplicate cd = new ContainsDuplicate();
            //bool val = cd.ContainsDuplicateMethod(new int[] { 1, 2, 3, 1 });

            //Console.WriteLine(val);


            //SingleNumber sn = new SingleNumber();
            //int val = sn.SingleNumberMethod(new int[] { 4, 1, 2, 1, 2 });
            //Console.WriteLine(val);


            //IntersectionOfTwoArrays IA = new IntersectionOfTwoArrays();
            //var lst= IA.IntersectionMethod(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 });
            //for (int i = 0; i < lst.Length; i++)
            //{
            //    Console.WriteLine(lst[i]);
            //}


            //HappyNumber hn = new HappyNumber();
            //Console.WriteLine(hn.IsHappy(7));


            //int[] nums = new int[4] { 2, 7, 11, 15 }; int target = 9;

            //TwoSum ts = new TwoSum();
            //var arr= ts.TwoSumMethod(nums, target);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //IsomorphicStrings iss= new IsomorphicStrings();
            //Console.WriteLine(iss.IsIsomorphic("egg", "add"));

            //MinimumIndexSum min = new MinimumIndexSum();
            //var result = min.FindRestaurant(new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" },
            //    new string[] { "KNN", "KFC", "Burger King", "Tapioca Express", "Shogun" });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //FirstUniqueCharacter fs = new FirstUniqueCharacter();
            //Console.WriteLine(fs.FirstUniqChar("loveleetcode"));

            //IntersectionOfTwoArrays11 ins = new IntersectionOfTwoArrays11();
            //var result =ins.Intersect(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 });
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}


            ContainsNearbyDuplicate cn = new ContainsNearbyDuplicate();
            Console.WriteLine(cn.ContainsNearbyDuplicateMethod(new int[] { 1, 2, 3, 1 }, 3));



            #endregion
        }
    }



    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
    
    public class SinglyLinkedListNode {
      
        public int data;
        public SinglyLinkedListNode next;
        public SinglyLinkedListNode(int val)
        {
            data = val;
        }
     
    }

    public class DoublyListNode
    {
        public int val;
        public DoublyListNode next, prev;
        public DoublyListNode(int x) { val = x; }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

}
