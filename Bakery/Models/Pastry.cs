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
        if (Order % 4 == 0)
        {
          int discountOrder = (Order - (Order / 4));
          int pastryTotalCost = discountOrder * 2;
          return pastryTotalCost;
        }
        else
        {
          return Order * 2;
        }
      }
    }
  }

}