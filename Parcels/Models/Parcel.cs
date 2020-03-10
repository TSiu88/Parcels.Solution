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
      return Length * Width * Height;
    }

    public int CostToShip()
    {
      if (Weight < 5)
      {
        return Volume();
      }
      else
      {
        return (Weight - 5) + Volume();
      }
    }
  }
}