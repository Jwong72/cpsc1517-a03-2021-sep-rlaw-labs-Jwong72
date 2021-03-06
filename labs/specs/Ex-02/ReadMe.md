# Train System - Ex02 - TryParse, and File I/O

> This is the third of a set of exercises that follow the evolution of a program to manage trains. This set is cumulative and will build upon previous exercises.

## Overview

Your task is to add functionality to the set of classes from the previous exercise for managing trains. You are expected to have completed and made corrections to your submission for the previous exercise.

Use the demos presented in class as a guide to implementing this exercise.
### General Validation Rules

All validation is to be performed by throwing exceptions. Continue to use these general requirements where/when applicable.

- Exceptions must have meaningful error messages.
- Error messages must include details about the limits for acceptable values.
- Weights must always be positive and non-zero whole numbers. Weights are to be in 100 pound increments (all weights are in pounds *unless otherwise noted*).
- All string information must contain text. Null, empty, and plain white-space text is not allowed. Sanitize your strings by trimming the leading and trailing whitespace.

### The `RollingStock`

Extend the `RollingStock` class by adding the following methods.

- Add **`Parse`** and **`TryParse`** methods to instantiate a `RollingStock` from a comma delimited string. The string's format is expected to match the formatting of the `ToString()` method.
  - In the `Parse` method, throw a [`FormatException`](https://docs.microsoft.com/dotnet/api/system.formatexception?view=net-5.0) if the supplied string does not match the expected format.
  - In the `TryParse` method, explicitly return a `bool` indicating if the parsing was successful. The parameters for this method are to be a `string` and an `out` parameter for the `RollingStock` type.

### The `Program`

In Program.cs create another method app.Ex02a(); that creates 5 cars in a list of type RollingStock. Do NOT create an engine here.

In the TrainSystem directory create a text file called Ex02.dat that will hold the comma-separated information for the 5 rail cars, one rail car per line.

Take the list of type RollingStock and write to the data file. Refer to the demos shown in class for guidance.

Test this method before moving on as the contents of the Ex02.dat file must be correct for the next Ex02b part to work.

Create another method app.Ex02b(); that creates an engine, reads the data from the Ex02.dat file and stores the data in a list of type string, where each string represents one line in the file. Again refer to the demos shown in class for guidance.

Read all the lines using the [`System.File`](https://docs.microsoft.com/dotnet/api/system.io.file?view=net-5.0) class and parse them using the `RollingStock.TryParse` method.

Add the cars to the train and print all data to the console. This includes the engine data, and all data from each of the 5 cars.

## Credits

- [AAR Car Type Codes Explained & Resources](https://www.railcartracking.com/aar-car-type-codes-explained-resources-2/)
