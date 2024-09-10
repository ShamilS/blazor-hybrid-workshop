// This using statement needs to go in the top of the Monkey.cs file
using System.Text.Json;

// This using statement needs to go in the top of the Monkey.cs file
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace MonkeyFinderHybrid.Model;

public class Monkey
{
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Details { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public int Population { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}

// Make sure that this is outside of the Monkey class
[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(List<Monkey>))]
internal sealed partial class MonkeyContext : JsonSerializerContext
{
}