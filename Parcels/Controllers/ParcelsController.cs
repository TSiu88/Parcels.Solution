using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/form")]
    public ActionResult Form() { return View(); }

    [HttpPost("/result")]
    public ActionResult Result(int weight, int length, int width, int height)
    {
      Parcel parcel = new Parcel(weight, length, width, height);
      return View(parcel);
    }
  }
}