﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengePart1
{
	public class Employee
	{
		public String EmpId { get; set; }
		public String EmpName { get; set; }
		public String Designation { get; set; }
		public int Salary { get; set; }

		public Employee(String eId, String eName, String desg, int sal)
		{
			this.EmpId = eId;
			this.EmpName = eName;
			this.Designation = desg;
			this.Salary = sal;
		}
	}
	class SalaryGreaterLinq
    {
		public static List<Employee> EmployeeList = new List<Employee>()
		{
			new Employee("EM101", "Tom", "Lead", 60000),
			new Employee("EM102", "Sally", "Manager", 55000),
			new Employee("EM103", "Merkel", "Lead", 70000),
			new Employee("EM104", "Stephen", "Lead", 75000),
			new Employee("EM105", "Sam", "Manager", 65000),
			new Employee("EM106", "Jose", "Lead", 50000),
			new Employee("EM107", "David", "Manager", 80000)
		};


		static void Main(string[] args)     //DO NOT CHANGE the 'Main' signature
		{
			//Implement your code here
			SalaryGreaterThanAverage();
			Console.ReadKey();
		}

		//Implement the method 'SalaryGreaterThanAverage'
		public static void SalaryGreaterThanAverage()
		{
			IEnumerable<Employee> emp = from employee in EmployeeList where employee.Salary >= EmployeeList.Average(a => a.Salary) select employee;
			foreach (Employee e in emp)
				Console.WriteLine(e.EmpName);
		}

		/** DO NOT CHANGE this ParameterExpression **/
		public static ParameterExpression variableExpr = Expression.Variable(typeof(IEnumerable<Employee>), "sampleVar");
		public static Expression GetMyExpression()
		{
			/** Copy ONLY the Query Expression into the specified comment area **/
			Expression assignExpr = Expression.Assign(variableExpr, Expression.Constant(from employee in EmployeeList where employee.Salary >= EmployeeList.Average(a => a.Salary) select employee));
			return assignExpr;
		}
	}
}
