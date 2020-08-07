using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Linq;

namespace Factory.Controllers
{
  public class EngineersController : Controller
  {
    private readonly FactoryContext _db;

    public EngineersController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Engineers.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "MachineName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Engineer engineer, int MachineId)
    {
      _db.Engineers.Add(engineer);
      if (MachineId !=0)
      {
        _db.MachineEngineer.Add(new MachineEngineer() { MachineId = MachineId, EngineerId = engineer.EngineerId});
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
      var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
      ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "MachineName");
      return View(thisEngineer);
    }

    [HttpPost]
    public ActionResult Edit(Engineer engineer, int MachineId)
    {
      if(MachineId !=0)
      {
        _db.MachineEngineer.Add(new MachineEngineer() {MachineId = MachineId, EngineerId = engineer.EngineerId});
      }
      _db.Entry(engineer).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Show(int id)
    {
      var thisEngineer = _db.Engineers
        .Include(engineer => engineer.Machines)
        .ThenInclude(join => join.Machine)
        .FirstOrDefault(engineer => engineer.EngineerId == id);
      return View(thisEngineer);
    }

    public ActionResult Delete(int id)
    {
      var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);  
      return View(thisEngineer);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int Id)
    {
      var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == Id);
      _db.Engineers.Remove(thisEngineer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

     [HttpPost]
    public ActionResult DeleteMachine(int joinId)
    {
      var joinEntry = _db.MachineEngineer.FirstOrDefault(entry => entry.MachineEngineerId == joinId);
      _db.MachineEngineer.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddMachine(int id)
    {
    var thisEngineer = _db.Engineers.FirstOrDefault(engineers => engineers.EngineerId == id);
    ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "MachineName");
    return View(thisEngineer);
    }
    [HttpPost]
    public ActionResult AddMachine(Engineer engineer, int MachineId)
    {
    if (MachineId != 0)
    {
    _db.MachineEngineer.Add(new MachineEngineer() { MachineId = MachineId, EngineerId = engineer.EngineerId });
    }
    _db.SaveChanges();
    return RedirectToAction("Index");
    }
  }
}