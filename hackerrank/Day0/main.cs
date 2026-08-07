using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        // Declare a variable named 'inputString' to hold our input.
        String usuario;

        Console.Write("Ponga un mensaje: ");
        
        // Read a full line of input from stdin (cin) and save it to our variable, input_string.
        usuario = Console.ReadLine(); 
        
        // Print a string literal saying "Hello, World." to stdout using cout.
        Console.WriteLine("Hello, World.");
        
        // TODO: Write a line of code here that prints the contents of input_string to stdout.
        Console.WriteLine($"Mensaje dirigido de la persona: {usuario}");
    }
}
