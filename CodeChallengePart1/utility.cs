using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengePart1
{
    public class Customer
    {
        int id;
        string name;
        string city;
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public Customer() { }
        public Customer(int id, string name, string city)
        {
            Id = id;
            Name = name;
            City = city;
        }
        public override string ToString()
        {
            return Id + " " + Name + " " + City;
        }
    }
    public class CustomerUtility
    {
        public List<Customer> custList { get; set; }
        public CustomerUtility()
        {
            custList = new List<Customer>();
        }
        public List<Customer> AddCustomer(Customer c)
        {
            this.custList.Add(c);
            return custList;
        }
        public Customer SearchCustomerByID(int id)
        {
            Customer cc = new Customer();
            cc = null;
            cc = this.custList.Find(c => c.Id == id);
            return cc;
        }
        public void DisplayAllCustomers()
        {
            foreach (var c in this.custList)
            {
                Console.Write("{0},{1},{2}", c.Id, c.Name, c.City);
            }
        }
        public void DeleteCustomer(int id)
        {
            Customer cc = new Customer();
            cc = null;
            cc = this.custList.Find(c => c.Id == id);
            if (cc != null)
            {
                bool b = this.custList.Remove(cc);
            }
        }
    }

    public class Utility
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Add Customer");
            Console.WriteLine("2.Display Customer");
            Console.WriteLine("3.Search Customer");
            Console.WriteLine("4.Delete Customer");
            CustomerUtility cu = new CustomerUtility();
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Enter your Choice");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter Customer id,name and city");
                    int id = int.Parse(Console.ReadLine());
                    string name = Console.ReadLine();
                    string city = Console.ReadLine();
                    Customer c = new Customer(id, name, city);
                    cu.AddCustomer(c);
                }
                if (choice == 2)
                {
                    if (cu.custList.Count != 0)
                    {
                        cu.DisplayAllCustomers();
                    }
                }
                if (choice == 3)
                {
                    int idd = int.Parse(Console.ReadLine());
                    Customer c = new Customer();
                    c = cu.SearchCustomerByID(idd);
                    if (c != null)
                    {
                        Console.WriteLine("{0} {1} {2}", c.Id, c.Name, c.City);
                    }
                }
                if (choice == 4)
                {
                    int id = int.Parse(Console.ReadLine());
                    cu.DeleteCustomer(id);
                }
            }
            Console.ReadKey();
        }
    }
}
