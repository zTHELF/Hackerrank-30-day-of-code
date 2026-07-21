using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int maxSuma = int.MinValue;

        for (int fila = 0; fila < 4; fila++)
        {
            for (int col = 0; col < 4; col++)
            {
                int suma =
                    arr[fila][col] + arr[fila][col + 1] + arr[fila][col + 2] +
                    arr[fila + 1][col + 1] +
                    arr[fila + 2][col] + arr[fila + 2][col + 1] + arr[fila + 2][col + 2];

                if (suma > maxSuma)
                {
                    maxSuma = suma;
                }
            }
        }

        Console.WriteLine(maxSuma);
    }
}