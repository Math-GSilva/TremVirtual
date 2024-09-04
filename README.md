# Autonomous Train Control System

This project is an implementation of an autonomous train control system developed using .NET.

The train moves along an infinite numerical track and responds to movement commands while adhering to safety and efficiency constraints.

## Features

- The train moves in response to commands: "ESQUERDA" (LEFT) and "DIREITA" (RIGHT).
- The system ensures that the train does not exceed 50 total movements.
- The train will not perform more than 20 consecutive movements in the same direction.
- Invalid commands are ignored, and appropriate messages are logged.
- The system prevents the train from moving further left if it is already at position 0.

## Usage

The main class `Train` provides the `DoTask` method, which accepts a list of commands for the train to execute.

### Example

```csharp
var trem = new Train.App.Train();
trem.DoTask(new List<string> { "DIREITA", "ESQUERDA", "DIREITA" });
Console.WriteLine(trem.Position); // Outputs the final position of the train
```

## Tests

Unit tests for this project have been implemented using the `XUnit` framework. These tests ensure the proper functionality of the train control system, covering scenarios such as valid and invalid commands, movement limits, and edge cases.

## Project Creators

This project was developed by **Matheus Gabriel da Silva** and **Larissa Hoffmann**.
