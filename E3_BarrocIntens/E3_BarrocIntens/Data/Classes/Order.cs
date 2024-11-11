using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_BarrocIntens.Data.Classes
{
    class Order
    {
        public enum OrderStatus
        {
            Pending,
            Shipped,
            Delivered,
            Canceled
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public OrderStatus Status { get; set; }
        public bool IsDelivered { get; set; }

        public Order(int id, string name, string description, int amount, OrderStatus status, bool isDelivered)
        {
            Id = id;
            Name = name;
            Description = description;
            Amount = amount;
            Status = status;
            IsDelivered = isDelivered;
        }
    }
}
