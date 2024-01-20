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
      Console.WriteLine("Here is our menu: \n* Bread: $5/loaf (French or Sourdough available)\n* Pastries: $2 each");
      Console.WriteLine("");
      Console.WriteLine("We have a deal today: Buy 2 loaves of bread, get one free! Buy 3 pastries, get one free!");
      PlaceOrder();
    }
    static void PlaceOrder()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("How much French bread would you like to order? Enter a number...");
      string frenchBreadQtyString = Console.ReadLine();
      Console.WriteLine("How much Sourdough bread would you like to order? Enter a number...");
      string sourBreadQtyString = Console.ReadLine();
      Console.WriteLine("How many pastries would you like to order? Enter a number...");
      string pastryQtyString = Console.ReadLine();
      try
      {
        int frenchBreadQtyInt = int.Parse(frenchBreadQtyString);
        int sourBreadQtyInt = int.Parse(sourBreadQtyString);
        int pastryQtyInt = int.Parse(pastryQtyString);
        Bread newBreadF = new Bread(frenchBreadQtyInt, "French");
        Bread newBreadS = new Bread(sourBreadQtyInt, "Sourdough");
        Pastry newPastry = new Pastry(pastryQtyInt);
        ConfirmOrder(newBreadF, newBreadS, newPastry);
      }
      catch (Exception ex)
      {
        Console.WriteLine("!!!!!!!");
        Console.WriteLine("Whoops!");
        Console.WriteLine("Error: {0}", ex.Message);
        Console.WriteLine("Please try again (numbers only)...");
        PlaceOrder();
      }
    }
    static void ConfirmOrder(Bread newBreadF, Bread newBreadS, Pastry newPastry)
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("...Please confirm your order...");
      Console.WriteLine($"I see you want to order: \n-{newBreadF.Order} loaves of French bread \n-{newBreadS.Order} loaves of Sourdough bread \n-{newPastry.Order} pastry item(s)");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Is that correct? Enter 'y' to receive your total order cost or 'n' to place your order again");
      string userInput = Console.ReadLine();
      if (userInput == "y" || userInput == "Y")
      {
        GetTotal(newBreadF, newBreadS, newPastry);
      }
      else
      {
        Console.WriteLine("");
        Console.WriteLine("Let's update your order.");
        PlaceOrder();
      }
    }
    static void UpdateQuantity(Bread newBreadF, Bread newBreadS, Pastry newPastry)
    {
      Console.WriteLine("Let's update your order...");
      Console.WriteLine("How many more loaves of French bread? Type 0 to skip.");
      string breadUpdateStrF = Console.ReadLine();
      Console.WriteLine("How many more loaves of Sourdough bread? Type 0 to skip.");
      string breadUpdateStrS = Console.ReadLine();
      Console.WriteLine("How many more pastry items? Type 0 to skip.");
      string pastryUpdateStr = Console.ReadLine();
      try
      {
        int breadUpdateF = int.Parse(breadUpdateStrF);
        int breadUpdateS = int.Parse(breadUpdateStrS);
        int pastryUpdate = int.Parse(pastryUpdateStr);
        newBreadF.UpdateOrder(breadUpdateF);
        newBreadS.UpdateOrder(breadUpdateS);
        newPastry.UpdateOrder(pastryUpdate);
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Console.WriteLine($"Your current order: \n-French Bread {newBreadF.Order} loaves \n-Sourdough Bread {newBreadS.Order} loaves \n-Pastries {newPastry.Order}.");
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Console.WriteLine("Type 'more' to add more baked goods or any other key to receive your receipt");
        string userUpdateInput = Console.ReadLine();
        if (userUpdateInput == "more")
        {
          UpdateQuantity(newBreadF, newBreadS, newPastry);
        }
        else
        {
          GetTotal(newBreadF, newBreadS, newPastry);
        }
      }
      catch
      {
        Console.WriteLine("!!!!!!!");
        Console.WriteLine("Whoops! You didn't enter a valid number");
        Console.WriteLine("Please try again...");
        UpdateQuantity(newBreadF, newBreadS, newPastry);
      }
    }
    static void GetTotal(Bread newBreadF, Bread newBreadS, Pastry newPastry)
    {
      int breadTotalF = newBreadF.CalcPrice();
      int breadTotalS = newBreadS.CalcPrice();
      int pastryTotal = newPastry.CalcPrice();
      Console.BackgroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("");
      Console.WriteLine(Bakery.UserInterfaceModels.SubMenuBanner.menuBanner);
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Your receipt:");
      Console.WriteLine("");
      Console.WriteLine($"French Bread: {newBreadF.Order} loaves: ${breadTotalF}");
      Console.WriteLine($"Sourdough Bread: {newBreadS.Order} loaves: ${breadTotalS}");
      Console.WriteLine($"Pastry: {newPastry.Order} item(s): ${pastryTotal}");
      Console.WriteLine("Your total due is: $" + (breadTotalF + breadTotalS + pastryTotal));
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Would you like to add more baked goods to your order? Type 'y' to add more items or any other key to exit");
      string userInput = Console.ReadLine();
      if (userInput == "y" || userInput == "Y")
      {
        UpdateQuantity(newBreadF, newBreadS, newPastry);
      }
      else
      {
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Console.WriteLine("Thanks for supporting Paola's Bakery.");
        Console.WriteLine(Bakery.UserInterfaceModels.GoodbyeBanner.Goodbye);
      }
    }
  }
}