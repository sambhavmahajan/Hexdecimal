# HexDecimal

HexDecimal is a simple C# library for converting between hexadecimal and decimal representations. It provides functionality to seamlessly convert hexadecimal strings to integers and vice versa.

## Features

- **Hexadecimal to Decimal Conversion:** Convert hexadecimal strings to their corresponding integer values.
- **Decimal to Hexadecimal Conversion:** Convert integer values to their corresponding hexadecimal strings.
- **Input Validation:** Ensure that input values are valid hexadecimal strings before performing conversion operations.

## Installation

To use HexDecimal in your C# projects, follow these steps:

1. Clone this repository to your local machine.
2. Include the `HexDecimal.cs` file in your C# project.
3. Ensure that the namespace `HexDecimal` is accessible in your project.

## Usage

Here's a basic example demonstrating how to use HexDecimal:

```csharp
using System;
using HexDecimal;

class Program
{
    static void Main(string[] args)
    {
        // Convert hexadecimal string to decimal
        string hexValue = "1A";
        int decimalValue = Hexdecimal.ConvertToInt(hexValue);
        Console.WriteLine($"Decimal value of {hexValue} is: {decimalValue}");

        // Convert decimal to hexadecimal string
        int intValue = 26;
        string hexString = Hexdecimal.ConvertToHex(intValue);
        Console.WriteLine($"Hexadecimal representation of {intValue} is: {hexString}");
    }
}
```

## Contributing

Contributions to HexDecimal are welcome! If you encounter any issues or have suggestions for improvements, please feel free to open an issue or submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE.txt) file for details.
