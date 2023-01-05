using Microsoft.AspNetCore.Mvc;
using DoctorsOffice.Models;

namespace DoctorsOffice.Controllers
{
  public class HomeController : Controller
  {
    private readonly DoctorsOfficeContext _db;

      public HomeController(DoctorsOfficeContext db)
      {
        _db = db;
      }

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}