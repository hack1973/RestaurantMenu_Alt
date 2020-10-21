using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItems> Food { get; set; }
        public DateTime currentTime { get; set; }


        public Menu(List<MenuItems> food)
        {

            Food = food;
            currentTime = DateTime.Now;
        }


        public void AddItem(MenuItems newItem)
        {
            List<MenuItems> ItemList = this.Food;
            if (!ItemList.Contains(newItem) == false)
            {

                Console.WriteLine("You should not add duplicate items to the menu");
            }
        }


        public void RemoveItem(MenuItems badItem)
        {
            Food.Remove(badItem);
            currentTime = DateTime.Now;
        }

        public void Print()
        {

            List<MenuItems> AllItems = this.Food;
            foreach (MenuItems item in AllItems)
            {
                Console.WriteLine("$$$$$$$$$$$$$$$$");
                Console.WriteLine($"{item.Item}/{item.Category}:  {item.Description}: Only  {item.Price}");
                Console.WriteLine("$$$$$$$$$$$$$$$$");
                Console.WriteLine();
            }

        }
    }
}
