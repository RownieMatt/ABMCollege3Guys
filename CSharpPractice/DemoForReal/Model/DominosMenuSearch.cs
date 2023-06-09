﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForReal.Model
{
    internal class DominosMenuSearch
    {
        public static void Main(string[] args)
        {
            string Province = SelectProvince();
            string Delivery = DeliveryorDineIn();
            double TotalCosts = MenuAdd();

        }
        public static string SelectProvince()
        {
            Console.WriteLine("-----Welcome to Dominos Pizza-------\n");
            Console.WriteLine("Which Province are you living in");
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
        public static string DeliveryorDineIn()
        {
            Console.WriteLine("Are you ordering for delivery? \n");
            Console.WriteLine("Yes or No \n");
            string isDelivery = Console.ReadLine();
            if (isDelivery == "Yes")
            {
                Console.WriteLine("You chose to have food Delivered.\n");
            }
            else if (isDelivery == "No")
            {

                Console.WriteLine("You chose to eat food in Dominos.\n");
            }
            else
            {
                Console.WriteLine("Please choose Yes or No \n");
            }
            return isDelivery;
        }
        public static double MenuAdd()
        {
            Console.WriteLine("----Dominos Menu---- \n");
            Console.WriteLine("Select Numbers from 0-9\n");
            Console.WriteLine("0.Hawaiian Pizza:$10.99 \n 1.Meatlovers Pizza:$10.99 \n 2.Veggie Pizza:$8.99 \n 3.Domino's special pizza:$12.99 \n 4.10 pcs. Chicken Wings:$6.99 \n 5. 10 pcs. CheeseBread:$6.99 \n 6. 2l Coke:$5.99 \n 7.2l Sprite:$5.99\n 8.2l Ice Tea:$4.99 \n 9.2l Milk:$3.99");
            string SelectedFood = Console.ReadLine();
            double Costs = 0;
            for (int MenuOp = 0; MenuOp <= SelectedFood.Length - 1; MenuOp++)
            {
                if (SelectedFood[MenuOp] == '0' || SelectedFood[MenuOp] == '1')
                {
                    Costs += 10.99;
                }
                else if (SelectedFood[MenuOp] == '2')
                {
                    Costs += 8.99;
                }
                else if (SelectedFood[MenuOp] == '3')
                {
                    Costs += 12.99;
                }
                else if (SelectedFood[MenuOp] == '4' || SelectedFood[MenuOp] == '5')
                {
                    Costs += 6.99;
                }
                else if (SelectedFood[MenuOp] == '6' || SelectedFood[MenuOp] == '7')
                {
                    Costs += 5.99;
                }
                else if (SelectedFood[MenuOp] == '8')
                {
                    Costs += 4.99;
                }
                else if (SelectedFood[MenuOp] == '9')
                {
                    Costs += 3.99;
                }

            }
            Console.WriteLine($"Costs of food without taxes ${Costs}");
            return Costs;
        }
    }
}