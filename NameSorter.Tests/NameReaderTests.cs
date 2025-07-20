using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NameSorter.App.Services;
using System.IO;

namespace NameSorter.Tests
{
    public class NameReaderTests
    {
        [Fact]
        public void ReadsNamesFromFile()
        {
            // Arrange create temp file
            var filePath = Path.GetTempFileName();
            File.WriteAllLines(filePath, new[]
            {
                "John Smith",
                "Alpha Romeo Juliet"
            });

            var reader = new NameReader();

            // Act
            var names = reader.ReadNames(filePath);

            // Assert
            Assert.Equal(2, names.Count);
            Assert.Equal("Alpha Romeo Juliet", names[1].ToString());
            //Assert.Equal("Alpha Romeo", names[1].ToString()); // Check fail test case
            Assert.Equal("Smith", names[0].LastName);
            Assert.Equal("Juliet", names[1].LastName);

            // Cleanup
            File.Delete(filePath);
        }

        [Fact]
        public void ThrowsOnMissingFile()
        {
            // Not Found
            var reader = new NameReader();
            Assert.Throws<FileNotFoundException>(() => reader.ReadNames("missing.txt"));
        }
    }
}

