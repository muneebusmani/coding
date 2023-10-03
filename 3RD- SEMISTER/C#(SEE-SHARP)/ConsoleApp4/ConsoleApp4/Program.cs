using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

public class Order
{
    protected const int back = 0;
    public List<string> Cart=new List<string>();

    static void Main()
    {
                Order order = new Order();
                order.Run();
    }

    protected void Run()
    {
        Console.Clear();
        Print("Welcome to My Fast Food Restaurant");
        Print("Press the corresponding number for the corresponding value");
        Print("1. Deals\n2. Burger\n3. Pizza\n4. Sandwich\n5. Fries\n6. Exit");

        int choice = GetUserChoice();

        switch (choice)
        {
            case 1:
                Deals Deal=new Deals();
                Deal.Order();
                break;
            case 2:
                Burger Burger=new Burger();
                Burger.Order();
                break;
            case 3:
                Pizza Pizza = new Pizza();
                Pizza.Order();
                break;
            case 4:
                Sandwich sandwich = new Sandwich();
                sandwich.Order();
                break;
            case 5:
                Fries Fries = new Fries();
                Fries.Order();
                break;
            case 6:
                Environment.Exit(0);
                break;
            default:
                Print("Invalid choice. Please select a valid option.");
                Thread.Sleep(2000);
                Run();
                break;
        }
    }
    protected int GetUserChoice()
    {
        Print("What do you want to order?");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
    protected void Back()
    {
        Run();
    }
    protected static void Print(string message)
    {
        Console.WriteLine(message);
    }
    protected void PaymentMethod()
    {

        Console.Clear();
        Print("Payment Method:");
        Print("1. Credit/Debit Card");
        Print("2. Cash On Delivery");
        Print("0. View Cart");
        int choice = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (choice)
        {
            case 1:
                Print("Enter Card Number:");
                int Card_No=int.Parse(Console.ReadLine());
                Console.Clear();
                Print("Enter Card Expiry:");
                int ExpDate=int.Parse(Console.ReadLine());
                Console.Clear();
                Print("Enter Card CVV:");
                int CVV=int.Parse(Console.ReadLine());
                Console.Clear();

                int[] Card={Card_No,ExpDate,CVV};
                Print("1. Proceed");
                Print("2. Re Enter Details");
                Print("0. Back");
                int num=int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 0:
                        break;
                }
                break;
            case 2:
                Console.Clear();
                COD();
                break;
            case back:
                ViewCart();
                break;
            default:
                Print("Invalid choice. Please select a valid option.");
                Thread.Sleep(2000);
                Console.Clear();
                PaymentMethod();
                break;
        }
    }
    protected void COD()
    {
        Print("Order Placed.");
        Print($"Order ID: {OrderId()}");
        Print("Cash On Delivery - Please have the exact amount ready.");
        Print("Thank you for ordering from My Fast Food Restaurant!");
    }
    protected int OrderId()
    {
        Random random = new Random();
        int minValue = (int)Math.Pow(10, 8 - 1);
        int maxValue = (int)Math.Pow(10, 8) - 1;
        int randomNumber = random.Next(minValue, maxValue + 1);
        return randomNumber;
    }
    protected void ViewCart()
    {
        Console.Clear();
        Print("Cart Contents:");

        if (Cart.Count == 0)
        {
            Print("Your cart is empty.");
        }
        else
        {
            foreach (string item in Cart)
            {
                Print(item);
            }
        }

        Print("Total Cost: $" + CalculateTotalCost());

        Print("1. Proceed to Payment");
        Print("2. Continue Shopping");
        Print("0. Back to Main Menu");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                PaymentMethod();
                break;
            case 2:
                Run();
                break;
            case back:
                Run();
                break;
            default:
                Print("Invalid choice. Please select a valid option.");
                Thread.Sleep(2000);
                Console.Clear();
                ViewCart();
                break;
        }
    }
    protected void AddToCart(string item)
    {
        Cart.Add(item);
        Print($"{item} added to cart.");
        Thread.Sleep(1000);
        Console.Clear();
        Print("1. Continue To Payment");
        Print("0. Add More Items");
        int choice=int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Clear();
                Print("Continuing To Payment...");
                PaymentMethod();
                break;
            case back:
                Console.Clear();
                Run();
                break;
            default:
                break;


        }
    }
    protected double CalculateTotalCost()
    {
        double totalCost = 0.0;

        foreach (string item in Cart)
        {
            // Extract the price from the item description
            string[] parts = item.Split('-');
            if (parts.Length == 2)
            {
                string priceString = parts[1].Trim();
                double price = 0.0;
                if (double.TryParse(priceString.Substring(1), out price))
                {
                    totalCost += price;
                }
            }
        }
        return totalCost;
    }
}

public class Deals : Order
{
    public void Order()
    {
        const int Combo = 1;
        const int Family = 2;
        const int Party = 3;

        string[][] Deals = 
        {
            new string[] { "Family Deal 1", "Family Deal 2", "Family Deal 3" },
            new string[] { "Combo Deal 1", "Combo Deal 2", "Combo Deal 3" },
            new string[] { "Party Deal 1", "Party Deal 2", "Party Deal 3" }
        };
        double[][] Prices =
        {
            new double[]{ 4.99, 9.99, 19.99 },
            new double[]{ 4.99, 9.99, 19.99 },
            new double[]{49.99,74.99,99.99},
        };
        string FamilyD1 = $"1. {Deals[0][0]} - ${Prices[0][0]}";
        string FamilyD2 = $"2. {Deals[0][1]} - ${Prices[0][1]}";
        string FamilyD3 = $"3. {Deals[0][2]} - ${Prices[0][2]}";
        
        string ComboD1 = $"1. {Deals[1][0]} - ${Prices[1][0]}";
        string ComboD2 = $"2. {Deals[1][1]} - ${Prices[1][1]}";
        string ComboD3 = $"3. {Deals[1][2]} - ${Prices[1][2]}";
        
        string PartyD1 = $"1. {Deals[2][0]} - ${Prices[2][0]}";
        string PartyD2 = $"2. {Deals[2][1]} - ${Prices[2][1]}";
        string PartyD3 = $"3. {Deals[2][2]} - ${Prices[2][2]}";

        Console.Clear();

        Print("Deals Menu:");
        Print("1. Combo Deals");
        Print("2. Family Deals");
        Print("3. Party Deals");
        Print("0. Back");
        int choice = int.Parse(Console.ReadLine());
        Console.Clear() ;

        switch (choice)
        {
            case Combo:
                Print("Combo Deals Menu");
                Print($"{ComboD1}");
                Print($"{ComboD2}");
                Print($"{ComboD3}");
                Print("0. Back");
                int combo=int.Parse(Console.ReadLine());
                switch (combo)
                {
                    case 1:
                        Print($"Adding to cart :{ComboD1}");
                        AddToCart(ComboD1);
                        break;
                    case 2:
                        Print($"Adding to cart :{ComboD2}");
                        AddToCart(ComboD2);
                        break;
                    case 3:
                        Print($"Adding to cart :{ComboD3}");
                        AddToCart(ComboD3);
                        break;
                    case 0:
                        Order();
                        break;
                    default:
                        Print("Invalid Option Selected");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Order();
                        break;
                }
                break;
            case Family:
                Print("Family Deals Menu");
                Print($"{FamilyD1}");
                Print($"{FamilyD2}");
                Print($"{FamilyD3}");
                Print("0. Back");
                int family = int.Parse(Console.ReadLine());
                switch (family)
                {
                    case 1:
                        Print($"Adding to cart :{FamilyD1}");
                        AddToCart(FamilyD1);
                        break;
                    case 2:
                        Print($"Adding to cart :{FamilyD2}");
                        AddToCart(FamilyD2);
                        break;
                    case 3:
                        Print($"Adding to cart :{FamilyD3}");
                        AddToCart(FamilyD3);
                        break;
                    case 0:
                        Order();
                        break;
                    default:
                        Print("Invalid Option Selected");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Order();
                        break;
                }
                break;
            case Party:
                Print("Party Deals Menu");
                Print($"{PartyD1}");
                Print($"{PartyD2}");
                Print($"{PartyD3}");
                Print("0. Back");
                int party = int.Parse(Console.ReadLine());
                switch (party)
                {
                    case 1:
                        Print($"Adding to cart :{PartyD1}");
                        AddToCart(PartyD1);
                        break;
                    case 2:
                        Print($"Adding to cart :{PartyD2}");
                        AddToCart(PartyD2);
                        break;
                    case 3:
                        Print($"Adding to cart :{PartyD3}");
                        AddToCart(PartyD3);
                        break;
                    case 0:
                        Order();
                        break;
                    default:
                        Print("Invalid Option Selected");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Order();
                        break;
                }
                break;
            case back:
                Console.Clear();
                Back();
                break;
            default:
                Print("Invalid Option Selected");
                Thread.Sleep(1000);
                Console.Clear();
                Order();
                break;
        }
        Console.ReadKey();
    }
}

public class Burger : Order
{
    public void Order()
    {

        string[] Burgers = {"Chicken Burger","Beef Burger","Chicken Zinger"};

        double[] Prices = { 9.99, 2.99, 5.99 };

        string[] Burger = {
            $"1. {Burgers[0]} - ${Prices[0]}",
            $"2. {Burgers[1]} - ${Prices[1]}",
            $"2. {Burgers[2]} - ${Prices[2]}"
        };

        Console.Clear();
        Print("Burgers Menu:");
        Print($"{Burger[0]}");
        Print($"{Burger[1]}");
        Print($"{Burger[2]}");
        Print("0. Back");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Print($"Adding to Cart: {Burger[0]}");
                AddToCart(Burger[0]);
                break;
            case 2:
                Print($"Adding to Cart: {Burger[1]}");
                AddToCart(Burger[1]);
                break;
            case 3:
                Print($"Adding to Cart: {Burger[2]}");
                AddToCart(Burger[2]);
                break;
            case back:
                Console.Clear();
                Back();
                break;
            default:
                Print("Invalid Option Selected");
                Thread.Sleep(1000);
                Console.Clear();
                Order();
                break;
        }
        Console.ReadKey();
    }
}

public class Pizza : Order
{
    public string[] size(string[] sizes, double[] prices)
    {
        Print("Size:");
        for (int i = 0; i < sizes.Length; i++)
        {
            string size = sizes[i];
            double price = prices[i];
            int counter = i + 1;
            string sizePrice = $"{counter}. {size} - ${price}";
            Print(sizePrice);
        }
        int choice = int.Parse(Console.ReadLine());
        if (choice < 1 || choice > sizes.Length)
        {
            Print("Invalid choice");
            return null; // Handle the error gracefully, e.g., return null
        }

        int selectedIndex = choice - 1;
        string selectedSize = sizes[selectedIndex];
        double selectedPrice = prices[selectedIndex];
        string[] sizeAndPrice = { selectedSize, selectedPrice.ToString() };

        return sizeAndPrice;
    }

    public void Order()
    {

        Console.Clear();
        Print("Pizza Menu:");
        string[] flavors = { "Chicken Fajita", "Pepperoni", "BBQ Chicken", "BBQ Beef", "Cheese Lover", "Vegetable Lover", "Chicken Tikka", "Beef Tikka" };
        string[] sizes   = { "Small","Meduim","Large","X - Large", "XX - Large", "XXX - Large" };
        double[] prices =  { 2.99,4.99,9.99,19.99,34.99,49.99};

        for (int i = 0; i < flavors.Length; i++)
        {
            string flavor = flavors[i];
            int counter = i + 1;
            Console.WriteLine($"{counter}. {flavor}");
        }
        int choice = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (choice)
        {
            case 1:
                string[] Size1=size(sizes,prices);
                string order1=$"{flavors[0]} {Size1[0]}  ${Size1[1]}";
                Print("adding to cart:");
                Print(order1);
                Thread.Sleep(1000);
                Console.Clear();
                AddToCart(order1);
                break;
            case 2:
                string[] Size2=size(sizes,prices);
                string order2=$"{flavors[1]} {Size2[0]}  ${Size2[1]}";
                Print("adding to cart:");
                Print(order2);
                Thread.Sleep(1000);
                Console.Clear();
                AddToCart(order2);
                break;
            case 3:
                string[] Size3=size(sizes,prices);
                string order3=$"{flavors[2]} {Size3[0]}  ${Size3[1]}";
                Print("adding to cart:");
                Print(order3);
                Thread.Sleep(1000);
                Console.Clear();
                AddToCart(order3);
                break;
            case 4:
                string[] Size4=size(sizes,prices);
                string order4=$"{flavors[3]} {Size4[0]}  ${Size4[1]}";
                Print("adding to cart:");
                Print(order4);
                Thread.Sleep(1000);
                Console.Clear();
                AddToCart(order4);
                break;
            case 5:
                string[] Size5=size(sizes,prices);
                string order5=$"{flavors[4]} {Size5[0]}  ${Size5[1]}";
                Print("adding to cart:");
                Print(order5);
                Thread.Sleep(1000);
                Console.Clear();
                AddToCart(order5);
                break;
            case 6:
                string[] Size6=size(sizes,prices);
                string order6=$"{flavors[5]} {Size6[0]}  ${Size6[1]}";
                Print("adding to cart:");
                Print(order6);
                Thread.Sleep(1000);
                Console.Clear();
                AddToCart(order6);
                break;
            case 7:
                string[] Size7=size(sizes,prices);
                string order7=$"{flavors[6]} {Size7[0]}  ${Size7[1]}";
                Print("adding to cart:");
                Print(order7);
                Thread.Sleep(1000);
                Console.Clear();
                AddToCart(order7);
                break;
            case 8:
                string[] Size8=size(sizes,prices);
                string order8=$"{flavors[7]} {Size8[0]}  ${Size8[1]}";
                Print("adding to cart:");
                Print(order8);
                Thread.Sleep(1000);
                Console.Clear();
                AddToCart(order8);
                break;
            case back       :
                Console.Clear();
                Back();
                break;
            default:
                Print("Invalid Option Selected");
                Thread.Sleep(1000);
                Console.Clear();
                Order();
                break;
        }
        Console.ReadKey();
    }
}

public class Sandwich : Order
{
    public void Order()
    {
        string[] sandwiches = { "Chicken Club Sandwich", "Vegetable and Cheese Sandwich", "Cheese Sandwich" };
        double[] prices     = { 5.99,6.99,7.49};
        string[] sandwich   = {$"1. {sandwiches[0]} - {prices[0]}", $"2. {sandwiches[1]} - {prices[1]}",$"3. {sandwiches[2]} - {prices[2]}"};

        Console.Clear();
        Print("Sandwich Menu:");
        Print($"{sandwich[0]}");
        Print($"{sandwich[1]}");
        Print($"{sandwich[2]}");
        Print("0. Back");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Print($"Ordering : {sandwich[0]}");
                AddToCart(sandwich[0]);
                break;
            case 2:
                Print($"Ordering : {sandwich[1]}");
                AddToCart(sandwich[1]);
                break;
            case 3:
                Print($"Ordering : {sandwich[2]}");
                AddToCart(sandwich[2]);
                break;
            case back:
                Console.Clear();
                Back();
                break;
            default:
                Print("Invalid Option Selected");
                Thread.Sleep(1000);
                Console.Clear();
                Order();
                break;
        }
        Console.ReadKey();
    }
}

public class Fries : Order
{
    public void Order()
    {
        string[] Fries  = { "Regular Fries", "Garlic and Mayo Fries", "Chilli Garlic and Mayo Fries", "Pizza Fries" };
        double[] prices = { 3.49 , 4.49 , 4.99 , 7.49 };

        string[] Friess = {$"1. {Fries[0]} - ${prices[0]}",$"2. {Fries[1]} - ${prices[1]}", $"3. {Fries[2]} - ${prices[2]}"};
        Console.Clear();
        Print("Fries Menu:");
        Print($"{Friess[0]}");
        Print($"{Friess[1]}");
        Print($"{Friess[2]}");
        Print("0. Back");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Print($"Ordering :{Friess[0]}");
                AddToCart(Friess[0]);
                break;
            case 2:
                Print($"Ordering :{Friess[1]}");
                AddToCart(Friess[1]);
                break;
            case 3:
                Print($"Ordering :{Friess[2]}");
                AddToCart(Friess[2]);
                break;
            case back:
                Console.Clear();
                Back();
                break;
            default:
                Print("Invalid Option Selected");
                Thread.Sleep(1000);
                Console.Clear();
                Order();
                break;
        }
        Console.ReadKey();
    }
}
