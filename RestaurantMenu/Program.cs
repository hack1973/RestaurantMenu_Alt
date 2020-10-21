using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuItems pasta = new MenuItems("Shrimp Scampi", 12.50, "Angel Hair pasts tossed with butter sauce and topped with prawns", "Main Dish");
            MenuItems burger = new MenuItems("American Hamburger", 8.50, "Angus Beef with lettice, Tomato, & Cheese", "Main Course");
            MenuItems beans = new MenuItems("Baked Beans", 3.50, "Slow cooked in brown sugar", "Side Dish");
            MenuItems chocIce = new MenuItems("Chocolate Ice Cream", 4.70, "Cold and refreshing", "Dessert");
            MenuItems water = new MenuItems("Water", 0.00, "Fresh from the tap", "Drink");
            MenuItems coke = new MenuItems("Coca-Cola Products", 2.00, "Fountain Drink", "Drink");


            List<MenuItems> food = new List<MenuItems>();
            food.Add(pasta);
            food.Add(beans);
            food.Add(burger);
            food.Add(chocIce);
            food.Add(water);
            food.Add(coke);


            Menu Menu1 = new Menu(food);
            Console.WriteLine(food.Count);//good
                                          //food.Print(); <---- NOT GOOD
                                          // AllItems.Print(); < ----NOT GOOD

            Menu1.Print(); //*******THIS IS HOW YOU CALL A FUCTION ***********



            //Console.WriteLine(Menu1.currentTime); //good
            //Console.WriteLine(pasta.Item); //good
            //Console.WriteLine(burger.Item);  //good
            //Console.WriteLine(beans.Item); //good
            //Console.WriteLine(chocIce.Item); //good
            //Console.WriteLine(water.Item); //good
            //Console.WriteLine(coke.Item); //good
        }
    }
}
