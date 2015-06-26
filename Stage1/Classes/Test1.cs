#define OPTIMIZED
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Solution
    {
#if !OPTIMIZED
        public bool isK(int X, int[] A, int k)
        {
            int equalCnt = 0, nonEqualCnt = 0;
            for (int i = 0; i < k; i++)
            {
                if (A[i] == X)
                    equalCnt++;
            }
            for (int i = k; i < A.Length; i++)
            {
                 if (A[i] != X)
                     nonEqualCnt++;
            }
            return equalCnt == nonEqualCnt;
        }
#endif
        public int solution(int X, int[] A)
        {
#if OPTIMIZED            
            List<int> nonEquailityIndex = new List<int>();
            int nonEqualityCounter = 0;

            for (int k = A.Length - 1; k >= 0; k--)
            {
                if (A[k] != X)
                    nonEqualityCounter++;
                nonEquailityIndex.Add(nonEqualityCounter);
            }
            int equalityCounter = 0;
            for (int k = 0; k < A.Length; k++)
            {
                if (A[k] == X)
                    equalityCounter++;
                if (equalityCounter > 0 && nonEquailityIndex.ElementAt(A.Length - k - 1) == equalityCounter)
                    return k;
            }
            return -1;
#else
            for(int k=0;k<A.Length;k++)
            {
                if (isK(X, A, k))
                   return k;
            }
#endif            
        }
    }
}
