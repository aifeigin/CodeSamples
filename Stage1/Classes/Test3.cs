using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    public enum Direction {  North, Ost, South, West };
    public class Solution
    {
        bool hasIntersection(ref int x, ref int y, int[,] field, Direction direction,int length)
        {
            int[] xIncrements = new int[] { 0, 1, 0, -1};
            int[] yIncrements = new int[] { 1, 0, -1, 0 };

            int xIncrement = xIncrements[(int)direction];
            int yIncrement = yIncrements[(int)direction];
            int offset=0;
            int i, j;
            for(i=x,j=y;offset<length;i+=xIncrement,j+=yIncrement)
            {
                if(field[i,j]==1)
                    return true;
                else
                    field[i,j]=1;
                offset++;
            }
            x = i;
            y = j;
            return false;
        }
        public int solution(int[] A)
        {
            int maxV = 0, maxH = 0, maxVer = 0, maxHor = 0;
            Direction[] directions = new Direction[] { Direction.North, Direction.Ost, Direction.South, Direction.West };
            for(int i=0;i<A.Length;i++)
            {
               switch (directions[i % 4])
               {
                   case Direction.North:
                   {                       
                       maxV+=A[i];
                       if (A[i]  > maxVer)
                           maxVer = A[i] ;
                       break;
                   }
                   case Direction.Ost:
                   {
                       maxH-=A[i];
                       if (A[i]> maxHor)
                           maxHor = A[i];
                       break;
                   }
                   case Direction.South:
                   {
                       maxV-=A[i];
                       if (A[i] > maxVer)
                           maxVer = A[i];
                       break;
                   }
                   case Direction.West:
                   {
                       maxH += A[i];
                       if (A[i] > maxHor)
                           maxHor = A[i];
                       break;
                   }
               } 
            }
            if(maxVer<Math.Abs(maxV))
            {
                maxVer = Math.Abs(maxV);
            }
            if (maxHor < Math.Abs(maxH))
            {
                maxHor = Math.Abs(maxH);
            }
            int[,] field = new int[maxHor * 2+1, maxVer * 2+1];
            int x = maxHor / 2, y = maxVer/2;            
            for (int i = 0; i < A.Length; i++)
            {
                if (hasIntersection(ref x, ref y, field, directions[i % 4], A[i]))
                    return i+1;
            }
            return -1;
        }

        public int Test1()
        {
            int[] A=new int[] { 1, 3, 2, 5, 4, 4, 6, 3, 2};
            return solution(A);
        }

    }
}
