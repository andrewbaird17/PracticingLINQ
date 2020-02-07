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

            // Problem 3
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };
            double output3 = AvgOfAvgs(classGrades);
            Console.WriteLine(output3);
            

            // Problem 4
            string word4 = "Terrill";
            string output4 = CompressAlphabeticalString(word4);
            Console.WriteLine(output4);
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

        static double AvgOfAvgs(List<string> input)
        {
            var output = input.Select(x => x.Split(',').Select(item => Convert.ToDouble(item)).ToList().ToList());

            output = output.Where(z => z.Remove(z.Min())).ToList();

            var result = output.Select(y => y.Average());

            return result.Average();
        }

        static string CompressAlphabeticalString(string input)
        {
            var sorted = input.ToUpper().ToCharArray().OrderBy(x => x).ToList();
            var distinctSorted = sorted.Distinct().ToList();
            var counts = distinctSorted.Select(x => (sorted.LastIndexOf(x) - sorted.IndexOf(x)) + 1);
            var output = distinctSorted.Zip(counts, (x, y) => String.Concat(x,y)).ToList();

            return String.Join("",output);
        }
    }
}
