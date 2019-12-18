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

    }
}
