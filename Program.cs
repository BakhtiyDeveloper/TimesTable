using System;

Console.WriteLine("Welcome to the Times Table project!!!");
Console.WriteLine("From numbers 1 to 10");

Console.Write("Enter first number: ");
int start = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Enter second number: ");
int finish = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine();
Console.WriteLine($"TIMES TABLE OF NUMBERS {start} TO {finish}");
Console.WriteLine();

for(int row = 1; row <= 10; row++)
{  
    for(int columns = start; columns <= finish; columns++)
    {  
        
        Console.Write($"{columns} * {row} = {columns * row} \t"); 
        
    } 
    Console.WriteLine(); 
} 

Console.WriteLine();
Console.WriteLine($"TIMES TABLE OF NUMBERS 1 TO 10");
Console.WriteLine();

for(int row = 1; row <= 10; row++)
{ 
    for(int columns = 1; columns <= 10; columns++)
    { 
        Console.Write($"{columns} * {row} = {row * columns} \t");        
    } 
    Console.WriteLine(); 
}


