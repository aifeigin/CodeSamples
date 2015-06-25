using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args[0]=="demo")
            { 
                var demo = new Demo.Solution();
                int[] A = new int[] { Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue };
                Console.WriteLine(demo.solution(A));
                Console.WriteLine("Demo passed");
                Console.ReadLine();
            }
            if(args[0]=="test1")
            { 
                var test1 = new Test1.Solution();
                Console.WriteLine(test1.Test1());
                Console.WriteLine(test1.Test2());
                Console.WriteLine("Test 1 passed");
                Console.ReadLine();
            }
            if (args[0] == "test2")
            {
                var test2 = new Test2.Solution();
                test2.Test1();
                test2.Test2();
                test2.Test3();
                Console.WriteLine("Test 2 passed");
                Console.ReadLine();
            }
            if (args[0] == "test3")
            {
                // to do
            }
        }
    }
}
