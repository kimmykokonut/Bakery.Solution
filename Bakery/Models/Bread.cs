using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Order { get; set; }
    public string Type { get; }
    private static Dictionary<string, int> _instances = new Dictionary<string, int>();
    public Bread(int quantity, string flavor)
    {
      Order = quantity;
      Type = flavor;
      if (_instances.ContainsKey(Type))
      {
        _instances[Type] += Order;
      }
      else
      {
        _instances.Add(Type, Order);
      }
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
          if (i % 3 != 0)
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
    public static Dictionary<string, int> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}