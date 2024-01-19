using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Order { get; set; }
    public Bread(int quantity)
    {
      Order = quantity;
    }
    public int CalcPrice()
    {
      if (Order < 1)
      {
        return 0;
      }
      else
      {
        int breadTotalCost = 0;

        for (int i = 1; i <= Order; i++)
        {
          if (i % 3 !=0)
          {
            breadTotalCost += 5;
          }
        }
        return breadTotalCost;
      }
    }
    public void UpdateOrder(int addToOrder)
    {
      Order = Order + addToOrder;
    }
  }
}