byte[] ages = {11, 14, 37, 47, 73, 102, 79};

byte minAge = byte.MaxValue;

System.Console.WriteLine(minAge); // 255

foreach (var age in ages)
{
    if (age < minAge)
    {
        minAge = age;
    }
}

System.Console.WriteLine(minAge); // 11
