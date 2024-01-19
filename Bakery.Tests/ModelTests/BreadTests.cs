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
      int breadOrder = badOrder.CalcPrice();
      Assert.AreEqual(0, breadOrder);
    }
    [TestMethod]
    public void CalcPrice_DeterminesPriceByOrderOver0_Int()
    {
      Bread newOrder = new Bread(2);
      int breadOrder = newOrder.CalcPrice();
      Assert.AreEqual(10, breadOrder);
    }
  }
}