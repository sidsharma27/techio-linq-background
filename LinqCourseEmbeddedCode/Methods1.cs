using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LinqCourseEmbeddedCode
{
    [TestClass]
    public class Methods1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //// START EMBED: First() ////
            List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3 };
            double whatsThis = doubles.First();
            //// END EMBED ////
            Assert.AreEqual(2.0, whatsThis);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //// START EMBED: Last() ////
            List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3 };
            double whatsThis = doubles.Last();
            //// END EMBED ////
            Assert.AreEqual(2.3, whatsThis);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //// START EMBED: ElementAt() ////
            List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3 };
            double whatsThis = doubles.ElementAt(2);
            //// END EMBED ////
            Assert.AreEqual(2.2, whatsThis);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMethod5()
        {
            //// START EMBED: Single() ////
            List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3 };
            double whatsThis = doubles.Single();
            //// END EMBED ////
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMethod2()
        {
            //// START EMBED: First() - condition ////
            List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3 };
            double whatsThis = doubles.First(val => val > 2.3);
            //// END EMBED ////
        }

        [TestMethod]
        public void TestMethod6()
        {
            //// START EMBED: Last() - condition ////
            List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3 };
            double whatsThis = doubles.Last(val => val < 2.1);
            //// END EMBED ////
            Assert.AreEqual(2.0, whatsThis);
        }

        [TestMethod]
        public void TestMethod7()
        {
            //// START EMBED: Single() - condition ////
            List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3 };
            double whatsThis = doubles.Single(val => val > 2.2);
            //// END EMBED ////
            Assert.AreEqual(2.3, whatsThis);
        }
    }
}