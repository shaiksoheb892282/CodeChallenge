using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengePart1
{
    class MaximumEnrollment
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Total students placed in CS");
            int cs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total students placed in MECH");
            int mech = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total students placed in MET");
            int met = Convert.ToInt32(Console.ReadLine());
            if (cs >= mech && cs >= met)
            {
                Console.WriteLine("Highest placement CS");
            }
            else if (cs <= mech && mech >= met)
            {
                Console.WriteLine("Highest placement MECH");
            }
            else //if (met >= mech && cs <= met)
            {
                Console.WriteLine("Highest placement MET");
            }
            Console.ReadKey();
        }
    }
}
