using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using LeapYearKata.Source;
using NUnit.Framework;

namespace LeapYearKata.Tests
{
    [TestFixture]
    public class LeapYearServiceShould
    {
        private readonly LeapYearService _leapYearService = new LeapYearService();

        [TestCase(16, true)]
        [TestCase(9, false)]
        [TestCase(41, false)]
        [TestCase(63, false)]
        [TestCase(100, false)]
        [TestCase(200, false)]
        [TestCase(300, false)]
        [TestCase(400, true)]
        [TestCase(800, true)]
        [TestCase(1200, true)]
        public void ReturnCorrectValue_WhenChecking(int year, bool expectedResult)
        {
            _leapYearService
                .IsLeapYear(year)
                .Should().Be(expectedResult);
        }
        
    }
}