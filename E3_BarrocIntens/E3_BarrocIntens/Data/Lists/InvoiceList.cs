using System;
using System.Collections.Generic;
using E3_BarrocIntens.Data.Classes;

namespace E3_BarrocIntens.Data.Lists
{
    internal class InvoiceList
    {
        List<Invoice> invoiceList = new List<Invoice>()
        {
            new Invoice(1, 1, new DateTime(2021, 1, 1), new DateTime(2021, 1, 31), 1000, false),
            new Invoice(2, 1, new DateTime(2021, 2, 1), new DateTime(2021, 2, 28), 2000, false),
            new Invoice(3, 1, new DateTime(2021, 3, 1), new DateTime(2021, 3, 31), 3000, false)
        };

        public List<Invoice> GetInvoices()
        {
            return invoiceList;
        }
    }
}
