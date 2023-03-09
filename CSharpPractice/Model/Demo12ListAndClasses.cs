using System;
using System.Collections.Generic;
public class Burgertime
{
    public static void Main(string[] args)
    {
        //Console.WriteLine ("Hello Mono World");
        List<Menu> MenuList = new List<Menu>();
        MenuList.Add(new Menu(1, "Burger", 2.9));
        MenuList.Add(new Menu(2, "poutine", 3.9));
        MenuList.Add(new Menu(3, "Chesse", 4.9));
        foreach (var menu in MenuList)
        {
            Console.WriteLine("Menu: {0}, {1}, {2}\n", menu.Id, menu.ItemName, menu.ItemCost);
        }
        double Subtotal = MenuAdd(Menu.itemCost);
    }
    public static double MenuAdd(List<Menu> MenuList)
    {
        string OrderPicked = Console.ReadLine();
        string[] InputArray = OrderPicked.Split(" ");
        double STotal = 0;

        for (int Orders = 1; Orders < InputArray.Length; Orders++)
        {
            foreach (var menu in MenuList)
            {
                if (menu.Id == Convert.ToInt32(InputArray[Orders]))
                {
                    Console.WriteLine("Menu: {0}, {1}, {2}\n", menu.Id, menu.ItemName, menu.ItemCost);
                    STotal += menu.ItemCost;
                }
            }
        }
        Console.WriteLine($"Your Subtotal is : ${STotal}");
        return STotal;
    }

}
public class Menu
{
    int id;
    string itemName;
    double itemCost;
    public Menu(int id, string itemName, double itemCost)
    {
        this.id = id;
        this.itemName = itemName;
        this.itemCost = itemCost;
    }
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }
    public double ItemCost
    {
        get { return itemCost; }
        set { itemCost = value; }
    }
}
internal class Options
{
    public int Id { get; set; }
    public string Order { get; set; }
    public double Cost { get; set; }

}
public class DominoesTrial
{
    public static void Main(string[] args)
    {
        List<Options> MenuOptions = new List<Options>()
            {
                new Options () { Id = 1 , Order = "Hawaiian Pizza" ,Cost = 10.99},
                new Options () { Id = 2 , Order = "Meat Lovers Pizza" ,Cost = 10.99},
                new Options () { Id = 3 , Order = "Vegetarian Pizza" ,Cost = 8.99},
                new Options () { Id = 4 , Order = "Domino's Special Pizza" ,Cost = 12.99},
                new Options () { Id = 5 , Order = "10 pcs. Chicken Wings" ,Cost = 6.99},
                new Options () { Id = 6 , Order = "10 pcs. Cheesebread" ,Cost = 6.99},
                new Options () { Id = 7 , Order = "2L Coke" ,Cost = 5.99},
                new Options () { Id = 8 , Order = "2L Sprite" ,Cost = 5.99},
                new Options () { Id = 9 , Order = "2L Ice Tea" ,Cost = 4.99},
                new Options () { Id = 10 , Order = "2L Milk" ,Cost = 3.99},
            };
        foreach (var options in MenuOptions)
        {
            Console.WriteLine(options.Id + ": " + options.Order + "_________ $" + options.Cost + "\n");
        }
    }
}
