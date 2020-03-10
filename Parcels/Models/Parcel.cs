using System;

namespace Parcels.Models
{
  public class Parcel
  {
    public string Name { get; set; }
    public string City { get; set; }

    public Parcel(string name)
    {
      Name = name;
      City = "Seattle";
    }

    public bool MethodName()
    {
      return true;
    }
  }
}