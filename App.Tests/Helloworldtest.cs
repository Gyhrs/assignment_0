using System;
using Xunit;
using System.IO;

namespace App.Tests
{
    public class Helloworldtest
    {
        [Fact]
        public void Main_prints_Hello_World()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Helloworld.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            // Assert
            Assert.Equal("Hello World!", output);
        }
    }
}
