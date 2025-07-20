using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.App.Models
{
    /// <summary>
    /// Personal name models. 
    /// Assumption that name with be splited by ' ' (space)
    /// </summary>
    public class PersonName
    {
        public List<string> GivenNames { get; }
        public string LastName { get; }

        public PersonName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Name cannot be null or empty.");

            var parts = fullName.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            // Check name has minimum 2 parts to be considered as valid name.
            if (parts.Length < 2)
                throw new ArgumentException("Must have at least one given and last name.");

            LastName = parts.LastOrDefault();
            GivenNames = parts.Take(parts.Length - 1).ToList();
        }

        /// <summary>
        /// Methods to concat the names again using override ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Join(" ", GivenNames.Append(LastName));
        }
    }
}

