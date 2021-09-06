using System;
using Xunit;

namespace App.Tests
{
    public class Leapyeartest
    {
        [Fact]
        public void isLeapYear_returns_true()
        {

            var leapyear = new Leapyear();
            //Assert
            Assert.True(leapyear.isLeapYear(2000));
            Assert.True(leapyear.isLeapYear(2004));
            Assert.True(leapyear.isLeapYear(2008));
            Assert.True(leapyear.isLeapYear(2012));
            Assert.True(leapyear.isLeapYear(2016));
            Assert.True(leapyear.isLeapYear(2020));
            Assert.True(leapyear.isLeapYear(2024));
            Assert.True(leapyear.isLeapYear(2028));
        }
        public void isLeapYear_returns_false() 
        {
            var leapyear = new Leapyear();
            Assert.False(leapyear.isLeapYear(2003));
            Assert.False(leapyear.isLeapYear(2007));
            Assert.False(leapyear.isLeapYear(2009));
            Assert.False(leapyear.isLeapYear(2013));
            Assert.False(leapyear.isLeapYear(2017));
            Assert.False(leapyear.isLeapYear(1700));
        }
    }
}
