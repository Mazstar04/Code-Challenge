using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestSubset
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(LongestSubset(new int[] { 19, 10,  12, 24, 10,  25, 22 }, 4));
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
