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
        Ticket t1 = new Ticket();
        t1.Id = 1;
        t1.Movie = "AOT";
        t1.Price = 500;
        Ticket t2 = new Ticket();
        t2.Id = 2;
        t2.Movie = "Barbie";
        t2.Price = 450;
        Ticket t3 = new Ticket();
        t3.Id = 3;
        t3.Movie = "TENET";
        t3.Price = 600;

        List<Ticket> allTicket = new();
        allTicket.Add(t1);
        allTicket.Add(t2);
        allTicket.Add(t3);

        return View(allTicket);
    }

    public IActionResult Add(){
        return View();
    }
    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Add(Ticket obj){
        _db.Tickets.Add(obj);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(){
        return View();
    }
}