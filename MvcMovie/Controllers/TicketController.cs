using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class TicketController : Controller
{

    public IActionResult Index(){
        Ticket t1 = new Ticket();
        t1.Id = "01";
        t1.Movie = "AOT";
        t1.Price = 500;
        Ticket t2 = new Ticket();
        t2.Id = "02";
        t2.Movie = "Barbie";
        t2.Price = 450;
        Ticket t3 = new Ticket();
        t3.Id = "03";
        t3.Movie = "TENET";
        t3.Price = 600;

        List<Ticket> allTicket = new();
        allTicket.Add(t1);
        allTicket.Add(t2);
        allTicket.Add(t3);

        return View(allTicket);
    }

    public IActionResult Create(){
        return View();
    }

    public IActionResult Delete(){
        return View();
    }
}