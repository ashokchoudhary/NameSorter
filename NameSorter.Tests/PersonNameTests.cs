using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NameSorter.App.Models;

namespace NameSorter.Tests
{
    public class PersonNameTests
    {
        [Fact]
        public void ParsesValidName()
        {
            // Arrange and Act
            var person = new PersonName("Alpha Romeo Juliet");
            
            // Assert
            Assert.Equal("Juliet", person.LastName);
            Assert.Equal(new[] { "Alpha", "Romeo" }, person.GivenNames);
            Assert.Equal("Alpha Romeo Juliet", person.ToString());
        }

        [Theory]
        [InlineData("")]
        [InlineData("  ")]
        [InlineData("Juliet")]
        public void ThrowsOnInvalidName(string name)
        {
            Assert.Throws<ArgumentException>(() => new PersonName(name));
        }
    }
}

