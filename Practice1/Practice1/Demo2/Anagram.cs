using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Demo2
{
    internal class Anagram


    {
        public static bool CheckFrequency(string s1 , string s2)
        {
            if (s1.Length !=  s2.Length) { return false; }
            int[] sf1 = new int[128];
            int[] sf2 = new int[128];
            foreach (char c in s1) {  sf1[c]++; }
            foreach (char c in s2) {  sf2[c]++; }
            for (int i = 0; i < 128; i++)
            {
                if (sf1[i] != sf2[i]) { return false; }
            }
            return true; 
        }
        public static void AnagramList(string str)
        {
            Console.WriteLine(str);
            int count = 0; 
            string[] ss = str.Split(' ');
            for (int i = 0; i < ss.Length-1; i++) {
                for (int j = i+1; j < ss.Length; j++)
                {
                    if (CheckFrequency(ss[i], ss[j])) { 
                        count++;
                        Console.WriteLine($"{ss[i]} and {ss[j]} are anagram");
                    }

                }

            }
            Console.WriteLine(count);
        }
    }
}
