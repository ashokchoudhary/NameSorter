using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NameSorter.App.Models;
using NameSorter.App.Services;

namespace NameSorter.Tests
{
    public class NameSorterServiceTests
    {
        /// <summary>
        /// Test case to sort
        /// </summary>
        [Fact]
        public void SortsByLastNameThenGivenNames()
        {
            // Arrange
            var unsorted = new List<PersonName>
            {
                new PersonName("Hunter Uriah Mathew Clarke"),
                new PersonName("Leo Gardner"),
                new PersonName("Vaughn Lewis"), // Same last name as Charlie
                new PersonName("Beau Tristan Bentley")
            };

            var sorter = new NameSorterService();

            // Act
            var sorted = sorter.Sort(unsorted);

            // Assert
            Assert.Equal("Beau Tristan Bentley", sorted[0].ToString());
            Assert.Equal("Hunter Uriah Mathew Clarke", sorted[1].ToString());
            Assert.Equal("Leo Gardner", sorted[2].ToString());
            Assert.Equal("Vaughn Lewis", sorted[3].ToString());
        }

        /// <summary>
        /// Test case if input list is null
        /// </summary>
        [Fact]
        public void Sort_ThrowsIfInputIsNull()
        {
            var sorter = new NameSorterService();
            Assert.Throws<ArgumentNullException>(() => sorter.Sort(null));
        }
    }
}
