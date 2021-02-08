using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalappsAutomation
{
    class Program
    {
        public static void Main(string[] args)
        {
            SalesDetails obj = new SalesDetails();
            Console.WriteLine("Enter sales id ");
            obj.SalesId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter customer name ");
            obj.CustomerName = Console.ReadLine();

            Console.WriteLine("Enter the number of units sold");
            obj.NoOfUnits = int.Parse(Console.ReadLine());






            Metalapps app = new Metalapps();
            app.CalculateNetAmount(obj);
            app.AddSalesDetails(obj);

            Console.WriteLine("Sales Bill ");
            Console.WriteLine("***********");
            Console.WriteLine("Sales Id : " + obj.SalesId);
            Console.WriteLine("Customer Name : " + obj.CustomerName);
            Console.WriteLine("Number of Units Sold : " + obj.NoOfUnits);
            Console.WriteLine("Net Amount : " + obj.NetAmount);
            //List<SalesDetails> l1 = new List<SalesDetails>();
            //l1=app.geList();
            //foreach (var item in l1)
            //{
            //    Console.WriteLine($"Sales Details of ID {((SalesDetails)item).SalesId} with name {((SalesDetails)item).CustomerName} has bought {((SalesDetails)item).NoOfUnits} with total of {((SalesDetails)item).NetAmount}");
            //}
            //Console.ReadKey();
        }

    }
}
