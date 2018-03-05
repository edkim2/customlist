using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestingCountInAddMethod()
        {

            customList<int> list = new customList<int>();
            // arrange
            int expected = 5;
            int actual;

            // act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            actual = list.Count; // list.count should equal 5 here beacause the User added 5 items.

            // assert
            Assert.AreEqual(expected, actual); 

        }

        [TestMethod]
        public void AddTest()
        {
            customList<int> list = new customList<int>();

            // arrange
            int expected = 50;
            int actual;

            // act
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            actual = list[4];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveTest()
        {
            customList<int> list = new customList<int>();

            // arrange
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            int expected = 40;

            //int[] testArray = new int[5] {10, 20, 30, 40, 50 };

            // act
            list.Remove(30);
            int actual = list[2];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveException()
        {
            customList<int> list = new customList<int>();

            // arrange
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);


            // act
            list.Remove(30);
            int actual = list[4];

            // assert
        }

        [TestMethod]
        public void RemoveCountTest()
        {
            customList<int> list = new customList<int>();

            // arrange
            // int[] testArray = new int[5] { 10, 20, 30, 40, 50 };
            int expected = 4;
            int actual;
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            // act
            list.Remove(30);
            actual = list.Count;
            // assert
            Assert.AreEqual(expected, actual);

        }
    }
}
