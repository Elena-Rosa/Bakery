using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
   [TestClass]

  public class PastryTests
 {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
     {
        Pastry newPastry = new Pastry();
        Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void PastryConstructor_SetPrice_2()
     {
        Pastry newPastry = new Pastry();
        Assert.AreEqual(2, newPastry.Price);
    }
    [TestMethod]
    public void PastryCalculateTotal_ReturnTotalQuantityZero_0()
     {
        Pastry newPastry = new Pastry();
        Assert.AreEqual(0, newPastry.calculateTotal(0));
    }
     [TestMethod]
    public void PastryCalculateTotal_ReturnTotalQuantity1_2()
     {
        Pastry newPastry = new Pastry();
        Assert.AreEqual(2, newPastry.calculateTotal(1));
    }
    [TestMethod]
    public void PastryCalculateTotal_ReturnTotalQuantity2_4()
     {
        Pastry newPastry = new Pastry();
        Assert.AreEqual(4, newPastry.calculateTotal(2));
    }
 }
} 