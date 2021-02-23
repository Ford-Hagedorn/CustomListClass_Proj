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
            actual = addOne.count;
            addOne.count++;

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
            actual = addExtra.count;
            
            
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
            actual = oops.count;
            oops.count++;
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
            actual = nothingNew.count;
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
            actual = timesTwo.count * 2;
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
            actual = minusOne.count;
            minusOne.count--;
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
            actual = minusExtra.count;
            minusExtra.count--;
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
            actual = oopsies.count;
            oopsies.count--;
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
            actual = nothingLost.count;
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
            actual = divideByTwo.count / 2;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
