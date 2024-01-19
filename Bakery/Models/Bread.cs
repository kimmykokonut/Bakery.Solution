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
        if (Order % 3 == 0)
        {
          int discountOrder = (Order - (Order / 3)); 
          int breadTotalCost = discountOrder * 5; 
          return breadTotalCost;
        }
        else
        {
          return Order * 5;
        }
      }
    }



  }

}
// price set. ea x = 5 unless x%3, then x=x-1
