using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Solution
    {
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
        public int solution(int X, int[] A)
        {
            for(int k=0;k<A.Length;k++)
            {
                if (isK(X, A, k))
                    return k;
            }
            return -1;
        }

        public int Test1()
        {
            int[] A = new int[] { 5, 5, 1, 7, 2, 3, 5 };
            return solution(5,A);
        }
        public int Test2()
        {
            int[] A = new int[100000];
            for(int i=0;i<A.Length;i++)
                A[i]=100000;
            return solution(5, A);
        }
    }
}
