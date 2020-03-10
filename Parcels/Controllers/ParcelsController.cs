using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/result")]
    public ActionResult Result(string name, string city)
    {
      Parcel parcel = new Parcel("DefaultName");
      parcel.Name = name;
      parcel.City = city;
      return View(parcel);
    }
  }
}