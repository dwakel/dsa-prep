using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var test1 = "abcabcbb";
            var test2 = "bbbbb";
            var test3 = "pwwkew";
            var test4 = "abcabcbhghgfaadvb";

            Solution solution = new();
            
            Console.WriteLine(solution.LengthOfLongestSubstring(test1));
            Console.WriteLine(solution.LengthOfLongestSubstring(test2));
            Console.WriteLine(solution.LengthOfLongestSubstring(test3));
            Console.WriteLine(solution.LengthOfLongestSubstring(test4));
        }

        
    }
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            List<char> chain = new List<char>();
            int highestChain = 0;
            int length = 0;
            foreach (char c in s)
            {
                if (chain.Contains(c))
                {
                    chain.RemoveRange(0, chain.IndexOf(c) + 1);
                }
                chain.Add(c);
                length = chain.Count();
                highestChain = highestChain >= length ? highestChain : length;
            }

            return highestChain;
        }
    }
}
