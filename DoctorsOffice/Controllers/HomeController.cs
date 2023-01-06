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
      Doctor [] docs = _db.Doctors.ToArray();
      Patient[] pats = _db.Patients.ToArray();
      Dictionary<string,object[]> model = new Dictionary<string, object[]>();
      model.Add("Doctors", docs);
      model.Add("Patients", pats);
      return View(model);
    }
  }
}