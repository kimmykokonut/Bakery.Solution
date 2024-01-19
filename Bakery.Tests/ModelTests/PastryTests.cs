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
    [TestMethod]
    public void SetPastryOrder_SetsValueOfOrder_Void()
    {
      Pastry newPastry = new Pastry(2);
      int newOrder = 3;
      newPastry.Order = newOrder;
      Assert.AreEqual(newOrder, newPastry.Order);
    }
    [TestMethod]
    public void CalcPrice_DeterminesPriceOrderLessThan1_Int()
    {
      Pastry badOrder = new Pastry(0);
      int pastryOrder = badOrder.CalcPrice();
      Assert.AreEqual(0, pastryOrder);
    }
  }
}