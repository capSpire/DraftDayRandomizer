using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftDay
{
    class Program
    {
        static void Main(string[] args)
        {
            var randNumber = new Random();
            var letterStrings = new[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l"};
            var randomNumberList = new List<int>();
            Console.WriteLine("Official Draft Day Randomizer doing magic voodoo random number generation.");
            Console.WriteLine("Results verified by the consulting firm capSpire, Inc.");
            while (randomNumberList.Count != 12)
            {
                var nextRand = randNumber.Next(1, 13);
                if (!randomNumberList.Contains(nextRand))
                {
                    randomNumberList.Add(nextRand);
                }
            }
            var draftDictionary = letterStrings.Zip(randomNumberList, (s, i) => new {s, i})
                .ToDictionary(item => item.s, item => item.i);
            foreach (KeyValuePair<string, int> keyValuePair in draftDictionary)
            {
                Console.WriteLine(keyValuePair.Key + " " + keyValuePair.Value);
            }
            Console.WriteLine("Here is your extra random list. Good luck with the draft.");
            Console.WriteLine("Press enter key to close.");
            Console.ReadLine();
        }
    }
}
