﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingInventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Top:
            Console.WriteLine("In which file you want to enter details - ");
            Console.WriteLine("1. User Details");
            Console.WriteLine("2. Category Details");
            Console.WriteLine("3. Product Details");
            Console.WriteLine("4. Purchase Details");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    int userId;
                    long phone;
                    string fName, lName, email;
                A:
                    Console.WriteLine("Enter user id - ");
                    userId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter first name - ");
                    fName = (Console.ReadLine());
                    Console.WriteLine("Enter last name - ");
                    lName = (Console.ReadLine());
                    Console.WriteLine("Enter email - ");
                    email = (Console.ReadLine());
                    Console.WriteLine("Enter phone - ");
                    phone = Convert.ToInt64(Console.ReadLine());

                    User obj = new User();
                    obj.Writefile(userId, fName, lName, email, phone);
                    Console.WriteLine("Do you want to enter more details - ");
                    string yesOrNo = Console.ReadLine();
                    if ((yesOrNo == "yes") || (yesOrNo == "Yes"))
                    {
                        goto A;
                    }
                    break;
                case 2:
                    long categoryId;
                    string categoryType;
                B:
                    Console.WriteLine("Enter category id - ");
                    categoryId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter category type - ");
                    categoryType = (Console.ReadLine());

                    Category obj1 = new Category();
                    obj1.Writefile(categoryId, categoryType);
                    Console.WriteLine("Do you want to enter more details - Yes/No ");
                    string yesOrNo2 = Console.ReadLine();
                    if ((yesOrNo2 == "yes") || (yesOrNo2 == "Yes"))
                    {
                        goto B;
                    }
                    break;
                case 3:
                    int productId;
                    int quantity;
                    string categoryType2, productName;
                    double price;
                C:
                    Console.WriteLine("Enter product id - ");
                    productId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter category type - ");
                    categoryType2 = (Console.ReadLine());
                    Console.WriteLine("Enter product name - ");
                    productName = (Console.ReadLine());
                    Console.WriteLine("Enter quantity - ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter price - ");
                    price = Convert.ToDouble(Console.ReadLine());

                    Product obj2 = new Product();
                    obj2.Writefile(productId, categoryType2, productName, quantity, price);
                    Console.WriteLine("Do you want to enter more details - Yes/No");
                    string yesOrNo3 = Console.ReadLine();
                    if ((yesOrNo3 == "yes") || (yesOrNo3 == "Yes"))
                    {
                        goto C;
                    }
                    break;
                case 4:
                    int salesId;
                    long productId2;
                    string salesDate;
                    double price2;
                D:
                    Console.WriteLine("Enter sales id - ");
                    salesId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter product id - ");
                    productId2 = Convert.ToInt64((Console.ReadLine()));
                    Console.WriteLine("Enter sales date - ");
                    salesDate = (Console.ReadLine());
                    Console.WriteLine("Enter price - ");
                    price2 = Convert.ToDouble(Console.ReadLine());

                    PurchaseAndSales obj3 = new PurchaseAndSales();
                    obj3.Writefile(salesId, productId2, salesDate, price2);
                    Console.WriteLine("Do you want to enter more details - Yes/No");
                    string yesOrNo4 = Console.ReadLine();
                    if ((yesOrNo4 == "yes") || (yesOrNo4 == "Yes"))
                    {
                        goto D;
                    }
                    break;
                default:
                    Console.WriteLine("--------------Oops.. YOU ENTERED WRONG NUMBER, PLEASE TRY AGAIN-------------");
                    goto Top;
            }

            Console.WriteLine("Do you also want to enter details in any other file ?");
            string finalans = Console.ReadLine();
            if ((finalans == "yes") || (finalans == "Yes"))
            {
                goto Top;
            }
            Console.WriteLine("....App Closed....");
            return;
        }
    }
}