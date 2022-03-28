using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

using System;

namespace WorkUnitTestProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void  Test_Assignment_1()
        {
            //ข้อ 1 
            AssignmentClass ac = new AssignmentClass();
            int input = 1020;
            string result = ac.GradeCalculate(input);
            Assert.AreEqual("A", result);
            result = ac.GradeCalculate(80);
            Assert.AreEqual("A", result);
            result = ac.GradeCalculate(-1);
            Assert.AreEqual("F", result);
            result = ac.GradeCalculate(79);
            Assert.AreEqual("B+", result);
            result = ac.GradeCalculate(49);
            Assert.AreEqual("F", result);

        }
        [TestMethod]
        public void Test_Assignment_2()
        {
            //ข้อ 2 
            AssignmentClass ac = new AssignmentClass();
            double result = ac.GetDistance(3, 2, 7, 8);
            Assert.AreEqual(7.21, result);
            result = ac.GetDistance(-3, 2, 7, -8);
            Assert.AreEqual(14.14, result);
            result = ac.GetDistance(-3, -2, -7, -8);
            Assert.AreEqual(7.21, result);
            result = ac.GetDistance(3, -2, -7, 8);
            Assert.AreEqual(14.14, result);
        }
        [TestMethod]
        public void Test_Assignment_3()
        {
            //ข้อ 3 
            AssignmentClass ac = new AssignmentClass();
            int n = ac.GetFactorial(5);
            Assert.AreEqual(120, n);
            n = ac.GetFactorial(1);
            Assert.AreEqual(1, n);
            n = ac.GetFactorial(0);
            Assert.AreEqual(1, n);
            n = ac.GetFactorial(-1);
            Assert.AreEqual(1, n);
        }
        [TestMethod]
        public void Test_Assignment_4()
        {
            //ข้อ 4
            AssignmentClass ac = new AssignmentClass();
            string password = ac.CheackPassword("abc12345");
            Assert.AreEqual("True", password);
            password = ac.CheackPassword("abc123");
            Assert.AreEqual(" ", password);
            password = ac.CheackPassword("abcdefgh");
            Assert.AreEqual(" ", password);
            password = ac.CheackPassword("12345678");
            Assert.AreEqual(" ", password);
        }
    }
}