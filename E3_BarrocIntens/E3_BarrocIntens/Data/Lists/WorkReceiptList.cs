using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E3_BarrocIntens.Data.Classes;

namespace E3_BarrocIntens.Data.Lists
{
    internal class WorkReceiptList
    {
        List<WorkReceipt> workReceiptList = new List<WorkReceipt>()
        {
            new WorkReceipt(1, "This is most definitely a work receipt", DateTime.Now)
        };
        public List<WorkReceipt> GetWorkReceipts()
        {
            return workReceiptList;
        }
    }
}
