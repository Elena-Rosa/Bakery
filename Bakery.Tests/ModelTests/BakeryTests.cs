using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]

  public class BreadTests
 {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
     {
        Bread newBread = new Bread();
        Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void BreadConstructor_SetPrice_5()
     {
        Bread newBread = new Bread();
        Assert.AreEqual(5, newBread.Price);
    }
    [TestMethod]
    public void BreadPrice_SetPrice_6()
     {
        Bread newBread = new Bread();
        newBread.Price = 6;
        Assert.AreEqual(6, newBread.Price);
    }
    [TestMethod]
    public void BreadCalculateTotal_ReturnTotalQuantityZero_0()
     {
        Bread newBread = new Bread();
        Assert.AreEqual(0, newBread.calculateTotal(0));
    }
     [TestMethod]
    public void BreadCalculateTotal_ReturnTotalQuantity1_5()
     {
        Bread newBread = new Bread();
        Assert.AreEqual(5, newBread.calculateTotal(1));
    }
    [TestMethod]
    public void BreadCalculateTotal_ReturnTotalQuantity2_10()
     {
        Bread newBread = new Bread();
        Assert.AreEqual(10, newBread.calculateTotal(2));
    }
    [TestMethod]
    public void BreadCalculateTotal_ReturnTotalQuantity3_10()
     {
        Bread newBread = new Bread();
        Assert.AreEqual(10, newBread.calculateTotal(3));
    }
    [TestMethod]
    public void BreadCalculateTotal_ReturnTotalQuantity4_15()
     {
        Bread newBread = new Bread();
        Assert.AreEqual(15, newBread.calculateTotal(4));
    }
   
    }
 }
