using System;

namespace E3_BarrocIntens.Data.Classes
{
    public enum ProductStatus
    {
        InStock,
        OutOfStock,
        PendingApproval
    }

    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public ProductStatus Status { get; set; }

        public Product()
        {
        }

        public Product(string title, string description, int stock, ProductStatus status)
        {
            Title = title;
            Description = description;
            Stock = stock;
            Status = status;
        }

        public Product(int id, string title, string description, int stock, ProductStatus status)
        {
            Id = id;
            Title = title;
            Description = description;
            Stock = stock;
            Status = status;
        }
    }
}
