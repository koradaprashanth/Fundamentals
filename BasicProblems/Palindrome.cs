﻿namespace BasicProblems
{
    public class Palindrome
    {
        public int getPalindrome(int number)
        {
            int reminder;
            int sum = 0;
            while (number > 0)
            {
                reminder = number % 10;

                sum = (sum * 10) + reminder;

                number = number / 10;
            }

            return sum;
        }
    }
}
