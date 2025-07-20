using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NameSorter.App.Interfaces;
using NameSorter.App.Models;

namespace NameSorter.App.Services
{
    /// <summary>
    /// Implementation of all the interface methods
    /// </summary>
    public class NameReader : INameReader
    {
        /// <summary>
        ///     Contains:
        ///     Skip bad lines without crashing
        ///     Present error to user if any
        /// </summary>
        /// <param name="filePath">Path to source file</param>
        /// <returns>Valid List<PersonName> to further processing</returns>
        /// <exception cref="FileNotFoundException"></exception>
        public List<PersonName> ReadNames(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Input file not found.", filePath);

            // Skip empty lines
            var lines = File.ReadAllLines(filePath)
                            .Where(line => !string.IsNullOrWhiteSpace(line))
                            .ToList();

            // Add to the return list
            var people = new List<PersonName>();
            foreach (var line in lines)
            {
                try
                {
                    people.Add(new PersonName(line));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Skip line: \"{line}\" ({ex.Message})");
                }
            }

            return people;
        }
    }
}

