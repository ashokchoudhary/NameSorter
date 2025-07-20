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
    /// Sorts names by last name, then given names.
    /// </summary>
    public class NameSorterService : INameSorter
    {
        public List<PersonName> Sort(List<PersonName> names)
        {
            if (names == null) throw new ArgumentNullException(nameof(names));

            return names.OrderBy(p => p.LastName)
                        .ThenBy(p => string.Join(" ", p.GivenNames))
                        .ToList();
        }
    }
}

