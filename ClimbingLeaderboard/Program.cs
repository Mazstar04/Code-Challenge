using System;
using System.Linq;

namespace DinbingLeaderboard
{
    class Program
    {
        static void Main(string[] args)
        {
            ClimbingLeaderBoard(new int[]{100, 100, 50, 40, 40, 20, 10}, new int[]{5, 25, 50, 120});
            Console.WriteLine("Hello World!");
        }

        public static int[] ClimbingLeaderBoard(int[]ranked, int[]scores)
        {

            int[] position = new int[ranked.Length];
            position[0] = 1;
            for(int i = 1; i<ranked.Length; i++)
            {
                if(ranked[i] >= ranked[i-1])
                {
                    position[i] = position[i-1];
                }
                else{
                    position[i] = position[i-1] + 1;
                }
            }

            int[] ranks = new int[scores.Length];
            for(int i = 0; i< scores.Length; i++)
            {
                for(int j = 0; j<ranked.Length; j++)
                {
                    if(scores[i] < ranked.Min())
                    {
                        ranks[i] = position.Max() + 1;
                    }
                    else if(scores[i] >= ranked[j])
                    {
                        ranks[i] = position[j];
                        break;
                    }
                }
            }

            foreach(var item in ranks)
            {
                Console.WriteLine(item);
            }
            return new int[5];
        }
    }
}
