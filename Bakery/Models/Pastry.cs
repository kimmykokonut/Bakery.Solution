namespace Bakery.Models
{
  public class Pastry
  {
    public int Order { get; set; }

    public Pastry(int quantity)
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
        int pastryTotalCost = 0;
        
        for (int i = 1; i <= Order; i++)
        {
          if (i % 4 != 0)
          {
            pastryTotalCost += 2;
          }
        }
          return pastryTotalCost;
        }
      }
    }
  }