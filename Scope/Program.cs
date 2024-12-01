// See https://aka.ms/new-console-template for more information
Console.WriteLine("Scope stuff!!");

// Code sample 1
bool flag = true;
int value;

if (flag) // as this is a variable
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}"); // this line is possible
}

Console.WriteLine($"Outside the code block: {value}"); // this line is also possible, hence error of uninitialised value


// Code sample 2
int value;  // this variable is not initalised

if (true)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}"); // this scopped var is initialised OK
}

Console.WriteLine($"Outside the code block: {value}"); // this var is not used NOT OK