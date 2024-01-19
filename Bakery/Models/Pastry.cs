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
      return Order;
    }
  }
}

}