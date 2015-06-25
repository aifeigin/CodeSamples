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
            try
            { 
            if(args[0]=="demo")
            { 
                var demo = new Demo.Solution();
                int[] A = new int[] { Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue };
                Console.WriteLine(demo.solution(A));
                Console.WriteLine("Demo passed");
            }
            if(args[0]=="test1")
            { 
                var test1 = new Test1.Solution();
                Console.WriteLine(test1.Test1());
                Console.WriteLine(test1.Test2());
                Console.WriteLine("Test 1 passed");
            }
            if (args[0] == "test2")
            {
                var test2 = new Test2.Solution();
                test2.Test1();
                test2.Test2();
                test2.Test3();
                Console.WriteLine("Test 2 passed");
            }
            if (args[0] == "test3")
            {
                var test3 = new Test3.Solution();
                Console.WriteLine(test3.Test1());
            }
           }
           catch(Exception ex)
           {
               Console.WriteLine("Something wrong");
               Console.WriteLine(ex.Message);               
           }
           Console.WriteLine("Press any key to finish");
           Console.ReadLine();
        }
    }
}
