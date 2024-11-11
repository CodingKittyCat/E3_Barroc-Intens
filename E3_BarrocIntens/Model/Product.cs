using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_BarrocIntens.Model
{
    class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string Status { get; set; }

        public Product()
        {
        }

        public Product(string title, string description, int stock, string status)
        {
            Title = title;
            Description = description;
            Stock = stock;
            Status = status;
        }

        public Product(int id, string title, string description, int stock, string status)
        {
            Id = id;
            Title = title;
            Description = description;
            Stock = stock;
            Status = status;
        }
    }
}
