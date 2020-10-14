using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    class ArraysTest
    {
        Library.Arrays arrays = new Library.Arrays();

        [TestInitialize]
        public void Init()
        {
            Library.Arrays ars = new Library.Arrays();
            ars.numsList = new List<object>();
        }

        [TestMethod]
        public void TestMethodArray25()
        {
            float result = 2;
            float[] massive = { 1, 2, 4, 8 };
            Assert.AreEqual(result, arrays.Array25(massive));
        }
        [TestMethod]
        public void TestMethodArray13()
        {
            int[] massive = { 1, 2, 4, 8 ,10};
            List<object> result = new List<object>();
            result.AddRange(new object[] {10, 4, 1 });
            Assert.AreEqual(result, arrays.Array13(massive));
        }
    }
}
