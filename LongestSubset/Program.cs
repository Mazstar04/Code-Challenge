using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestSubset
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 10, c = 5___3__2;
            (b , a , c) = (a, c, b);
            Console.WriteLine($"{a} - {b} -{c}");
            //Console.WriteLine(LongestSubset(new int[] { 1, 7, 2, 4 }, 3));
        }

        public static int LongestSubset(int[] s, int k)
        {
            List<int> subset = s.Distinct().ToList(); 
            
            
            for (int i = 0; i < subset.Count; i++)
            {

                for (int j = i+1; j < subset.Count; j++)
                {

                    if ((subset[i] + subset[j]) % k == 0)
                    {
                        subset.Remove(subset[j]);
                    }
                }
            }
           
            return subset.Count();
        }
    }

}
