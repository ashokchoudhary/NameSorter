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
    /// Takes care of writing given list to console and a file.
    /// </summary>
    public class NameWriter : INameWriter
    {
        public void Write(List<PersonName> names, string outputFilePath)
        {
            if (names == null || names.Count == 0)
            {
                Console.WriteLine("No names to write.");
                return;
            }

            // Print to console
            Console.WriteLine("Sorted Names:");
            foreach (var name in names)
            {
                Console.WriteLine(name.ToString());
            }

            // Write to file (overwrite)
            File.WriteAllLines(outputFilePath, names.Select(name => name.ToString()));
        }
    }
}
