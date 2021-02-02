using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengePart1
{
    class DesignDisplay
    {
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter the Company Name");
			string cName = Console.ReadLine();

			Console.WriteLine("Enter the Employee Name");
			string eName = Console.ReadLine();

			Console.WriteLine("Enter the Project Name");
			string pName = Console.ReadLine();

			Console.WriteLine("Enter the Year");
			int year = int.Parse(Console.ReadLine());

			entireMessage(cName, eName, pName, year);
			Console.ReadKey();

		}

		public static void headerMessage(string cName)
		{
			Console.WriteLine(cName + " Employee Information");
		}

		public static void footerMessage(int year)
		{
			Console.WriteLine("Copyright " + year);
			Console.WriteLine("All Rights Reserved. ");
		}

		public static void entireMessage(string cName, string eName, string pName, int year)
		{
			headerMessage(cName);
			Console.WriteLine(eName);
			Console.WriteLine(pName);
			footerMessage(year);
		}


	}
}
