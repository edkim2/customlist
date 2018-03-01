using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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

        public void TestMethod2()
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

    }
}
