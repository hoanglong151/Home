using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool res03 = Program.IsOdd(3);
            Assert.AreEqual(true, res03);
            bool res04 = Program.IsOdd(4);
            Assert.AreEqual(false, res04);

        }
        [TestMethod]
        public void TestMethod2()
        {
            bool res03 = Program.IsEven(3);
            Assert.AreEqual(false, res03);
            bool res04 = Program.IsEven(4);
            Assert.AreEqual(true, res04);
        }
        [TestMethod]
        public void TestMethod3()
        {
            bool res03 = Program.IsPrime(3);
            Assert.AreEqual(true, res03);
            bool res04 = Program.IsPrime(4);
            Assert.AreEqual(false, res04);
        }
        [TestMethod]
        public void TestCeil()
        {
            int result1 = Program.Ceil((float)2.3);
            Assert.AreEqual(3, result1);
            int result2 = Program.Ceil(-2.3f);
            Assert.AreEqual(-2, result2);
            int result3 = Program.Ceil(3);
            Assert.AreEqual(3, result3);
        }
        [TestMethod]
        public void TestFloor()
        {
            int result1 = Program.Floor((float)2.3);
            Assert.AreEqual(2, result1);
            int result2 = Program.Floor((float)-3.4);
            Assert.AreEqual(-4, result2);
            int result3 = Program.Floor(5);
            Assert.AreEqual(5, result3);
        }
        [TestMethod]
        public void TestSquare()
        {
            int res03 = Program.Square(1);
            Assert.AreEqual(1, res03);
            int res04 = Program.Square(2);
            Assert.AreEqual(4, res04);
        }
        [TestMethod]
        public void TestCube()
        {
            int res03 = Program.Cube(3);
            Assert.AreEqual(27, res03);
            int res04 = Program.Cube(2);
            Assert.AreEqual(8, res04);
        }
        [TestMethod]
        public void Testabs()
        {
            int res03 = Program.abs(-3);
            Assert.AreEqual(3, res03);
            int res04 = Program.abs(2);
            Assert.AreEqual(2, res04);
        }
        [TestMethod]
        public void TestPow()
        {
            int res03 = Program.pow(2,3);
            Assert.AreEqual(8, res03);
            int res04 = Program.pow(3,2);
            Assert.AreEqual(9, res04);
        }
        [TestMethod]
        public void TestFactorial()
        {
            long res03 = Program.Factorial(2);
            Assert.AreEqual(2 , res03);
            long res04 = Program.Factorial(3);
            Assert.AreEqual(6, res04);
        }
    }
}