using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class Solution
    {
        public int Base2Decimal(int[] bValue)
        {
            int base2 = 0, base2degree = 1;
            for (int i = 0;i<bValue.Length; i++)
            {
                base2 += bValue[i] * base2degree;
                base2degree *= -2;
            }
            return base2;
        }
        public int[] Decimal2Base(int dValue)
        {
            List<int> result = new List<int>();
            while (dValue != 0)
            {
                int modulus = dValue % -2;
                dValue = dValue / -2;

                if (modulus < 0)
                {
                    modulus += 2;
                    dValue += 1;
                }
                result.Add(modulus);
            }
            return result.ToArray();
        }
 
        public int[] solution(int[] A)
        {            
            int dValue   =  Base2Decimal(A);            

            int[] bValue =  Decimal2Base(-dValue);

            return bValue;
        }
    }
}
