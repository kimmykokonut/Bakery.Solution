namespace Bakery.Models
{
  public class Bread
  {
    public int Order { get; set; }
    public Bread(int quantity)
    {
      Order = quantity;
    }
  }

}
// price set. ea x = 5 unless x%3, then x=x-1
