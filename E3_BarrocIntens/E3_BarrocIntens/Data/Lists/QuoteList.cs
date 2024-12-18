
using E3_BarrocIntens.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_BarrocIntens.Data.Lists
{
    internal class QuoteList
    {
        List<Quote> quoteList = new List<Quote>()
        {
            new Quote(1, 1, DateTime.Now.AddDays(-30), DateTime.Now.AddDays(-10), 1200.50m, "Pending", false),
            new Quote(2, 1, DateTime.Now.AddDays(-15), DateTime.Now.AddDays(15), 800.75m, "Accepted", true),
            new Quote(3, 1, DateTime.Now.AddDays(-45), DateTime.Now.AddDays(-5), 2500.00m, "Pending", false),
        };

        public List<Quote> GetQuotes()
        {
            return quoteList;
        }
    }
}
