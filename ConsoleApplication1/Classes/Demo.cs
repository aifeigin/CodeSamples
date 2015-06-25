using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    // you can also use other imports, for example:
    // using System.Collections.Generic;

    // you can use Console.WriteLine for debugging purposes, e.g.
    // Console.WriteLine("this is a debug message");

    public class Solution
    {
        public int solution(int[] A)
        {
            Int64 totalA = 0;
            foreach (int elem in A)
                totalA += elem;
            Int64 currentTotal = 0, leftTotal = totalA;
            for(int i=0;i<A.Length;i++)
            {
                leftTotal -= A[i];
                if (currentTotal == leftTotal)
                    return i;
                currentTotal += A[i];
            }
            return -1;
        }
    }
}
