using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastryOrder_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetPastryOrder_ReturnsQuantity_Int()
    {
      int newOrder = 1;
      Pastry newPastry = new Pastry(newOrder);
      int result = newPastry.Order;
      Assert.AreEqual(newOrder, result);
    }
  }
}