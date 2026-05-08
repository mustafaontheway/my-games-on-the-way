Calculus c = new Calculus(11, -7); // Calculus class creation started...

c.Sum();

c.Subtract();

// Sum: 4
// Subtraction: 18

class Calculus
{
    private int _number1;
    private int _number2;
  
    public Calculus(int number1, int number2) // constructor
    {
        _number1 = number1;
        _number2 = number2;
        System.Console.WriteLine("Calculus class creation started with numbers...");
    }

    public void Sum()
    {
        System.Console.WriteLine($"Sum: {_number1 + _number2}");
    }

    public void Subtract()
    {
        System.Console.WriteLine($"Subtraction: {_number1 - _number2}");
    }
}

// dotnet run
