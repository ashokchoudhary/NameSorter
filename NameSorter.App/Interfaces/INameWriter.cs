using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NameSorter.App.Models;

namespace NameSorter.App.Interfaces
{
    /// <summary>
    /// Contract for writing names to output.
    /// </summary>
    //
    public interface INameWriter
    {
        /// <summary>
        /// Writes list of names to console and file.
        /// </summary>
        /// <param name="names">List<PersonName> Sorted list</param>
        /// <param name="outputFilePath">string File path to write the sorted names to</param>
        void Write(List<PersonName> names, string outputFilePath);
    }
}
