using System;
using Xunit;
using System.IO;

namespace App.Tests
{
    public class PromptUsertest
    {
        [Fact]
        public void Main_prints_Hello_World()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            PromptUser.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            // Assert
            Assert.Equal("Type in a year to learn if it is a leapyear!", output);
        }
    }
}
