namespace Bakery.Models
{
public class Pastry
{
  public int Order { get; set; }

  public Pastry(int quantity)
  {
    Order = quantity;
  }
}

}