using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcels.Models;

namespace Parcels.Tests
{
  [TestClass]
  public class ParcelTests
  {
    [TestMethod]
    public void MethodName1_DescriptionOfBehavior1_ExpectedResult1()
    {
      Parcel classObj = new Parcel("hi", 12, "hello");
      Assert.AreEqual("hi", classObj.Property1);
    }

  }
}