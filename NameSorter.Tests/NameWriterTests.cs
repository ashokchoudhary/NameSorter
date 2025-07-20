using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NameSorter.App.Models;
using NameSorter.App.Services;

namespace NameSorter.Tests
{
    public class NameWriterTests
    {
        [Fact]
        public void WritesSortedNamesToFile()
        {
            // Arrange
            var names = new List<PersonName>
            {
                new PersonName("Hunter Uriah Mathew Clarke"),
                new PersonName("Leo Gardner"),
                new PersonName("Vaughn Lewis"), 
                new PersonName("Beau Tristan Bentley")
            };

            var outputPath = Path.GetTempFileName();
            var writer = new NameWriter();

            // Act
            writer.Write(names, outputPath);

            // Assert
            var lines = File.ReadAllLines(outputPath);
            Assert.Equal(4, lines.Length);
            Assert.Contains("Beau Tristan Bentley", lines);
            Assert.Contains("Hunter Uriah Mathew Clarke", lines);
            Assert.Contains("Leo Gardner", lines);
            Assert.Contains("Vaughn Lewis", lines);

            // Clean up
            File.Delete(outputPath);
        }

        [Fact]
        public void HandlesEmptyListGracefully()
        {
            var outputPath = Path.GetTempFileName();
            var writer = new NameWriter();

            // Should not throw
            writer.Write(new List<PersonName>(), outputPath);

            // Clean up
            File.Delete(outputPath);
        }
    }
}
