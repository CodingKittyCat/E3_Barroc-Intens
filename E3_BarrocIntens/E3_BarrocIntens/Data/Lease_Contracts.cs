using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_BarrocIntens.Data
{
    class Lease_Contracts
    {
        public int Id { get; set; }
        public string Type_Of_Time { get; set; }
        public int Time_Per_Period { get; set; }
        public int Amount_Of_Periods { get; set; }
        public double Total_Price { get; set; }
        public double Price_Per_Period { get; set; }
        public string Product { get; set; }
        public int Company_Id { get; set; }
        public DateTime? Date_Created { get; set; }
        public DateTime? End_Date { get; set; }
        public string Payment_Status { get; set; }
        public bool Bkr_Check { get; set; }

        public Lease_Contracts()
        {
            Date_Created = DateTime.Now; // Mainly for seeded values, wouldn't be used in production
            End_Date = Date_Created.Value.AddMonths(Time_Per_Period);
            Payment_Status = "Unpaid";
        }

    }
}
