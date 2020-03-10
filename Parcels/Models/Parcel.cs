using System;

namespace Parcels.Models
{
  public class Parcel
  {
    public int Weight { get; set; }
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public Parcel(int weight, int length, int width, int height)
    {
      Weight = weight;
      Length = length;
      Width = width;
      Height = height;
    }

    public int Volume()
    {
      return 1;
    }

    public int CostToShip()
    {
      return 2;
    }
  }
}