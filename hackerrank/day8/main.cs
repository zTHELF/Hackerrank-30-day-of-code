using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
int n = Convert.ToInt32(Console.ReadLine().Trim());

        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        for (int i = 0; i < n; i++) {
            string[] entry = Console.ReadLine().Split(' ');
            string name = entry[0];
            string number = entry[1];
            phoneBook[name] = number;
        }

        string query;
        while ((query = Console.ReadLine()) != null) {
            if (phoneBook.ContainsKey(query)) {
                Console.WriteLine($"{query}={phoneBook[query]}");
            } else {
                Console.WriteLine("Not found");
            }
        }
    }
}