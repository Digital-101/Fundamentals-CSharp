using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundamentalsCS._21_High_Quality_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._21_High_Quality_Code.Tests
{
    [TestClass]
    public class SumatorTests
    {
        Sumator Sumator_Accessor = new Sumator();

        [TestMethod]
        public void SumTestTypicalCase()
        {
            //Arrange
            int[] numbers = new int[] { 1, 2};
            long expected = 3;
            long actual = Sumator_Accessor.Sum(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SumTestOverFlow()
        {
            int[] numbers = new int[] { 2000000000, 2000000000 };
            long expected = 4000000000;
            long actual = Sumator_Accessor.Sum(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SumTestNullArray()
        {
            Sumator_Accessor.Sum(null);
        }

        //
        //[TestMethod()]
        //public void SumTest()
        //{
        //    Assert.Fail();
        //}
    }
}