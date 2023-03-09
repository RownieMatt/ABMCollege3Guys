using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForReal.Model
{
    public class Options
    {
        public int Id { get; set; }
        public string Order { get; set; }
        public double Cost { get; set; }

    }
    internal class DominosMenuV2
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
            string Province = SelectProvince();
            bool RealDelivery = DeliveryorDineIn();
            double Subtotal = MenuTotal(MenuOptions, RealDelivery, Province);

        }
        public static string SelectProvince()
        {
            Console.WriteLine("-----Welcome to Dominos Pizza-------\n");
            Console.WriteLine("Which Province are you living in?\n");
            Console.WriteLine("1.Alberta , 2.British Columbia , 3. Ontario\n");
            string WhatProvince = Console.ReadLine();
            Console.WriteLine($"You chose : {WhatProvince}");

            if (WhatProvince == "1")
            {
                Console.WriteLine("Alberta is selected.");
            }
            else if (WhatProvince == "2")
            {
                Console.WriteLine("British Columbia is selected.");
            }
            else if (WhatProvince == "3")
            {
                Console.WriteLine("Ontario is selected.");
            }
            else
            {
                Console.WriteLine("Please enter from 1 to 3\n");
                Console.WriteLine("1.Alberta , 2.British Columbia , 3. Ontario\n");
            }
            return WhatProvince;

        }
        public static bool DeliveryorDineIn()
        {
            Console.WriteLine("Are you ordering for delivery? \n");
            Console.WriteLine("Yes or No \n");
            string Delivery = Console.ReadLine();
            bool isDelivery = true;
            if (Delivery == "Yes")
            {
                Console.WriteLine("You chose to have food Delivered.\n");
            }
            else if (Delivery == "No")
            {

                Console.WriteLine("You chose to eat food in Dominos.\n");
                isDelivery = false;
            }
            else
            {
                Console.WriteLine("Please choose Yes or No \n");
                return DeliveryorDineIn();
            }
            return isDelivery;
        }

        public static double MenuTotal(List<Options> options, bool Deliver, string WhichProvince)
        {
            Console.WriteLine("------Dominos Menu------\n");
            foreach (var options1 in options)
            {
                Console.WriteLine($"{options1.Id}: {options1.Order}___________${options1.Cost}\n");
            }
            Console.WriteLine("Please type in your order number with spaces between numbers.(Example: 1 2 3 4 5)\n");
            string SelectedFood = Console.ReadLine();
            string[] SelectedArray = SelectedFood.Split(" ");
            double Costs = 0;
            Console.WriteLine("You Ordered:\n");
            for (int Orders = 0; Orders < SelectedArray.Length; Orders++)
            {
                foreach (var options1 in options)
                {
                    if (options1.Id == Convert.ToInt32(SelectedArray[Orders]))
                    {

                        Console.WriteLine($"{options1.Id}: {options1.Order}___________${options1.Cost}\n");
                        Costs += options1.Cost;

                    }
                }
            }
            Console.WriteLine($"The Subtotal is ${Costs}");
            if (Costs >= 20)
            {
                Console.WriteLine("$20+ food charges: 5% ");
                Costs += (Costs * 0.05);
            }
            if (Deliver == true)
            {
                Console.WriteLine("Delivery charge : $5 ");
                Costs += 5;
            }
            if (WhichProvince == "1")
            {
                Console.WriteLine("Provincial Tax : 5% ");
                Costs += (Costs * 0.05);
            }
            if (WhichProvince == "2")
            {
                Console.WriteLine("Provincial Tax : 12% ");
                Costs += (Costs * 0.12);
            }
            if (WhichProvince == "3")
            {
                Console.WriteLine("Provincial Tax : 13%");
                Costs += (Costs * 0.05);
            }

            Console.WriteLine($"The Total is ${Costs}");
            return Costs;
        }
    }
}
