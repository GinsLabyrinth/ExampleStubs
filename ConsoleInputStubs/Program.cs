using ConsoleInputStubs;
try
{
    //Console.WriteLine($"Output was {InputStubs.InputInt()}");
    //Console.WriteLine($"Output was {InputStubs.InputNaturalInt()}");
    Console.WriteLine($"Output was [{String.Join(", ",InputStubs.InputIntList())}]");
    Console.WriteLine($"Output was [{String.Join(", ", InputStubs.InputNaturalIntList())}]");
    Console.WriteLine($"Output was {InputStubs.InputString()}");
    Console.WriteLine($"Output was {InputStubs.InputWord()}");
}
catch (QuitInputException)
{
    Console.WriteLine("Quit Input Triggered. Exiting.");
}
