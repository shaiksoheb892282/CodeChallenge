using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengePart1
{
    class BankAccountDetails
    {
        public static List<SavingAccount> SavingList = new List<SavingAccount>();
        static void Main(String[] args)
        {
            //fill the code
            string filename = @"details.txt";
            GetAcountDetails(filename);
        }
        public static void GetAccountDetails(string file)
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                FileContent += line;
                string[] accDetails = line.Split(', ');
                SavingsList.Add(new SavingAccount(int.Parse(accDetails[0]), accDetails[1], int.Parse(accDetails[2])));
            }
        }
}
