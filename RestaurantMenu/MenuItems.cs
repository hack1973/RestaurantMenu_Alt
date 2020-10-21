using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class MenuItems
    {
        public string Item { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public bool IsNew { get; set; }

        public MenuItems(string item, double price, string description, string category)
        {

            Item = item;
            Price = price;
            Description = description;
            Category = category;

        }
    }
}
