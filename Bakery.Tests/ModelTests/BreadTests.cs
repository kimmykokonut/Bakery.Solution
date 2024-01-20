using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBreadOrder_Bread()
    {
      Bread newBread = new Bread(1, "French");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetBreadOrder_ReturnsQuantity_Int()
    {
      int newOrder = 1;
      Bread newBread = new Bread(newOrder, "French");
      int result = newBread.Order;
      Assert.AreEqual(newOrder, result);
    }
    [TestMethod]
    public void SetBreadOrder_SetsValueOfOrder_Void()
    {
      Bread newBread = new Bread(1, "French");
      int newOrder = 5;
      newBread.Order = newOrder;
      Assert.AreEqual(newOrder, newBread.Order);
    }
    [TestMethod]
    public void CalcPrice_DeterminesPriceByOrderLessThan1_Int()
    {
      Bread badOrder = new Bread(0, "French");
      int breadOrder = badOrder.CalcPrice();
      Assert.AreEqual(0, breadOrder);
    }
    [TestMethod]
    public void CalcPrice_DeterminesPriceByOrderOver0_Int()
    {
      Bread newOrder = new Bread(2, "French");
      int breadOrder = newOrder.CalcPrice();
      Assert.AreEqual(10, breadOrder);
    }
    [TestMethod]
    public void CalcPrice_DeterminesPriceMultipleOf3_Int()
    {
      Bread newOrder = new Bread(9, "French");
      int breadOrder = newOrder.CalcPrice();
      Assert.AreEqual(30, breadOrder);
    }
    [TestMethod]
    public void CalcPrice_DeterminesPriceOrderOver3NotMult3_Int()
    {
      Bread newOrder = new Bread(5, "French");
      int breadOrder = newOrder.CalcPrice();
      Assert.AreEqual(20, breadOrder);
    }
    [TestMethod]
    public void UpdateOrder_SetsUpdatedOrderValue_Void()
    {
      Bread testBread = new Bread(3, "French");
      int addToOrder = 5;
      testBread.UpdateOrder(addToOrder);
      Assert.AreEqual(8, testBread.Order);
    }
    public void GetBreadType_ReturnsTypeOfBread_String()
    {
      string newType = "French";
      Bread newBread = new Bread(1, "French");
      string result = newBread.Type;
      Assert.AreEqual(newType, result);
    }

  }
}