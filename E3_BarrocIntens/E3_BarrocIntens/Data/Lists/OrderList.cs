using E3_BarrocIntens.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_BarrocIntens.Data.Lists
{
    class OrderList
    {
        List<Order> Orderlist = new List<Order>()
        {
            // 5 Orders with status Pending (isDelivered set to false)
            new Order(1, "La Marzocco Linea Mini", "Delivery to Cafe Aroma", 1, Order.OrderStatus.Pending, false),
            new Order(2, "Breville Barista Pro", "Delivery of 3 units to Office Central", 3, Order.OrderStatus.Pending, false),
            new Order(3, "Keurig K-Elite Brewer", "Delivery to Small Bean Coffee Shop", 1, Order.OrderStatus.Pending, false),
            new Order(4, "De'Longhi La Specialista", "Two units for University Campus Cafe", 2, Order.OrderStatus.Pending, false),
            new Order(5, "Jura E8 Automatic Coffee Machine", "Bulk order of 10 units for Hotel Deluxe", 10, Order.OrderStatus.Pending, false),

            // 5 Orders with status Shipped (isDelivered set to false)
            new Order(6, "La Marzocco GS3", "Shipped to Coffee House", 1, Order.OrderStatus.Shipped, false),
            new Order(7, "Gaggia Classic Pro", "Shipped to Gourmet Coffee Roasters", 1, Order.OrderStatus.Shipped, false),
            new Order(8, "Nespresso VertuoPlus Deluxe", "Shipped to Riverside Cafe", 1, Order.OrderStatus.Shipped, false),
            new Order(9, "Philips 3200 Series", "Shipped to Downtown Coffee Hub", 2, Order.OrderStatus.Shipped, false),
            new Order(10, "Miele CM5310 Silence", "Shipped to Green Leaf Hotel", 4, Order.OrderStatus.Shipped, false),

            // 5 Orders with status Delivered (isDelivered set to true)
            new Order(11, "Breville Bambino Plus", "Delivered to The Daily Grind", 2, Order.OrderStatus.Delivered, true),
            new Order(12, "Saeco Xelsis", "Delivered to Tech Corp Office", 1, Order.OrderStatus.Delivered, true),
            new Order(13, "Rancilio Silvia", "Delivered to The Roastery", 3, Order.OrderStatus.Delivered, true),
            new Order(14, "De'Longhi Dinamica Plus", "Delivered to Cozy Corner Cafe", 2, Order.OrderStatus.Delivered, true),
            new Order(15, "Rocket Appartamento", "Delivered to Bella's Bistro", 1, Order.OrderStatus.Delivered, true),

            // 5 Orders with status Canceled (isDelivered set to false)
            new Order(16, "Ascaso Dream PID", "Order canceled for The Brew House", 1, Order.OrderStatus.Canceled, false),
            new Order(17, "Nuova Simonelli Oscar II", "Order canceled for Java Junction", 1, Order.OrderStatus.Canceled, false),
            new Order(18, "Smeg ECF01", "Order canceled for Bites & Brews", 2, Order.OrderStatus.Canceled, false),
            new Order(19, "Breville Oracle Touch", "Order canceled for Sunset Cafe", 1, Order.OrderStatus.Canceled, false),
            new Order(20, "De'Longhi Magnifica S", "Order canceled for The Coffee Spot", 1, Order.OrderStatus.Canceled, false)
        };

        public List<Order> GetOrders()
        {
            return Orderlist;
        }
    }
}
