using NameSorter.App.Interfaces;
using NameSorter.App.Services;

// Fetch argument parameter
var inputFile = args.Length > 0 ? args[0] : null;
if (string.IsNullOrWhiteSpace(inputFile))
{
    Console.WriteLine("Command: NameSorter InputFilePath");
    return;
}

var outputFile = "sorted-names-list.txt";

// Instantiate services
INameReader reader = new NameReader();
INameSorter sorter = new NameSorterService();
INameWriter writer = new NameWriter();

try
{
    // Get file path
    string absolutePath = Path.GetFullPath(inputFile);
    if (!File.Exists(absolutePath))
    {
        throw new FileNotFoundException("Input file not found.", absolutePath);
    }

    // Read data from file
    var names = reader.ReadNames(inputFile);
    // Sort data
    var sorted = sorter.Sort(names);
    // Write data to output file
    writer.Write(sorted, outputFile);
    Console.WriteLine($"\nSorted names saved to '{outputFile}'");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Error occurred: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error occurred: {ex.Message}");
}
