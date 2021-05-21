using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;
using System.Collections.Generic;
using System.Linq;

namespace Salon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly SalonContext _db;

    public StylistsController(SalonContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }
  }
}