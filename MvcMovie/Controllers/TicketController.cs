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

    public IActionResult Delete(){
        return View();
    }
}