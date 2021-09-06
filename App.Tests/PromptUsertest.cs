using System;
using Xunit;
using System.IO;

namespace App.Tests
{
    public class PromptUsertest
    {
        [Fact]
        public void argumentexception_is_thrown() 
        {
            var leapyear = new Leapyear();
            Assert.Throws<ArgumentException>(new Action(()=>
            {
                leapyear.isLeapYear(100);
            }));
        }

        [Fact]
        public void FormatException_is_thrown() 
        {
            var leapyear = new Leapyear();
            Assert.Throws<FormatException>(new Action(()=>
            {
                leapyear.promptUser("string");
            }));
        }
    }
}
