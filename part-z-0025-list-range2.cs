using System.Collections.Generic;

using System.Text.Json;

var points = new List<byte>
{
    45, 77, 23, 79, 92, 66, 72
};

points.AddRange(new byte[] {98, 95, 94, 32, 24});

var successPoints = new List<byte>();

var failPoints = new List<byte>();

foreach (var point in points)
{
    if (point >= 70)
    {
        successPoints.Add(point);
    }
    else
    {
        failPoints.Add(point);
    }
}

Console.WriteLine(JsonSerializer.Serialize(successPoints));
Console.WriteLine(JsonSerializer.Serialize(failPoints));

// [77,79,92,72,98,95,94]
// [45,23,66,32,24]

//dotnet run
