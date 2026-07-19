using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        StringBuilder output = new StringBuilder();
        
        for (int i = 0; i < n; i++) {
            string str = Console.ReadLine();
            
            StringBuilder even = new StringBuilder();
            StringBuilder odd = new StringBuilder();
            
            for (int j = 0; j < str.Length; j++) {
                if (j % 2 == 0) {
                    even.Append(str[j]);
                } else {
                    odd.Append(str[j]);
                }
            }
            
            output.Append(even.ToString() + " " + odd.ToString());
            if (i < n - 1) {
                output.Append("\n");
            }
        }
        
        Console.WriteLine(output.ToString());
    }
}