using System;
using System.Collections.Generic;
using E3_BarrocIntens.Data.Classes;

namespace E3_BarrocIntens.Data.Lists
{
    internal class InvoiceList
    {
        List<Invoice> invoiceList = new List<Invoice>()
        {
            new Invoice(1, "John Doe", DateTime.Now.AddDays(-30), DateTime.Now.AddDays(-10), 1200.50f, true),
            new Invoice(2, "Jane Smith", DateTime.Now.AddDays(-15), DateTime.Now.AddDays(15), 800.75f, false),
            new Invoice(3, "Acme Corp", DateTime.Now.AddDays(-45), DateTime.Now.AddDays(-5), 2500.00f, true),
            new Invoice(4, "Global Industries", DateTime.Now.AddDays(-20), DateTime.Now.AddDays(10), 1500.30f, false),
            new Invoice(5, "Tech Solutions", DateTime.Now.AddDays(-10), DateTime.Now.AddDays(20), 950.60f, false)
        };

        public List<Invoice> GetInvoices()
        {
            return invoiceList;
        }
    }
}
