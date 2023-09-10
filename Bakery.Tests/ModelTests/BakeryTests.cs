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
 }
} 