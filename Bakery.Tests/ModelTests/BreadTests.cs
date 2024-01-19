using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBreadOrder_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetBreadOrder_ReturnsQuantity_Int()
    {
      int newOrder = 1;
      Bread newBread = new Bread(newOrder);
      int result = newBread.Order;
      Assert.AreEqual(newOrder, result);
    }
    [TestMethod]
    public void SetBreadOrder_SetsValueOfOrder_Void()
    {
      Bread newBread = new Bread(1);
      int newOrder = 5;
      newBread.Order = newOrder;
      Assert.AreEqual(newOrder, newBread.Order);
    }
    [TestMethod]
    public void CalcPrice_DeterminesPriceByOrderLessThan1_Int()
    {
      Bread badOrder = new Bread(0);
      string breadOrder = badOrder.CalcPrice();
      Assert.AreEqual("Error, you must order at least 1 loaf of bread", breadOrder);
    }
  }
}