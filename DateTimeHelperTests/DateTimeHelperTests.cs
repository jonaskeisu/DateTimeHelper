using System;
using NUnit.Framework;
using DateTimeHelperLib;
using System.Collections.Generic;
using System.Linq;

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
            Assert.AreEqual(new DateTime(1978, 5, 1), firstInMonth);
        }

        [Test]
        public void LastInMonthTest()
        {
            DateTime date = new DateTime(1978, 5, 17);
            DateTime firstInMonth = date.LastInMonth();
            Assert.AreEqual(new DateTime(1978, 5, 31), firstInMonth);
        }

        [Test]
        public void EnumerateDaysTest()
        {
            DateTime date = new DateTime(1978, 5, 17);
            IEnumerable<DateTime> days = date.Days();
            CollectionAssert.AreEqual(
                new DateTime[] {
                    new DateTime(1978, 5, 17),
                    new DateTime(1978, 5, 18),
                    new DateTime(1978, 5, 19)
                },
                days.Take(3)    
            );
            
        }
    }
}