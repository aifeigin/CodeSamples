using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    public class Soluition
    {
        public void sort(int[] array,int lowIndex,int highIndex)
        {
            var median = array[(highIndex + lowIndex) / 2];
            var i=lowIndex;
            var j=highIndex;
            while(i<j)
            {
                while (array[i] < median) i++;
                while (array[j] > median) j--;
                if(i<=j)
                {
                    var t = array[i];
                    array[i] = array[j];
                    array[j] = t;
                    i++;
                    j--;
                }
            }
            if (lowIndex < j)
                sort(array, lowIndex, j);
            if (i<highIndex)
                sort(array, i, highIndex);
        }
    }
}
