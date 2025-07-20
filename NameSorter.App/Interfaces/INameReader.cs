using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NameSorter.App.Models;

namespace NameSorter.App.Interfaces
{
    /// <summary>
    /// Interface contract to be consumed mocking and feature extention
    /// </summary>
    public interface INameReader
    {
        List<PersonName> ReadNames(string filePath);
    }
}
