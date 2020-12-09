using System;
using NUnit.Framework;
using DateTimeHelperLib;

namespace DateTimeHelperTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FirstOfMonthTest()
        {
            DateTime date = new DateTime(1978, 5, 17);
            DateTime firstInMonth = date.FirstInMonth();
            Assert.AreEqual(firstInMonth, new DateTime(1978, 5, 1));
        }

        [Test]
        public void LastInMonthTest()
        {
            DateTime date = new DateTime(1978, 5, 17);
            DateTime firstInMonth = date.LastInMonth();
            Assert.AreEqual(firstInMonth, new DateTime(1978, 5, 31));
        }
    }
}