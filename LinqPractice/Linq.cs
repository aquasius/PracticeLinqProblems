using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    class Linq
    {
        public static void Question2()
        {
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var noDuplicates = names.Distinct().ToList();
            foreach (string value in noDuplicates)
            {
                Console.WriteLine(value);
            }
        }

        public static void Question4()
        {
             Console.WriteLine("enter a string: ");
             var alphabetize = Console.ReadLine().ToLower().OrderBy(str => str);
             string result = "";
             var letterCounter = alphabetize.GroupBy(str => str).Where(str => str.Count() > 0).Select(str => str.Count()).ToList();
             var answer = alphabetize.Distinct();
             answer = string.Concat(answer.Zip(letterCounter, (first, second) => first + "" + second));
             result += answer;
            
            Console.Write(result);
            Console.ReadLine();
    
        }



    }
}
