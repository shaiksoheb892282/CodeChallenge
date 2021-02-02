using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengePart1
{
    class DrawPattern
    {
        static void Main(string[] args)
        {
            string symbol;
            int num;
            Console.WriteLine("Enter any symbol $ or * or @ ");
            symbol = Console.ReadLine();
            Console.WriteLine("Enter the number of repeats :");
            num = int.Parse(Console.ReadLine());
            int k = (int)(num / 1) + 1;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k-i-1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (2*i)+1; j++)
                {
                    Console.Write(symbol);
                }
                for (int j = 0; j < k-i-1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
