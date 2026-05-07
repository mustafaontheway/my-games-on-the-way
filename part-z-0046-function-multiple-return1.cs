sbyte[] posOrNeg = {12, -5, 4, -7, 11, -3, 9, 75, };

var (maxVal, minVal) = findMaxMin(posOrNeg);

System.Console.WriteLine($"Max number: {maxVal}");

System.Console.WriteLine($"Min number: {minVal}");


static (sbyte, sbyte) findMaxMin(sbyte[] nums)
{
    sbyte minVal = sbyte.MaxValue;

    sbyte maxVal = sbyte.MinValue;

    foreach (var num in nums)
    {
        if (num > maxVal)
        {
            maxVal = num;
        }

        if (num < minVal)
        {
            minVal = num;
        }
    }

    return (maxVal, minVal);
}

// Max number: 75
// Min number: -7
