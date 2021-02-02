using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengePart1
{
    class ClearanceSale
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the product");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the price of the product");
            int price = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Is the product on sale(yes/no)");
            string sale = Console.ReadLine();
            Console.WriteLine("Enter number of product sale in day1");
            int day1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of product sale in day2");
            int day2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of product sale in day3");
            int day3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(name);
            if (sale == "yes")
            {
                double day1sale = (day1 * price * 0.93);
                Console.WriteLine("day1 sales total is" + day1sale);
                double day2sale = (day2 * price * 0.93 * 0.93);
                Console.WriteLine("day2 sales total is" + day2sale);
                double day3sale = (day3 * price * 0.93 * 0.93 * 0.93);
                Console.WriteLine("day3 sales total is" + day3sale);
            }
            if (sale == "no")
            {
                double day1sale = (day1 * price);
                Console.WriteLine("day1 sales total is" + day1sale);
                double day2sale = (day2 * price);
                Console.WriteLine("day2 sales total is" + day2sale);
                double day3sale = (day3 * price);
                Console.WriteLine("day3 sales total is" + day3sale);
            }
            Console.ReadKey();
        }
    }
}
