using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    class Linq
    {
        public static void questionOne()
        {
            List<string> randomwords = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            var wordsWithTh =
                    from word in randomwords
                    where word.Contains("th")
                    select word;

            foreach (var word in wordsWithTh)
            {
                Console.WriteLine(word);
                Console.ReadLine();
            }
        }
        public static void Question2()
        {
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var noDuplicates = names.Distinct().ToList();
            foreach (string value in noDuplicates)
            {
                Console.WriteLine(value);
            }
        }

        public static void Question3DeterminingClassAverage()
        {
            List<double> studentGrades = new List<double>();
            List<int> updatedClassGrades = new List<int>();
            List<string> classGrades = new List<string>()
            {
            "80,100,92,89,65",
            "93,81,78,84,69",
            "73,88,83,99,64",
            "98,100,66,74,55"
            };

            for (int i = 0; i < classGrades.Count; i++)
            {
                string[] splitGrades = classGrades[i].Split(',');

                for (int j = 0; j < splitGrades.Length; j++)
                {
                    string newString = splitGrades[j].Trim();

                    var newint = Int32.Parse(newString);

                    updatedClassGrades.Add(newint);
                }

                var lowestGrade = updatedClassGrades.Min();
                updatedClassGrades.Remove(lowestGrade);

                var averageStudentGrade = updatedClassGrades.Average();
                studentGrades.Add(averageStudentGrade);

            }
            
            var averageClassGrade = studentGrades.Average();

           Console.WriteLine(averageClassGrade);

            //Expected output: 86.125
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
