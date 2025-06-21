using System;
using System.Collections.Generic;

namespace Dev420_RestaurantManagementSystem
{
    public class Order
    {
        public string OrderId { get; set; }
        public string UserId { get; set; }
        public List<ItemOrder> Items { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }

    }
}