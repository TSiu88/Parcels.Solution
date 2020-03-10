using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcels.Models;

namespace Parcels.Tests
{
  [TestClass]
  public class ParcelTests
  {
    [TestMethod]
    public void ParcelConstructor_ParcelObjectCreatedCorrectly_ParcelObject()
    {
      Parcel parcel = new Parcel(3, 4, 2, 5);
      Assert.AreEqual(typeof(Parcel), parcel.GetType());
    }

    [TestMethod]
    public void ParcelConstructor_InitializeParcelProperties_Ints()
    {
      int expectedWeight = 1;
      int expectedLength = 2;
      int expectedWidth = 3;
      int expectedHeight = 4;
      Parcel parcel = new Parcel(expectedWeight, expectedLength, expectedWidth, expectedHeight);
      Assert.AreEqual(expectedWeight, parcel.Weight);
      Assert.AreEqual(expectedLength, parcel.Length);
      Assert.AreEqual(expectedWidth, parcel.Width);
      Assert.AreEqual(expectedHeight, parcel.Height);
    }
  }
}