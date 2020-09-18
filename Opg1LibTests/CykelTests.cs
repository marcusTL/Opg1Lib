using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opg1Lib;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opg1Lib.Tests
{
    [TestClass()]
    public class CykelTests
    {
        private Cykel c1;
        //Method that all tests will begin with
        [TestInitialize]
        public void init()
        {
            c1 = new Cykel();
        }
        //The other tests give plenty of coverage when dealing with the conditions and validation
        //of the individual properties and values in the constructor.
        //I can therefore only think of testing whether the produced object is null or not. 
        [TestMethod()]
        public void ConstructerTest()
        {
            Assert.IsNotNull(c1);
        }
        [TestMethod()]
        public void ColorTest()
        {
            //arrange color as "r"
            c1.Color = "r";
            //Assert whether c1.color is "r"
            Assert.AreEqual(c1.Color,"r");
            //assert whether c1.color is 1 character long
            Assert.AreEqual(c1.Color.Length,1);
            //asset whether the conditions work
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => c1.Color = "");
        }

        [TestMethod()]
        public void PriceTest()
        {
            //arrange
            c1.Price = 1;
            //assert
            Assert.AreEqual(c1.Price,1);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => c1.Price = 0);
        }

        [TestMethod()]
        public void GearTest()
        {
            c1.Gear = 3;
            Assert.AreEqual(c1.Gear,3);

            c1.Gear = 32;
            Assert.AreEqual(c1.Gear,32);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => c1.Gear = 2);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => c1.Gear = 33);
        }
    }
}