using System;
using Bakery.Models;
using Bakery.UserInterfaceModels;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.BackgroundColor = ConsoleColor.DarkGreen;
      Console.Clear();
      Console.WriteLine(Bakery.UserInterfaceModels.WelcomeBanner.Welcome);
      Console.WriteLine("Welcome to Paola's Bakery!");
      Console.WriteLine("");
      Console.WriteLine("Here is our menu: \n* Bread: $5/loaf\n* Pastries: $2 each");
      Console.WriteLine("");
      Console.WriteLine("We have a deal today: Buy 2 loaves of bread, get one free! Buy 3 pastries, get one free!");
      //PlaceOrder();
    }
    // static void PlaceOrder()
    // {
    //   Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
    //   Console.WriteLine("How much bread would you like to order? Enter a number...");
    //   string breadQtyString = Console.ReadLine();
    //   Console.WriteLine("How many pastries would you like to order? Enter a number...");
    //   string pastryQtyString = Console.ReadLine();
    //   try
    //   {
    //     int breadQtyInt = int.Parse(breadQtyString);
    //     int pastryQtyInt = int.Parse(pastryQtyString);
    //     Bread newBread = new Bread(breadQtyInt);
    //     Pastry newPastry = new Pastry(pastryQtyInt);
    //     ConfirmOrder(newBread, newPastry);
    //   }
    //   catch (Exception ex)
    //   {
    //     Console.WriteLine("!!!!!!!");
    //     Console.WriteLine("Whoops!");
    //     Console.WriteLine("Error: {0}", ex.Message);
    //     Console.WriteLine("Please try again (numbers only)...");
    //     PlaceOrder();
    //   }

    // }
    // static void ConfirmOrder(Bread newBread, Pastry newPastry)
    // {
    //   Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
    //   Console.WriteLine("...Please confirm your order...");
    //   Console.WriteLine($"I see you want to order {newBread.Order} loaves of bread and {newPastry.Order} pastry item(s)");
    //   Console.WriteLine("Is that correct? Enter 'y' to receive your total order cost or 'n' to place your order again");
    //   string userInput = Console.ReadLine();
    //   if (userInput == "y" || userInput == "Y")
    //   {
    //     GetTotal(newBread, newPastry);
    //   }
    //   else
    //   {
    //     Console.WriteLine("");
    //     Console.WriteLine("Let's update your order.");
    //     PlaceOrder();
    //   }
    // }
    // static void UpdateQuantity(Bread newBread, Pastry newPastry)
    // {
    //   Console.WriteLine("Let's update your order...");
    //   Console.WriteLine("How many more loaves of bread? Type 0 to skip.");
    //   string breadUpdateStr = Console.ReadLine();
    //   Console.WriteLine("How many more pastry items? Type 0 to skip.");
    //   string pastryUpdateStr = Console.ReadLine();
    //   try
    //   {
    //     int breadUpdate = int.Parse(breadUpdateStr);
    //     int pastryUpdate = int.Parse(pastryUpdateStr);
    //     newBread.UpdateOrder(breadUpdate);
    //     newPastry.UpdateOrder(pastryUpdate);
    //     Console.WriteLine($"Your current bread order is {newBread.Order} loaves. \nYour current pastry order is {newPastry.Order} pastries. \nType 'more' to add more baked goods or any other key to receive your receipt");
    //     string userUpdateInput = Console.ReadLine();
    //     if (userUpdateInput == "more")
    //     {
    //       UpdateQuantity(newBread, newPastry);
    //     }
    //     else
    //     {
    //       GetTotal(newBread, newPastry);
    //     }
    //   }
    //   catch
    //   {
    //     Console.WriteLine("!!!!!!!");
    //     Console.WriteLine("Whoops! You didn't enter a valid number");
    //     Console.WriteLine("Please try again...");
    //     UpdateQuantity(newBread, newPastry);
    //   }
    // }
    // static void GetTotal(Bread newBread, Pastry newPastry)
    // {
    //   int breadTotal = newBread.CalcPrice();
    //   int pastryTotal = newPastry.CalcPrice();
    //   Console.BackgroundColor = ConsoleColor.DarkRed;
    //   Console.WriteLine("");
    //   Console.WriteLine(Bakery.UserInterfaceModels.SubMenuBanner.menuBanner);
    //   Console.WriteLine("-----------------------------------------");
    //   Console.WriteLine("Your receipt:");
    //   Console.WriteLine($"Bread: {newBread.Order} loaves: ${breadTotal}");
    //   Console.WriteLine($"Pastry: {newPastry.Order} item(s): ${pastryTotal}");
    //   Console.WriteLine("Your total due is: $" + (breadTotal + pastryTotal));
    //   Console.WriteLine("-----------------------------------------");
    //   Console.WriteLine("Would you like to add more baked goods to your order? Type 'y' to add more items or any other key to exit");
    //   string userInput = Console.ReadLine();
    //   if (userInput == "y" || userInput == "Y")
    //   {
    //     UpdateQuantity(newBread, newPastry);
    //   }
    //   else
    //   {
    //     Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
    //     Console.WriteLine("Thanks for supporting Paola's Bakery.");
    //     Console.WriteLine(Bakery.UserInterfaceModels.GoodbyeBanner.Goodbye);
    //   }
    //}
  }

}