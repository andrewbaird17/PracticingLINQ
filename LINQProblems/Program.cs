using System;
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
            List<string> output = LookForTH(words);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();



        }

        static List<string> LookForTH(List<string> input)
        {
            return input.Where(x => x.Contains("th")).ToList();
        }
    }
}
