using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PierresTreats.Controllers
{
  public class TreatsController : Controller
  {
    private readonly PierresTreatsContext _db;

    public TreatsController(PierresTreatsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Flavors.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Treat treat, int FlavorId)
    {
      return View();
    }

    public ActionResult Details(int id)
    {
      return View();
    }

    public ActionResult Edit(int id)
    {
      return View();
    }

    [HttpPost]
    public ActionResult Edit(Treat treat, int TreatId)
    {
      return RedirectToAction("Index");
    }

    public ActionResult AddTreat(int id)
    {
      return View();
    }

    [HttpPost]
    public ActionResult AddTreat(Treat treat, int FlavorId)
    {
      return View();
    }

    public ActionResult Delete(int id)
    {
      return View();
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {

      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteFlavors(int joinId)
    {

      return RedirectToAction("Index");
    }
  }
}