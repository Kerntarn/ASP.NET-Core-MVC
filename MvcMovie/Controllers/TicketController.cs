using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class TicketController : Controller
{
    private readonly ApplicationDBContext _db;

    public TicketController(ApplicationDBContext db){
        _db = db;
    }
    public IActionResult Index(){
        
        IEnumerable<Ticket> allTicket = _db.Tickets;
        
        return View(allTicket);
    }

    public IActionResult Add(){
        return View();
    }
    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Add(Ticket obj){
        if (ModelState.IsValid){
            _db.Tickets.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(obj);
    }   

    public IActionResult Edit(int? id){
        if (id==null || id==0){
            return NotFound();
        }
        var obj = _db.Tickets.Find(id);
        if (obj == null){
            return NotFound();
        }
        return View(obj);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Ticket obj){
        if (ModelState.IsValid){
            _db.Tickets.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(obj);
    }   

    public IActionResult Delete(int? id){
        if (id == null || id == 0){
            return NotFound();
        }
        var obj = _db.Tickets.Find(id);
        if (obj == null){
            return NotFound();
        }
        _db.Tickets.Remove(obj);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
}