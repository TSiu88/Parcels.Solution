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

    [TestMethod]
    public void Volume_CalculateVolume_Int()
    {
      Parcel parcel = new Parcel(5, 1, 2, 3);
      int expectedVolume = 6;
      Assert.AreEqual(expectedVolume, parcel.Volume());
    }

    [TestMethod]
    public void CostToShip_GetCostUnder5Pounds_Int()
    {
      Parcel parcel = new Parcel(4, 1, 2, 3);
      int expectedCost = 6;
      Assert.AreEqual(expectedCost, parcel.CostToShip());
    }

    [TestMethod]
    public void CostToShip_GetCostOver5Pounds_Int()
    {
      Parcel parcel = new Parcel(8, 1, 2, 3);
      int expectedCost = 9;
      Assert.AreEqual(expectedCost, parcel.CostToShip());
    }
  }
}