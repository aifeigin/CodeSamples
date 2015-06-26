using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1_TestMethod1()
        {
            var test = new Test1.Solution();
            int[] A = new int[] { 5, 5, 1, 7, 2, 3, 5 };
            Assert.AreEqual(test.solution(5,A), 4);
        }
        [TestMethod]
        public void Test1_TestMethod2()
        {
            var test = new Test1.Solution();
            int[] A = new int[100000];
            for (int i = 0; i < A.Length; i++)
                A[i] = 100000;
            Assert.AreEqual(test.solution(100000, A), -1);
        }
        [TestMethod]
        public void Test1_TestMethod3()
        {
            var test = new Test1.Solution();
            int[] A = new int[100000];
            for (int i = 0; i < A.Length; i++)
                if (i < A.Length / 2)
                    A[i] = 100000;
            Assert.AreEqual(test.solution(100000, A), 49999);
        }

        bool IsEqual(int[] array1,int[] array2)
        {
            if (array1.Length != array2.Length)
                return false;
            for(int i = 0;i<array1.Length;i++)
            {
                if (array1[i] != array2[i])
                    return false;
            }
            return true;
        }

        [TestMethod]
        public void Test2_TestMethod1()
        {
            var test = new Test2.Solution();
            int[] A = new int[] { 1, 0, 0, 1, 1 };
            int[] negA = test.solution(A);
            Assert.AreEqual(IsEqual(A,test.solution(negA)), true);
        }
        [TestMethod]
        public void Test2_TestMethod2()
        {
            var test = new Test2.Solution();
            int[] A = new int[] { 0, 0, 0, 0, 0, 1 };
            int[] negA = test.solution(A);
            Assert.AreEqual(IsEqual(A, test.solution(negA)), true);
        }
        [TestMethod]
        public void Test2_TestMethod3()
        {
            var test = new Test2.Solution();
            int[] A = test.Decimal2Base(100000);
            int[] negA = test.solution(A);
            Assert.AreEqual(IsEqual(A, test.solution(negA)), true);
        }
        [TestMethod]
        public void Test3_TestMethod1()
        {
            var test = new Test3.Solution();
            int[] A = new int[] { 1, 3, 2, 5, 4, 4, 6, 3, 2 };
            Assert.AreEqual(test.solution(A), 7);
        }
        [TestMethod]
        public void Test3_TestMethod2()
        {
            var test = new Test3.Solution();
            int[] A = new int[] { 1, 3, 2, 5, 4, 4, 6, 3, 2 };
            int[] B = new int[100000];
            for (int i = 0; i < B.Length; i++)
                B[i] = A[i % A.Length];
            Assert.AreEqual(test.solution(B), 7);
        }
    }
}
