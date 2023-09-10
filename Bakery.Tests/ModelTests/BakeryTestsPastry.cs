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
 }
} 