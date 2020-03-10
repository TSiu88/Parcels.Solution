using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    // The line above is a route decorator -- it overrides needing to go to home/index, instead just /index
    public ActionResult Index() { return View(); }
  }
}