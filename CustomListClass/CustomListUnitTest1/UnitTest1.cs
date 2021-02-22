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
            actual = firstCheck.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void Add_OneToCount()
        {
            //Arrange
            CustomList<int> addOne = new CustomList<int>();
            int expected = 1;
            int actual;

            //Act
            actual = addOne.Count;
            addOne.Count++;

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
            actual = addExtra.Count;
            if (addExtra.Count < 5)
            {
                addExtra.Count++;
            }
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
            actual = oops.Count;
            if (oops.Count < 5)
            {
                oops.Count++;
            }
            Assert.AreEqual(expected, actual);

        }
    }
}
