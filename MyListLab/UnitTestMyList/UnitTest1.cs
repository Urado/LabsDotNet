using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyListLab;

namespace UnitTestMyList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BaseFunctionTest()
        {
            var myListInt = new MyList<int>();

            Assert.IsTrue(myListInt.Count == 0);

            myListInt.Add(0);
            Assert.IsTrue(myListInt[0] == 0);

            Assert.IsTrue(myListInt.Count == 1);


            myListInt.Add(1);
            Assert.IsTrue(myListInt[0] == 0);
            Assert.IsTrue(myListInt[1] == 1);

            Assert.IsTrue(myListInt.Count == 2);

            myListInt.Add(2);
            Assert.IsTrue(myListInt[0] == 0);
            Assert.IsTrue(myListInt[1] == 1);
            Assert.IsTrue(myListInt[2] == 2);

            Assert.IsTrue(myListInt.Count == 3);


            myListInt.Clear();

            Assert.IsTrue(myListInt.Count == 0);

            myListInt.Add(4);
            Assert.IsTrue(myListInt[0] == 4);

            Assert.IsTrue(myListInt.Count == 1);


            myListInt.Add(5);
            Assert.IsTrue(myListInt[0] == 4);
            Assert.IsTrue(myListInt[1] == 5);

            Assert.IsTrue(myListInt.Count == 2);

            myListInt.Add(6);
            Assert.IsTrue(myListInt[0] == 4);
            Assert.IsTrue(myListInt[1] == 5);
            Assert.IsTrue(myListInt[2] == 6);
        }

        [TestMethod]
        public void IndexOfTest()
        {
            var myListInt = new MyList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Assert.IsTrue("1 2 3 4 5 6 7 8 9 10 " == myListInt.ToCheckString());

            Assert.IsTrue(myListInt.IndexOf(1) == 0);
            Assert.IsTrue(myListInt.IndexOf(10) == 9);
            Assert.IsTrue(myListInt.IndexOf(2) == 1);

            myListInt.Add(11);

            Assert.IsTrue(myListInt.IndexOf(1) == 0);
            Assert.IsTrue(myListInt.IndexOf(11) == 10);
            Assert.IsTrue(myListInt.IndexOf(10) == 9);

            Assert.IsTrue(myListInt.IndexOf(42) == -1);
        }

        [TestMethod]
        public void RemoveTest()
        {
            var myListInt = new MyList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Assert.IsTrue("1 2 3 4 5 6 7 8 9 10 " == myListInt.ToCheckString());

            Assert.IsTrue(myListInt.Contains(1));
            Assert.IsTrue(myListInt.Contains(5));
            Assert.IsTrue(myListInt.Contains(10));
            Assert.IsTrue(!myListInt.Contains(0));

            myListInt.RemoveAt(1);
            Assert.IsTrue(!myListInt.Contains(2));
            Assert.IsTrue("1 3 4 5 6 7 8 9 10 " == myListInt.ToCheckString());

            myListInt.RemoveAt(0);
            Assert.IsTrue(!myListInt.Contains(1));
            Assert.IsTrue("3 4 5 6 7 8 9 10 " == myListInt.ToCheckString());

            myListInt.RemoveAt(7);
            Assert.IsTrue(!myListInt.Contains(10));
            Assert.IsTrue("3 4 5 6 7 8 9 " == myListInt.ToCheckString());

            myListInt.RemoveAt(7);
            Assert.IsTrue(!myListInt.Contains(10));
            Assert.IsTrue("3 4 5 6 7 8 9 " == myListInt.ToCheckString());

            myListInt.RemoveAt(-1);
            Assert.IsTrue(!myListInt.Contains(10));
            Assert.IsTrue("3 4 5 6 7 8 9 " == myListInt.ToCheckString());

            myListInt.Remove(4);
            Assert.IsTrue(!myListInt.Contains(4));
            Assert.IsTrue("3 5 6 7 8 9 " == myListInt.ToCheckString());

            myListInt.Remove(3);
            Assert.IsTrue(!myListInt.Contains(3));
            Assert.IsTrue("5 6 7 8 9 " == myListInt.ToCheckString());
        }

        [TestMethod]
        public void InsertTest()
        {
            var myListInt = new MyList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            myListInt.Insert(10, 11);
            myListInt.Insert(0, 0);
            myListInt.Insert(5, 30);
            Assert.IsTrue("0 1 2 3 4 30 5 6 7 8 9 10 11 " == myListInt.ToCheckString());

        }

        [TestMethod]
        public void EnumeratorTest()
        {
            var myListInt = new MyList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string listString = "";
            foreach (var i in myListInt)
            {
                listString += i.ToString() + " ";
            }
            Assert.IsTrue("1 2 3 4 5 6 7 8 9 10 " == listString);

            myListInt.Clear();
            listString = "";

            foreach (var i in myListInt)
            {
                listString += i.ToString() + " ";
            }

            Assert.IsTrue("" == listString);
        }

        [TestMethod]
        public void ErrorTest()
        {
            var myListInt = new MyList<int>() { 1, 2, 3 };
        }
    }
}
