using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NameSorter.App.Models;

namespace NameSorter.App.Interfaces
{
    /// <summary>
    /// Contract for sorting logic.
    /// </summary>
    public interface INameSorter
    {
        /// <summary>
        /// Sorts the PersonName by last name, then given names.
        /// </summary>
        List<PersonName> Sort(List<PersonName> names);
    }
}
