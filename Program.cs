using System;

Console.WriteLine("Welcome to the Times Table project!!!");
Console.WriteLine("From numbers 1 to 10");

Console.Write("Enter first number: ");
int start = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Enter second number: ");
int finish = Convert.ToInt32(Console.ReadLine()); 



for(int row = 1; row <= 10; row++)
{  
    for(int columns = start; columns <= finish; columns++)
    {  
        
        Console.Write($"{columns} * {row} = {columns * row} \t"); 
        
    } 
    Console.WriteLine(); 
} 


Console.WriteLine("Keyingisi");

Console.WriteLine("Keyingisi");


for(int row = 1; row <= 10; row++)
{ 
    for(int columns = 1; columns <= 10; columns++)
    { 
        Console.Write($"{columns} * {row} = {row * columns} \t"); 
         
    } 
    Console.WriteLine(); 
}


