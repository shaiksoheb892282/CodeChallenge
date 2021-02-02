using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengePart1
{
    class CalculateNetPay
    {
		public static void Main(string[] args)      //DO NOT CHANGE the 'Main' signature
		{
			//Implement your code here
			Console.WriteLine("Enter the number of hours worked");
			int hoursWorked = int.Parse(Console.ReadLine());

			Console.WriteLine($"The calculated Net pay is {CalculateNetPayment(hoursWorked)}");
			Console.ReadKey();
		}

		//Implement methods here. Keep the method 'public' and 'static'
		public static double GetGrossPay(int hoursWorked)
		{
			double grossPay;

			if (hoursWorked < 56)
				grossPay = 56 * 80;
			else
			{
				int extraHours = hoursWorked - 56;
				grossPay = (extraHours * 1.5 * 80) + (56 * 80);
			}

			return grossPay;
		}

		public static double CalculateTax(double grossPay)
		{
			double deductableTax;

			deductableTax = grossPay * 0.02;

			return deductableTax;
		}

		public static double CalculateNetPayment(int hoursWorked)
		{
			double netPay, grossPay, deductableTax;

			grossPay = GetGrossPay(hoursWorked);
			deductableTax = CalculateTax(grossPay);
			netPay = grossPay - deductableTax;

			return netPay;
		}
	}
}
