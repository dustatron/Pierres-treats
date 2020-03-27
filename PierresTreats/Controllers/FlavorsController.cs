using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PierresTreats.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly PierresTreatsContext _db;

    public FlavorsController(PierresTreatsContext db)
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
    public ActionResult Create(Flavor flavor, int RecipeId)
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
    public ActionResult Edit(Flavor flavor, int TreatId)
    {
      return RedirectToAction("Index");
    }

    public ActionResult AddTreat(int id)
    {
      return View();
    }

    [HttpPost]
    public ActionResult AddTreat(Flavor flavor, int TreatId)
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
    public ActionResult DeleteRecipes(int joinId)
    {

      return RedirectToAction("Index");
    }
  }
}