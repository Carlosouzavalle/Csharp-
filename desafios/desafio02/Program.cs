string txt = "Enter your name: ";
Console.Write(txt);
string? name = Console.ReadLine();
Console.WriteLine($"Hello, {name}!");





// Warning CS8600 occurs because you are assigning a value that might be null to a variable that has been declared as non-nullable.

// How to Fix ItYou can resolve this warning in one of four ways, depending on how your code should handle a potential null value

// 1. Allow the variable to accept null
// Add a ? to the data type to explicitly tell the compiler that this variable is allowed to be null.
// string? name = Console.ReadLine();



// 2. Provide a default fallback value
// Use the null-coalescing operator (??) to supply a non-null alternative if the source expression resolves to null.
// string name = Console.ReadLine() ?? string.Empty;



// 3. Throw an exception immediately
//If your application cannot safely proceed when the value is null, enforce a hard crash with an exception.
// string name = Console.ReadLine() ?? throw new ArgumentNullException("Input cannot be null");



// 4. Force-suppress the warning (Use with caution)
// If you are 100% certain the value will never be null at runtime, append the null-forgiving operator (!) to silence the compiler.
// string name = Console.ReadLine()!;
