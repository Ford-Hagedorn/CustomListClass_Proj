using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListClass;

namespace CustomListUnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckListCapacity()
        {
            //Arrange
            CustomList<int> firstCheck = new CustomList<int>();
            int expected = 4;
            int actual;
            //Act
            actual = firstCheck.capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Adding Method Tests
        [TestMethod]

        public void Add_OneToCount()
        {
            //Arrange
            CustomList<int> addOne = new CustomList<int>();
            int expected = 1;
            int actual;

            //Act
            addOne.Add(1);
            actual = addOne.Count;
             

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void Add_Multiple()
        {
            //Arrange
            CustomList<int> addExtra = new CustomList<int>();
            int expected = 5;
            int actual;
            //Act
            addExtra.Add(5);
            actual = addExtra.Count;
            
            
            //Assert
            Assert.AreEqual(expected, actual);
            

        }
        [TestMethod]

        public void Add_Invalid()
        {
            //Arrange
            CustomList<int> oops = new CustomList<int>();
            int expected = 6;
            int actual;
            //Act
            oops.Add(2);
            actual = oops.Count;
            
            //Assert
            Assert.AreNotEqual(expected, actual);

        }
        [TestMethod]

        public void Add_Nothing()
        {
            //Arrange
            CustomList<int> nothingNew = new CustomList<int>();
            int expected = 0;
            int actual;
            //Act
            actual = nothingNew.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void Add_DoubleCount()
        {
            //Arrange
            CustomList<int> timesTwo = new CustomList<int>();
            int expected = 8;
            int actual;
            //Act
            actual = timesTwo.Count * 2;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Removing Method Tests
        [TestMethod]

        public void Remove_One()
        {
            //Arrange
            CustomList<int> minusOne = new CustomList<int>();
            int expected = -1;
            int actual;
            //Act
            minusOne.Remove(1);
            actual = minusOne.Count;
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void Remove_Multiple()
        {
            //Arrange
            CustomList<int> minusExtra = new CustomList<int>();
            int expected = -5;
            int actual;
            //Act
            minusExtra.Remove(5);
            actual = minusExtra.Count;
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void Remove_Invalid()
        {
            //Arrange
            CustomList<int> oopsies = new CustomList<int>();
            int expected = -6;
            int actual;
            //Act
            oopsies.Remove(4);
            actual = oopsies.Count;
            
            //Assert
            Assert.AreNotEqual(expected, actual);
        }
        [TestMethod]

        public void Remove_Nothing()
        {
            //Arrange
            CustomList<int> nothingLost = new CustomList<int>();
            int expected = 0;
            int actual;
            //Act
            actual = nothingLost.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void Remove_Half()
        {
            //Arrange
            CustomList<double> divideByTwo = new CustomList<double>();
            double expected = 0.5;
            double actual;
            //Act
            actual = divideByTwo.Count / 2;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
