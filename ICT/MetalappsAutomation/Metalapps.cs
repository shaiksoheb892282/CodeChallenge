using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MetalappsAutomation
{
    public class Metalapps            //DO NOT change the class name
    {
        //Implement the property as per the description
        //Implement the methods as per the description

        public SqlConnection SqlCon { get; set; }

        DBHandler db = new DBHandler();
        /*
        public List<SalesDetails> geList()
        {
            try
            {
                SqlCon = db.GetConnection();

                SqlCon.Open();
                SqlCommand cmd = new SqlCommand("select * from  SalesDetails order by Sales_id", SqlCon);
                SqlDataReader reader = cmd.ExecuteReader();
                List<SalesDetails> l1 = new List<SalesDetails>();
                while (reader.Read())
                {
                    SalesDetails sd1 = new SalesDetails();
                    sd1.SalesId = Convert.ToInt32(reader[0]);
                    sd1.CustomerName = reader[1].ToString();
                    sd1.NoOfUnits = Convert.ToInt32(reader[2]);
                    sd1.NetAmount = Convert.ToDouble(reader[3]);
                    l1.Add(sd1);
                }


                SqlCon.Close();
                return l1;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error : "+e.Message);
            }
            return null;
        }*/
        public void AddSalesDetails(SalesDetails sd)
        {
            SqlCon = db.GetConnection();

            SqlCon.Open();

            SqlCommand cmd = new SqlCommand("insert into SalesDetails values(@Sales_id,@Customer_name,@Noof_units,@Net_amount)", SqlCon);
            cmd.Parameters.AddWithValue("@Sales_id", sd.SalesId);
            cmd.Parameters.AddWithValue("@Customer_name", sd.CustomerName);
            cmd.Parameters.AddWithValue("@Noof_units", sd.NoOfUnits);
            cmd.Parameters.AddWithValue("@Net_amount", Convert.ToInt32(sd.NetAmount));
            cmd.ExecuteNonQuery();


            SqlCon.Close();
        }

        public void CalculateNetAmount(SalesDetails details)
        {
            int units = details.NoOfUnits;


            if (units <= 5)
                details.NetAmount = 75350 * units;
            else if (units > 5 && units <= 10)
                details.NetAmount = 75350 * units * 0.98;
            else if (units > 10 && units <= 15)
                details.NetAmount = 75350 * units * 0.95;
            else if (units > 15 && units <= 20)
                details.NetAmount = 75350 * units * 0.92;
            else if (units > 20)
                details.NetAmount = 75350 * units * 0.90;

            //AddSalesDetails(details);
        }


    }
}
