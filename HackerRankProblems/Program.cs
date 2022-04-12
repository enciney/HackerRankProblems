using System;
using System.Linq;
using System.Collections.Generic;

namespace HackerRankProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var x = sockMerchant(11, new List<int> { 10, 20, 10, 30, 30, 40, 10,40,50,50,10 });
            var y = countingValleys(8, "DUUDDUUD");

        }


        /*
        * Complete the 'sockMerchant' function below.
        *
        * The function is expected to return an INTEGER.
        * The function accepts following parameters:
        *  1. INTEGER n
        *  2. INTEGER_ARRAY ar
        */
        //https://www.hackerrank.com/challenges/sock-merchant/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
        public static int sockMerchant(int n, List<int> ar)
        {
            var x = ar.GroupBy(d => d).Select(c => c.Count());
            return x.Select(d => (int)(d/2)).Sum();

        }
        /*
        * Complete the 'countingValleys' function below.
        *
        * The function is expected to return an INTEGER.
        * The function accepts following parameters:
        *  1. INTEGER steps
        *  2. STRING path
        */
        //https://www.hackerrank.com/challenges/counting-valleys/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup&h_r=next-challenge&h_v=zen
        public static int countingValleys(int steps, string path)
        {
            var actualPath = path.ToCharArray().Select(s =>
            {
               if (s == 'U')
               {
                   return 1;
               }

               else if (s == 'D')
               {
                   return -1;
               }

               return 0;
            }).ToArray();
            var oneStepAhead = actualPath[0];
            var current = 0;
            var count = 0;
            for(int i = 1; i < steps; i++)
			{
                if (current >= 0 && oneStepAhead < 0)
                {
                    count++;
                }
                current = oneStepAhead;
                oneStepAhead += actualPath[i];
			}

            return count;

        }


    }
}
