using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        int entero = 0;
        double decimal_ = 0.0;
        string texto = "";

        // Read and save an integer, double, and String to your variables.
        Console.Write("Ingrese un número entero: ");
        entero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese un número decimal: ");
        decimal_ = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese un texto: ");
        texto = Console.ReadLine();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine($"La suma de los numeros enteros: {i + entero}");

        // Print the sum of the double variables on a new line.
        Console.WriteLine($"La suma de los numeros decimales: {d + decimal_}");

        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine($"La concatenacion entre los textos es: {s}{texto}");

    }
}