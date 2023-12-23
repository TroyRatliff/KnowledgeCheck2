using System.Text.Json;


Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Guitar>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var guitar = new Guitar();

    Console.WriteLine("Enter the value for electric: ");
    guitar.electric = Console.ReadLine();

    Console.WriteLine("Enter the value for country: ");
    guitar.country = Console.ReadLine();



    recordList.Add(guitar);
}

// Print out the list of records using Console.WriteLine()
Console.WriteLine("Printing the values in recordList: ");
foreach (var guitar in recordList)
{
    string json = JsonSerializer.Serialize(guitar);
    Console.WriteLine(json);
}
public class Music
{
    public string country { get; set; }
}

public class Guitar : Music
{
    public string electric { get; set; }
}

