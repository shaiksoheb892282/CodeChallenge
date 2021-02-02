using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallengePart2     //DO NOT CHANGE the name of namespace
{
    public class Employee
	{
		public int empId { get; set; }
		public string empName { get; set; }
		public string band { get; set; }
	}
    
    public class FilterEmployeeList   //DO NOT CHANGE the name of class 'Program'
    {
        //DO NOT CHANGE the 'empList' declaration and initialization
        static List<Employee> empList = new List<Employee>()
        {
            new Employee { empId=101, empName = "Rex", band="B4" },
            new Employee { empId=102, empName = "Tom", band="B2" },
            new Employee { empId=103, empName = "Peter", band="B1" },
        };

        static IEnumerable<Employee> nameList = empList.Where(emp => emp.band == "B1"); //Give the Lambda Expression here
                                                    //and store the result in 'nameList'
                                                    //Implement ONLY using Lambda

        public static void Main(string[] args)
        {
            foreach(var val in nameList)
            {
                Console.WriteLine(" " + val.empId+" "+val.empName+" "+val.band);
            }

            Console.ReadKey();
        }
    }
}