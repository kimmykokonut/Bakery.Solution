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
      PlaceOrder();
    }
    static void PlaceOrder()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("How much bread would you like to order? Enter a number...");
      string breadQtyString = Console.ReadLine();
      int breadQtyInt = int.Parse(breadQtyString);
      Console.WriteLine("How many pastries would you like to order? Enter a number...");
      string pastryQtyString = Console.ReadLine();
      int pastryQtyInt = int.Parse(pastryQtyString);
      Bread newBread = new Bread(breadQtyInt);
      Pastry newPastry = new Pastry(pastryQtyInt);
      ConfirmOrder(newBread, newPastry);
    }
    static void ConfirmOrder(Bread newBread, Pastry newPastry)
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("...Please confirm your order...");
      Console.WriteLine($"I see you want to order {newBread.Order} loaves of bread and {newPastry.Order} pastry item(s)");
      Console.WriteLine("Is that correct? Enter 'y' to receive your total order cost or 'n' to place your order again");
      string userInput = Console.ReadLine();
      if (userInput == "y" || userInput == "Y")
      {
        GetTotal(newBread, newPastry);
      }
      else
      {
        Console.WriteLine("");
        Console.WriteLine("Let's update your order.");
        PlaceOrder();
      }
    }
    static void GetTotal(Bread newBread, Pastry newPastry)
    {
      int breadTotal = newBread.CalcPrice();
      int pastryTotal = newPastry.CalcPrice();
      Console.BackgroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("");
      Console.WriteLine(Bakery.UserInterfaceModels.SubMenuBanner.menuBanner);
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Your receipt:");
      Console.WriteLine($"Bread: {newBread.Order} loaves: ${breadTotal}");
      Console.WriteLine($"Pastry: {newPastry.Order} item(s): ${pastryTotal}");
      Console.WriteLine("Your total due is: $" + (breadTotal + pastryTotal));
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Would you like to add to your total? Type 'y' to add more items or any other key to exit");
      string userInput = Console.ReadLine();
      if (userInput == "y" || userInput == "Y")
      {
        PlaceOrder(); //creates new order. can you instance? or running total...
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