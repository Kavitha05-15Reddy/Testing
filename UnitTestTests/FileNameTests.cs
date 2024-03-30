using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Tests
{
    [TestClass()]
    public class FileNameTests
    {
        FileName f = new FileName();
        [TestMethod()]
        public void AddTest()
        {
            
            int res = f.Add(2, 4);
            int expected = 6;
            Assert.AreEqual(expected,res);
        }
        [TestMethod()]
        public void SubTest()
        {
            int res = f.Sub(10,5);
            int expected = 5;
            Assert.AreEqual(expected, res);
        }
        [TestMethod()]
        public void MulTest()
        {
            int res = f.Mul(10, 5);
            int expected = 50;
            Assert.AreEqual(expected, res);
        }
        [TestMethod()]
        public void DivTest()
        {
            int res = f.Div(10, 5);
            int expected = 2;
            Assert.AreEqual(expected, res);
        }
        //Strings
        [TestMethod()]
        public void ConcatTest()
        {
            string res = f.Concat("Hello", "World");
            string expected = "HelloWorld";
            Assert.AreEqual(expected, res);
        }
        [TestMethod()]
        public void SubStringTest()
        {
            string res = f.SubString("Hello World", 6);
            string expected = "World";
            Assert.AreEqual(expected, res);
        }
        [TestMethod()]
        public void ReplaceStringTest()
        {
            string res = f.ReplaceString("Hello World","World","Kavitha");
            string expected = "Hello Kavitha";
            Assert.AreEqual(expected, res);
        }
        [TestMethod()]
        public void ReverseStringTest()
        {
            string res = f.ReverseString("Hello");
            string expected = "olleH";
            Assert.AreEqual(expected, res);
        }
        [TestMethod()]
        public void PalindromeTest()
        {
            bool res = f.Palindrome("radar");
            Assert.IsTrue(res);
        }
        [TestMethod()]
        public void LengthStringTest()
        {
            int res = f.LengthString("Hello");
            int expected = 5;
            Assert.AreEqual(expected, res);
        }
        [TestMethod()]
        public void NullStringTest()
        {
            string input = null;
            Assert.ThrowsException<ArgumentNullException>(() => f.LengthString(input));
        }
        //Arrays
        [TestMethod()]
        public void SumTest()
        {
            //Arrange
            int[] numbers = { 1, 2, 3, 4, 5 };
            //Act
            int res = f.Sum(numbers);
            int expected = 15;
            //Assert
            Assert.AreEqual(expected, res);
        }
        [TestMethod()]
        public void AverageTest()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            double res = f.Average(numbers);
            double expected = 3; 
            Assert.AreEqual(expected, res);
        }
        [TestMethod()]
        public void MaxTest()
        {
            int[] numbers = { 5, 3, 7, 2, 8 };
            int res = f.Max(numbers);
            int expected = 8;
            Assert.AreEqual(expected, res);
        }
        [TestMethod()]
        public void MinTest()
        {
            int[] numbers = { 5, 3, 7, 2, 8 };
            int res = f.Min(numbers);
            int expected = 2;
            Assert.AreEqual(expected, res);
        }
        [TestMethod()]
        public void ReverseTest()
        {
            int[] numbers = { 5, 3, 7, 2, 8 };
            var res = f.Reverse(numbers);
            int[] expected = { 8, 2, 7, 3, 5 };
            CollectionAssert.AreEqual(expected, res);
        }
        [TestMethod()]
        public void SortTest()
        {
            int[] numbers = { 5, 3, 7, 2, 8 };
            var res = f.Sort(numbers);
            int[] expected = { 2, 3, 5, 7, 8 };
            CollectionAssert.AreEqual(expected, res);
        }
        [TestMethod()]
        public void CopyTest()
        {
            int[] arr1 = { 5, 3, 7, 2, 8 };
            int[] arr2 = { 5, 3, 7, 2, 8 };
            var res = f.Copy(arr1, arr2);
            CollectionAssert.AreEqual(arr2, res);
        }
        [TestMethod()]
        public void LengthTest()
        {
            int[] numbers = { 5, 3, 7, 2, 8 };
            int res = f.Length(numbers);
            int expected = 5;
            Assert.AreEqual(expected, res);
        }
        [TestMethod()]
        public void EmptyTest()
        {
            int[] numbers = { };
            Assert.ThrowsException<ArgumentException>(() => f.Length(numbers));
        }
    }    
}