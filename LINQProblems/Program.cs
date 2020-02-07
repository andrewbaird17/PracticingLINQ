﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1
            List<string> words = new List<string> { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> output1 = LookForTH(words);
            foreach (var item in output1)
            {
                Console.WriteLine(item);
            }

            // Problem 2
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            List<string> output2 = RemoveDuplicate(names);
            foreach (var item in output2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }

        static List<string> LookForTH(List<string> input)
        {
            return input.Where(x => x.Contains("th")).ToList();
        }

        static List<string> RemoveDuplicate(List<string> input)
        {
            return input.Distinct().ToList();
        }
    }
}
